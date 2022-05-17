using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace OrdersManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<User> users = new List<User>();
        public static List<Order> orders = new List<Order>();
        public static List<Product> products = new List<Product>();
        public static string pathToUsers = "users.json";
        public static string pathToProducts = "products.json";

        private void MainForm_Shown(object sender, EventArgs e)
        {
            tbLogin.Text = tbPassword.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DeserializeData();
            
            SerializeData();
        }

        /// <summary>
        /// Авторизация пользователя.
        /// </summary>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string login = tbLogin.Text.Trim();
                string password = GetHashSha256(tbPassword.Text.Trim() + login);
                foreach (var user in users)
                    if (user.Login == login && user.Password == password)
                    {
                        this.Hide();
                        tbLogin.Text = tbPassword.Text = "";
                        UserForm userForm = new UserForm(user);
                        UserForm.users = users;
                        UserForm.orders = orders;
                        UserForm.products = products;
                        MessageBox.Show($"Добро пожаловать, {user.Name}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userForm.ShowDialog();
                        this.Show();
                        return;
                    }
                MessageBox.Show("Введенные логин и пароль неправильны. Попробуйте другие или зарегестрируйтесь, если у вас еще нет аккаунта.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Регистрация пользователя.
        /// </summary>
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {

                ExtraEnterForm.users = users;
                ExtraEnterForm.orders = orders;
                ExtraEnterForm.products = products;
                ExtraEnterForm extraEnterForm = new ExtraEnterForm(false);
                extraEnterForm.ShowDialog();
                if (extraEnterForm.newUser != null)
                    users.Add(extraEnterForm.newUser);
                SerializeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Режим продавца.
        /// </summary>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                ExtraEnterForm.users = users;
                ExtraEnterForm.orders = orders;
                ExtraEnterForm.products = products;
                ExtraEnterForm extraEnterForm = new ExtraEnterForm(true);
                extraEnterForm.ShowDialog();
                SerializeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сериализация данных.
        /// </summary>
        public static void SerializeData()
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(pathToUsers))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, users);
                }
                using (StreamWriter sw = new StreamWriter(pathToProducts))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Десериализация данных.
        /// </summary>
        public static void DeserializeData()
        {
            try
            {
                users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(pathToUsers));
                products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(pathToProducts));
                orders.Clear();

                foreach (var user in users)
                    foreach (var order in user.Orders)
                    {
                        orders.Add(order);
                        //foreach (var product in order.Products)
                        //    if (!IsContainedProduct(product.Name))
                        //        products.Add(product);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Шифрование пароля с помощью SHA256.
        /// </summary>
        public static string GetHashSha256(string text)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                SHA256Managed hashstring = new SHA256Managed();
                byte[] hash = hashstring.ComputeHash(bytes);
                string hashString = string.Empty;
                foreach (byte x in hash)
                    hashString += String.Format("{0:x2}", x);

                return hashString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }


        // Вспомогательный метод поиска по имени.
        public static bool IsContainedProduct(string name)
        {
            foreach (var item in products)
                if (item.Name == name)
                    return true;
            return false;
        }


    }
}

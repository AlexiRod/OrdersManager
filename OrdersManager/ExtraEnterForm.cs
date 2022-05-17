using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersManager
{
    public partial class ExtraEnterForm : Form
    {
        string pathToSeller = "seller.txt";
        private bool isSeller;

        public static List<User> users = new List<User>();
        public static List<Order> orders = new List<Order>();
        public static List<Product> products = new List<Product>();
        public User newUser = null;
        public ExtraEnterForm(bool isSeller)
        {
            this.isSeller = isSeller;
            InitializeComponent();
        }

        private void ExtraEnterForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Режим продавца.
                if (isSeller)
                {
                    lblHeader.Text = "Авторизация продавца";
                    lblLogin.Text = "Логин продавца";
                    lblPassword.Text = "Пароль продавца";
                    btnApply.Text = "Авторизоваться";
                    groupBoxExtra.Visible = false;
                    btnApply.Top = groupBoxExtra.Top;
                    this.Height = 290;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Регистрация/Авторизация разработчика.
        /// </summary>
        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isSeller)
                {
                    string login = tbLogin.Text.Trim();
                    string password = tbPassword.Text.Trim();
                    if (login == "")
                    {
                        MessageBox.Show("Пожалуйста введите логин", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (password == "")
                    {
                        MessageBox.Show("Пожалуйста введите пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    foreach (var user in users)
                        if (user.Login == login)
                        {
                            MessageBox.Show("Пользователь с таким логином уже зарегестрирован. Попробуйте другой", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    string name = tbName.Text.Trim();
                    string telephone = tbTelephone.Text.Trim();
                    string adress = tbAdress.Text.Trim();
                    string image = SaveImage(pbImage.Image);
                    foreach (var user in users)
                        if (user.Name == name)
                        {
                            MessageBox.Show("Пользователь с таким никнеймом уже зарегестрирован. Попробуйте другой", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    newUser = new User(name, telephone, adress, login, MainForm.GetHashSha256(password + login), image);
                    MessageBox.Show($"Пользователь {name} успешно зарегестрирован. Войдите в аккаунт для подтверждения", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string[] parts = File.ReadAllLines(pathToSeller);
                    if (tbLogin.Text.Trim() != parts[0])
                    {
                        MessageBox.Show("Неправильный логин продавца! (логин и пароль можно посмотреть в файле seller.txt в папке проекта)", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MainForm.GetHashSha256(tbPassword.Text.Trim() + tbLogin.Text.Trim()) != MainForm.GetHashSha256(parts[1] + parts[0]))
                    {
                        MessageBox.Show("Неправильный пароль продавца! (логин и пароль можно посмотреть в файле seller.txt в папке проекта)", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"Добро пожаловать, {parts[0]}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SellerForm sellerForm = new SellerForm();
                    SellerForm.users = users;
                    SellerForm.orders = orders;
                    SellerForm.products = products;
                    sellerForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Конвертация изображения в стрку с помощью BASE64.
        /// </summary>
        private string SaveImage(Image image)
        {
            try
            {
                MemoryStream m = new MemoryStream();
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();

                return Convert.ToBase64String(imageBytes);
            }
            catch (Exception)
            {
                return "";
            }

        }

        /// <summary>
        /// Автозаполнение никнейма.
        /// </summary>
        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            tbLogin.Text = tbLogin.Text.Replace(' ', '_');
            tbName.Text = tbLogin.Text;
        }


        /// <summary>
        /// Изменение изображения.
        /// </summary>
        private void btnFixImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Изображения(*.png)|*.png|Изображения(*.jpg)|*.jpg|Изображения(*.jpeg)|*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                pbImage.Image = Image.FromFile(openFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

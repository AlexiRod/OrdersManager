using OrdersManager.Properties;
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

#warning TODO: панель сверху (три кнопки), регистрация, приложение админа



namespace OrdersManager
{
    public partial class UserForm : Form
    {
        public static List<User> users;
        public static List<Order> orders;
        public static List<Product> products;

        private Point location = new Point(7, 158);
        private List<Panel> productPanels = new List<Panel>();
        private User currentUser;

        public UserForm(User user)
        {
            currentUser = user;
            InitializeComponent();
        }
    

        private void UserForm_Load(object sender, EventArgs e)
        {
            DrawProductPanels();
        }

        /// <summary>
        /// Оформление заказа.
        /// </summary>
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> orderProducts = new List<Product>();
                List<int> orderProductsCount = new List<int>();
                foreach (var panel in productPanels)
                    if (((Tuple<Product, int>)panel.Tag).Item2 > 0)
                    {
                        orderProducts.Add(((Tuple<Product, int>)panel.Tag).Item1);
                        orderProductsCount.Add(((Tuple<Product, int>)panel.Tag).Item2);
                    }

                if (orderProducts.Count == 0)
                {
                    MessageBox.Show("Для оформления заказа нужно выбрать хотя бы один товар.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OrderMakeForm orderMakeForm = new OrderMakeForm(new Tuple<List<Product>, List<int>>(orderProducts, orderProductsCount), currentUser.Login);
                orderMakeForm.ShowDialog();
                Order newOrder = orderMakeForm.resultOrder;
                if (newOrder != null)
                {
                    orders.Add(newOrder);
                    currentUser.AddOrder(newOrder);
                }
                MainForm.SerializeData();
                DrawProductPanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Корзина пользователя.
        /// </summary>
        private void pbBasket_Click(object sender, EventArgs e)
        {
            BasketForm.orders = currentUser.Orders;
            BasketForm basketForm = new BasketForm();
            basketForm.ShowDialog();
        }


        /// <summary>
        /// Профиль пользователя.
        /// </summary>
        private void pbProfile_Click(object sender, EventArgs e)
        {
            AccountForm.user = currentUser;
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
        }


        /// <summary>
        /// Выход из аккаунта.
        /// </summary>
        private void pbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите выйти из аккаунта {currentUser.Name}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        /// <summary>
        /// Динамическая отрисовка всех элементов.
        /// </summary>
        public void DrawProductPanels()
        {
            try
            {
                location = new Point(7, 158);
                foreach (var item in productPanels)
                    this.Controls.Remove(item);
                productPanels.Clear();
                foreach (var product in products)
                    AddProductPanel(product);
                if (products.Count == 0)
                    this.Controls.Add(new Label()
                    {
                        AutoSize = true,
                        Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = location,
                        Text = "* Пока нет доступных товаров"
                    });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Динамическая отрисовка товаров.
        /// </summary>
        public void AddProductPanel(Product product)
        {
            if (product.Count == 0)
                return;
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;
            panel.Size = new Size(990, 147);
            panel.Tag = new Tuple<Product, int>(product, 0);


            PictureBox pictureBox = new PictureBox();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(12, 12);
            pictureBox.Size = new Size(120, 120);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            { pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(product.ImageString))); }
            catch (Exception)
            { pictureBox.Image = Resources.NoImage; }


            GroupBox groupBox = new GroupBox();
            groupBox.Font = new Font("Myanmar Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(140, 12);
            groupBox.Size = new Size(829, 121);
            groupBox.Text = product.Name;


            Label lblPrice = new Label();
            lblPrice.Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(64, 64, 64);
            lblPrice.Location = new Point(6, 42);
            lblPrice.Size = new Size(148, 43);
            lblPrice.Text = $"Цена: {product.Price} руб.";


            Label lblArticule = new Label();
            lblArticule.Font = new Font("Myanmar Text", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblArticule.ForeColor = Color.DarkGray;
            lblArticule.Location = new Point(8, 80);
            lblArticule.Size = new Size(116, 34);
            lblArticule.Text = product.Articule;


            Label lblCount = new Label();
            lblCount.Font = new Font("Myanmar Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(64, 64, 64);
            lblCount.Location = new Point(622, 29);
            lblCount.Size = new Size(137, 34);
            lblCount.Text = $"На складе: {product.Count}";
        

            NumericUpDown nudCount = new NumericUpDown();
            nudCount.BorderStyle = BorderStyle.FixedSingle;
            nudCount.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nudCount.Location = new Point(628, 58);
            nudCount.Size = new Size(147, 35);
            nudCount.Maximum = product.Count;


            Label lblEmpty = new Label();
            lblEmpty.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpty.ForeColor = Color.Red;
            lblEmpty.Location = new Point(599, 97);
            lblEmpty.Size = new Size(249, 17);
            lblEmpty.Text = "На складе больше нет этого товара!";
            lblEmpty.Visible = false;


            Button btnInfo = new Button();
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Location = new Point(781, 54);
            btnInfo.Size = new Size(40, 40);
            btnInfo.TextAlign = ContentAlignment.MiddleRight;
            btnInfo.BackgroundImage = Resources.Information;
            btnInfo.BackgroundImageLayout = ImageLayout.Zoom;
            nudCount.ValueChanged += (s, e) =>
            {
                if (nudCount.Value >= nudCount.Maximum)
                    lblEmpty.Visible = true;
                else lblEmpty.Visible = false;
                if (nudCount.Value >= 1)
                    panel.BackColor = Color.Lime;
                else panel.BackColor = Color.White;
                nudCount.Value = (int)nudCount.Value;
                panel.Tag = new Tuple<Product, int>(product, (int)nudCount.Value);
            };
            btnInfo.Click += (s, e) =>
            {
                ProductForm.products = products;
                ProductForm productInfoForm = new ProductForm(product, "Info");
                productInfoForm.ShowDialog();
            };


            groupBox.Controls.Add(lblPrice);
            groupBox.Controls.Add(btnInfo);
            groupBox.Controls.Add(lblCount);
            groupBox.Controls.Add(lblEmpty);
            groupBox.Controls.Add(lblArticule);
            groupBox.Controls.Add(nudCount);

            panel.Controls.Add(groupBox);
            panel.Controls.Add(pictureBox);
            panel.Location = location;
            location.Y += panel.Height + 3;
            this.Controls.Add(panel);
            productPanels.Add(panel);
            nudCount.BringToFront();
        }


        // Вспомогательный метод для поиска по имени.
        public static Product FindProduct(string name)
        {
            try
            {
                foreach (var item in products)
                    if (item.Name == name)
                        return item;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}

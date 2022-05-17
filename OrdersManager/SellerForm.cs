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

namespace OrdersManager
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        public static List<User> users = new List<User>();
        public static List<Order> orders = new List<Order>();
        public static List<Product> products = new List<Product>();

        private List<Control> productPanels = new List<Control>();
        private Point location = new Point(7, 158);

        private void SellerForm_Load(object sender, EventArgs e)
        {
            DrawProductPanels();
        }


        
        /// <summary>
        /// Отчет по товару.
        /// </summary>
        private void pbDefected_Click(object sender, EventArgs e)
        {
            DefectReportForm.products = products;
            DefectReportForm.users = users;
            DefectReportForm defectReportForm = new DefectReportForm();
            defectReportForm.ShowDialog();
        }

        
        /// <summary>
        /// Отчет по сумме.
        /// </summary>
        private void pbPriced_Click(object sender, EventArgs e)
        {
            PriceReportForm.users = users;
            PriceReportForm priceReportForm = new PriceReportForm();
            priceReportForm.ShowDialog();
        }


        /// <summary>
        /// Список пользователей.
        /// </summary>
        private void pbUsers_Click(object sender, EventArgs e)
        {
            SellerUsersForm.users = users;
            SellerUsersForm sellerUsersForm = new SellerUsersForm();
            sellerUsersForm.ShowDialog();
            MainForm.SerializeData();
        }


        /// <summary>
        /// Список заказов.
        /// </summary>
        private void pbOrders_Click(object sender, EventArgs e)
        {
            SellerOredersForm.orders = orders;
            SellerOredersForm sellerOredersForm = new SellerOredersForm();
            sellerOredersForm.ShowDialog();
            MainForm.SerializeData();
        }


        /// <summary>
        /// Выход из аккаунта.
        /// </summary>
        private void pbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите выйти из аккаунта продавца?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }

        /// <summary>
        /// Отрисовка всех элементов.
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

                Button btnAdd = new Button()
                {
                    FlatStyle = FlatStyle.Popup,
                    Location = new Point(location.X + 12, location.Y + 3),
                    Size = new Size(100, 100),
                    BackgroundImage = Resources.Add,
                    BackgroundImageLayout = ImageLayout.Zoom,
                };
                btnAdd.Click += (s, e) =>
                    {
                        ProductForm.products = products;
                        ProductForm productInfoForm = new ProductForm(null, "Add");
                        productInfoForm.ShowDialog();
                        Product newProduct = productInfoForm.result;
                        if (newProduct == null)
                            return;

                        products.Add(newProduct);
                        MainForm.SerializeData();
                        DrawProductPanels();
                    };

                this.Controls.Add(btnAdd);
                productPanels.Add(btnAdd);
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
            lblCount.AutoSize = true;
            lblCount.Location = new System.Drawing.Point(507, 59);
            lblCount.Text = "На складе: ";


            NumericUpDown nudCount = new NumericUpDown();
            nudCount.BorderStyle = BorderStyle.FixedSingle;
            nudCount.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nudCount.Location = new Point(628, 58);
            nudCount.Size = new Size(147, 35);
            nudCount.Maximum = int.MaxValue;
            nudCount.Value = product.Count;


            Button btnFix = new Button();
            btnFix.FlatStyle = FlatStyle.Popup;
            btnFix.Location = new Point(781, 54);
            btnFix.Size = new Size(40, 40);
            btnFix.TextAlign = ContentAlignment.MiddleRight;
            btnFix.BackgroundImage = Resources.Fix;
            btnFix.BackgroundImageLayout = ImageLayout.Zoom;
            nudCount.ValueChanged += (s, e) =>
            {
                nudCount.Value = product.Count = (int)nudCount.Value;
                panel.Tag = new Tuple<Product, int>(product, (int)nudCount.Value);
            };
            btnFix.Click += (s, e) =>
            {
                ProductForm.products = products;
                ProductForm productInfoForm = new ProductForm(product, "Edit");
                productInfoForm.ShowDialog();
                Product newProduct = productInfoForm.result;
                if (newProduct == null)
                    return;
                product.FixProperties(newProduct);
                MainForm.SerializeData();
                DrawProductPanels();
            };


            groupBox.Controls.Add(lblPrice);
            groupBox.Controls.Add(btnFix);
            groupBox.Controls.Add(lblCount);
            groupBox.Controls.Add(lblArticule);
            groupBox.Controls.Add(nudCount);

            panel.Controls.Add(groupBox);
            panel.Controls.Add(pictureBox);
            panel.Location = location;
            location.Y += panel.Height + 3;
            this.Controls.Add(panel);
            productPanels.Add(panel);
        }

    }
}

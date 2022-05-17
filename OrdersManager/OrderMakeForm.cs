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
    public partial class OrderMakeForm : Form
    {
        public Order resultOrder = null;

        private List<Product> products = new List<Product>();
        private List<int> counts = new List<int>();
        private Point location = new Point(6, 50);
        private string userName;

        public OrderMakeForm(Tuple<List<Product>, List<int>> productsAndCounts, string userName)
        {
            this.products = productsAndCounts.Item1;
            this.counts = productsAndCounts.Item2;
            this.userName = userName;
            InitializeComponent();
        }


        private void OrderMakeForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < products.Count; i++)
                AddProductPanel(products[i], counts[i]);
        }

        /// <summary>
        /// Подтверждение оформления заказа.
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Math.Abs(DateTime.Now.ToString().GetHashCode());
                Order order = new Order($"Заказ №{number}", number, DateTime.Now, userName, MyStatus.Без_статуса);
                for (int i = 0; i < products.Count; i++)
                    order.AddProduct(products[i], counts[i]);
                resultOrder = order;
                MessageBox.Show($"{order.Name} с {order.Count} товарами успешно оформлен и сейчас имеет статус 'Без_статуса'. " +
                    $"Итоговая стоимость заказа: {order.Price} руб.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Отмена оформления заказа.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите отменить оформление данного заказа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        /// <summary>
        /// Динамическая отрисовка товаров.
        /// </summary>
        public void AddProductPanel(Product product, int count)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;
            panel.Size = new Size(717, 93);


            PictureBox pictureBox = new PictureBox();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Size = new Size(84, 84);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            { pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(product.ImageString))); }
            catch (Exception)
            { pictureBox.Image = Resources.NoImage; }


            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new Font("Myanmar Text", 16.2F);
            lblName.Location = new Point(92, 8);
            lblName.Text = product.Name;


            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(64, 64, 64);
            lblPrice.Location = new Point(93, 44);
            lblPrice.Text = $"Общая цена: {product.Price * count} руб.";


            NumericUpDown nudCount = new NumericUpDown();
            nudCount.BorderStyle = BorderStyle.FixedSingle;
            nudCount.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nudCount.Enabled = false;
            nudCount.Location = new Point(566, 29);
            nudCount.Size = new Size(92, 35);
            nudCount.Maximum = int.MaxValue;
            nudCount.Value = count;



            Button btnInfo = new Button();
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Location = new Point(666, 29);
            btnInfo.Size = new Size(40, 40);
            btnInfo.BackgroundImage = Resources.Information;
            btnInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnInfo.Click += (s, e) =>
            {
                ProductForm productInfoForm = new ProductForm(product, "Info");
                productInfoForm.ShowDialog();
            };


            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);
            // panel.Controls.Add(lblArticule);
            panel.Controls.Add(nudCount);
            panel.Controls.Add(btnInfo);


            groupBox.Controls.Add(panel);
            panel.Location = location;
            location.Y += panel.Height + 3;
        }


    }
}

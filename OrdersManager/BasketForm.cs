using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersManager
{
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
        }

        public static List<Order> orders = new List<Order>();
        private Point location;

        private void BasketForm_Load(object sender, EventArgs e)
        {
            try
            {
                location = new Point(10, 85);
                if (orders.Count == 0)
                {
                    this.Controls.Add(new Label()
                    {
                        AutoSize = true,
                        Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Text = "* У пользователя пока нет заказов",
                        Location = location
                    });
                }
                foreach (var order in orders)
                    AddOrderPanel(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Динамическая отрисовка заказов
        /// </summary>
        private void AddOrderPanel(Order order)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Font = new Font("Myanmar Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox.Size = new Size(840, 123);
            groupBox.Text = order.Name;

            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlText;
            lblPrice.Location = new Point(12, 42);
            lblPrice.Size = new Size(308, 43);
            lblPrice.Text = $"Общая стоимость: {order.Price} руб.";


            Label lblDate = new Label();
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Myanmar Text", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.DarkGray;
            lblDate.Location = new Point(15, 79);
            lblDate.Size = new Size(142, 34);
            lblDate.Text = order.Date.ToString();


            Label lblStatus = new Label();
            lblStatus.AutoSize = false;
            lblStatus.Font = new Font("Myanmar Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(431, 54);
            lblStatus.Size = new Size(240, 34);
            lblStatus.Text = $"Статус: {order.Status}";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;


            Button btnPay = new Button();
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.Font = new Font("Myanmar Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(677, 35);
            btnPay.Size = new Size(152, 35);
            btnPay.Text = "Оплатить";
            btnPay.UseVisualStyleBackColor = true;
            if (order.Status.HasFlag(MyStatus.Без_статуса) || order.Status.HasFlag(MyStatus.Оплачен))
                btnPay.Enabled = false;
            btnPay.Click += (s, e) =>
            {
                MessageBox.Show("Счастливый обладатель золотой карты оплачивает все в один клик! :)", "Вжух!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                order.Status = order.Status & ~MyStatus.Без_статуса | MyStatus.Оплачен;
                lblStatus.Text = $"Статус: {order.Status}";
                btnPay.Enabled = false;
            };
            

            Button btnInfo = new Button();
            btnInfo.FlatStyle = FlatStyle.Popup;
            btnInfo.Font = new Font("Myanmar Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(677, 76);
            btnInfo.Size = new Size(151, 35);
            btnInfo.Text = "Информация";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += (s, e) => {
                MessageBox.Show(order.ToString(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);};

            groupBox.Controls.Add(lblDate);
            groupBox.Controls.Add(lblPrice);
            groupBox.Controls.Add(lblStatus);
            groupBox.Controls.Add(btnPay);
            groupBox.Controls.Add(btnInfo);
            groupBox.Location = location;
            location.Y += groupBox.Height + 3;

            this.Controls.Add(groupBox);
        }

    }
}

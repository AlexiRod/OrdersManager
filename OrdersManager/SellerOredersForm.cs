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
    public partial class SellerOredersForm : Form
    {
        public SellerOredersForm()
        {
            InitializeComponent();
        }

        public static List<Order> orders = new List<Order>();
        private List<GroupBox> panelOrders = new List<GroupBox>();
        private Point location = new Point(12, 137);
        private bool isActive = false;

        private void SellerOredersForm_Load(object sender, EventArgs e)
        {
            try
            {
                location = new Point(12, 137);
                foreach (var order in orders)
                    AddOrderPanel(order, isActive);

                if (orders.Count == 0)
                    this.Controls.Add(new Label()
                    {
                        AutoSize = true,
                        Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = location,
                        Text = "* Пока нет заказов от пользвателей"
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        /// <summary>
        /// Отображение активных/всех заказов.
        /// </summary>
        private void btnShowActive_Click(object sender, EventArgs e)
        {
            try
            {
                isActive = !isActive;
                if (isActive)
                    btnShowActive.Text = "Показать все заказы";
                else btnShowActive.Text = "Показать активные заказы";


                location = new Point(12, 137);
                foreach (var gb in panelOrders)
                    this.Controls.Remove(gb);
                panelOrders.Clear();
                foreach (var order in orders)
                    AddOrderPanel(order, isActive);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Динамическая отрисовка заказов.
        /// </summary>
        private void AddOrderPanel(Order order, bool isActive)
        {
            if (isActive && order.Status.HasFlag(MyStatus.Исполнен))
                return;
            GroupBox groupBox = new GroupBox();
            groupBox.Font = new Font("Myanmar Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox.Size = new Size(850, 123);
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
            lblDate.Text = order.UserID + "; " + order.Date.ToString();


            Label lblStatus = new Label();
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Myanmar Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(539, 62);
            lblStatus.Text = "Статус:";


            Label lblPaid = new Label();
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Myanmar Text", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPaid.ForeColor = SystemColors.ControlText;
            lblPaid.Location = new Point(414, 62);
            lblPaid.Text = $"Оплата: {(order.Status.HasFlag(MyStatus.Оплачен) ? "Да" : "Нет")}";


            ComboBox cbStatus = new ComboBox();
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(622, 62);
            cbStatus.Size = new Size(222, 38);
            cbStatus.Items.Add(MyStatus.Без_статуса);
            cbStatus.Items.Add(MyStatus.Обработан);
            cbStatus.Items.Add(MyStatus.Отгружен);
            cbStatus.Items.Add(MyStatus.Исполнен);
            foreach (MyStatus item in cbStatus.Items)
                if (order.Status.HasFlag(item))
                    cbStatus.SelectedItem = item;
            cbStatus.SelectedValueChanged += (s, e) =>
            {
                try
                {
                    if (order.Status.HasFlag(MyStatus.Оплачен))
                        order.Status = (MyStatus)cbStatus.SelectedItem | MyStatus.Оплачен;
                    else order.Status = (MyStatus)cbStatus.SelectedItem;
                    if (order.Status.HasFlag(MyStatus.Исполнен))
                        groupBox.BackColor = Color.Lime;
                    else groupBox.BackColor = Color.White;
                }
                catch (Exception) { }
            };


            groupBox.BackColor = order.Status.HasFlag(MyStatus.Исполнен) ? Color.Lime : Color.White;
            groupBox.Controls.Add(lblDate);
            groupBox.Controls.Add(lblPrice);
            groupBox.Controls.Add(lblPaid);
            groupBox.Controls.Add(lblStatus);
            groupBox.Controls.Add(cbStatus);
            groupBox.Location = location;
            location.Y += groupBox.Height + 3;

            panelOrders.Add(groupBox);
            this.Controls.Add(groupBox);
        }

    }
}

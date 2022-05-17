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
    public partial class AccountForm : Form
    {
        public static User user;
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblName.Text += user.Name;
                lblLogin.Text += user.Login;
                lblAdress.Text += user.Adress;
                lblTelephone.Text += user.Telephone;
                try
                {
                    pbPhoto.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(user.ImageString)));
                }
                catch (Exception)
                {
                    pbPhoto.Image = Resources.Account;
                }

                if (user.Orders.Count == 0)
                    lblOrders.Text = "* У пользователя пока нет заказов.";
                foreach (var order in user.Orders)
                    lblOrders.Text += $"{order.Name} - {order.Status}\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

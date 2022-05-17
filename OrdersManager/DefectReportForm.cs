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
    public partial class DefectReportForm : Form
    {
        public DefectReportForm()
        {
            InitializeComponent();
        }

        public static List<Product> products = new List<Product>();
        public static List<User> users = new List<User>();
        
        private List<Tuple<User, Order>> defUsers = new List<Tuple<User, Order>>();
        private List<Panel> panelUsers = new List<Panel>();
        private Point location = new Point(12, 240);


        private void DefectReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var product in products)
                    cbProduct.Items.Add(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        /// <summary>
        /// Определение пользователей для отчета.
        /// </summary>
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProduct.SelectedItem == null)
                    return;
                defUsers.Clear();
                foreach (var user in users)
                    foreach (var order in user.Orders)
                        if (ContainName(order, ((Product)cbProduct.SelectedItem).Name))
                        {
                            defUsers.Add(new Tuple<User, Order>(user, order));
                            break;
                        }

                location = new Point(12, 240);
                foreach (var panel in panelUsers)
                    Controls.Remove(panel);
                panelUsers.Clear();
                foreach (var tuple in defUsers)
                    AddProductPanel(tuple.Item1, tuple.Item2);
                lblListUsers.Visible = true;
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        /// <summary>
        /// Сохранение отчета.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Текстовый файл (*.txt) | *.txt";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                string res = $"Пользователи, когда-либо заказывавшие товар {((Product)cbProduct.SelectedItem).Name}:\n\n";
                foreach (var tuple in defUsers)
                    res += $"{tuple.Item1.Name} ({tuple.Item1.Login}) - {tuple.Item2.Name} [{tuple.Item2.Date}]\n";
                File.WriteAllText(openFileDialog.FileName, res);
                MessageBox.Show("Отчет о пользователях успешно создан.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Динамическая отрисовка пользователей.
        /// </summary>
        public void AddProductPanel(User user, Order order)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;
            panel.Size = new Size(800, 173);
            panel.Tag = user;


            PictureBox pictureBox = new PictureBox();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(12, 34);
            pictureBox.Size = new Size(120, 120);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            { pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(user.ImageString))); }
            catch (Exception)
            { pictureBox.Image = Resources.NoImage; }


            GroupBox groupBox = new GroupBox();
            groupBox.Font = new Font("Myanmar Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(140, 9);
            groupBox.Size = new Size(655, 147);
            groupBox.Text = user.Name;


            Label lblLogin = new Label();
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(64, 64, 64);
            lblLogin.Location = new Point(8, 44);
            lblLogin.Size = new Size(336, 43);
            lblLogin.Text = user.Login;


            Label lblAdress = new Label();
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Myanmar Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdress.ForeColor = Color.DarkGray;
            lblAdress.Location = new Point(8, 81);
            lblAdress.Size = new Size(143, 34);
            lblAdress.Text = user.Adress;


            Label lblTelephone = new Label();
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Myanmar Text", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTelephone.ForeColor = Color.DarkGray;
            lblTelephone.Location = new Point(8, 109);
            lblTelephone.Size = new Size(128, 34);
            lblTelephone.Text = user.Telephone;


            Label lblOrder = new Label();
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrder.Location = new Point(400, 72);
            lblOrder.Text = $"{order.Name}";


            groupBox.Controls.Add(lblLogin);
            groupBox.Controls.Add(lblTelephone);
            groupBox.Controls.Add(lblAdress);
            groupBox.Controls.Add(lblOrder);
            panel.Controls.Add(groupBox);
            panel.Controls.Add(pictureBox);

            panel.Location = location;
            location.Y += panel.Height + 3;
            this.Controls.Add(panel);
            panelUsers.Add(panel);
        }


        // Вспомогательный метод поиска
        private bool ContainName(Order order, string name)
        {
            foreach (var pr in order.Products)
                if (pr.Name == name)
                    return true;
            return false;
        }
    }
}

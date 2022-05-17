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
    public partial class PriceReportForm : Form
    {
        public PriceReportForm()
        {
            InitializeComponent();
        }

        public static List<User> users = new List<User>();
        List<User> sumUsers = new List<User>();
        List<Panel> panelUsers = new List<Panel>();
        Point location = new Point(12, 240);

        private void PriceReportForm_Load(object sender, EventArgs e)
        {
            nudSum.Maximum = decimal.MaxValue;
        }


        /// <summary>
        /// Определение пользователей для отчета.
        /// </summary>
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                sumUsers.Clear();
                foreach (var user in users)
                    if (user.GetAllSum() >= (double)nudSum.Value)
                        sumUsers.Add(user);


                location = new Point(12, 240);
                foreach (var panel in panelUsers)
                    Controls.Remove(panel);
                panelUsers.Clear();
                foreach (var user in sumUsers)
                    AddProductPanel(user);
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

                string res = $"Пользователи, потратившие за все время на заказы более {(double)nudSum.Value} руб:\n\n";
                foreach (var user in sumUsers)
                    res += $"{user.Name} ({user.Login}) - {user.GetAllSum()} руб.\n";
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
        public void AddProductPanel(User user)
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


            Label lblSum = new Label();
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(410, 72);
            lblSum.Text = $"Сумма: {user.GetAllSum()} руб.";


            groupBox.Controls.Add(lblLogin);
            groupBox.Controls.Add(lblTelephone);
            groupBox.Controls.Add(lblAdress);
            groupBox.Controls.Add(lblSum);
            panel.Controls.Add(groupBox);
            panel.Controls.Add(pictureBox);

            panel.Location = location;
            location.Y += panel.Height + 3;
            this.Controls.Add(panel);
            panelUsers.Add(panel);
        }

    }
}

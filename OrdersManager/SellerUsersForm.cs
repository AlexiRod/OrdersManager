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
    public partial class SellerUsersForm : Form
    {
        public SellerUsersForm()
        {
            InitializeComponent();
        }

        public static List<User> users = new List<User>();
        private Point location = new Point(7, 108);

        private void SellerUsersForm_Load(object sender, EventArgs e)
        {
            DrawUserPanels();
        }


        /// <summary>
        /// Динамическая отрисовка всех элементов.
        /// </summary>
        public void DrawUserPanels()
        {
            try
            {
                location = new Point(7, 108);

                foreach (var user in users)
                    AddUserPanel(user);

                if (users.Count == 0)
                    this.Controls.Add(new Label()
                    {
                        AutoSize = true,
                        Font = new Font("Myanmar Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = location,
                        Text = "* Пока нет зарегестрированных пользвателей"
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Динамическая отрисовка пользователей.
        /// </summary>
        public void AddUserPanel(User user)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;
            panel.Size = new Size(846, 173);
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
            groupBox.Size = new Size(694, 147);
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


            Button btnInfo = new Button();
            btnInfo.BackgroundImage = Resources.Information;
            btnInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnInfo.FlatStyle = FlatStyle.Popup;
            btnInfo.Location = new Point(634, 67);
            btnInfo.Size = new Size(40, 40);
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += (s, e) =>
            {

                string res = $"Заказы пользователя {user.Name}:\n\n";

                foreach (var order in user.Orders)
                    res += $"{order.Name} [{order.Date}]\nОплата: {(order.Status.HasFlag(MyStatus.Оплачен) ? order.Price.ToString() : "Не оплачен")}\n\n";

                
                res += $"Всего оплачено на сумму: {user.GetAllSum()} руб.";
                MessageBox.Show(res, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };


            groupBox.Controls.Add(lblLogin);
            groupBox.Controls.Add(lblTelephone);
            groupBox.Controls.Add(lblAdress);
            groupBox.Controls.Add(btnInfo);
            panel.Controls.Add(groupBox);
            panel.Controls.Add(pictureBox);

            panel.Location = location;
            location.Y += panel.Height + 3;
            this.Controls.Add(panel);
        }

    }
}

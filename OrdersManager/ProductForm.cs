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
    public partial class ProductForm : Form
    {
        public Product result;
        public static List<Product> products;
        private string type = null;
        public ProductForm(Product product = null, string type = null)
        {
            InitializeComponent();
            try
            {
                result = product;
                this.type = type;
                Text = "Добавление";

                if (product != null)
                {
                    textBoxName.Text = product.Name;
                    textBoxArticule.Text = product.Articule;
                    textBoxPrice.Text = product.Price.ToString();
                    textBoxCount.Text = product.Count.ToString();
                    textBoxText.Text = product.Text;
                    buttonDeleteImage.Enabled = false;
                    try
                    {
                        pictureBoxImage.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(product.ImageString)));
                        buttonDeleteImage.Enabled = true;
                    }
                    catch (Exception)
                    {
                        pictureBoxImage.Image = Resources.NoImage;
                    }
                }

                // Информация о товаре.
                if (type == "Info")
                {
                    Text = "Информация";
                    labelHeader.Text = "Карточка товара";
                    buttonAdd.Text = "ОК";
                    textBoxName.ReadOnly = true;
                    textBoxArticule.ReadOnly = true;
                    textBoxPrice.ReadOnly = true;
                    textBoxCount.ReadOnly = true;
                    textBoxText.ReadOnly = true;
                    buttonEditImage.Enabled = false;
                    buttonDeleteImage.Enabled = false;
                    buttonAdd.Enabled = false;
                }

                // Изменение товара.
                if (type == "Edit")
                {
                    Text = "Изменение";
                    labelHeader.Text = "Изменение товара";
                    buttonAdd.Text = "Применить изменения";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Подтверждение действия.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim().Replace('\'', '\"');
                if (name == string.Empty)
                {
                    MessageBox.Show("Введите подходящее название", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (FindProduct(name) != null && type != "Edit")
                {
                    DialogResult dialogResult = MessageBox.Show("Товар с таким названием уже существует. Его данные будут перезаписаны. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult != DialogResult.Yes)
                        return;
                }
                string articule = textBoxArticule.Text.Trim();
                if (articule == string.Empty)
                {
                    MessageBox.Show("Введите подходящий артикул", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(textBoxPrice.Text.Trim(), out double price) || price < 0)
                {
                    MessageBox.Show("Цена товара должна быть натуральным числом без символов валюты или нулем", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxCount.Text.Trim(), out int count) || count < 0)
                {
                    MessageBox.Show("Количество товара на складе должно быть натуральным числом или нулем", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string text = textBoxText.Text;

                if (result != null)
                {
                    result.Name = name;
                    result.Articule = articule;
                    result.Price = price;
                    result.Count = count;
                    result.Text = text;
                    result.ImageString = SaveImage(pictureBoxImage.Image);
                }
                else
                    result = new Product(name, articule, price, count, text, SaveImage(pictureBoxImage.Image));

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при работе: " + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение изображения.
        /// </summary>
        private void buttonEditImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Изображения(*.png)|*.png|Изображения(*.jpg)|*.jpg|Изображения(*.jpeg)|*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                pictureBoxImage.Image = Image.FromFile(openFileDialog.FileName);
                buttonDeleteImage.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание! При работе произошла неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Удаление изображения.
        /// </summary>
        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            buttonDeleteImage.Enabled = false;
            pictureBoxImage.Image = Resources.NoImage;
        }


        /// <summary>
        /// Конвертация изображения в строку.
        /// </summary>
        private string SaveImage(Image image)
        {
            try
            {
                if (image == null)
                    return "";
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

        // Вспомогательный метод для поиска по имени.
        public static Product FindProduct(string name)
        {
            foreach (var item in products)
                if (item.Name == name)
                    return item;
            return null;
        }

    }
}

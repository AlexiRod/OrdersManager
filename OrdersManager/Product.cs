using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public string Articule { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Text { get; set; }
        public string ImageString { get; set; }

        public Product() { }
        public Product(string name, string articule, double price, int count, string text, string image)
        {
            Name = name;
            Articule = articule;
            Price = price;
            Count = count;
            Text = text;
            ImageString = image;
        }

        public void FixProperties(Product product)
        {
            Name = product.Name;
            Articule = product.Articule;
            Price = product.Price;
            Count = product.Count;
            Text = product.Text;
            ImageString = product.ImageString;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

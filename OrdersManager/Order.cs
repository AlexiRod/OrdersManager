using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OrdersManager
{
    [Serializable]
    public class Order
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string UserID { get; set; }
        public List<Product> Products { get; set; }
        public int Count { get => Products.Count; }
        public double Price
        {
            get
            {
                double sum = 0;
                foreach (Product product in Products)
                    sum += product.Count * product.Price;
                return sum;
            }
        }
        public MyStatus Status { get; set; }


        public Order(string name, int number, DateTime dateTime, string userID, MyStatus status = 0)
        {
            Name = name;
            Number = number;
            Date = dateTime;
            UserID = userID;
            Status = status;
            Products = new List<Product>();
        }

        public bool AddProduct(Product product, int count)
        {
            if (product.Count < count)
                return false;

            product.Count -= count;
            Product findProduct = null;
            if (!TryFindProduct(product.Name, ref findProduct))
            {
                Product addProduct = new Product(product.Name, product.Articule, product.Price, count, product.Text, product.ImageString);
                Products.Add(addProduct);
            }
            else findProduct.Count += count;
            return true;
        }

        public void PayOrder()
        {
            List<Product> copiedProducts = Products.ToList();
            Products = copiedProducts;
        }

        public bool TryFindProduct(string name, ref Product product)
        {
            foreach (var item in Products)
                if (item.Name == name)
                {
                    product = item;
                    return true;
                }
            return false;
        }

        public override string ToString()
        {
            string ret = $"{Name}\nДата оформления: {Date}\nСтатус: {Status}\nОбщая стоимость: {Price} руб.\n\nТовары в заказе ({Count} шт.):";
            foreach (var product in Products)
                ret += $"\n{product.Name} [{product.Articule}] - {product.Price} руб. X {product.Count} шт.";
            return ret;
        }
    }

    [Flags]
    public enum MyStatus
    {
        // Специально на русском языке
        Без_статуса = 1,
        Обработан = 2,
        Оплачен = 4,
        Отгружен = 8,
        Исполнен = 16
    }
}

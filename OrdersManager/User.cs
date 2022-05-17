using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OrdersManager
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }
        public string ImageString { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Order> Orders { get; set; }

        public User(string name, string phone, string adress, string login, string password, string imagestring = "")
        {
            Name = name;
            Telephone = phone;
            Adress = adress;
            Login = login;
            Password = password;
            ImageString = imagestring;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            order.UserID = Login;
        }

        public double GetAllSum()
        {
            double sum = 0;
            foreach (var order in Orders)
                if (order.Status.HasFlag(MyStatus.Оплачен))
                    sum += order.Price;
            return sum;
        }
    }
}

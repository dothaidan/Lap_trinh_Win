using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        public Menu(string name, int count, double price, double totalPrice = 0)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = Convert.ToDouble(row["totalPrice"].ToString());
        }
        private double totalPrice;
        private double price;
        private int count;
        private string name;

        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}

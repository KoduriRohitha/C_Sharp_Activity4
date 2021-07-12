using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4BL
{
    public class Product
    {
        private Category category;
        public static int currentProductId;
        private string description;
        private double price;
        private string productId;
        private string productName;
        public Category Category { get; set; }
        public string Description { get; set; }
        public double Price { get { return price; } set { price = value; } }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        static Product()
        {

        }
        public Product()
        {

        }
        public Product(string productName, string description, double price, Category category)
        {

        }
    }
}
  

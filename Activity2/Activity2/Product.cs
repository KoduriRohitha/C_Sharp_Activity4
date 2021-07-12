using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2BL
{
    public class Product
    {
        public static int currentProductId;
        private string description;
        private double price;
        private string productId;
        private string productName;

        //Properties
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        static Product()
        {
            currentProductId = 100;
        }

        public Product()
        {
            productId = ("P" + currentProductId);
            currentProductId++;
            Console.WriteLine(productId);
        }
    }
}

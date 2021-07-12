using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3BL
{
    class RegularCustomer:Customer
    {
        private double discountPercentage;
        public double DiscountPercentage 
        { 
            get 
            { 
                return discountPercentage; 
            }
            set 
            {
                discountPercentage = value; 
            }
        }
        public RegularCustomer(string customerName, string address, DateTime dateOfBirth, string emailId, Enum.Gender gender, string password)
        {
            if (discountPercentage > 0)
            {
                discountPercentage = 2;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

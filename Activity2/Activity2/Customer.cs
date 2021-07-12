using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2BL
{
    public class Customer
    {
        public class Enums
        {
            public enum Gender
            { 
                male,
                female,
                other
            }
        }
        private string address;
        public static int currentValueForCustomerId;
        private int customerId;
        private string customerName;
        private string customerType;
        private DateTime dateOfBirth;
        private string emailId;
        private Enums.Gender gender;
        private string password;

        //properties
        static Customer()
        {
            currentValueForCustomerId=1000;
        }
        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId++;
            Console.WriteLine(customerId);
        }
    }
}

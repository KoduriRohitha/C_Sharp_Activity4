using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3BL
{
    public class Customer
    {
        public enum CustomerCardType
        {
            Silver,
            Gold,
            Platinum
        }
        public class Enum
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
        private DateTime dateOfBirth;
        private string emailId;
        private Enum.Gender gender;
        private string password;

        //Properties
        public string Address {get; set;}
        public int CustomerId {get; set;}
        public string CustomerName {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string EmailId {get; set;}
        public string Gender {get; set;}
        public string Password {get; set;}
        static Customer()
        {
            currentValueForCustomerId = 1000;
        }
        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId++;
            Console.WriteLine(customerId);
        }
        public Customer(string customerName,string address,DateTime dateOfBirth,string emailId,Enum.Gender gender,string password)
        {
            customerName = this.customerName;
            address = this.address;
            dateOfBirth = this.dateOfBirth;
            emailId = this.emailId;
            gender = this.gender;
            password = this.password;
        }
    }
}

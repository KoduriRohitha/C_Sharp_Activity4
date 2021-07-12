using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3BL
{
    public class EliteCustomer :Customer
    {
        private int ownedCoupons;
        public int OwnedCoupons 
        { 
            get { 
                return ownedCoupons;
            } 
            set { 
                ownedCoupons = value;
            } 
        }

        public EliteCustomer(string stomerName,string address, DateTime dateOfBirth, string emailId, Enum.Gender gender, string password, int ownedCoupons)
        {
            ownedCoupons = this.ownedCoupons;
            if (ownedCoupons > 0)
            {
                Console.WriteLine("Owned Coupon is valid");
            }
            else
            {
                Console.WriteLine("Entered value is invalid");
            }
        }
    }
}

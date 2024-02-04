using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class Order
    {
        // Properties to store order information
        public string customerName;
        public double phonenumber;
        public string email;

        public Order()
        {

        }

        // Constructor to create a new order
        public Order(string customerName, double phoneNumber, string email)
        {
            this.customerName = customerName;
            this.phonenumber = phoneNumber;
            this.email = email;
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public double PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }

}

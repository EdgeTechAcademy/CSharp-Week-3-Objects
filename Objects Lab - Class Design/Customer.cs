using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Lab___Class_Design
{
    class Customer
    {
        int customerId;
        string custName;
        string phoneNumber;

        public Customer(int customerId, string custName, string phoneNumber)
        {
            this.customerId = customerId;
            this.custName = custName;
            this.phoneNumber = phoneNumber;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustName { get => custName; set => custName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}

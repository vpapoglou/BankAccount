using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Customer
    {

        protected string firstName { get; set; }
        protected string lastName { get; set; }
        protected string iban { get; set; }

        public Customer(string firstName, string lastName, string iban)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iban = iban;
        }



    }
}

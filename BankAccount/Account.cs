using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Account:Customer
    {
        protected DateTime date = DateTime.Now.Date;

        public Account(string firstName, string lastName, string iban) : base( firstName,  lastName,  iban)
        {
            
        }


        protected double balance = 2000;
        protected double transactionLimit = 5000;
        protected double interenstrate = 0.01;

        void printStatementTransaction() {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class LotteryAccount:SavingsAccount
    {
        public LotteryAccount(string firstName, string lastName, string iban) : base(firstName, lastName, iban)
        {

        }

        protected double winAmount = 50;

        public void winPercentage()
        {
            Random rnd = new Random();

            int a = rnd.Next(1, 100);

            int b = rnd.Next(1, 100);

            if(a==b)
            {
                balance += winAmount;
            }
        }
   
}
}

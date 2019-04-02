using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class CreditAccount : Account
    {

        public CreditAccount(string firstName, string lastName, string iban) : base(firstName, lastName, iban)
        {

        }

        double fee = 0.02;
        double creditLimit = 200;
        
        public void charge(double amount)
        {
            while (amount > balance || amount > transactionLimit || creditLimit < amount)
            {
                Console.WriteLine("Amount too big\n");
                amount = long.Parse(Console.ReadLine());

            }
            balance -= amount + amount * fee;

            Console.WriteLine("\n IBAN: {0} \n Name: {1} {2} \nType: Credit \n \t DATE \t \t | \t REASON \t | \t AMOUNT \t | \t BALANCE \n {3} \t | \t CHARGE  \t | \t {4}  \t \t | \t {5} \n", iban, firstName, lastName, date.Date, amount, balance);

        }

        public void deposit(double amount)
        {
            balance += amount;

            Console.WriteLine("\n IBAN: {0} \n Name: {1} {2} \nType: Credit \n \t DATE \t \t | \t REASON \t | \t AMOUNT \t | \t BALANCE \n {3} \t | \t DEPOSIT  \t | \t {4}  \t \t | \t {5} \n", iban, firstName, lastName, date.Date, amount, balance);
        }

        public void addPayment()
        {
            balance += balance * interenstrate;

            Console.WriteLine("\n IBAN: {0} \n Name: {1} {2} \nType: Credit \n \t DATE \t \t | \t REASON \t | \t AMOUNT \t | \t BALANCE \n {3} \t | \t ADD PAYMENT  \t | \t {4}  \t \t | \t {5} \n", iban, firstName, lastName, date.Date, balance*interenstrate, balance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class SavingsAccount:Account
    {
        public SavingsAccount(string firstName, string lastName, string iban) : base(firstName, lastName, iban)
        {

        }

        public void withdraw(double amount)
        {
            while (amount > balance || amount > transactionLimit)
            {
                Console.WriteLine("Amount too big\n");
                amount = long.Parse(Console.ReadLine());

            }
            balance -= amount;

            Console.WriteLine("\n IBAN: {0} \n Name: {1} {2} \nType: Savings \n \t DATE \t \t | \t REASON \t | \t AMOUNT \t | \t BALANCE \n {3} \t | \t WITHDRAW  \t | \t {4}  \t \t | \t {5} \n", iban, firstName, lastName, date.Date, amount, balance);


        }

        public void deposit(double amount)
        {
            balance += amount;

            Console.WriteLine("\n IBAN: {0} \n Name: {1} {2} \nType: Savings \n \t DATE \t \t | \t REASON \t | \t AMOUNT \t | \t BALANCE \n {3} \t | \t DEPOSIT  \t | \t {4}  \t \t | \t {5} \n", iban, firstName, lastName, date.Date, amount, balance);
        }

        public void addInterest()
        {
            balance += balance * interenstrate;

            Console.WriteLine("\n IBAN: {0} \n Name: {1} {2} \nType: Savings \n \t DATE \t \t | \t REASON \t | \t AMOUNT \t | \t BALANCE \n {3} \t | \t ADD INTEREST  \t | \t {4}  \t \t | \t {5} \n", iban, firstName, lastName, date.Date, balance * interenstrate, balance);
        }
    }
}

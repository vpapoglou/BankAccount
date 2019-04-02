using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bool HasNumber(string input)//elegxos na mhn dwthoun arithmitika stoixeia
            {
                return input.Where(x => Char.IsDigit(x)).Any();
            }

            Console.WriteLine("Welcome to our Bank.\nPlease enter first name:\n");
            string firstName = Console.ReadLine();
            while (HasNumber(firstName))
            {
                Console.WriteLine("Please enter first name without numbers:\n");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Please enter last name:\n");
            string lastName = Console.ReadLine();
            while (HasNumber(lastName))
            {
                Console.WriteLine("Please enter last name without numbers:\n");
                lastName = Console.ReadLine();
            }

            Regex ibanRegex = new Regex("[0-9]"); 

            Console.WriteLine("Please enter IBAN:\n");
            string iban = Console.ReadLine();
            while (!(ibanRegex.IsMatch(iban) && iban.Length==16)) //elegxoume an to iban exei mono arithmous kai einai 16pshfio
            {
                Console.WriteLine("Please enter a 16 numbers - IBAN without chars:\n");
                iban = Console.ReadLine();
            }

            Customer customer1 = new Customer(firstName, lastName, iban);

            long amount;
            

            Console.WriteLine("Please choose:\n 1 for Credit Account.\n 2 for Savings Account.\n 3 for Lottery Account.\n 4 Quit. \n");
            string decision = Console.ReadLine();
            while (decision != "4")
            {
                switch (decision)
                {
                    case "1":
                        CreditAccount creditAccount1 = new CreditAccount(firstName, lastName, iban);
                        Console.WriteLine("Please choose:\n 1 for Charge.\n 2 for Deposit.\n 3 for Add Payment.\n 4 Quit. \n");
                        decision = Console.ReadLine();
                        while (decision != "4")
                        {
                            switch (decision)
                            {
                                case "1":
                                    Console.WriteLine("Write your amount:\n");
                                    amount = long.Parse(Console.ReadLine());
                                    creditAccount1.charge(amount);
                                    break;
                                case "2":
                                    Console.WriteLine("Write your amount:\n");
                                    amount = long.Parse(Console.ReadLine());
                                    creditAccount1.deposit(amount);
                                    break;
                                case "3":
                                    creditAccount1.addPayment();
                                    break;
                                default:
                                    Console.WriteLine("Choose right number");
                                    break;
                            }

                            Console.WriteLine("Please choose:\n 1 for Charge.\n 2 for Deposit.\n 3 for Add Payment.\n 4 Quit.\n");
                            decision = Console.ReadLine();
                        }


                        break;
                    case "2":
                        SavingsAccount savingsAccount1 = new SavingsAccount(firstName, lastName, iban);
                        Console.WriteLine("Please choose:\n 1 for Withdraw.\n 2 for Deposit.\n 3 for Add Interest.\n 4 Quit.\n");
                        decision = Console.ReadLine();
                        while (decision != "4")
                        {
                            switch (decision)
                            {
                                case "1":
                                    Console.WriteLine("Write your amount:\n");
                                    amount = long.Parse(Console.ReadLine());
                                    savingsAccount1.withdraw(amount);
                                    break;
                                case "2":
                                    Console.WriteLine("Write your amount:\n");
                                    amount = long.Parse(Console.ReadLine());
                                    savingsAccount1.deposit(amount);
                                    break;
                                case "3":
                                    savingsAccount1.addInterest();
                                    break;
                                default:
                                    Console.WriteLine("Choose right number");
                                    break;
                            }

                            Console.WriteLine("Please choose:\n 1 for Withdraw.\n 2 for Deposit.\n 3 for Add Interest.\n 4 Quit.\n");
                            decision = Console.ReadLine();
                        }

                        break;

                    case "3":
                        LotteryAccount lotteryAccount1 = new LotteryAccount(firstName, lastName, iban);
                        Console.WriteLine("Please choose:\n 1 for Withdraw.\n 2 for Deposit.\n 3 Quit.\n");
                        decision = Console.ReadLine();
                        while (decision != "3")
                        {
                            switch (decision)
                            {
                                case "1":
                                    Console.WriteLine("Write your amount:\n");
                                    amount = long.Parse(Console.ReadLine());
                                    lotteryAccount1.withdraw(amount);
                                    lotteryAccount1.winPercentage(); //sygkrinei 2 tyxaious arithmous se kathe synallagi me pithanotita 1% na dwsei 50 eyrw
                                    break;
                                case "2":
                                    Console.WriteLine("Write your amount:\n");
                                    amount = long.Parse(Console.ReadLine());
                                    lotteryAccount1.deposit(amount);
                                    lotteryAccount1.winPercentage(); 
                                    break;

                                default:
                                    Console.WriteLine("Choose right number.\n");
                                    break;
                            }

                            Console.WriteLine("Please choose:\n 1 for Withdraw.\n 2 for Deposit.\n 3 Quit.\n");
                            decision = Console.ReadLine();
                        }

                        break;
                    default:
                        Console.WriteLine("Choose right number.\n");
                        break;     
                }

                Console.WriteLine("Please choose:\n 1 for Credit Account.\n 2 for Savings Account.\n 3 for Lottery Account.\n 4 Quit. \n");
                decision = Console.ReadLine();
            }          
        }
    }
}

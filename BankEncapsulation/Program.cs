using System;

namespace BankEncapsulation
{

    


    public class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            var account = new BankAccount();

            Console.WriteLine("Welcome to Darlenes Banking!");
            Console.WriteLine("--------");

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1: Deposit Money");
                Console.WriteLine("2: Check balance");
                Console.WriteLine("3: Exit terminal");


                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Write("Invalid input. Please enter a valid option");
                    continue;
                }
                else
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("How much would you like to deposit?");

                            double num1 = double.Parse(Console.ReadLine());
                            account.Deposit(num1);
                            Console.WriteLine("Deposit is complete.");
                            break;

                        case 2:
                            Console.WriteLine($"${account.GetBalance()}");
                            break;

                        case 3:

                            Console.WriteLine("Thank you for banking with us.");
                            return;

                        default:
                            Console.WriteLine("Invalid input.");
                            break;

                    }


                }


            }

        }
    }

}

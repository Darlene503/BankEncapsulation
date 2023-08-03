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
                if(! int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Write("Invalid input. Please enter a valid option");
                    continue;
                }

                Console.WriteLine("Please try again ..");
            }


        }

    }
}
    
      
using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Vacation Budget Planner!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            int counter = 1;

            while (counter <=3)
            {
                Console.WriteLine("Please enter password.");
                string password = Console.ReadLine();
                if (password == "vacation")
                {
                    break;
                }
                counter++;
                if (counter > 3)
                {
                    Environment.Exit(0);
                }
            }
            
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine($"Hello {name}. Where would you like to travel to Mexico or Jamaica?");
                string destination = Console.ReadLine();
                switch (destination.ToLower())
                {
                    case "mexico":
                        Console.WriteLine("How many days will you like to spend on your trip?");
                        int mDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much spending money would you like to bring?");
                        Console.Write("$ ");
                        double mMoney = double.Parse(Console.ReadLine());
                        double mPerDay = mMoney / mDays;
                        Console.WriteLine($"Hey {name}, you are going to {destination} for {mDays} days with {mMoney:c} for spending money. You can spend {mPerDay:c} per day.");
                        break;
                    case "jamaica":
                        Console.WriteLine("How many days will you like to spend on your trip?");
                        int jDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much spending money would you like to bring?");
                        Console.Write("$ ");
                        double jMoney = double.Parse(Console.ReadLine());
                        double jPerDay = jMoney / jDays;
                        Console.WriteLine($"Hey {name}, you are going to {destination} for {jDays} days with {jMoney:c} for spending money. You can spend {jPerDay:c} per day.");
                        break;
                    default:
                        Console.WriteLine("That's not one of your choices.");
                        break;
                }
                Console.WriteLine("Would you like to make any changes, yes or no?");
                string rerun = (Console.ReadLine()).ToLower();
                keepGoing = false;
                if (rerun == "yes" || rerun == "y")
                {
                    keepGoing = true;
                }
            }
            Console.WriteLine("Have a great trip!");

            Console.WriteLine("Please press enter to exit.");
            Console.ReadLine();
           
        }
    }
}

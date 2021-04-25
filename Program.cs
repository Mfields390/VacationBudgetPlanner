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
            Console.WriteLine($"Hello {name}. Where would you like to travel to Mexico or Jamaica?");
            string destination = Console.ReadLine();
            Console.WriteLine("How many days will you like to spend on your trip?");
            int days = int.Parse (Console.ReadLine());
            Console.WriteLine("How much spending money would you like to bring?");
            Console.Write("$ ");
            double money = double.Parse(Console.ReadLine());
            double perDay = money / days;
            Console.WriteLine($"Hey {name}, you are going to {destination} for {days} days with {money:c} for spending money. You can spend {perDay:c} per day.");



            Console.WriteLine("Please press enter to exit.");
            Console.ReadLine();
           
        }
    }
}

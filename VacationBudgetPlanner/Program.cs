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
        }
    }
}

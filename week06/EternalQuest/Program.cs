using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        bool running = true;

        GoalManager manager = new GoalManager();

        while (running)
        {
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nSelect a choice from the menu: ");


            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                manager.CreateGoal();
            }

            else if (choice == "2")
            {
                manager.ListGoalNames();
            }

            else if (choice == "3")
            {
                manager.SaveGoals();
            }
            else if (choice == "4")
            {
                manager.LoadGoals();
            }

            else if (choice == "5")
            {
                manager.RecordGoals();
            }
            else if (choice == "6")
            {
                Console.WriteLine("\nThank you for using the Eternalquest. Goodbye!");
                running = false;

            }
            else
            {
                Console.WriteLine("Please select a valid option (a number between 1 and 6)\n");
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");

        bool running = true;


        while (running)
        {
            Console.WriteLine("What activity would you like to try");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Enter the number (1-4)");
            string choice = Console.ReadLine();

            Console.Clear();
            if (choice == "1")
            {
                Breathing breathingActivity = new Breathing();
                breathingActivity.Run();
            }

            else if (choice == "2")
            {
                Reflecting reflectingActivity = new Reflecting();
                reflectingActivity.Run();
            }

            else if (choice == "3")
            {
                Listing ListingActivity = new Listing();
                ListingActivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Project. Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Please select a valid option (a number between 1 and 4)\n");
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
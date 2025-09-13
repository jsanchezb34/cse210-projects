using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("This is your Journal prgram\n");
        int input = 0;

        while (input != 5)
        {
            
            Console.WriteLine("Select an option from the menu below:\n");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file\n");
            Console.WriteLine("5. Quit\n");


            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("what date is today?: (mm/dd/yyyy)");
                string date = Console.ReadLine();
                PromptGenerator generator = new PromptGenerator();
                Console.WriteLine(generator.GetRandomPrompt());
                Console.Write("Your response: ");
                string userEntry = Console.ReadLine();
                Console.WriteLine("what else would you like to do?");
                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());
            }


            else if (input == 2)
            {
                Console.WriteLine("Display all entries");
            }
            else if (input == 3)
            {
                Console.WriteLine("\nSaving entries to file");
            }
            else if (input == 4)
            {
                Console.WriteLine("Files saved");
            }
            else if (input == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");


            }

        }

    }
}   



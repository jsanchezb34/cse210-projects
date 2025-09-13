using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("This is your Journal prgram\n");
        Console.WriteLine("Select an option from the menu below:\n");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save entries to file");
        Console.WriteLine("4. Load entries from file\n");
        Console.WriteLine("5. Quit\n");

        int input;
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
        }
        else if (input == 2)
        {
            Console.WriteLine("Display all entries");
        }
        else if (input == 3)
        {
            Console.WriteLine("\nSave entries to file");
        }
        else if (input == 4)
        {
            Console.WriteLine("Load entries from file");
        }
        else if (input == 5)
        {
            Console.WriteLine("Quit");
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");


        }

    }
}

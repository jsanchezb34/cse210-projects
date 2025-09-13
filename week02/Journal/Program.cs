using System;
using System.ComponentModel.Design;

class Program
{
    static void WelcomeMessage()
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("This is your Journal prgram\n");

    }

    static void Menu()
    {
        Console.WriteLine("Select an option from the menu below:\n");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save entries to file");
        Console.WriteLine("4. Load entries from file\n");
        Console.WriteLine("5. Quit\n");
    }
    static void Main(string[] args)
        {

            WelcomeMessage();

            int input = 0;
            while (input != 5)
            {
                Menu();

                Console.WriteLine("Select an option from the menu below:\n");
                Console.WriteLine("1. Write a new journal entry");
                Console.WriteLine("2. Display all entries");
                Console.WriteLine("3. Save entries to file");
                Console.WriteLine("4. Load entries from file\n");
                Console.WriteLine("5. Quit\n");


                Console.Write("\nEnter number: ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("what date is today?: (mm/dd/yyyy)");
                    string date = Console.ReadLine();
                    PromptGenerator generator = new PromptGenerator();
                    Console.WriteLine(generator.GetRandomPrompt());
                    Console.Write("Your response: \n");
                    string userEntry = Console.ReadLine();
                    Console.WriteLine("what else would you like to do?\n");
                    Menu();
                    Console.Write("Enter number: ");
                    input = int.Parse(Console.ReadLine());
                }


                else if (input == 2)
                {
                    Console.WriteLine("\nDisplay all entries\n");
                }
                else if (input == 3)
                {
                    Console.WriteLine("\nSaving entries to file\n");
                }
                else if (input == 4)
                {
                    Console.WriteLine("\nFiles saved\n");
                }
                else if (input == 5)
                {
                    Console.WriteLine("\nGoodbye!\n");
                }
                else
                {
                    Console.WriteLine("\nInvalid option. Please try again.\n");


                }

            }

        }
}   



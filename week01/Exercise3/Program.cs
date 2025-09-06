using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.Write("What is the magic number? ");
        int magic = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magic)
        {
            if (guess > magic)
            {
                Console.WriteLine("lower");
            }

            else if (guess < magic)
            {
                Console.WriteLine("higher");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
            
       Console.WriteLine("You guessed it!");

    }
}
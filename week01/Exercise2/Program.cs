using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        char letter;

        if (grade >= 90)
            letter = 'A';
        else if (grade >= 80)
            letter = 'B';
        else if (grade >= 70)
            letter = 'C';
        else if (grade >= 60)
            letter = 'D';
        else
            letter = 'F';

        Console.WriteLine($"Your grade letter grade is {letter}");
        if (grade >= 70)
            Console.WriteLine("Congrats! You passed");
        else
            Console.WriteLine("Sorry, you did not pass, try harder");
        
    }
    
}
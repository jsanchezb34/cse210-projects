using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("Welcome to the program!");
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        Console.Write("Please enter your favorite number: ");
        int fav = int.Parse(Console.ReadLine());

        double square = fav * fav;

        Console.Write($"{name}, the square of your number is {square}");



    }
}
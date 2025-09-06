using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();
        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
                numbers.Add(input);
        }
        while (input != 0);
        Console.WriteLine("You entered: ");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);

        }

        int sum = 0;
        int largest = 0;

        foreach (int n in numbers)
        {
            sum += n;
            if (n > largest)
                largest = n;
        }
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The highest is: {largest}");

    }
}
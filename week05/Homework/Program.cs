using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "1-20");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());


        WritingAssignment writing = new WritingAssignment("Mary", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetWritingInformation());
    }
}
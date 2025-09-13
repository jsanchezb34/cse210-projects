using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Let´s begging writing about your day!");
        PromptGenerator generator = new PromptGenerator();
        Console.WriteLine(generator.GetRandomPrompt());
    }
}
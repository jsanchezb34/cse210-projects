using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.\n");
        
        Reference ref1 = new Reference("1 Nephi", 3, 7);
        Scripture scripture1 = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: \nI will go and do the things which the Lord hath commanded, \nfor I know that the Lord giveth no commandments unto the children of men, \nsave he shall prepare a way for them that they may accomplish \nthe thing which he commandeth them.");
        
        // This will start by displaying "AAA" and waiting for the user to press the enter key
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine("\nPress enter to continue or type 'quit' to exit.");

        Console.ReadLine();

        // This will clear the console
        Console.Clear();

        // This will show "BBB" in the console where "AAA" used to be
        Console.WriteLine("BBB");
        
    }
}
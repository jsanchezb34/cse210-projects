
using System.Diagnostics;

public class Listing: activity
{
    public Listing() : base("Listing",
    "\nThis activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area.")
    {
    }

    private string[] _prompts ={
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Length)];
    }
    
    public void Run()
    {
        Start();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine("\nType **Stop** to finish");
        Console.WriteLine($"\n{GetRandomPrompt()}\n");
        Console.WriteLine("Beggin in: ");
        ShowCountdown(5);

        List<string> responses = new List<string>();
        Stopwatch timer = new Stopwatch();
        timer.Start();

        while (timer.Elapsed.TotalSeconds < GetDuration())
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }
        Console.WriteLine($"\nYou listed {responses.Count} items!");
        End();
    }
}
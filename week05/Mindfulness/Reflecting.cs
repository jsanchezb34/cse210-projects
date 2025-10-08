using System.Runtime.CompilerServices;
using System.Timers;

public class Reflecting : activity
{
    private string[] _prompts ={
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions ={
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Length)];
    }


    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Length)];
    }
    public Reflecting() : base("Reflecting",
    "\nThis activity will help you reflect on times in your life\nwhen you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it\nin other aspects of your life.\n")
    {
    }
    public void Run()
    {
        Start();
        Console.WriteLine("\nConsider the following...");
        Console.WriteLine($"\n{GetRandomPrompt()}");
        Console.WriteLine("Done?; Press **ENTER** to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions: ");
        Console.WriteLine($"> {GetRandomQuestion()}");
        Showspinnner(5);
        End();
    }
}

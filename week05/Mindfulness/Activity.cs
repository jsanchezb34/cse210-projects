
using System.Runtime.CompilerServices;

public class activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like the excercice to last?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Starting in");
        Showspinnner(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell  done!!\n");
        Console.WriteLine($"You just completed {_name} for {_duration} seconds");
    }

    protected void Showspinnner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
         Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

}
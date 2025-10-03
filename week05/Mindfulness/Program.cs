using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        TestBreathingActivity();
        
    }

    static void TestBreathingActivity()
    {
        Breathing breathingActivity = new Breathing();
        breathingActivity.Run();
    }
    




}
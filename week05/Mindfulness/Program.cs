using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");
        TestBreathingActivity();
        TestReflectingActivity();

    }

    static void TestBreathingActivity()
    {
        Breathing breathingActivity = new Breathing();
        breathingActivity.Run();
    }

    static void TestReflectingActivity()
    {
        Reflecting reflectingActivity = new Reflecting();
        reflectingActivity.Run();
    }
}
using System;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        var activities = new List<Activity>();
        {
            Running run = new Running(new DateTime(2025, 10, 12), 40, 2.0);
            Cycling bike = new Cycling(new DateTime(2025, 10, 13), 50, 5.0);
            Swimming swim = new Swimming(new DateTime(2025, 10, 14), 60, 60);
        };

    

        foreach (Activity activity in activities) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
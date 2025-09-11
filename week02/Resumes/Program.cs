using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();

        job1._jobTitle = "software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume Name1 = new Resume();

        Name1._Name = "Allison";
        Name1._LastName = "Rose";

        Name1.displayfullname();
        job1.displayjobdetails();
        job2.displayjobdetails();
    }
}
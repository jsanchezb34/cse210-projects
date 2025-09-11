using System.Security.Cryptography.X509Certificates;

public class Job
{
    public String _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;


    public void displayjobdetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    
} 

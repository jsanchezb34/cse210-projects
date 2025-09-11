using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _Name;
    public string _LastName;

    public void displayfullname()
    {
        Console.WriteLine($"Name: {_Name} {_LastName}");
        Console.WriteLine("Jobs: ");
    }

}
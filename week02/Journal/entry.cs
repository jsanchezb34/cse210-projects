using System.Security.Cryptography.X509Certificates;

//--------------------------------------------------------------------------------------

public class Entry
{
    public string Date;
    public string Prompt;
    public string UserEntry;

    public Entry(string Prompt, string UserEntry)
    {
        Date = Date;
        Prompt = Prompt;
        UserEntry = UserEntry;
    }

    public override string ToString()
    {
        return $"{Date}\n{Prompt}\n{UserEntry}\n";
    }

}
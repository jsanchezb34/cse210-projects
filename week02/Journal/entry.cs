
public class Entry
{
    private string _date;
    private string _prompt;
    private string _userEntry;

    public Entry(string prompt, string userEntry)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _prompt =prompt;
        _userEntry = userEntry;
    }

    public override string ToString()
    {
        return $"{_date}\n{_prompt}\n{_userEntry}\n";
    }

}
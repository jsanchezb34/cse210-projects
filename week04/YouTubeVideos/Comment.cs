
public class Comment
{
    private string _Name;
    private string _Text;

    public Comment(string name, string text)
    {
        _Name = name;
        _Text = text;
    }

    public string GetName()
    {
        return _Name;
    }

    public string GetText()
    {
        return _Text;
    }

}
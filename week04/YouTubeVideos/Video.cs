
public class Video
{
    private string _title
    private string _author;
    private int _lengthInSeconds;
    List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public string GetDisplayText()
    {
        return $"{_title} by {_author}, Length: {_lengthInSeconds} seconds";
    }

    public void addComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comment.Count;
    }
    public List<Comment> GetComments ()
    {
       return _comment;
    }
}
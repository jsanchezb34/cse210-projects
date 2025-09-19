public class Reference
{
    private string _book = "1 Nephi";
    private int _chapter = 3;
    private int _verse = 7;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}
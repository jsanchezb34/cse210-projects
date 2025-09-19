

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
            .Select(word => new Word(word))
            .ToList();
    }
    public string GetDisplayText()
    {
        string joinedWords = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {joinedWords}";

    }

    public void HideRandomWord()
    {
        var visibleWords = _words.Where(w => w.GetDisplayText() != "_____").ToList();
        if (visibleWords.Count > 0)
        {
            Random rand = new Random();
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w=> w.GetDisplayText() == "_____");
    }

    
}

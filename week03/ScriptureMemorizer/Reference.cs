public class Reference
{
    private string _reference;
    private string _text;

    private string _book;
    private string _chapter;

    private string _verse;

    private string _verses;

    public Reference()
    {

    }

    public string GetReference()
    {
        return _book + " " + _chapter + ":" + _verses;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public string getChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

    public string getVerse()
    {
        return _verse;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }

    public string getVerses()
    {
        return _verses;
    }

    public void SetVerses(string verses)
    {
        _verses = verses;
    }
}
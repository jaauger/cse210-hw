using System.Security.Cryptography.X509Certificates;

public class Word
{
    private int _length;
    private string _word;

    public Word(string word)
    {
        _length = word.Length;
        _word = word;
    }

    public string GetDashes()
    {
        string dashes = "";
        for (int i = 0; i < _length; i++)
        {
            dashes += "-";
        }
        return dashes;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }
    
}
using System.ComponentModel;
using System.Reflection;

public class Scripture
{
    private string _text;
    private string[] _result;
    private int end = 0;

    private int _numOfWordsToHide;
    private int _timesRun;

    List<Word> _words = new List<Word>();
    List<int> _nums = new List<int>();

    private readonly Random _random = new Random();

    public Scripture()
    {

    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
        LoadWordList();
    }

    public void SetWordsToHide(int nums)
    {
        _numOfWordsToHide = nums;
    }

    public string DisplayScripture()
    {
        return _text;
    }

    public void DisplayWithWordsHidden()
    {
        List<int> rNums = new List<int>();
        int runs = NumOfRand();
        for (int i = 0; i < runs; i++)
        {
            rNums.Add(GetRandomNumber());
        }

        for (int i = 0; i < _words.Count; i++)
        {
            var word = _words[i];
            if (rNums.Contains(i))
            {
                string hidden = word.GetDashes();
                Console.Write(hidden + " ");
                _words[i].SetWord(hidden);               
            }
            else
            {
                Console.Write(word.GetWord() + " ");
            }
        }

        if (end >= _words.Count)
        {
            Environment.Exit(0);
        }
    }

    private void LoadWordList()
    {
        _result = _text.Split(" ");
        foreach (string item in _result)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
    }

    private int GetRandomNumber()
    {

        int rNum;
        do
        {
            rNum = _random.Next(0, _words.Count);
        }
        while (_nums.Contains(rNum));

        _nums.Add(rNum);
        end++;
        return rNum;
    }

    private int NumOfRand()
    {        
        _timesRun++;        
        if (_timesRun <= _words.Count / _numOfWordsToHide)
            return _numOfWordsToHide;
        else
            return _words.Count % _numOfWordsToHide;
        
    }
}
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
    string _author;
    int _length; // in seconds
    string _title;

    List<Comment> comments = new List<Comment>();

    public Video()
    {

    }

    public Video(string author, int length, string title)
    {
        _author = author;
        _length = length;
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void AddComment(string author, string text)
    {
        Comment comment = new Comment(author, text);
        comments.Add(comment);

    }

    public void DisplayComments()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine(comment.GetAuthor() + " - " + comment.GetText());
            Console.WriteLine();
        }
    }

}
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Activity
{

    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    { 
        
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public DateTime EndTime()
    {
        DateTime dateTime = DateTime.Now;
        DateTime endTime = dateTime.AddSeconds(_duration);

        return endTime;
    }
    public void DisplayActivityWelcome()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the " + _name);

        Console.WriteLine(_description);

        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        string input = Console.ReadLine();
        _duration = int.Parse(input);

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Get Ready...");

        ShowSpinner(7);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");

        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("You have completed another " + _duration + " seconds of the " + _name);
        ShowSpinner(5);
        
    }

    public void ShowSpinner(int seconds)
    {
        List<string> strings = new List<string>();

        strings.Add("-");
        strings.Add("\\");
        strings.Add("|");
        strings.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(strings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= strings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        //Console.WriteLine("This is from ShowCountDown");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i >= 10)
                Console.Write("\b\b  \b\b");
            else
                Console.Write("\b \b");    
        }
    }

}

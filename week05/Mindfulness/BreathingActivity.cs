using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void Run()
    {
        
        DisplayActivityWelcome();
        DisplayStartingMessage();
        
        bool first = true;
        DateTime stopTime = EndTime();
        while (DateTime.Now < stopTime)
        {
            Console.Write(BreathIn());
            if (first)
            {
                Thread.Sleep(5000);
                first = false;
            }
            else
                ShowCountDown(5);

            Console.WriteLine();
            Console.Write(BreathOut());

            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }

    private string BreathIn()
    {
        return "Breath In... ";
    }

    private string BreathOut()
    {
        return "Breath Out... ";
    }
}

using System.Threading.Tasks.Dataflow;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    private List<string> _responses = new List<string>();

    public ListingActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void Run()
    {

        DisplayActivityWelcome();
        DisplayStartingMessage();

        DateTime stopTime = EndTime();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin:");

        while (DateTime.Now < stopTime)
        {
            Console.Write(">");
            _responses.Add(Console.ReadLine());

        }
        Console.WriteLine("You listed " + _responses.Count + " items!");

        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("--- Who are people that you appreciate? ---");
        prompts.Add("--- What are personal strengths of yours? ---");
        prompts.Add("--- Who are people that you have helped this week? ---");
        prompts.Add("--- When have you felt the Holy Ghost this month? ---");
        prompts.Add("--- Who are some of your personal heroes?---");

        Random random = new Random();
        Console.WriteLine(prompts[random.Next(0, prompts.Count)]);
    }

    public List<string> GetListFromUser()
    {
        
        return _responses;
    }
}
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void Run()
    {
        string input;
        
        DisplayActivityWelcome();
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("when you have something in mind, press enter to continue:");



        input = Console.ReadLine();

        DateTime stopTime = EndTime();

        if (input == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
            Console.Write("You may begin in...");
            ShowCountDown(5);
        }
        Console.Clear();

        while (DateTime.Now < stopTime)
        {
            Console.Write("> " + GetRandomQuestion() + " ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("---Think of a time when you stood up for someone else.---");
        prompts.Add("---Think of a time when you did something really difficult.---");
        prompts.Add("---Think of a time when you helped someone in need.---");
        prompts.Add("---Think of a time when you did something truly selfless.---");

        Random random = new Random();
        
        return prompts[random.Next(0, prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        List<string> questions = new List<string>();

        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        
        return questions[random.Next(0, questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}    

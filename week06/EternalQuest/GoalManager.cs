
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private Store _store = new Store();
    protected int _score;

    public GoalManager()
    {

    }
    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            Action action = ReadLineInt() switch
            {
                1 => CreateGoal,
                2 => ListGoalDetails,
                3 => SaveGoals,
                4 => LoadGoals,
                5 => RecordEvent,
                6 => VisitStore,
                7 => () => Environment.Exit(0),
                _ => () => Console.WriteLine("Invalid option. Try again")
            };

            action.Invoke();
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You currently have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Visit the Store");
        Console.WriteLine("  7. Quit.");
        Console.Write("Select a choice from the menu: ");
    }
    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            string complete = " ";
            if (goal.IsComplete())
                complete = "X";
            Console.WriteLine($"{i}. [{complete}] {goal.GetDetailsString()}");
            i++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");

        int choice = ReadLineInt();
        List<string> info = GoalQuestions();

        Goal goal = choice switch
        {
            1 => new SimpleGoal(info[0], info[1], info[2], false),
            2 => new EternalGoal(info[0], info[1], info[2]),
            3 => CreateChecklistGoal(info),
            _ => null
        };

        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine("Goal created successfully!");
        }
    }
    private ChecklistGoal CreateChecklistGoal(List<string> info)
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(info[0], info[1], info[2], bonus, target, 0);
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int goalIndex = ReadLineInt() - 1;

        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }

        Goal goal = _goals[goalIndex];
        goal.RecordEvent();

        if (!int.TryParse(goal.GetPoints(), out int points))
        {
            Console.WriteLine("Error: Could not determine points for this goal.");
            return;
        }

        if (points > 0)
        {
            Console.WriteLine($"Congratulations! You earned {points} points!");
        }

        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter log = new StreamWriter(fileName, false))
        {
            string score = $"CurrentScore: | {_score}";
            log.WriteLine(score);
            foreach (Goal goal in _goals)
            {
                log.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Your goals have been saved successfully!");
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        char delimiter = '|';
        Console.WriteLine($"Loading goals now from {fileName}....");

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lineParts = line.Split(delimiter, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine($"This should be the goal type: {lineParts[0]}");
                if (lineParts[0] == "CurrentScore:")
                {
                    _score = int.Parse(lineParts[1]);
                }
                if (lineParts[0] == "SimpleGoal")
                {
                    bool complete = (lineParts[4] == "True") ? true : false;
                    SimpleGoal simpleGoal = new SimpleGoal(lineParts[1], lineParts[2], lineParts[3], complete);
                    _goals.Add(simpleGoal);
                    //Console.WriteLine("Loaded Simple Goal");
                }
                if (lineParts[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(lineParts[1], lineParts[2], lineParts[3]);
                    _goals.Add(eternalGoal);
                    //Console.WriteLine("Loaded Eternal Goal");
                }
                if (lineParts[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(lineParts[1], lineParts[2], lineParts[3],
                                                                    int.Parse(lineParts[4]), int.Parse(lineParts[5]),
                                                                    int.Parse(lineParts[6]));
                    _goals.Add(checklistGoal);
                    //Console.WriteLine("Loaded Checklist Goal");
                }
            }
        }
    }
    private int ReadLineInt()
    {
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    private string ReadLineStr()
    {
        return Console.ReadLine();
    }
    private List<string> GoalQuestions()
    {
        List<String> str = new List<string>();
        Console.Write("What is the name of your goal? ");
        str.Add(ReadLineStr());
        Console.Write("what is a short description of it? ");
        str.Add(ReadLineStr());
        Console.Write("What is the amount of points associated with it? ");
        str.Add(ReadLineStr());

        return str;
    }
    
    private void VisitStore()
    {
        bool stayInStore = true;

        while (stayInStore)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("1. View Available Items");
            Console.WriteLine("2. View Purchased Items");
            Console.WriteLine("3. Purchase an Item");
            Console.WriteLine("4. Return to Main Menu");
            Console.Write("Choose an option: ");

            int storeChoice = ReadLineInt();

            switch (storeChoice)
            {
                case 1:
                    _store.DisplayItems();
                    break;
                case 2:
                    _store.DisplayPurchased();
                    break;
                case 3:
                    _store.DisplayItems();
                    Console.Write("Enter item number to purchase: ");
                    int itemNumber = ReadLineInt();

                    int cost = _store.Purchase(itemNumber, _score);
                    if (cost > 0)
                    {
                        _score -= cost;
                        Console.WriteLine($"Remaining points: {_score}");
                    }
                    break;
                case 4:
                    stayInStore = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
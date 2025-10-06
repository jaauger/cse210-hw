public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _firstComplete = false;

    public ChecklistGoal(string name, string description, string points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
        }
        else
        {
            Console.WriteLine("This goal has been completed. Please choose another goal.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetPoints()
    {
        if (!IsComplete())
        {
            return _points;
        }
        if (!_firstComplete)
        {
            _firstComplete = true;
            return _bonus.ToString();
        }

        return "0";     
    }
    public override string GetDetailsString()
    {
        return $"{_name} ({_description}) -- currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {_name} | {_description} | {_points} | {_bonus} | {_target} | {_amountCompleted}";
    }
}
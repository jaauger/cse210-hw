public class SimpleGoal : Goal
{
    private bool _IsComplete;
    private bool _allowPoints = true;

    public SimpleGoal(string name, string description, string points, bool complete) : base(name, description, points)
    {
        _IsComplete = complete;
    }

    public override void RecordEvent()
    {
        if (_IsComplete == true)
        {
            Console.WriteLine("This goal has been completed. Please choose another goal.");
        }
        else
        {
            _IsComplete = true; 
        }
              
    }
    public override string GetPoints()
    {
        if (IsComplete() && _allowPoints)
        {
            _allowPoints = false;
            return _points;
        }
        
        return "0";       
    }
    public override bool IsComplete()
    {
        return _IsComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal | {_name} | {_description} | {_points} | {_IsComplete}";
    }    
}
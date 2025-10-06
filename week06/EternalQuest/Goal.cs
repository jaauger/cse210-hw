using System.ComponentModel;

public class Goal
{
    protected string _name;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual string GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

}
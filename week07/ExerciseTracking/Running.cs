
public class Running : Activity
{
    private double _distance;
    
    public Running(DateOnly date, int duration, double distance) : base("Running", date, duration)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Pace()
    {
        return _duration / Distance();
    }

    public override double Speed()
    {
        return Distance() / _duration * 60;
    }    
}

// VAV110 130 218c
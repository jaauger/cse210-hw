
public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateOnly date, int duration, double speed) : base("Cycling", date, duration)
    {
        _speed = speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Distance()
    {
        return (_speed * _duration) / 60;
    }

    public override double Pace()
    {
        return _duration / Distance();
    }

}
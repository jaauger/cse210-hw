
public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateOnly date, int duration, int laps) : base("Swimming", date, duration)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000 * 0.62;
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
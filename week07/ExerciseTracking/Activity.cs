using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    protected DateOnly _date;
    protected int _duration; // minutes

    protected string _activityType;
    public Activity(string activityType, DateOnly date, int duration)
    {
        _activityType = activityType;
        _date = date;
        _duration = duration;
    }

    public abstract double Speed();

    public abstract double Pace();
    public abstract double Distance();

    public virtual void GetSummary()
    {

        Console.WriteLine(
            $"{_date:dd MMM yyyy} {_activityType} ({_duration} min) - " +
            $"Distance {Distance():0.0} miles, " +
            $"Speed {Speed():0.0} mph, " +
            $"Pace {Pace():0.0} min per mile"
        );
    }
    
    /*
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
    */
}
    
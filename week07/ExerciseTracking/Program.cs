using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);

        Cycling cycling = new Cycling(dateOnly, 300, 18.0);
        activities.Add(cycling);

        Running running = new Running(dateOnly, 30, 4);
        activities.Add(running);
        
        Swimming swimming = new Swimming(dateOnly, 60, 100);
        activities.Add(swimming);

        Cycling cycling1 = new Cycling(dateOnly, 180, 14);
        activities.Add(cycling1);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
} 
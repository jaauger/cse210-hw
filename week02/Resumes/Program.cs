using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "System Engineer";
        job1._company = "Honeywell";
        job1._startYear = 2007;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "VBFA";
        job2._startYear = 2016;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Jason Auger";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}
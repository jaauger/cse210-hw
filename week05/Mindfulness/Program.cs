
/*
1. Session Logging:
    - Each completed activity is recorded in a text file ("mindfulness_log.txt")
      with the date, time, activity type, and duration.
    - This allows the user to track their mindfulness practice history,
      making the program feel more like a real-world app.

 2. Personalized Messages:
    - At the beginning of the program, the user is asked for their name.
    - The program then uses the name in activity messages (for example:
      "Great job, Sarah! You completed 60 seconds of mindful breathing.")
    - This makes the experience more engaging and encouraging.
*/
using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write(@"
Menu Options:
    1. Start Breathing Activity
    2. Start Reflecting Activity
    3. Start Listing Activity
    4. Quit.
Select a choice from the menu: ");
            int choice = 0;
            string input = Console.ReadLine();
            choice = int.Parse(input);

            switch (choice)
            { 
                case 1:
                    {
                        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity",
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");                        
                        breathingActivity.Run();                        
                        break;
                    }
                case 2:
                    {
                        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help  you recognize the power you have and how you can use it in other aspects of your life.");
                        reflectingActivity.Run();
                        break;
                    }
                case 3:
                    {
                        ListingActivity listingActivity = new ListingActivity("Listing Activity",
                        "This activity will help you reflect on the good things in your life by having  you list as many things as you can in a certain area.");
                        listingActivity.Run();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }    
    }
}
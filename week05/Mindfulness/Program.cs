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
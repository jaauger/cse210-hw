using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Boolean changeFlag = false;
        do
        {
            string welcome = @"Welcome to the journaling program.
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

            Console.Write(welcome);

            string str = Console.ReadLine();
            int choice = int.Parse(str);

            switch (choice)
            {
                case 1:
                    Random userChoice = new Random();
                    int selection = userChoice.Next(1, 5);
                    Console.WriteLine(RandomQuestion(selection));
                    Console.Write(">");
                    Entry userEntry = new Entry(RandomQuestion(selection), Console.ReadLine());
                    journal.AddEntry(userEntry);
                    changeFlag = true;
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    journal.LoadFromFile("myJournal.txt");
                    break;
                case 4:
                    journal.SaveToFile("myJournal.txt");
                    break;
                case 5:
                    if (changeFlag)
                    {
                        Console.Write("You have unsaved changes to your journal. Would you like to save the changes? (y/n) ");
                        string input = Console.ReadLine();
                        if (input == "y" || input == "Y")
                        { 
                            journal.SaveToFile("myJournal.txt");
                        }                        
                    }
                    Environment.Exit(0);
                    break;

            }
        } while (true);

            static string RandomQuestion(int selection)
            {
                Dictionary<int, string> questions = new Dictionary<int, string>();

                questions.Add(1, "Who was the most interesting person I interacted with today?");
                questions.Add(2, "What was the best part of my day?");
                questions.Add(3, "How did I see the hand of the Lord in my life today?");
                questions.Add(4, "What was the strongest emotion I felt today?");
                questions.Add(5, "If I had one thing I could do over today, what would it be?");

                string question = questions[selection];
                return question;
            }

        }    
    
}
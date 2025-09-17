// Week 3 Assignment scripture memorizer, CSE210, Jason Auger
// Added functionality -- Added option for user to select between 1 and 5 words to hide for each enter key press.  
// This will make the memorizer more challenging if the user selects the higher number of words to hide.
// Added the stretch recommendation to only hide each word once. The program keeps track of the hidden words to make sure not to hide them again.

using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Program.");
        
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        
        reference.SetBook("Proverbs");
        reference.SetChapter("3");
        reference.SetVerses("5-6");
        scripture.SetText("Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct the paths.");
        Console.WriteLine("How many words would you like to hide at a time? (1-5) ");
        Console.Write("> ");
        string strg = Console.ReadLine();
        int choice = int.Parse(strg);
        scripture.SetWordsToHide(choice);
        Console.Write(reference.GetReference() + " ");
        Console.WriteLine(scripture.DisplayScripture());
                
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string str = Console.ReadLine();
            if ( str == "")
            {
                Console.Clear();
                Console.Write(reference.GetReference() + " ");
                scripture.DisplayWithWordsHidden();
                Console.WriteLine();
            }
            else if (str == "quit")
            {
                Environment.Exit(0);
            }
        }
    }        
}   
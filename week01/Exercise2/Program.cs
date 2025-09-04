using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string str = Console.ReadLine();
        int grade = int.Parse(str);
        int remainder = grade % 10;
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        if (grade >= 60 && grade <= 93)
        {
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
            else if (remainder == 0)
            {
                sign = "";
            }
            else
            {
                sign = "";
            }
        }

        Console.WriteLine($"Your gade in the class is a {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the class!");
        }
        else if (grade < 60)
        {
            Console.WriteLine("You did not pass the class. Please retake the class again. I know you can do it!");
        }
        Console.WriteLine($"the remainder is {remainder}");

    }    
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static int SquareNumber(int num)
        {
            return num * num;
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string EnteredName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        static int FavoriteNum()
        {
            Console.Write("Please enter your favorite number: ");
            string str = Console.ReadLine();
            int num = int.Parse(str);

            return num;
        }

        WelcomeMessage();
        string userName = EnteredName();
        int userNum = FavoriteNum();

        int sqr = SquareNumber(userNum);

        Console.WriteLine($"{userName}, the square of your number is: {sqr}");
    }
}
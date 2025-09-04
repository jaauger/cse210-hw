using System;
using System.Data;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        Console.WriteLine("Welcome to the magic number guessing game.");
        string contGame = "yes";
        
        
        do
        {
            int number = randomGenerator.Next(1, 100);
            int numOfGuesses = 0;
            Boolean guessing = true;

            while (guessing == true)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                int guess = int.Parse(input);

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    numOfGuesses += 1;
                    continue;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    numOfGuesses += 1;
                    continue;
                }
                else
                {
                    numOfGuesses++;
                    if (numOfGuesses == 1)
                    {
                        Console.WriteLine("Hole in One! You guessed it in 1 guess");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {numOfGuesses} guesses");
                        break;
                    }

                }

            }

            Console.WriteLine("Would you like to play again? (yes/no)");
            contGame = Console.ReadLine();
        } while (contGame == "yes");



    }
}
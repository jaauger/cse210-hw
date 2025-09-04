using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string str = Console.ReadLine();
            int num = int.Parse(str);

            if (num != 0)
            {
                numbers.Add(num);
            }
            else
            {
                break;
            }
        }

        int sum = 0;
        float average = 0;
        float minVal = float.PositiveInfinity;
        float maxVal = float.NegativeInfinity;
        float minPosVal = float.PositiveInfinity;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > maxVal)
            {
                maxVal = num;
            }

            if (num < minVal)
            {
                minVal = num;
            }
            if (num >= 0 && num < minPosVal)
            {
                minPosVal = num;
            }
        }
        
        average = sum / numbers.Count;
        Console.WriteLine($"A total of {numbers.Count} numbers were added");
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the number is: {average}");
        Console.WriteLine($"The Largest number is: {maxVal}");
        Console.WriteLine($"The smallest number is: {minVal}");
        Console.WriteLine($"The smallest Positive number is: {minPosVal}");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        numbers.Reverse();

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        

    }
}
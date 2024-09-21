using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }


        int total = 0;
        foreach (int value in numbers)
        {
            total += value;
        }
        Console.WriteLine($"The sum is: {total}");


        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int highestNumber = -1;

        foreach (int value in numbers)
        {
            if (value > highestNumber)
            {
                highestNumber = value;
            }
        }
        Console.WriteLine($"The highest number is: {highestNumber}");

        int smallestNumber = 999999999;

        foreach(int value in numbers)
        {
            if (value < smallestNumber && value > 0)
            {
                smallestNumber = value;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
    }
}
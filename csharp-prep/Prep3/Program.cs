using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int secretNumber = randomGenerator.Next(1, 11);

            int guessCount = 0;

            int guess = -1;

            while (guess != secretNumber)
            {
                guessCount ++;
                Console.Write("Please enter a guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > secretNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }
            Console.Write("Would you like to play again? yes/no: ");
            response = Console.ReadLine();
        }
    }
}
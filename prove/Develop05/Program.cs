using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start a breathing activity");
            Console.WriteLine("2. Start a reflecting activity");
            Console.WriteLine("3. Start a listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a number from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (answer == "2")
            {

            }
            else if (answer == "3")
            {

            }
            else if (answer == "4")
            {
                Console.WriteLine("Thanks for using the program!");
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid selection");
                Console.WriteLine();
            }
        }
    }
}
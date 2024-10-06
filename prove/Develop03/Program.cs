using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        Console.Clear();
        Console.Write(reference.GetDisplayText("Proverbs", 3, 5, 6));
        Console.WriteLine(scripture.GetDisplayText());

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWords(3);
                Console.Clear();
                Console.Write(reference.GetDisplayText("Proverbs", 3, 5, 6));
                Console.WriteLine(scripture.GetDisplayText());
            }
        }
    }
}
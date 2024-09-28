using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Test Code

        // Real Code

        Journal entries = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!");
        string choice;
        do
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            // Create entry object to pass through into the journal
            Entry newEntry = new Entry();
            string date = newEntry.Date();
            string prompt = newEntry.GetRandomPrompt();
            newEntry.Display();
            string userResponse = Console.ReadLine();
            newEntry._entryText = userResponse;

            entries.AddEntry(date, prompt, userResponse);
        }
        else if (choice == "2")
        {
            entries.DisplayAll();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Enter the filename:");
            string filename = Console.ReadLine();
            entries.LoadFromFile(filename);
        }
        else if (choice == "4")
        {
            Console.WriteLine("Enter the filename:");
            string filename = Console.ReadLine();
            entries.SaveToFile(filename);
        }
        else if (choice == "5")
        {
            Console.WriteLine("Thanks for using the Journal!");
        }
        else
        {
            Console.WriteLine("Please select a valid operation.");
        }

        } while (choice != "5");
    }
}
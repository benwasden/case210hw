// I ended up removing the .csv part in the Journal class. I thought that appending it for the user would make it easier, but I lost points for it so I just removed it.
// I adjusted the SaveToFile method as well. I couldn't figure out a way to check a csv file for duplicate entries, so I went ahead and adjusted it to make saving
// more in line with what the rubric wanted. It still checks for whether the file exists or not, though if a file is found it asks the user to confirm if they want to overwrite it.
// The same addition of checking whether or not the file exists is also present in the LoadFromFile method.

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
        
        Console.Clear();
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
            Console.WriteLine("Entry recorded!");
            Console.WriteLine();
        }
        else if (choice == "2")
        {
            entries.DisplayAll();
            Console.WriteLine();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Enter the filename:");
            string filename = Console.ReadLine();
            entries.LoadFromFile(filename);
        }
        else if (choice == "4")
        {
            Console.WriteLine("Enter the filename (.txt or .csv preferred):");
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
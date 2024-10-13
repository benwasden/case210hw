using System;
using System.Net;
using System.Runtime.InteropServices;
using System.IO;
using System.Formats.Asn1;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string tdate, string tprompt, string tentry)
    {
        // Put newEntry into _entries
        Entry newEntry = new Entry();
        newEntry._date = tdate;
        newEntry._promptText = tprompt;
        newEntry._entryText = tentry;

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Display all of the entries in _entries list
        // foreach loop and use .Display()

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // Loop through each item in _entries and save to file

        if (File.Exists(file))
        {
            Console.WriteLine();
            Console.WriteLine($"{file} already exists. Would you like to overwrite this journal? (Y/N): ");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "Y")
            {
                // using (StreamWriter outputFile = File.AppendText(file))
                // {
                //     foreach (Entry entry in _entries)
                //     {
                //         outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                //     }
                // }
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                    }
                }
                Console.WriteLine("Save Complete!");
            }
            else
            {
                Console.WriteLine("Exited");
            }
        }
        else
        {
            Console.WriteLine($"Creating {file} and adding entries...");
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
            }
            Console.WriteLine("Save Complete!");
        }
        Console.WriteLine();
    }

    public void LoadFromFile(string file)
    {
        // Loop through each line of file and create Entry objects to put in list

        if (File.Exists(file))
        {
            _entries.Clear();
            Console.WriteLine();
            Console.WriteLine($"Loading {file}...");
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string date = parts[0];
                string prompt = parts[1];
                string userInput = parts[2];

                AddEntry(date, prompt, userInput);
            }
            Console.WriteLine("Load complete!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{file} doesn't exist. Please enter a valid filename.");
            Console.WriteLine();
        }
    }
}
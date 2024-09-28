using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public string Date()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();

        return _date;
    }

    public string GetRandomPrompt()
    {
        PromptGenerator genPrompt = new PromptGenerator();
        _promptText = genPrompt.GetRandomPrompt();

        return _promptText;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date} : {_promptText}");
        Console.WriteLine(_entryText);
    }
}
using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are the people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        Console.WriteLine("List as many responses as you can for the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> totalResponses = GetListFromUser();
        Console.WriteLine($"You listed {totalResponses.Count()} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int indexNumber = randomGenerator.Next(0, _prompts.Count());
        string selectedPrompt = _prompts[indexNumber];

        Console.WriteLine($" --- {selectedPrompt} --- ");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string> {};

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            Console.Write(" > ");
            string response = Console.ReadLine();

            responses.Add(response);
        }
        
        return responses;
    }
}
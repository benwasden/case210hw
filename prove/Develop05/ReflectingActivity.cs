using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you weren't as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        DisplayPrompt();
        Console.Clear();
        DisplayQuestions();
        Console.Clear();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int indexNumber = randomGenerator.Next(0, _prompts.Count());
        string selectedPrompt = _prompts[indexNumber];
        
        return selectedPrompt;
    }
    public string GetRandomQuestion()
    {
        // List<string> usedQuestions = new List<string> {};

        Random randomGenerator2 = new Random();
        int indexNumber2 = randomGenerator2.Next(0, _questions.Count());

        string selectedQuestion = _questions[indexNumber2];

        // for (int i = 0; i < usedQuestions.Count; i++)
        // {
        //     if (usedQuestions.Contains(selectedQuestion))
        //     {
        //         indexNumber2 = randomGenerator2.Next(0, _questions.Count());
        //     }
        //     else
        //     {
        //         usedQuestions.Add(selectedQuestion);
  
        //     }
        // }
        // selectedQuestion = _questions[indexNumber2];

        return selectedQuestion;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
    }
    public void DisplayQuestions()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            ShowSpinner(7);
            Console.WriteLine();
        }
    }
}
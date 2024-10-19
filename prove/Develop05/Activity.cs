using System;
using Microsoft.VisualBasic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        _duration = Convert.ToInt32(durationString);
        Console.Clear();
        Console.WriteLine("Get Ready...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You completed {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
        }
    }
}
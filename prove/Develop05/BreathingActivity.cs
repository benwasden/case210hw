using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(4);
        Console.WriteLine();
        Console.Write("Breathe out...");
        ShowCountDown(4);
        Console.WriteLine();

        while (currentTime <= endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(4);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

        DisplayEndingMessage();
    }
}
using System;

public abstract class Activity
{
    protected string _name;
    private string _date;
    protected double _duration;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_duration} min)- Distance: {Math.Round(CalculateDistance(), 1)} miles, Speed: {Math.Round(CalculateSpeed(), 1)} mph, Pace: {Math.Round(CalculatePace(), 1)} min per mile");
    }
}
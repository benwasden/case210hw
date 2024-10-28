using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double duration, double distance) : base(date, duration)
    {
        _name = "Running";
        _distance = distance;
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (_distance / _duration) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = _duration / _distance;
        return pace;
    }
}
using System;

public class Swimming : Activity
{
    private double _lapCount;
    
    public Swimming(string date, double duration, double lapCount) : base (date, duration)
    {
        _name = "Swimming";
        _lapCount = lapCount;
    }

    public override double CalculateDistance()
    {
        double distance = _lapCount * 50 / 1000 * 0.62;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (CalculateDistance() / _duration) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        return pace;
    }

}
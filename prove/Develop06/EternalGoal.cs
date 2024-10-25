using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public override string RecordEvent()
    {
        return (" ");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return ($"EternalGoal,{_shortName},{_description},{_points}");
    }
}
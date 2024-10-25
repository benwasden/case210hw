using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override string RecordEvent()
    {
        if (_isComplete == true)
        {
            return ("X");
        }
        else
        {
            return (" ");
        }
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return ($"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}");
    }
}
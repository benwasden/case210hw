using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountComplete) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountComplete;
    }

    public override string RecordEvent()
    {
        if (IsComplete() == true)
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
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int GetPoints()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine("You got a bonus for finishing this goal!");
            return _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override string GetDetailsString()
    {
        return ($"{_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}");
    }
    public override string GetStringRepresentation()
    {
        return ($"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}");
    }
}
using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract string RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        return ($"{_shortName} ({_description})");
    }
}
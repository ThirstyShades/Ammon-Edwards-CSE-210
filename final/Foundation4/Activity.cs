using System;

abstract class Activity
{
    protected string _type;
    protected string _date;
    protected int _minutes;

    public Activity(string type, string date, int minutes)
    {
        _type = type; // activity type
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {_type} ({_minutes} min):";
    }
}
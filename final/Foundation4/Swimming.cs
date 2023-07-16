using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base("Swimming", date, minutes)
    {
        _laps = laps;
    }

    // all values are rounded to two decimals
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000.0 * 0.62; // miles
        double roundedDistance = Math.Round(distance,2);
        return roundedDistance;
    }

    public override double GetSpeed()
    {
        double speed =  GetDistance() / _minutes * 60;
        double roundedSpeed = Math.Round(speed, 2);
        return roundedSpeed;
    }

    public override double GetPace()
    {
        double pace = _minutes / GetDistance();
        double roundedPace = Math.Round(pace, 2);
        return roundedPace;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile"; 
    }
}

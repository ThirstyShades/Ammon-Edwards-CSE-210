using System;

class Running : Activity
{
    private double _distance;

// after making the foundation three progroum I learned a more effecit way to assign a name/type attribute, instead of doing so in each class, I can just do it in the base and pass it in. I am really glad I did the four pillars now isntead of making my own program as I have defenditly learned alot more neat tricks. 
    public Running(string date, int minutes, double distance) : base("Running", date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";// to make it more clear when I am inharting the base I tryed a old python trick of using the + to append two strings/parts together, it worked! 
    }
}

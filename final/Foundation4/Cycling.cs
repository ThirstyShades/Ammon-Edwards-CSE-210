using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base("Cycling", date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // We do not use this (I think it is really difficult to figure out what information the program wan'ts from the descirption it's to vauge and only gives a exsample for the running class. however it is a stationary bisicle so it dose not go anywere however I am cetain there is a dial on the bike that tells you such things. so here is the math if somone ever did wan't to know) 
        // Distance (miles) = Speed (mph) * Time (hours)
        return _speed * (_minutes / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" Speed: {_speed} mph, Pace: {GetPace()} min per mile"; // I tryed to round the values to 2 decimals but it was not working so I took it out. I don't belive that is reqiared, just a persinal preferance thing I wan'ted to do. 
    }
}

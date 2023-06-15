public class Square : Shape // IDK we need to do this it is LITERLY THE SAME AS A RECTANGLE!!!
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    
    public override double GetArea()
    {
        return _side * _side;
    }
}
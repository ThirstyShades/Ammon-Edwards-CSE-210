public class Circle : Shape
{
    private double _rad;

    public Circle(string color, double rad) : base (color)
    {
        _rad = rad;
    }

    public override double GetArea()
        {
            // return _rad * _rad * float.Parse(Math.PI);
            // I don't get double but whatever
            return _rad * _rad * Math.PI;
        }

        
}


// using System;

// class Program
// {
//     List<Shape> shapes = new List<Shape>();
//     Square square1 = new Square("Blue", 5);
//     shapes.Add(square1);

//     Rect rect1 = new Rect("Red", 5, 2);

//     Circle Cir1 = new Circle("Yellow", 10);

//     foreach (Shape i in shapes)
//     {
//         string color = i.GetColor;
//         string
//     }
    

    
// }

using System;

class Program
{
    static void Main(string[] args)
    {
       
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 4);
        shapes.Add(s1);

        Rect s2 = new Rect("Blue", 5, 10);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 3);
        shapes.Add(s3);

        foreach (Shape i in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = i.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = i.GetArea();

            Console.WriteLine($"Color:{color}\n Area: {area}.");
        }
    }
}
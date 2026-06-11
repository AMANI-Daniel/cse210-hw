using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("red", 6);
        Rectangle rectangle = new Rectangle("blue", 4, 5);
        Circle circle = new Circle("green", 4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The shape is {color} and its area is {area}.");
        }

    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Shape square = new Square("Red", 3);
        Shape rectangle = new Rectangle("bue", 4, 5);
        Shape circle = new Circle("Green", 6);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine($"--------------------------------");
        }
    }
}
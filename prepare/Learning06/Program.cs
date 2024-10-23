using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("Red", 5);
        shapes.Add(square);
        
        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 4);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
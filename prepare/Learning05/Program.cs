using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store different shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // Iterate through the list and display shape details
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}

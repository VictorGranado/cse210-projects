using System;
using System.Collections.Generic;

namespace Learning05
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square("Red", 5));
            shapes.Add(new Rectangle("Blue", 4, 6));
            shapes.Add(new Circle("Green", 3));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Color: " + shape.Color);
                Console.WriteLine("Area: " + shape.GetArea());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}


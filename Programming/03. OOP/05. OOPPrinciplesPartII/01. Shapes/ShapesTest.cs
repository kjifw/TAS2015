// Problem 1. Shapes
// * Define abstract class Shape with only one abstract method 
//   CalculateSurface() and fields width and height.
// * Define two new classes Triangle and Rectangle that implement 
//   the virtual method and return the surface of the figure 
//   (heightwidth for rectangle and heightwidth/2 for triangle).
// * Define class Circle and suitable constructor so that at 
//   initialization height must be kept equal to width and implement 
//   the CalculateSurface() method.
// * Write a program that tests the behaviour of the CalculateSurface()
//   method for different shapes (Circle, Rectangle, Triangle) stored 
//   in an array.

namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    class ShapesTest
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = GenerateShapes();

            foreach (var item in shapes)
            {
                Console.WriteLine("{0}: {1}", item.GetType().Name, item);
                Console.WriteLine("surface: {0}", item.CalculateSurface());
            }
        }

        private static List<Shape> GenerateShapes()
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Triangle(8.2, 1.1));
            shapes.Add(new Rectangle(7.3, 6.6));
            shapes.Add(new Triangle(2.2, 7.6));
            shapes.Add(new Circle(2.4));
            shapes.Add(new Rectangle(2.1, 5.6));
            shapes.Add(new Triangle(4.1, 3.7));
            shapes.Add(new Circle(3.8));

            return shapes;
        }
    }
}

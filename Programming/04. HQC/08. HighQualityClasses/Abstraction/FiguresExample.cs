namespace Abstraction
{
    using System;

    public class FiguresExample
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle.");
            Console.WriteLine("My perimeter is {0:f2}.", circle.CalculatePerimeter());
            Console.WriteLine("My surface is {0:f2}.", circle.CalculateSurface());

            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle.");
            Console.WriteLine("My perimeter is {0:f2}.", rect.CalculatePerimeter());
            Console.WriteLine("My surface is {0:f2}.", rect.CalculateSurface());
        }
    }
}

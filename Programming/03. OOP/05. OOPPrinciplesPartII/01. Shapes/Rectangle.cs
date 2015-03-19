
namespace _01.Shapes
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
 
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;

            return surface;
        }
    }
}

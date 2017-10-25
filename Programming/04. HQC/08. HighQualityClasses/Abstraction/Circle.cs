namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Width;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Width * this.Height;
            return surface;
        }
    }
}

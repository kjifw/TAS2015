
namespace _01.Shapes
{
    using System;

    public class Circle : Shape
    {
        public Circle(double width)
            : base(width, width)
        {

        }

        public override double CalculateSurface()
        {
            double surface = (this.Height / 2) * (this.Width / 2) * Math.PI;

            return surface;
        }
    }
}

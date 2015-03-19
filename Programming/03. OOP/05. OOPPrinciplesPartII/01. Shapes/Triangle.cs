﻿
namespace _01.Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            double surface = (this.Height * this.Width) / 2;

            return surface;
        }
    }
}
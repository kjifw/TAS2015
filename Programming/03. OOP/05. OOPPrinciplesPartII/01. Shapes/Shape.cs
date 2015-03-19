
namespace _01.Shapes
{
    using System;
    using System.Text;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive");
                }

                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            StringBuilder shapeInfo = new StringBuilder();

            shapeInfo.Append("width: " + this.Width + ";");
            shapeInfo.Append(" height: " + this.Height);

            return shapeInfo.ToString();
        }
    }
}

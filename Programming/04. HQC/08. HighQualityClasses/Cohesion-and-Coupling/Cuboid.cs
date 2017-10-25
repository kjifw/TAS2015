namespace CohesionAndCoupling
{
    using System;

    public class Cuboid
    {
        private double width;
        private double height;
        private double depth;

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Cuboid.ValidateDimetionalMetrics(value);
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
                Cuboid.ValidateDimetionalMetrics(value);
                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                Cuboid.ValidateDimetionalMetrics(value);
                this.depth = value;
            }
        }

        public double Volume
        {
            get
            {
                return this.Width * this.Height * this.Depth;
            }
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = GeometryUtilities.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = GeometryUtilities.CalculateDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = GeometryUtilities.CalculateDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = GeometryUtilities.CalculateDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        private static void ValidateDimetionalMetrics(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Value cannot be less than 0.");
            }
        }
    }
}

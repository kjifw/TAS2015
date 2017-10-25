namespace Methods
{
    using System;

    public class Point
    {
        public Point(double coordX, double coordY)
        {
            this.CoodX = coordX;
            this.CoordY = coordY;
        }

        public double CoodX { get; set; }
        
        public double CoordY { get; set; }

        public double CalculateDistanceTo(Point second)
        {
            double distanceX = (second.CoodX - this.CoodX) * (second.CoodX - this.CoodX);
            double distanceY = (second.CoordY - this.CoordY) * (second.CoordY - this.CoordY);
            double distance = Math.Sqrt(distanceX + distanceY);
            return distance;
        }
    }
}


namespace _01.To04.Point3D
{
    using System;

    public static class Distance
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double distance;
            double x;
            double y;
            double z;

            x = Math.Pow((second.CoordX - first.CoordX), 2);
            y = Math.Pow((second.CoordY - first.CoordY), 2);
            z = Math.Pow((second.CoordZ - first.CoordZ), 2);

            distance = Math.Sqrt(x + y + z);

            return distance;
        }
    }
}

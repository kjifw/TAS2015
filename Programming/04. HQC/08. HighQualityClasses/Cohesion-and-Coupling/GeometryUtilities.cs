namespace CohesionAndCoupling
{
    using System;

    public static class GeometryUtilities
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(CalculateCoordinatesDistance(x1, x2) + CalculateCoordinatesDistance(y1, y2));
            return distance;
        }

        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(
                CalculateCoordinatesDistance(x1, x2) + 
                CalculateCoordinatesDistance(y1, y2) + 
                CalculateCoordinatesDistance(z1, z2));
            
            return distance;
        }

        private static double CalculateCoordinatesDistance(double first, double second)
        {
            double result = (second - first) * (second - first);
            return result;
        }
    }
}

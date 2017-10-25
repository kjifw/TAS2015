namespace CohesionAndCoupling
{
    using System;

    public static class UtilitiesExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileUtilities.GetFileExtension("example"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                GeometryUtilities.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                GeometryUtilities.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid cube = new Cuboid(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", cube.Volume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", cube.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cube.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cube.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cube.CalculateDiagonalYZ());
        }
    }
}

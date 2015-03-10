
namespace _01.To04.Point3D
{
    using System;
    using System.Collections.Generic;

    class Point3DTest
    {
        static void Main(string[] args)
        {
            // for tasks conditions refer to Tasks.txt in the current project
            Point3D firstPoint = new Point3D(12, 11, 10);
            Point3D secondPoint = new Point3D(6, 7, 3);

            Console.WriteLine("coordinate system start:");
            Console.WriteLine(Point3D.CoordSystemStart);

            Console.WriteLine("first point:");
            Console.WriteLine("{0}", firstPoint);
            Console.WriteLine("second point:");
            Console.WriteLine("{0}", secondPoint);

            double dist = Distance.CalculateDistance(firstPoint, secondPoint);
            
            Console.WriteLine();
            Console.WriteLine("distance between first and second point: {0}", dist);

            Path currentPath = new Path();
            currentPath.AddPoint(Point3D.CoordSystemStart);
            currentPath.AddPoint(firstPoint);
            currentPath.AddPoint(secondPoint);
            currentPath.AddPoint(new Point3D(-2, -4, -3));
            Console.WriteLine();

            Console.WriteLine("Path saved to file: ");
            Console.WriteLine(currentPath);
            PathStorage.SaveToFile(null, currentPath.PathIn3DSpace);

            currentPath.ClearPoints();

            currentPath.AddListOfPoints(PathStorage.LoadFromFile(null));

            Console.WriteLine("Path extracted from file: ");
            Console.WriteLine(currentPath);
        }
    }
}

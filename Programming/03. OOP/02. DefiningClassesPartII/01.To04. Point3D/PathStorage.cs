
namespace _01.To04.Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    public static class PathStorage
    {
        private const string defaultPathToFile = "..//..//sequenceOfPoints.telerikacademy";

        public static string DefaultPathToFile
        {
            get
            {
                return defaultPathToFile;
            }
        }

        public static void SaveToFile(string pathToFile, List<Point3D> points)
        {
            if (string.IsNullOrEmpty(pathToFile))
            {
                pathToFile = PathStorage.DefaultPathToFile;
            }

            StreamWriter writer = new StreamWriter(pathToFile);

            using (writer)
            {
                foreach (var item in points)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static List<Point3D> LoadFromFile(string pathToFile)
        {
            List<Point3D> points = new List<Point3D>();

            if (string.IsNullOrEmpty(pathToFile))
            {
                pathToFile = defaultPathToFile;
            }

            StreamReader reader = new StreamReader(pathToFile);

            using (reader)
            {
                string line = reader.ReadLine();
                int x = 0;
                int y = 0;
                int z = 0;

                while (line != null)
                {
                    string[] coords = line.Split(' ');

                    for (int i = 0; i < coords.Length - 1; i += 2)
                    {
                        if (coords[i] == "x:")
                        {
                            x = Convert.ToInt32(coords[i + 1]);
                        }

                        if (coords[i] == "y:")
                        {
                            y = Convert.ToInt32(coords[i + 1]);
                        }

                        if (coords[i] == "z:")
                        {
                            z = Convert.ToInt32(coords[i + 1]);
                        }
                    }

                    Point3D newPoint = new Point3D(x, y, z);
                    points.Add(newPoint);

                    line = reader.ReadLine();
                }
            }

            return points;
        }
    }
}
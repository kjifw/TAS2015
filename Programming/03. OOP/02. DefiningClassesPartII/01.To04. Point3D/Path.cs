
namespace _01.To04.Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Path
    {
        private List<Point3D> pathIn3DSpace = new List<Point3D>();

        public List<Point3D> PathIn3DSpace
        {
            get
            {
                return this.pathIn3DSpace;
            }
            private set
            {
                this.pathIn3DSpace = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.PathIn3DSpace.Add(point);
        }

        public void AddListOfPoints(List<Point3D> points)
        {
            this.PathIn3DSpace = points;
        }

        public void ClearPoints()
        {
            this.PathIn3DSpace.Clear();
        }

        public override string ToString()
        {
            StringBuilder currentPath = new StringBuilder();

            foreach (var item in this.PathIn3DSpace)
            {
                currentPath.AppendFormat("x: {0}, y: {1}, z:{2}\n", item.CoordX, item.CoordY, item.CoordZ);
            }

            return currentPath.ToString();
        }
    }
}

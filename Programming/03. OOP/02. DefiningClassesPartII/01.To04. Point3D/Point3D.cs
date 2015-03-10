
namespace _01.To04.Point3D
{
    using System;
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D coordSystemStart = new Point3D() { CoordX = 0, CoordY = 0, CoordZ = 0 };

        public Point3D(int x, int y, int z)
            : this()
        {
            this.CoordX = x;
            this.CoordY = y;
            this.CoordZ = z;
        }

        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public int CoordZ { get; set; }
        public static Point3D CoordSystemStart
        {
            get
            {
                return coordSystemStart;
            }
        }

        public override string ToString()
        {
            StringBuilder point = new StringBuilder();

            point.AppendFormat("x: {0} ", this.CoordX);
            point.AppendFormat("y: {0} ", this.CoordY);
            point.AppendFormat("z: {0} ", this.CoordZ);

            return point.ToString();
        }
    }
}

// Problem 4. Triangle surface
// * Write methods that calculate the surface of a triangle by given:
//    * Side and an altitude to it;
//    * Three sides;
//    * Two sides and an angle between them;
// * Use System.Math.

namespace _04.TriangleSurface
{
    using System;

    class TriangleSurface
    {
        static void Main(string[] args)
        {
            double a, b, c, h, angle;
            double area;
            int choice;
            string inputStr;

            Console.WriteLine("Input: ");
            Console.WriteLine("1 if you want to calculate triangle area with one side and altitude");
            Console.WriteLine("2 if you want to calculate triangle area with two sides and angle between them");
            Console.WriteLine("3 if you want to calculate triangle area with three sides");

            inputStr = Console.ReadLine();
            choice = Convert.ToInt32(inputStr);

            switch (choice)
            {
                case 1:
                    Console.Write("Input side: ");
                    inputStr = Console.ReadLine();
                    a = Convert.ToDouble(inputStr);

                    Console.Write("Input altitude: ");
                    inputStr = Console.ReadLine();
                    h = Convert.ToDouble(inputStr);

                    area = TriangleAreaSideAndAltitude(a, h);
                    Console.WriteLine(area);
                    break;

                case 2:
                    Console.Write("Input side: ");
                    inputStr = Console.ReadLine();
                    a = Convert.ToDouble(inputStr);

                    Console.Write("Input side: ");
                    inputStr = Console.ReadLine();
                    b = Convert.ToDouble(inputStr);

                    Console.Write("Input angle: ");
                    inputStr = Console.ReadLine();
                    angle = Convert.ToDouble(inputStr);

                    area = TriangleAreaTwoSidesAndAngle(a, b, angle);
                    Console.WriteLine(area);
                    break;

                case 3:
                    Console.Write("Input side: ");
                    inputStr = Console.ReadLine();
                    a = Convert.ToDouble(inputStr);

                    Console.Write("Input side: ");
                    inputStr = Console.ReadLine();
                    b = Convert.ToDouble(inputStr);

                    Console.Write("Input side: ");
                    inputStr = Console.ReadLine();
                    c = Convert.ToDouble(inputStr);

                    area = TriangleAreaThreeSides(a, b, c);
                    Console.WriteLine(area);
                    break;
            }
        }

        private static double TriangleAreaSideAndAltitude(double side, double alt)
        {
            double area;
            area = (side * alt) / 2;
            return area;
        }

        private static double TriangleAreaThreeSides(double first, double second, double third)
        {
            double area;
            double semiperimeter;
            semiperimeter = (first + second + third) / 2;
            area = Math.Sqrt(semiperimeter * (semiperimeter - first) * (semiperimeter - second)
                * (semiperimeter - third));
            return area;
        }

        private static double TriangleAreaTwoSidesAndAngle(double first, double second, double angle)
        {
            double angleRads = angle * (Math.PI / 180);
            double area = (first * second) * Math.Sin(angleRads) / 2;
            return area;
        }
    }
}

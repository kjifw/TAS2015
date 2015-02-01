// ### Problem 7. Point in a Circle
// * Write an expression that checks if given point (x,  y) is inside a circle `K({0, 0}, 2)`.
// 
// _Examples:_
// 
// |   x  |   y   | inside |
// |:----:|:-----:|:------:|
// | 0    | 1     | true   |
// | -2   | 0     | true   |
// | -1   | 2     | false  |
// | 1.5  | -1    | true   |
// | -1.5 | -1.5  | false  |
// | 100  | -30   | false  |
// | 0    | 0     | true   |
// | 0.2  | -0.8  | true   |
// | 0.9  | -1.93 | false  |
// | 1    | 1.655 | true   |

namespace _07.PointInACircle
{
    using System;

    class PointInACircle
    {
        static void Main(string[] args)
        {
            const int CircleRadius = 2;

            double pointXCoord;
            double pointYCoord;
            string inputStr;
            bool check;

            Console.Write("x: ");
            inputStr = Console.ReadLine();
            pointXCoord = Convert.ToDouble(inputStr);
            Console.Write("y: ");
            inputStr = Console.ReadLine();
            pointYCoord = Convert.ToDouble(inputStr);

            check = Math.Pow(pointXCoord, 2) + Math.Pow(pointYCoord, 2) < Math.Pow(CircleRadius, 2);

            Console.Write("Is inside: ");
            if (check)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

// ### Problem 10. Point Inside a Circle & Outside of a Rectangle
// * Write an expression that checks for given point (x, y) if it is within the circle `K({1, 1}, 1.5)` 
//   and out of the rectangle `R(top=1, left=-1, width=6, height=2)`.
// 
// _Examples:_
// 
// |   x  |   y  | inside K & outside of R |
// |:----:|:----:|:-----------------------:|
// | 1    | 2    | yes                     |
// | 2.5  | 2    | no                      |
// | 0    | 1    | no                      |
// | 2.5  | 1    | no                      |
// | 2    | 0    | no                      |
// | 4    | 0    | no                      |
// | 2.5  | 1.5  | no                      |
// | 2    | 1.5  | yes                     |
// | 1    | 2.5  | yes                     |
// | -100 | -100 | no                      |

namespace _10.PointInOrOutOfFigures
{
    using System;

    class PointInOrOutOfFigures
    {
        static void Main(string[] args)
        {
            string inputStr;
            double pointX;
            double pointY;
            double radius = 1.5;
            double circleX = 1;    // x coordinate of the center of the circle
            double circleY = 1;    // y coordinate of the center of the circle
            double rectTop = 1;
            double rectLeft = -1;
            double rectWidth = 6;
            double rectHeight = 2;

            Console.Write("x: ");
            inputStr = Console.ReadLine();
            pointX = Convert.ToDouble(inputStr);
            Console.Write("y: ");
            inputStr = Console.ReadLine();
            pointY = Convert.ToDouble(inputStr);

            double dist = Math.Pow(pointX - circleX, 2) + Math.Pow(pointY - circleY, 2) - Math.Pow(radius, 2);

            double rectRight = Math.Abs(rectLeft - rectWidth);
            double rectBottom = rectTop - rectHeight;

            bool isOutsideRect = pointX <= rectLeft || rectRight <= pointX || pointY <= rectBottom || rectTop <= pointY;

            Console.Write("inside K & outside of R: ");

            if (dist < 0 && isOutsideRect)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

// ### Problem 3. Circle Perimeter and Area
// * Write a program that reads the radius `r` of a circle and prints its 
//   perimeter and area formatted with `2` digits after the decimal point.
// 
// _Examples:_
// 
// |          r          |          perimeter         |  area |
// |:-------------------:|:--------------------------:|:-----:|
// | 2                   | 12.57                      | 12.57 |
// | 3.5                 | 21.99                      | 38.48 |

namespace _03.CirclePerimeterAndArea
{
    using System;

    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            string inputStr;
            double circleRadius;
            double circlePerimeter;
            double circleArea;

            Console.Write("r: ");
            inputStr = Console.ReadLine();
            circleRadius = Convert.ToDouble(inputStr);

            circlePerimeter = 2 * Math.PI * circleRadius;
            circleArea = Math.PI * Math.Pow(circleRadius, 2);

            Console.WriteLine("perimeter: {0:0.00}", circlePerimeter);
            Console.WriteLine("area: {0:0.00}", circleArea);
        }
    }
}

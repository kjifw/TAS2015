// ### Problem 9. Trapezoids
// * Write an expression that calculates trapezoid's area by given sides `a` and `b` and height `h`.
// 
// _Examples:_
// 
// |   a   |   b   |   h   |    area   |
// |:-----:|:-----:|:-----:|:---------:|
// | 5     | 7     | 12    | 72        |
// | 2     | 1     | 33    | 49.5      |
// | 8.5   | 4.3   | 2.7   | 17.28     |
// | 100   | 200   | 300   | 45000     |
// | 0.222 | 0.333 | 0.555 | 0.1540125 |

namespace _09.Trapezoids
{
    using System;

    class Trapezoids
    {
        static void Main(string[] args)
        {
            string inputStr;
            double a;
            double b;
            double h;
            double area;

            Console.Write("a: ");
            inputStr = Console.ReadLine();
            a = Convert.ToDouble(inputStr);
            Console.Write("b: ");
            inputStr = Console.ReadLine();
            b = Convert.ToDouble(inputStr);
            Console.Write("h: ");
            inputStr = Console.ReadLine();
            h = Convert.ToDouble(inputStr);

            if (a > 0 && b > 0 && h > 0)
            {
                area = ((a + b) / 2) * h;
                Console.WriteLine("area: {0}", area);
            }
            else
            {
                Console.WriteLine("a, b, h must be positive");
            }
        }
    }
}

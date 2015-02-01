// ### Problem 6. Quadratic Equation
// * Write a program that reads the coefficients `a`, `b` and `c` 
//   of a quadratic equation ax<sup>2</sup> + bx + c = 0 and solves it 
//   (prints its real roots).
// 
// _Examples:_
// 
// |   a  |  b  |  c  |     roots     |
// |:----:|:---:|:---:|---------------|
// | 2    | 5   | -3  | x1=-3; x2=0.5 |
// | -1   | 3   | 0   | x1=3; x2=0    |
// | -0.5 | 4   | -8  | x1=x2=4       |
// | 5    | 2   | 8   | no real roots |

namespace _06.QuadraticEquation
{
    using System;

    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double x1;
            double x2;
            double d;
            string inputStr;

            Console.Write("a: ");
            inputStr = Console.ReadLine();
            a = Convert.ToDouble(inputStr);
            Console.Write("b: ");
            inputStr = Console.ReadLine();
            b = Convert.ToDouble(inputStr);
            Console.Write("c: ");
            inputStr = Console.ReadLine();
            c = Convert.ToDouble(inputStr);

            d = (b * b) - (4 * a * c);

            if (d > 0 && a != 0)
            {
                x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Roots are: {0} and {1}", x1, x2);
            }
            else if (d == 0 && a != 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("Roots are: {0}", x1);
            }
            else if (d < 0)
            {
                Console.WriteLine("No real roots.");
            }
            else if (a == 0 && b != 0)
            {
                x1 = (-c) / b;
                Console.WriteLine("Root is: {0}", x1);
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}

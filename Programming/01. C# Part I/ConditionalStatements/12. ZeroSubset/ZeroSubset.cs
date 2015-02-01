// ### Problem 12.* Zero Subset
// * We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// * Assume that repeating the same subset several times is not a problem.
// 
// _Examples:_
// 
// | numbers       | result                |
// |---------------|-----------------------|
// | 3  -2  1  1 8 | -2 + 1 + 1 = 0        |
// |               |                       |
// | 3 1 -7 35 22  | no zero subset        |
// |               |                       |
// | 1 3 -4 -2 -1  | 1 + -1 = 0            |
// |               | 1 + 3 + -4 = 0        |
// |               | 3 + -2 + -1 = 0       |
// |               |                       |
// | 1 1 1 -1 -1   | 1 + -1 = 0            |
// |               | 1 + 1 + -1 + -1 = 0   |
// |               |                       |
// | 0 0 0 0 0     | 0 + 0 + 0 + 0 + 0 = 0 |
// 
// _Hint: you may check for zero each of the 32 subsets with 32 `if` statements._

namespace _12.ZeroSubset
{
    using System;

    class ZeroSubset
    {
        static void Main(string[] args)
        {
            // a, b, c, d, e are used for variables names 
            // for simplicity
            string inputStr;
            int a;
            int b;
            int c;
            int d;
            int e;
            string[] numbers;
            int counter = 0;

            inputStr = Console.ReadLine();
            numbers = inputStr.Split(' ');

            a = Convert.ToInt32(numbers[0]);
            b = Convert.ToInt32(numbers[1]);
            c = Convert.ToInt32(numbers[2]);
            d = Convert.ToInt32(numbers[3]);
            e = Convert.ToInt32(numbers[4]);

            if (a == 0)
            {
                counter++;
                Console.WriteLine("{0} = 0", a);
            }

            if (b == 0)
            {
                counter++;
                Console.WriteLine("{0} = 0", b);
            }

            if (c == 0)
            {
                counter++;
                Console.WriteLine("{0} = 0", c);
            }

            if (d == 0)
            {
                counter++;
                Console.WriteLine("{0} = 0", d);
            }

            if (e == 0)
            {
                counter++;
                Console.WriteLine("{0} = 0", e);
            }

            if ((a + b) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", a, b);
            }

            if ((a + c) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", a, c);
            }

            if ((a + d) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", a, d);
            }

            if ((a + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", a, e);
            }

            if ((b + c) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", b, c);
            }

            if ((b + d) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", b, d);
            }

            if ((b + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", b, e);
            }

            if ((c + d) == 0)
            {
                counter++; 
                Console.WriteLine("{0} + {1} = 0", c, d);
            }

            if ((c + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", c, e);
            }

            if ((d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} = 0", d, e);
            }

            if ((a + b + c) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            }

            if ((a + b + d) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            }

            if ((a + b + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            }

            if ((a + c + d) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            }

            if ((a + c + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            }

            if ((a + d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            }

            if ((b + c + d) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            }

            if ((b + c + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            }

            if ((b + d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            }

            if ((c + d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            }

            if ((a + b + c + d) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }

            if ((a + b + c + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            }

            if ((a + b + d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            }

            if ((a + c + d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            }

            if ((b + c + d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            }

            if ((a + b + c + d + e) == 0)
            {
                counter++;
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            }

            if (counter == 0)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}

// ### Problem 10. Fibonacci Numbers
// * Write a program that reads a number `n` and prints on the console the first `n` 
//   members of the Fibonacci sequence (at a single line, separated by comma and space - `, `) :
//   `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …`.
// 
// _Note: You may need to learn how to use loops._
// 
// _Examples:_
// 
// |   n  |        comments        |
// |:----:|------------------------|
// | 1    | 0                      |
// | 3    | 0 1 1                  |
// | 10   | 0 1 1 2 3 5 8 13 21 34 |

namespace _10.FibonacciNumbers
{
    using System;
    using System.Text;

    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int previous = -1;
            int next = 1;
            int n;
            string inputStr;
            StringBuilder output = new StringBuilder();
            int current;

            Console.Write("n: ");
            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            for (int i = 0; i < n; i++)
            {
                current = previous + next;

                if (i == n - 1)
                {
                    output.Append(current.ToString() + "\n");
                }
                else
                {
                    output.Append(current.ToString() + ", ");
                }

                previous = next;
                next = current;                
            }

            Console.WriteLine(output.ToString());
        }
    }
}

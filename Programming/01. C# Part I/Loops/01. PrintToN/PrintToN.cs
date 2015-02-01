// ### Problem 1. Numbers from 1 to N
// * Write a program that enters from the console a positive integer `n` 
//   and prints all the numbers from `1` to `n`, on a single line, separated by a space.
// 
// _Examples:_
// 
// | n            | output    | 
// |--------------|-----------|
// | 3            | 1 2 3     | 
// | 5            | 1 2 3 4 5 |

namespace _01.PrintToN
{
    using System;
    using System.Text;

    class PrintToN
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            StringBuilder output = new StringBuilder();

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            for (int i = 1; i <= n; i++)
            {
                output.AppendFormat("{0} ", i);
            }
            
            Console.WriteLine(output.ToString().TrimEnd(' '));
        }
    }
}

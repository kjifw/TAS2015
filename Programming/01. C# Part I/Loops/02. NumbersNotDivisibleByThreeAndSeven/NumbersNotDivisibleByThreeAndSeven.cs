// ### Problem 2. Numbers Not Divisible by 3 and 7
// * Write a program that enters from the console a positive integer `n` 
//   and prints all the numbers from `1` to `n` not divisible by `3` and `7`, 
//   on a single line, separated by a space.
// 
// _Examples:_
// 
// | n  | output       |
// |----|--------------|
// | 3  | 1 2          |
// | 10 | 1 2 4 5 8 10 |

namespace _02.NumbersNotDivisibleByThreeAndSeven
{
    using System;
    using System.Text;

    class NumbersNotDivisibleByThreeAndSeven
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
                if (i % 3 != 0)
                {
                    if (i % 7 != 0)
                    {
                        output.AppendFormat("{0} ", i);
                    }
                }
            }

            Console.WriteLine(output.ToString().TrimEnd(' '));
        }
    }
}

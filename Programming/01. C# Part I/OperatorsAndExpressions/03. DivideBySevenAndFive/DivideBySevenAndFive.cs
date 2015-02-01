// ### Problem 3. Divide by 7 and 5
// * Write a Boolean expression that checks for given integer if it can be divided
// (without remainder) by `7` and `5` at the same time.
// 
// _Examples:_
// 
// |  n  | Divided by 7 and 5? |
// |:---:|:-------------------:|
// | 3   | false               |
// | 0   | false               |
// | 5   | false               |
// | 7   | false               |
// | 35  | true                |
// | 140 | true                |

namespace _03.DivideBySevenAndFive
{
    using System;

    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            const int Divisor = 35;

            string inputStr;
            int dividend;
            int remainder;
            bool divisionResult;

            Console.Write("Input number: ");
            inputStr = Console.ReadLine();
            dividend = Convert.ToInt32(inputStr);

            remainder = dividend % Divisor;

            divisionResult = remainder == 0 ? true : false;

            Console.WriteLine("Divisible by 5 and 7 at the same time: {0}", divisionResult);
        }
    }
}

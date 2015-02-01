// ### Problem 1. Exchange If Greater
// * Write an if-statement that takes two double variables a and b and exchanges 
//   their values if the first one is greater than the second one. As a result 
//   print the values a and b, separated by a space.
// 
// _Examples:_
// 
// | a    | b   | result  |
// |------|-----|---------|
// | 5    | 2   | 2 5     |
// | 3    | 4   | 3 4     |
// | 5.5  | 4.5 | 4.5 5.5 |

namespace _01.ExchangeIfGreater
{
    using System;

    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double firstDouble;
            double secondDouble;
            string inputStr;

            inputStr = Console.ReadLine();
            firstDouble = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            secondDouble = Convert.ToDouble(inputStr);

            if (firstDouble > secondDouble)
            {
                firstDouble = firstDouble + secondDouble;
                secondDouble = firstDouble - secondDouble;
                firstDouble = firstDouble - secondDouble;
            }

            Console.WriteLine("{0} {1}", firstDouble, secondDouble);
        }
    }
}

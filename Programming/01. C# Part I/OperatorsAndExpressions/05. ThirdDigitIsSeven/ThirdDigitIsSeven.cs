// ### Problem 5. Third Digit is 7?
// * Write an expression that checks for given integer if its third digit from right-to-left is `7`.
// 
// _Examples:_
// 
// |    n    | Third digit 7? |
// |:-------:|:--------------:|
// | 5       | false          |
// | 701     | true           |
// | 9703    | true           |
// | 877     | false          |
// | 777877  | false          |
// | 9999799 | true           |

namespace _05.ThirdDigitIsSeven
{
    using System;

    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;
            int thirdDigit;
            bool result;

            Console.Write("input number: ");
            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            number /= 100;
            thirdDigit = Math.Abs(number % 10);

            result = thirdDigit == 7 ? true : false;

            Console.WriteLine("third digit from left is 7: {0}", result);
        }
    }
}


namespace _01._369
{
    using System;
    using System.Numerics;

    class ThreeSixNine
    {
        static void Main(string[] args)
        {
            string inputStr;
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            BigInteger result = 0;

            inputStr = Console.ReadLine();
            firstNumber = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            thirdNumber = Convert.ToInt32(inputStr);

            if (secondNumber == 3)
            {
                result = firstNumber + thirdNumber;
            }
            else if (secondNumber == 6)
            {
                result = (BigInteger)firstNumber * (BigInteger)thirdNumber;
            }
            else if (secondNumber == 9)
            {
                result = firstNumber % thirdNumber;
            }

            if (result % 3 == 0)
            {
                Console.WriteLine(result / 3);
            }
            else
            {
                Console.WriteLine(result % 3);
            }

            Console.WriteLine(result);
        }
    }
}

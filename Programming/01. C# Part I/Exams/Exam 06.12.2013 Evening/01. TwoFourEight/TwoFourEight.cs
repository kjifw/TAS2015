
namespace _01.TwoFourEight
{
    using System;
    using System.Numerics;

    class TwoFourEight
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

            if (secondNumber == 2)
            {
                result = firstNumber % thirdNumber;
            }
            else if (secondNumber == 4)
            {
                result = firstNumber + thirdNumber;
            }
            else if (secondNumber == 8)
            {
                result = (BigInteger)firstNumber * (BigInteger)thirdNumber;
            }

            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
            }
            else
            {
                Console.WriteLine(result % 4);
            }

            Console.WriteLine(result);
        }
    }
}

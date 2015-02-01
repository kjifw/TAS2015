
namespace _02.NightmareOnCodeStreet
{
    using System;
    using System.Numerics;
    using System.Text.RegularExpressions;

    class NightmareOnCodeStreet
    {
        static void Main(string[] args)
        {
            string inputStr;
            BigInteger oddDigitSum = 0;
            int oddDigitCount = 0;

            inputStr = Console.ReadLine();

            for (int i = 0; i < inputStr.Length; i++)
            {
                if ((i & 1) == 1)
                {
                    var isValidDigit = Regex.IsMatch(inputStr[i].ToString(), @"^[0-9]");
                    if (isValidDigit)
                    {
                        oddDigitSum += inputStr[i] - '0';
                        oddDigitCount++;
                    }
                }
            }

            Console.WriteLine(oddDigitCount + " " + oddDigitSum);
        }
    }
}


namespace _02.TheHorror
{
    using System;
    using System.Numerics;
    using System.Text.RegularExpressions;

    class TheHorror
    {
        static void Main(string[] args)
        {
            string inputStr;
            char[] number;
            BigInteger evenDigitSum = 0;
            long evenDigitCount = 0;

            inputStr = Console.ReadLine();
            number = inputStr.ToCharArray();

            for (int i = 0; i < number.Length; i++)
            {
                if ((i & 1) == 0)
                {
                    var isValidSymbol = Regex.IsMatch(number[i].ToString(), @"^[0-9]");
                    if (isValidSymbol)
                    {
                        evenDigitSum += (number[i] - '0');
                        evenDigitCount++;
                    }
                }
            }

            Console.WriteLine(evenDigitCount + " " + evenDigitSum);
        }
    }
}

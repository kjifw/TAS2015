
namespace _01.StrangeLandNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StrangeLandNumbers
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long numberInDec;
            List<string> digits = new List<string>();
            digits.Add("f");
            digits.Add("bIN");
            digits.Add("oBJEC");
            digits.Add("mNTRAVL");
            digits.Add("lPVKNQ");
            digits.Add("pNWE");
            digits.Add("hT");

            numberInDec = StrangeLandToDec(number, digits);

            Console.WriteLine(numberInDec);
        }

        private static long StrangeLandToDec(string number, List<string> digits)
        {
            string numberAsStr = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {
                string currentDigitAsStr = string.Empty;

                for (int j = i; j < number.Length; j++)
                {
                    currentDigitAsStr += number[j];

                    if (digits.Contains(currentDigitAsStr))
                    {
                        numberAsStr += digits.IndexOf(currentDigitAsStr).ToString();
                        break;
                    }
                }
            }
            
            long numberInDec = 0;
            int power = 0;
            for (int i = numberAsStr.Length - 1; i >= 0; i--)
            {
                int currentDigit = numberAsStr[i] - '0';

                numberInDec += currentDigit * (long)Math.Pow(digits.Count, power);

                power++;
            }

            return numberInDec;
        }

    }
}

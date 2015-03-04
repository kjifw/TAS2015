
namespace _01.Zerg
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Zerg
    {
        static void Main(string[] args)
        {
            const int ZergSystemBase = 15;
            string[] symbolsInZerg = {
                                         "Rawr", "Rrrr", "Hsst", "Ssst",
                                         "Grrr", "Rarr", "Mrrr", "Psst",
                                         "Uaah", "Uaha", "Zzzz", "Bauu",
                                         "Djav", "Myau", "Gruh"
                                     };

            string numberInZerg = Console.ReadLine();

            long numberInDec = ConvertZergToDec(numberInZerg, ZergSystemBase, symbolsInZerg);

            Console.WriteLine(numberInDec);
        }

        private static long ConvertZergToDec(string numberInZerg, int zergSystemBase, string[] symbolsInZerg)
        {
            long number = 0;
            int currentPower = 0;

            for (int i = numberInZerg.Length - 1; i >= 0; i -= 4)
            {
                string currentDigitAsStr =
                    numberInZerg[i - 3].ToString() +
                    numberInZerg[i - 2].ToString() +
                    numberInZerg[i - 1].ToString() +
                    numberInZerg[i - 0].ToString();

                int currentDigit = Array.IndexOf(symbolsInZerg, currentDigitAsStr);

                long systemBaseOnPower = 1;

                for (int j = 0; j < currentPower; j++)
                {
                    systemBaseOnPower *= zergSystemBase;
                }

                number += currentDigit * systemBaseOnPower;
                currentPower++;
            }

            return number;
        }
    }
}

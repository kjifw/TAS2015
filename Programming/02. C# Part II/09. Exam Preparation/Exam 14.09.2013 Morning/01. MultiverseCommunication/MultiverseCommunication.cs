
namespace _01.MultiverseCommunication
{
    using System;

    class MultiverseCommunication
    {
        static void Main(string[] args)
        {
            string[] mulComSymbols = { 
                                     "CHU", "TEL", "OFT", "IVA",
                                     "EMY", "VNB", "POQ", "ERI",
                                     "CAD", "K-A", "IIA", "YLO", "PLA"};

            string numberInMulti = Console.ReadLine();

            long numberInDec = MultiToDec(numberInMulti, mulComSymbols);

            Console.WriteLine(numberInDec);
        }

        private static long MultiToDec(string numberInMulti, string[] mulComSymbols)
        {
            long numberInDec = 0;
            int numeralSystemBase = mulComSymbols.Length;
            int power = 0;

            for (int i = numberInMulti.Length - 1; i >= 0; i -= 3)
            {
                string currentDigitAsStr = numberInMulti[i - 2].ToString() +
                    numberInMulti[i - 1].ToString() +
                    numberInMulti[i].ToString();

                int currentDigit = Array.IndexOf(mulComSymbols, currentDigitAsStr);

                long baseOnPower = 1;

                for (int j = 0; j < power; j++)
                {
                    baseOnPower *= numeralSystemBase;
                }

                numberInDec += currentDigit * baseOnPower;
                power++;
            }

            return numberInDec;
        }
    }
}

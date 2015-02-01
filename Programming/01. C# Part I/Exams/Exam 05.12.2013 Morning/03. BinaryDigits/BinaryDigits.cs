
namespace _03.BinaryDigits
{
    using System;

    class BinaryDigits
    {
        static void Main(string[] args)
        {
            const int bitLines = 4;
            const int bitCount = 16;

            string[] bitZero = new string[bitLines] {   "###", 
                                                        "#.#",
                                                        "#.#",
                                                        "###" };

            string[] bitOne = new string[bitLines] {    ".#.", 
                                                        "##.",
                                                        ".#.",
                                                        "###" };

            int number;
            string inputStr;
            string numberInBinary;
            string lastSixteenBits;

            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            numberInBinary = Convert.ToString(number, 2).PadLeft(32, '0');

            if (numberInBinary.Length > 16)
            {
                lastSixteenBits = numberInBinary.Substring(16, 16);
            }
            else
            {
                lastSixteenBits = numberInBinary;
            }

            for (int i = 0; i < bitLines; i++)
            {
                for (int j = 0; j < bitCount; j++)
                {
                    string currentBit = lastSixteenBits[j].ToString();

                    if (currentBit == "0")
                    {
                        Console.Write(bitZero[i]);
                    }
                    else
                    {
                        Console.Write(bitOne[i]);
                    }

                    if (j != bitCount - 1)
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

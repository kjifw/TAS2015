// Problem 6. binary to hexadecimal
// * Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace _06.BinToHex
{
    using System;
    using System.Text.RegularExpressions;

    class BinToHex
    {
        static void Main(string[] args)
        {
            string inputStr;
            string numberInHex;
            string pattern = @"^[0-1]+$";

            inputStr = Console.ReadLine();
            bool isValidBinaryNumber = Regex.IsMatch(inputStr, pattern);

            while (!isValidBinaryNumber)
            {
                Console.Clear();
                Console.WriteLine("Binary numbers use - 0 and 1");
                inputStr = Console.ReadLine();
                isValidBinaryNumber = Regex.IsMatch(inputStr, pattern);
            }

            numberInHex = BinaryToHexidecimal(inputStr);

            Console.WriteLine(numberInHex);
        }

        private static string BinaryToHexidecimal(string binaryNumber)
        {
            string numberInHexidecimal = string.Empty;
            int remider = binaryNumber.Length % 4;
            string leadingZeros = string.Empty;

            if (remider != 0)
            {
                for (int i = 0; i < 4 - remider; i++)
                {
                    leadingZeros += "0";
                }

                binaryNumber = leadingZeros + binaryNumber;
            }

            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                string temp = binaryNumber[i].ToString() 
                    + binaryNumber[i + 1].ToString() 
                    + binaryNumber[i + 2].ToString() 
                    + binaryNumber[i + 3].ToString();

                switch (temp)
                {
                    case "0000": numberInHexidecimal += "0"; break;
                    case "0001": numberInHexidecimal += "1"; break;
                    case "0010": numberInHexidecimal += "2"; break;
                    case "0011": numberInHexidecimal += "3"; break;
                    case "0100": numberInHexidecimal += "4"; break;
                    case "0101": numberInHexidecimal += "5"; break;
                    case "0110": numberInHexidecimal += "6"; break;
                    case "0111": numberInHexidecimal += "7"; break;
                    case "1000": numberInHexidecimal += "8"; break;
                    case "1001": numberInHexidecimal += "9"; break;
                    case "1010": numberInHexidecimal += "A"; break;
                    case "1011": numberInHexidecimal += "B"; break;
                    case "1100": numberInHexidecimal += "C"; break;
                    case "1101": numberInHexidecimal += "D"; break;
                    case "1110": numberInHexidecimal += "E"; break;
                    case "1111": numberInHexidecimal += "F"; break;
                }
            }

            return numberInHexidecimal;
        }
    }
}

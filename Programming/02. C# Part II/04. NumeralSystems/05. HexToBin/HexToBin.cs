// Problem 5. Hexadecimal to binary
// * Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _05.HexToBin
{
    using System;
    using System.Text.RegularExpressions;

    class HexToBin
    {
        static void Main(string[] args)
        {
            string inputStr;
            string numberInBin; 
            string hexPattern = @"^[A-F0-9]+$";

            inputStr = Console.ReadLine();
            bool isValidHexNumber = Regex.IsMatch(inputStr, hexPattern);
           
            while (!isValidHexNumber)
            {
                Console.Clear();
                Console.WriteLine("Hex numbers use - 0 to 9 and A to F");
                inputStr = Console.ReadLine();
                isValidHexNumber = Regex.IsMatch(inputStr, hexPattern);
            }

            numberInBin = HexidecimalToBinary(inputStr);

            Console.WriteLine(numberInBin);
        }

        private static string HexidecimalToBinary(string hex)
        {
            string binaryAsStr = string.Empty;

            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '1': binaryAsStr += "0001"; break;
                    case '2': binaryAsStr += "0010"; break;
                    case '3': binaryAsStr += "0011"; break;
                    case '4': binaryAsStr += "0100"; break;
                    case '5': binaryAsStr += "0101"; break;
                    case '6': binaryAsStr += "0110"; break;
                    case '7': binaryAsStr += "0111"; break;
                    case '8': binaryAsStr += "1000"; break;
                    case '9': binaryAsStr += "1001"; break;
                    case 'A': binaryAsStr += "1010"; break;
                    case 'B': binaryAsStr += "1011"; break;
                    case 'C': binaryAsStr += "1100"; break;
                    case 'D': binaryAsStr += "1101"; break;
                    case 'E': binaryAsStr += "1110"; break;
                    case 'F': binaryAsStr += "1111"; break;
                }
            }

            binaryAsStr = binaryAsStr.TrimStart('0');

            return binaryAsStr;
        }
    }
}

// ### Problem 1. Declare Variables
// * Declare five variables choosing for each of them the most appropriate 
//   of the types `byte, sbyte, short, ushort, int, uint, long, ulong` 
//   to represent the following values: `52130, -115, 4825932, 97, -10000`.
// * Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

namespace _01.VariablesDeclaration
{
    using System;

    class VariablesDeclaration
    {
        static void Main(string[] args)
        {
            ushort firstNumber = 52130;
            sbyte secondNumber = -115;
            int thirdNumber = 4825932;
            byte fourthNumber = 97;
            short fifthNumber = -10000;

            Console.WriteLine("ushort: {0}", firstNumber);
            Console.WriteLine("sbyte: {0}", secondNumber);
            Console.WriteLine("int: {0}", thirdNumber);
            Console.WriteLine("byte: {0}", fourthNumber);
            Console.WriteLine("short: {0}", fifthNumber);
        }
    }
}

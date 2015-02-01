// ### Problem 12. Extract Bit from Integer
// * Write an expression that extracts from given integer `n` the value of given bit at index `p`.
// 
// _Examples:_
// 
// |   n   | binary representation |  p  | bit @ p |
// |:-----:|:---------------------:|:---:|:-------:|
// | 5     | 00000000 00000101     | 2   | 1       |
// | 0     | 00000000 00000000     | 9   | 0       |
// | 15    | 00000000 00001111     | 1   | 1       |
// | 5343  | 00010100 11011111     | 7   | 1       |
// | 62241 | 11110011 00100001     | 11  | 0       |

namespace _12.ExtractBitFromInteger
{
    using System;

    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;
            int position;
            int bitAtPosition;
            int mask;

            Console.Write("number: ");
            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);
            Console.Write("p: ");
            inputStr = Console.ReadLine();
            position = Convert.ToInt32(inputStr);

            mask = 1 << position;

            if ((number & mask) == mask)
            {
                bitAtPosition = 1;
            }
            else
            {
                bitAtPosition = 0;
            }

            Console.WriteLine("bit @ p: {0}", bitAtPosition);
        }
    }
}

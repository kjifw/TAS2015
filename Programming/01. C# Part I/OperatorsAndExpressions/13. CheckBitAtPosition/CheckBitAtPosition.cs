// ### Problem 13. Check a Bit at Given Position
// * Write a Boolean expression that returns if the bit at position `p` 
//   (counting from `0`, starting from the right) in given integer number `n`, 
//   has value of 1.
// 
// _Examples:_
// 
// |   n   | binary representation of n |  p  | bit @ p == 1 |
// |:-----:|:--------------------------:|:---:|:------------:|
// | 5     | 00000000 00000101          | 2   | true         |
// | 0     | 00000000 00000000          | 9   | false        |
// | 15    | 00000000 00001111          | 1   | true         |
// | 5343  | 00010100 11011111          | 7   | true         |
// | 62241 | 11110011 00100001          | 11  | false        |

namespace _13.CheckBitAtPosition
{
    using System;

    class CheckBitAtPosition
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;
            int position;
            bool bitAtPositionIsOne;
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
                bitAtPositionIsOne = true;
            }
            else
            {
                bitAtPositionIsOne = false;
            }

            Console.WriteLine("bit @ p == 1: {0}", bitAtPositionIsOne);
        }
    }
}

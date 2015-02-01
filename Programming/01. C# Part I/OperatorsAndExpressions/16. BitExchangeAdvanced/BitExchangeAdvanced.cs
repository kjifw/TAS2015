// ### Problem 16.** Bit Exchange (Advanced)
// * Write a program that exchanges bits `{p, p+1, …, p+k-1}` with bits `{q, q+1, …, q+k-1}` of a given 32-bit unsigned integer.
// * The first and the second sequence of bits may not overlap.
// 
// _Examples:_
// 
// |      n      |   p  |  q  |  k |      binary representation of n     | binary result                       | result       |
// |:-----------:|:----:|:---:|:--:|:-----------------------------------:|:-----------------------------------:|--------------|
// | 1140867093  | 3    | 24  | 3  | 01000100 00000000 01000000 00010101 | 01000010 00000000 01000000 00100101 | 1107312677   |
// | 4294901775  | 24   | 3   | 3  | 11111111 11111111 00000000 00001111 | 11111001 11111111 00000000 00111111 | 4194238527   |
// | 2369124121  | 2    | 22  | 10 | 10001101 00110101 11110111 00011001 | 01110001 10110101 11111000 11010001 | 1907751121   |
// | 987654321   | 2    | 8   | 11 | -                                   | -                                   | overlapping  |
// | 123456789   | 26   | 0   | 7  | -                                   | -                                   | out of range |
// | 33333333333 | -1   | 0   | 33 | -                                   | -                                   | out of range |

namespace _16.BitExchangeAdvanced
{
    using System;

    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            string inputStr;
            uint number;
            int positionP;
            int positionQ;
            int numBits;
            uint mask = 0;

            Console.Write("number: ");
            inputStr = Console.ReadLine();
            number = Convert.ToUInt32(inputStr);
            Console.Write("p: ");
            inputStr = Console.ReadLine();
            positionP = Convert.ToInt32(inputStr);
            Console.Write("q: ");
            inputStr = Console.ReadLine();
            positionQ = Convert.ToInt32(inputStr);
            Console.Write("k: ");
            inputStr = Console.ReadLine();
            numBits = Convert.ToInt32(inputStr);

            if (positionP > positionQ)
            {
                int temp = positionP;
                positionP = positionQ;
                positionQ = temp;
            }

            if (positionQ < 0 || (positionQ + numBits) > 32)
            {
                Console.WriteLine("out of range");
            }
            else if ((positionP + numBits) > positionQ)
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                for (int i = 0; i < numBits; i++)
                {
                    mask = mask | Convert.ToUInt32(1 << i);
                }

                uint firstSeq = Convert.ToUInt32(number & (mask << positionP));
                uint secondSeq = Convert.ToUInt32(number & (mask << positionQ));

                number = Convert.ToUInt32(~number);
                number = Convert.ToUInt32(number | (mask << positionP));
                number = Convert.ToUInt32(number | (mask << positionQ));
                number = Convert.ToUInt32(~number);
                number = number | (firstSeq << (positionQ - positionP));
                number = number | (secondSeq >> (positionQ - positionP));

                Console.WriteLine("result: {0}", number);
            }
        }
    }
}

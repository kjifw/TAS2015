// ### Problem 9. Print a Sequence
// * Write a program that prints the first 10 members of the sequence: `2, -3, 4, -5, 6, -7, ...`

namespace _09.PrintSequence
{
    using System;
    using System.Text;

    class PrintSequence
    {
        static void Main(string[] args)
        {
            int sequenceStart = 2;
            int sequenceLength = 10;
            StringBuilder output = new StringBuilder();

            for (int i = sequenceStart; i <= sequenceLength; i += 2)
            {
                output.AppendFormat("{0}\n", i);
                output.AppendFormat("{0}\n", -(i + 1));
            }

            Console.WriteLine(output.ToString());
        }
    }
}

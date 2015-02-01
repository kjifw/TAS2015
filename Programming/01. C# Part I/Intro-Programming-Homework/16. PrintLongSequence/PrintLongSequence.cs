// ### Problem 16.* Print Long Sequence
// * Write a program that prints the first 1000 members of the sequence: `2, -3, 4, -5, 6, -7, …`
// * You might need to learn how to use loops in C# (search in Internet).

namespace _16.PrintLongSequence
{
    using System;
    using System.Text;

    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            int sequenceStart = 2;
            int sequenceLength = 1000;
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

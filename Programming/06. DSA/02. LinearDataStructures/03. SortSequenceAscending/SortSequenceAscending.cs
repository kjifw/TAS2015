namespace _03.SortSequenceAscending
{
    using System;
    using System.Collections.Generic;

    public class SortSequenceAscending
    {
        public static void Main()
        {
            List<int> sequence = ReadSequence();

            PrintSequenceAscending(sequence);
        }

        private static List<int> ReadSequence()
        {
            List<int> sequence = new List<int>();

            string inputStr = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(inputStr))
            {
                int currentNumber = Convert.ToInt32(inputStr);
                sequence.Add(currentNumber);

                inputStr = Console.ReadLine();
            }

            return sequence;
        }

        private static void PrintSequenceAscending(List<int> sequence)
        {
            sequence.Sort();

            foreach (var item in sequence)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}

namespace _06.RemoveOddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddOccurrences
    {
        public static void Main()
        {
            Dictionary<int, int> sequence = ReadSequence();

            Dictionary<int, int> evenOccurrencesOnly = RemoveOddOccurrencesFromSeq(sequence);

            PrintSequence(evenOccurrencesOnly);
        }

        private static void PrintSequence(Dictionary<int, int> evenOccurrencesOnly)
        {
            foreach (var item in evenOccurrencesOnly)
            {
                Console.Write("{0} ", item.Key);
            }

            Console.WriteLine();
        }

        private static Dictionary<int, int> RemoveOddOccurrencesFromSeq(Dictionary<int, int> sequence)
        {
            Dictionary<int, int> evenOccurrencesOnly = new Dictionary<int, int>();

            foreach (var item in sequence)
            {
                if (!((item.Value & 1) == 1))
                {
                    evenOccurrencesOnly.Add(item.Key, item.Value);
                }
            }

            return evenOccurrencesOnly;
        }

        private static Dictionary<int, int> ReadSequence()
        {
            Dictionary<int, int> sequence = new Dictionary<int, int>();

            string inputStr = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(inputStr))
            {
                int currentNumber = Convert.ToInt32(inputStr);

                if (sequence.ContainsKey(currentNumber))
                {
                    sequence[currentNumber]++;
                }
                else
                {
                    sequence.Add(currentNumber, 1);
                }

                inputStr = Console.ReadLine();
            }

            return sequence;
        }
    }
}

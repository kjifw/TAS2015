// Task 2. Write a program that extracts from a given sequence of strings all 
//         elements that present in it odd number of times. Example:
// {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}

namespace _02.FindOddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindOddOccurrences
    {
        public static void Main()
        {
            Dictionary<string, int> sequence = ReadSequence();

            Dictionary<string, int> oddOccurrences = FindOddOccurrencesInSeq(sequence);

            PrintSequence(oddOccurrences);
        }

        private static void PrintSequence(Dictionary<string, int> evenOccurrencesOnly)
        {
            foreach (var item in evenOccurrencesOnly)
            {
                Console.Write("{0} ", item.Key);
            }

            Console.WriteLine();
        }

        private static Dictionary<string, int> FindOddOccurrencesInSeq(Dictionary<string, int> sequence)
        {
            Dictionary<string, int> oddOccurrences = new Dictionary<string, int>();

            foreach (var item in sequence)
            {
                if ((item.Value & 1) == 1)
                {
                    oddOccurrences.Add(item.Key, item.Value);
                }
            }

            return oddOccurrences;
        }

        private static Dictionary<string, int> ReadSequence()
        {
            Dictionary<string, int> sequence = new Dictionary<string, int>();

            string inputStr = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(inputStr))
            {
                if (sequence.ContainsKey(inputStr))
                {
                    sequence[inputStr]++;
                }
                else
                {
                    sequence.Add(inputStr, 1);
                }

                inputStr = Console.ReadLine();
            }

            return sequence;
        }
    }
}

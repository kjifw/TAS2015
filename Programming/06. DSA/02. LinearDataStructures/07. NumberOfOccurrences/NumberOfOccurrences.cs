namespace _07.NumberOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberOfOccurrences
    {
        public static void Main()
        {
            Dictionary<int, int> sequence = ReadSequence();

            PrintSequence(sequence);
        }

        private static void PrintSequence(Dictionary<int, int> sequence)
        {
            foreach (var item in sequence.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} --> {1} times", item.Key, item.Value);
            }

            Console.WriteLine();
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

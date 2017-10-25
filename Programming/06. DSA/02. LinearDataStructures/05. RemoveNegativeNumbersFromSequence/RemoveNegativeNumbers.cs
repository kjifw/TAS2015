namespace _05.RemoveNegativeNumbersFromSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativeNumbers
    {
        public static void Main()
        {
            List<int> sequence = ReadSequence();

            List<int> positiveSequence = sequence
                .Where(x => x >= 0)
                .ToList();

            PrintSequence(positiveSequence);
        }

        private static void PrintSequence(List<int> positiveSequence)
        {
            foreach (var item in positiveSequence)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
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
    }
}

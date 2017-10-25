namespace _04.LongestEquelSubSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestEquelSubSequence
    {
        public static void Main()
        {
            List<int> sequence = ReadSequence();

            List<int> maxEqualSequence = FindMaxEqualSequence(sequence);

            PrintSequence(maxEqualSequence);
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

        private static void PrintSequence(List<int> maxEqualSequence)
        {
            foreach (var item in maxEqualSequence)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }

        private static List<int> FindMaxEqualSequence(List<int> sequence)
        {
            int currentSeqCount = 0;
            int currentSeqIndex = 0;
            int maxSeqIndex = 0;
            int maxSeqCount = 0;
            List<int> maxEqSubArr = new List<int>();

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentSeqCount++;
                    currentSeqIndex = i;
                }
                else
                {
                    currentSeqCount = 1;
                    currentSeqIndex = i + 1;
                }

                if (currentSeqCount > maxSeqCount)
                {
                    maxSeqCount = currentSeqCount;
                    maxSeqIndex = currentSeqIndex;
                }
            }

            for (int i = 0; i < maxSeqCount; i++)
            {
                maxEqSubArr.Add(sequence[maxSeqIndex]);
            }

            return maxEqSubArr;
        }
    }
}

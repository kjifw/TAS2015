namespace _01.SumAvgOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAvgOfSequence
    {
        public static void Main()
        {
            List<int> sequence = ReadSequence();

            double sum = sequence.Sum();
            double average = sequence.Average();

            Console.WriteLine("Sum of the sequence: {0}", sum);
            Console.WriteLine("Average of the sequence: {0}", average);
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

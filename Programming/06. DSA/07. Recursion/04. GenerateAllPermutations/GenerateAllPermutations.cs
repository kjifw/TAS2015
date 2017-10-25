namespace _04.GenerateAllPermutations
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class GenerateAllPermutations
    {
        private static StringBuilder result = new StringBuilder();
        private static int[] arr;

        public static void Main()
        {
            string inputStr = Console.ReadLine();
            int n = Convert.ToInt32(inputStr);

            arr = new int[n];

            GeneratePermutations(0, 1, n);

            Console.WriteLine(result.ToString());
        }

        private static void GeneratePermutations(int index, int start, int end)
        {
            if (index == arr.Length)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            return;
                        }
                    }
                }

                result.AppendLine(string.Join(" ", arr));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;
                GeneratePermutations(index + 1, start, end);
            }
        }
    }
}

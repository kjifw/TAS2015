namespace _06.GenerateSubsetsOfStrings
{
    using System;
    using System.Text;

    public class GenerateSubsetsOfStrings
    {
        private static StringBuilder result = new StringBuilder();
        private static int[] arr;
        private static string[] set = { "test", "rock", "fun" };

        public static void Main()
        {
            string inputStr = Console.ReadLine();
            int k = Convert.ToInt32(inputStr);

            arr = new int[k];

            GenerateCombinations(0, 1, set.Length);

            Console.WriteLine(result.ToString());
        }

        private static void GenerateCombinations(int index, int start, int end)
        {
            if (index == arr.Length)
            {
                StringBuilder current = new StringBuilder();

                for (int i = 0; i < arr.Length; i++)
                {
                    current.Append(set[arr[i] - 1] + " ");
                }

                current.Length--;
                result.AppendLine(current.ToString());

                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;
                GenerateCombinations(index + 1, i + 1, end);
            }
        }
    }
}

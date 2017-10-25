namespace _02.CombinationsWithDuplicates
{
    using System;
    using System.Text;

    public class CombinationsWithDuplicates
    {
        private static StringBuilder result = new StringBuilder();
        private static int[] arr;

        public static void Main()
        {
            string inputStr = Console.ReadLine();
            int n = Convert.ToInt32(inputStr); 
            
            inputStr = Console.ReadLine();
            int k = Convert.ToInt32(inputStr);

            arr = new int[k];

            GenerateCombinations(0, 1, n);

            Console.WriteLine(result.ToString());
        }

        private static void GenerateCombinations(int index, int start, int end)
        {
            if (index == arr.Length)
            {
                result.AppendLine(string.Join(" ", arr));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;
                GenerateCombinations(index + 1, start, end);
            }
        }
    }
}

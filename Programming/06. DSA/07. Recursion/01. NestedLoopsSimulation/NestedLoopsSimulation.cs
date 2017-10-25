namespace _01.NestedLoopsSimulation
{
    using System;
    using System.Text;

    public class NestedLoopsSimulation
    {
        private static StringBuilder result = new StringBuilder();
        private static int[] arr;

        public static void Main()
        {
            string inputStr = Console.ReadLine();
            int num = Convert.ToInt32(inputStr);

            arr = new int[num];

            GenerateCombinations(0, 1, num);

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

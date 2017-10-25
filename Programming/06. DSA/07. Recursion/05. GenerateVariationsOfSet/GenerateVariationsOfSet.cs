namespace _05.GenerateVariationsOfSet
{
    using System;
    using System.Text;

    public class GenerateVariationsOfSet
    {
        private static StringBuilder result = new StringBuilder();
        private static int[] arr;
        private static string[] set = { "hi", "a", "b" };

        public static void Main()
        {
            string inputStr = Console.ReadLine();
            int k = Convert.ToInt32(inputStr);

            arr = new int[k];

            GenerateVariations(0, 1, set.Length);

            Console.WriteLine(result.ToString());
        }

        private static void GenerateVariations(int index, int start, int end)
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
                GenerateVariations(index + 1, start, end);
            }
        }
    }
}

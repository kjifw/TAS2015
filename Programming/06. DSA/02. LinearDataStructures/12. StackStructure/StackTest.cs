namespace _12.StackStructure
{
    using System;

    public class StackTest
    {
        public static void Main()
        {
            int count = 20;
            Stack<int> sequence = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                sequence.Push(i);
            }

            Console.WriteLine("Number of elements in stack: {0}", sequence.Count);

            while (sequence.Count > 0)
            {
                Console.Write("{0} ", sequence.Pop());
            }

            Console.WriteLine();
        }
    }
}

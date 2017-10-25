namespace _09.PrintSequenceOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrintSequenceOfNumbers
    {
        public static void Main()
        {
            string inputStr;
            int number;
            int count = 50;
            Queue<int> workQueue = new Queue<int>();
            List<int> numbers = new List<int>();

            Console.Write("Input n: ");
            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            workQueue.Enqueue(number);

            for (int i = 0; i < count; i += 3)
            {
                int currentElement = workQueue.Dequeue();

                numbers.Add(currentElement);

                workQueue.Enqueue(currentElement + 1);
                workQueue.Enqueue((2 * currentElement) + 1);
                workQueue.Enqueue(currentElement + 2);
            }

            while (workQueue.Count > 0)
            {
                numbers.Add(workQueue.Dequeue());
            }

            numbers.RemoveRange(count, Math.Abs(numbers.Count - count));

            foreach (var item in numbers)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine();
        }
    }
}

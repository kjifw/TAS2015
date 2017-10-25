namespace _02.ReverseSequence
{
    using System;
    using System.Collections.Generic;

    public class ReverseSequence
    {
        public static void Main()
        {
            string inputStr;
            int numbersCount;
            Stack<int> sequenceStack = new Stack<int>();

            Console.Write("Input N:");
            inputStr = Console.ReadLine();

            numbersCount = Convert.ToInt32(inputStr);

            for (int i = 0; i < numbersCount; i++)
            {
                inputStr = Console.ReadLine();
                int currentNumber = Convert.ToInt32(inputStr);
                sequenceStack.Push(currentNumber);
            }

            PrintNumbersFromStack(sequenceStack);
        }

        private static void PrintNumbersFromStack(Stack<int> sequenceStack)
        {
            while (sequenceStack.Count > 0)
            {
                Console.Write("{0} ", sequenceStack.Pop());
            }

            Console.WriteLine();
        }
    }
}

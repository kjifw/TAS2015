namespace _01.VarPrinter
{
    using System;

    public class OuterPrinter
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            OuterPrinter.InnerPrinter currentPrinter = new OuterPrinter.InnerPrinter();
            currentPrinter.Print(true);
        }

        public class InnerPrinter
        {
            public void Print(bool value)
            {
                string valueAsStr = value.ToString();
                Console.WriteLine(valueAsStr);
            }
        }
    }
}

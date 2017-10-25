namespace _03.CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class CompareAdvancedMaths
    {
        private const int IterationCount = 10000;
        private static readonly Stopwatch StopWatch = new Stopwatch();

        public static void Main(string[] args)
        {
            MeasureMathSqrtFunctionTime<float>(100.0f);
            MeasureMathSqrtFunctionTime<double>(100.0);
            MeasureMathSqrtFunctionTime<decimal>(100.0m);

            Console.WriteLine();

            MeasureLogarithmFunctionTime<float>(100.0f);
            MeasureLogarithmFunctionTime<double>(100.0f);

            // MeasureLogarithmFunctionTime<decimal>(100.0m);

            MeasureSineFunctionTime<float>(100.0f);
            MeasureSineFunctionTime<double>(100.0f);
            MeasureSineFunctionTime<decimal>(100.0m);

            Console.WriteLine();
        }

        public static void MeasureMathSqrtFunctionTime<T>(T a)
        {
            StopWatch.Restart();

            for (int i = 1; i < IterationCount; i++)
            {
                a = (T)Math.Sqrt(Convert.ToDouble((dynamic)a));
            }

            StopWatch.Stop();

            Console.WriteLine("Sqrt {0, 15}: {1} ", typeof(T), StopWatch.Elapsed);
        }

        public static void MeasureLogarithmFunctionTime<T>(T a)
        {
            StopWatch.Restart();

            for (int i = 0; i < IterationCount; i++)
            {
                a = (T)Math.Log(Convert.ToDouble((dynamic)a));
            }

            StopWatch.Stop();

            Console.WriteLine("Log {0, 15}: {1} ", typeof(T), StopWatch.Elapsed);
        }

        public static void MeasureSineFunctionTime<T>(T a)
        {
            StopWatch.Restart();

            for (int i = 0; i < IterationCount; i++)
            {
                a = (T)Math.Sin(Convert.ToDouble((dynamic)a));
            }

            StopWatch.Stop();

            Console.WriteLine("Sine {0, 15}: {1} ", typeof(T), StopWatch.Elapsed);
        }
    }
}

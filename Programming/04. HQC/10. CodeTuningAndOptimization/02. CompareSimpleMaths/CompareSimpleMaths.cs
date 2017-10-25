namespace _02.CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class CompareSimpleMaths
    {
        private const int IterationCount = 10000000;
        private static readonly Stopwatch StopWatch = new Stopwatch();

        public static void Main(string[] args)
        {
            MeasureAdditionTime<int>(5, 1);
            MeasureAdditionTime<long>(5, 1);
            MeasureAdditionTime<double>(2.3, 1);
            MeasureAdditionTime<float>(2.3f, 1);
            MeasureAdditionTime<decimal>(2.3m, 1);
            
            Console.WriteLine();

            MeasureSubtractionTime<int>(5, 1);
            MeasureSubtractionTime<long>(5, 1);
            MeasureSubtractionTime<double>(2.3, 1);
            MeasureSubtractionTime<float>(2.3f, 1);
            MeasureSubtractionTime<decimal>(2.3m, 1);

            Console.WriteLine();

            MeasureIncrementationTime<int>(5);
            MeasureIncrementationTime<long>(5);
            MeasureIncrementationTime<double>(2.3);
            MeasureIncrementationTime<float>(2.3f);
            MeasureIncrementationTime<decimal>(2.3m);

            Console.WriteLine();

            MeasureMultiplicationTime<int>(5, 1);
            MeasureMultiplicationTime<long>(5, 1);
            MeasureMultiplicationTime<double>(2.3, 1);
            MeasureMultiplicationTime<float>(2.3f, 1);
            MeasureMultiplicationTime<decimal>(0.5m, 1);

            Console.WriteLine();

            MeasureDivisionTime<int>(5, 1);
            MeasureDivisionTime<long>(5, 1);
            MeasureDivisionTime<double>(2.3, 1);
            MeasureDivisionTime<float>(2.3f, 1);
            MeasureDivisionTime<decimal>(0.5m, 1);

            Console.WriteLine();
        }

        public static void MeasureAdditionTime<T>(T a, T b)
        {
            StopWatch.Restart();

            for (int i = 1; i < IterationCount; i++)
            {
                a = (dynamic)a + (dynamic)b + i;
            }

            StopWatch.Stop();

            Console.WriteLine("Addition {0, 15}: {1}", typeof(T), StopWatch.Elapsed);
        }

        public static void MeasureSubtractionTime<T>(T a, T b)
        {
            StopWatch.Restart();

            for (int i = 1; i < IterationCount; i++)
            {
                a = (dynamic)a - (dynamic)b - i;
            }

            StopWatch.Stop();

            Console.WriteLine("Subtraction {0, 15}: {1}", typeof(T), StopWatch.Elapsed);
        }

        public static void MeasureIncrementationTime<T>(T a)
        {
            StopWatch.Restart();

            for (int i = 1; i < IterationCount; i++)
            {
                a = (dynamic)a + 1;
            }

            StopWatch.Stop();

            Console.WriteLine("Incrementation {0, 15}: {1}", typeof(T), StopWatch.Elapsed);
        }

        public static void MeasureMultiplicationTime<T>(T a, T b)
        {
            StopWatch.Restart();

            for (int i = 1; i < IterationCount; i++)
            {
                a = (dynamic)a * (dynamic)b;
            }

            StopWatch.Stop();

            Console.WriteLine("Multiplication {0, 15}: {1}", typeof(T), StopWatch.Elapsed);
        }

        public static void MeasureDivisionTime<T>(T a, T b)
        {
            StopWatch.Restart();

            for (int i = 1; i < IterationCount; i++)
            {
                a = (dynamic)a / (dynamic)b;
            }

            StopWatch.Stop();

            Console.WriteLine("Division {0, 15}: {1}", typeof(T), StopWatch.Elapsed);
        }
    }
}

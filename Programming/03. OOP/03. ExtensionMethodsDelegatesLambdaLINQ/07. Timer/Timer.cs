
namespace _07.Timer
{
    using System;
    using System.Threading;

    public delegate void PrintCurrentTime(int t);

    public static class Timer
    {
        public static void PrintTime(int t)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString(string.Format("hh:mm:ss tt")));
                Thread.Sleep(t * 1000);
            }
        }
    }
}

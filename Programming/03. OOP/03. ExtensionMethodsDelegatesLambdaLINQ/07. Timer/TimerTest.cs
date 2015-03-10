// Problem 7. Timer
// * Using delegates write a class Timer that can execute certain 
//   method at each t seconds.

namespace _07.Timer
{
    using System;

    class TimerTest
    {
        static void Main(string[] args)
        {
            int t = 1;

            PrintCurrentTime current = new PrintCurrentTime(Timer.PrintTime);

            current.Invoke(t);
        }
    }
}

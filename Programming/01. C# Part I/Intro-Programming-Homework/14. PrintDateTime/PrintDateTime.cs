// ### Problem 14.* Current Date and Time
// * Create a console application that prints the current date and time. Find out how in Internet.

namespace _14.PrintDateTime
{
    using System;
    
    class PrintDateTime
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine(currentDateTime);
        }
    }
}

// Problem 3. Range Exceptions
// * Define a class InvalidRangeException<T> that holds information about an error 
//   condition related to invalid range. It should hold error message and a range definition [start … end].
// * Write a sample application that demonstrates the InvalidRangeException<int> 
//   and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the
//   range [1.1.1980 … 31.12.2013].

namespace _03.RangeExceptions
{
    using System;

    class RangeExceptions
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            int number = 1405;
            try
            {
                if (number < start || number > end)
                {
                    throw new InvalidRangeException<int>(start, end);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Range is: ({0}, {1})", e.LowBorder, e.HighBorder);
            }

            DateTime firstDate = new DateTime(1980, 1, 1);
            DateTime secondDate = new DateTime(2014, 12, 31);

            DateTime testDate = new DateTime(2016, 1, 4);
            try
            {
                if (testDate < firstDate || testDate > secondDate)
                {
                    throw new InvalidRangeException<DateTime>(firstDate, secondDate);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Range is: ({0}, {1})",
                    e.LowBorder.ToShortDateString(), e.HighBorder.ToShortDateString());
            }
        }
    }
}

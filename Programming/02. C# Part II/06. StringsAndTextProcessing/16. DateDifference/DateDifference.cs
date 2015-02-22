// Problem 16. Date difference
// * Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
// Example:
// 
// Enter the first date: 27.02.2006
// Enter the second date: 3.03.2006
// Distance: 4 days

namespace _16.DateDifference
{
    using System;

    class DateDifference
    {
        static void Main(string[] args)
        {
            DateTime startDate = ReadDate();
            DateTime endDate = ReadDate();

            int dateDistance = DaysBetweenDates(startDate, endDate);

            Console.WriteLine(dateDistance);
        }

        private static DateTime ReadDate()
        {
            string[] inputStrs;

            Console.Write("Input end date in format dd/mm/yyyy or dd.mm.yyyy: ");
            inputStrs = Console.ReadLine().Split(new char[] { '/', '.' }, StringSplitOptions.RemoveEmptyEntries);
            
            DateTime date = new DateTime(
                 Convert.ToInt32(inputStrs[2]),
                 Convert.ToInt32(inputStrs[1]),
                 Convert.ToInt32(inputStrs[0]));

            return date;
        }

        private static int DaysBetweenDates(DateTime startDate, DateTime endDate)
        {
            int count = 0;

            while (startDate.Year <= endDate.Year)
            {

                if (startDate.Year == endDate.Year)
                {
                    while (startDate.DayOfYear < endDate.DayOfYear)
                    {
                        startDate = startDate.AddDays(1);
                        count++;
                    }

                    if (startDate.DayOfYear == endDate.DayOfYear)
                    {
                        break;
                    }
                }
                else
                {
                    startDate = startDate.AddDays(1);
                    count++;
                }
            }

            return count;
        }
    }
}

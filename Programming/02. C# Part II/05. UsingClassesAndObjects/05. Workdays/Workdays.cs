// Problem 5. Workdays
// * Write a method that calculates the number of workdays between 
//   today and given date, passed as parameter.
// * Consider that workdays are all days from Monday to Friday except 
//   a fixed list of public holidays specified preliminary as array.

namespace _05.Workdays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Workdays
    {
        static void Main(string[] args)
        {
            string[] inputStr;
            DateTime startDate = DateTime.Now;
            DateTime endDate;
            int workdays;

            // holidays only for 2015
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(2015, 3, 2));
            holidays.Add(new DateTime(2015, 3, 3));
            holidays.Add(new DateTime(2015, 4, 10));
            holidays.Add(new DateTime(2015, 4, 13));
            holidays.Add(new DateTime(2015, 5, 1));
            holidays.Add(new DateTime(2015, 5, 6));
            holidays.Add(new DateTime(2015, 9, 21));
            holidays.Add(new DateTime(2015, 9, 22));
            holidays.Add(new DateTime(2015, 12, 24));
            holidays.Add(new DateTime(2015, 12, 25));
            holidays.Add(new DateTime(2015, 12, 31));

            Console.Write("Input end date in format dd/mm/yyyy or dd.mm.yyyy: ");
            inputStr = Console.ReadLine().Split(new char[] { '/', '.' }, StringSplitOptions.RemoveEmptyEntries);

            endDate = new DateTime(
                Convert.ToInt32(inputStr[2]),
                Convert.ToInt32(inputStr[1]),
                Convert.ToInt32(inputStr[0]));

            workdays = NumberOfWorkdays(startDate, endDate, holidays);

            Console.WriteLine(workdays);
        }

        private static int NumberOfWorkdays(DateTime start, DateTime end, List<DateTime> holidays)
        {
            int workdays = 0;
            DateTime currentDate = start;

            while (currentDate.Year <= end.Year)
            {
                if (currentDate.Year == end.Year)
                {
                    while (currentDate.DayOfYear < end.DayOfYear)
                    {
                        if (currentDate.DayOfWeek != DayOfWeek.Saturday
                            && currentDate.DayOfWeek != DayOfWeek.Sunday
                            && !holidays.Contains(currentDate.Date))
                        {
                            workdays++;
                        }

                        currentDate = currentDate.AddDays(1);
                    }

                    if (currentDate.DayOfYear > end.DayOfYear)
                    {
                        break;
                    }
                }
                else
                {
                    if (currentDate.DayOfWeek != DayOfWeek.Saturday
                        && currentDate.DayOfWeek != DayOfWeek.Sunday
                        && !holidays.Contains(currentDate.Date))
                    {
                        workdays++;
                    } 
                }

                currentDate = currentDate.AddDays(1);
            }

            return workdays;
        }
    }
}

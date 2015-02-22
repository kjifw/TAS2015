

namespace _03.DayOfTheWeek
{
    using System;

    class DayOfTheWeek
    {
        static void Main(string[] args)
        {
            string day;

            day = CurrentDayOfTheWeek();

            Console.WriteLine(day);
        }

        private static string CurrentDayOfTheWeek()
        {
            DateTime currentDate = DateTime.Now;
            string day = currentDate.DayOfWeek.ToString();

            return day;
        }
    }
}

// Problem 17. Date in Bulgarian
// * Write a program that reads a date and time given in the format: 
//   day.month.year hour:minute:second and prints the date and time 
//   after 6 hours and 30 minutes (in the same format) along with the 
//   day of week in Bulgarian.

namespace _17.DateInBulgarian
{
    using System;
    using System.Globalization;
    using System.Text;

    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            // adjust console fonts
            string inputStr;
            DateTime currentDate;
            int hours = 6;
            int minutes = 30;
            
            inputStr = Console.ReadLine(); //"31.12.2007 23:58:35";

            currentDate = GetDate(inputStr);
            currentDate = currentDate.AddHours(hours);
            currentDate = currentDate.AddMinutes(minutes);

            PrintDateAndDayInBulgarian(currentDate);
        }

        private static void PrintDateAndDayInBulgarian(DateTime date)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo bulgarianCulture = CultureInfo.CreateSpecificCulture("bg-BG");
            DateTimeFormatInfo dateFormat = bulgarianCulture.DateTimeFormat;
           
            Console.WriteLine(Convert.ToString(date, bulgarianCulture));
            Console.WriteLine("ден от седмицате --> {0}", date.ToString("dddd", dateFormat));
        }

        private static DateTime GetDate(string dateAsStr)
        {
            string[] splitDateTime = dateAsStr.Split(' ');
            string date = splitDateTime[0];
            string time = splitDateTime[1];
            string[] splitDate = date.Split('.');
            string[] splitTime = time.Split(':');

            DateTime currentDateAndTime = new DateTime(
                Convert.ToInt32(splitDate[2]), 
                Convert.ToInt32(splitDate[1]), 
                Convert.ToInt32(splitDate[0]),
                Convert.ToInt32(splitTime[0]), 
                Convert.ToInt32(splitTime[1]), 
                Convert.ToInt32(splitTime[2]));

            return currentDateAndTime;
        }
    }
}

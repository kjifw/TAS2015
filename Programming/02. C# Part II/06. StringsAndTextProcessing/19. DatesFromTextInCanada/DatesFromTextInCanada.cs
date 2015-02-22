// Problem 19. Dates from text in Canada
// * Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// * Display them in the standard date format for Canada.

namespace _19.DatesFromTextInCanada
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;

    class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
//            string text = @"Lorem ipsum dolod 223.12.2007 tit amet, 14.12.1815 consectetur adipiscing 17.05.15 to 17.04.0225 elit. 
//                            Aenean consequat id lorol sed 26.121.1999 lorem varius. Fusce 45.16.9999 egestas dictum nunc et mollis. 
//                            Donec elementum libero velit, 17.07.20414 teget lorem -14.-12.-2015 ullamcorper est maximus ut. 
//                            Suspendisse 13.11.2015 condimentum lamal pellentesque 21.02.2015 lebel et porttitor. Aenean ut semper eros.";

            string text = Console.ReadLine();

            List<DateTime> dates = new List<DateTime>();

            dates = ExtractDates(text);

            PrintDatesInCanadian(dates);
        }

        private static void PrintDatesInCanadian(List<DateTime> dates)
        {
            CultureInfo cult = CultureInfo.CreateSpecificCulture("en-CA");
            foreach (var item in dates)
            {
                Console.WriteLine(Convert.ToString(item, cult));
            }

            cult = CultureInfo.CreateSpecificCulture("fr-CA");
            foreach (var item in dates)
            {
                Console.WriteLine(Convert.ToString(item.Date, cult));
            }
        }

        private static List<DateTime> ExtractDates(string text)
        {
            List<DateTime> dates = new List<DateTime>();

            MatchCollection matchedDates = Regex.Matches(text, @"\s+(([0-9]{2})\.([0-9]{2})\.([0-9]{4}))\s+");

            foreach (Match item in matchedDates)
            {
                int date = Convert.ToInt32(item.Groups[2].Value);
                if (date >= 1 && date <= 31)
                {
                    int mounth = Convert.ToInt32(item.Groups[3].Value);
                    if (mounth >= 1 && mounth <= 12)
                    {
                        int year = Convert.ToInt32(item.Groups[4].Value);
                        if (year >= 0 && year <= 9999)
                        {
                            dates.Add( 
                                new DateTime(
                                    Convert.ToInt32(item.Groups[4].Value),
                                    Convert.ToInt32(item.Groups[3].Value),
                                    Convert.ToInt32(item.Groups[2].Value)));
                        }
                    }
                }
            }

            return dates;
        }
    }
}

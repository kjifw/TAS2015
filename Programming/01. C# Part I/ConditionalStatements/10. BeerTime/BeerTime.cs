// ### Problem 10.* Beer Time
// * A beer time is after `1:00 PM` and before `3:00 AM`.
// * Write a program that enters a time in format “hh:mm tt” 
//   (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//   and prints `beer time` or `non-beer time` according to the definition above 
//   or `invalid time` if the time cannot be parsed.
//
// _Note: You may need to learn how to parse dates and times._ 
// 
// _Examples:_
// 
// | time     | result        |
// |----------|---------------|
// | 1:00 PM  | beer time     |
// | 4:30 PM  | beer time     |
// | 10:57 PM | beer time     |
// | 8:30 AM  | non-beer time |
// | 02:59 AM | beer time     |
// | 03:00 AM | non-beer time |
// | 03:26 AM | non-beer time |

namespace _10.BeerTime
{
    using System;

    class BeerTime
    {
        static void Main(string[] args)
        {
            const string AnteMeridiem = "AM";
            const string PostMeridiem = "PM";

            string inputStr;
            string[] input;
            string designator;
            string result;
            int minutes;
            int hours;

            inputStr = Console.ReadLine();
            input = inputStr.Split(' ', ':');

            hours = Convert.ToInt32(input[0]);
            minutes = Convert.ToInt32(input[1]);
            designator = input[2];

            // this while loop is used because of the restrictions for hours and minutes and designator in the task 
            while ((hours > 12 || hours <= 0) || (minutes > 59 || minutes < 0) || 
                (designator != PostMeridiem && designator != AnteMeridiem))
            {
                Console.Clear();
                Console.WriteLine("0 < hours < 12");
                Console.WriteLine("0 <= minutes < 59");
                Console.WriteLine("designator - AM/PM");

                inputStr = Console.ReadLine();
                input = inputStr.Split(' ', ':');

                hours = Convert.ToInt32(input[0]);
                minutes = Convert.ToInt32(input[1]);
                designator = input[2];
            }

            if (hours >= 1 && hours < 12 && designator == PostMeridiem)
            {
                result = "beer time";
            }
            else if ((hours >= 1 && hours < 3 || hours == 12) && designator == AnteMeridiem)
            {
                result = "beer time";
            }
            else
            {
                result = "non-beer time";
            }

            Console.WriteLine(result);
        }
    }
}

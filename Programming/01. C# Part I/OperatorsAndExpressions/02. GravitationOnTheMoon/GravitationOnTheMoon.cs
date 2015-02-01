// ### Problem 2. Gravitation on the Moon
// * The gravitational field of the Moon is approximately `17%` of that on the Earth.
// * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
// 
// _Examples:_
// 
// | weight | weight on the Moon |
// |:------:|:------------------:|
// | 86     | 14.62              |
// | 74.6   | 12.682             |
// | 53.7   | 9.129              |

namespace _02.GravitationOnTheMoon
{
    using System;

    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            const double MoonGravField = 0.17;

            string inputStr;
            double earthWeight;
            double moonWeight;

            Console.Write("Input weight on the Earth: ");
            inputStr = Console.ReadLine();
            earthWeight = Convert.ToDouble(inputStr);

            moonWeight = earthWeight * MoonGravField;

            Console.WriteLine("Weight on the Moon is: {0}", moonWeight);
        }
    }
}

namespace Methods
{
    using System;

    internal class Methods
    {
        internal static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Triangle sides must be positive and bigger than 0.");
            }

            bool isValidTriangle = (a < b + c) && (b < a + c) && (c < a + b);

            if (!isValidTriangle)
            {
                throw new ArgumentException("Triangle with the provided sides is not valid and the area cannot be calculated.");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return area;
        }

        internal static string NumberToDigit(int number)
        {
            if (number < 0 || number > 9)
            {
                throw new ArgumentException("Number cannot be converted to digit.");
            }

            string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eigth", "nine" };

            return digitNames[number];
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Elements cannot be null.");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("The length of the provided array must be atleast one.");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        internal static void PrintAsFixedPoint(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        internal static void PrintRightAlign(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        internal static string LinePosition(Point first, Point second)
        {
            string position = string.Empty;

            if (first.CoodX == second.CoodX)
            {
                position = "vertical";
            }
            else if (first.CoordY == second.CoordY)
            {
                position = "horizontal";
            }
            else
            {
                position = "other";
            }

            return position;
        }

        internal static void Main()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Console.WriteLine("Triangle area: " + CalcTriangleArea(a, b, c));

            int number = 5;
            Console.WriteLine("Number as string digit: " + NumberToDigit(number));

            int[] arr = { 5, -1, 3, 2, 14, 2, 3 };
            Console.WriteLine("Max number in array is: " + FindMax(arr));

            object firstNumber = 1.3;
            object secondNumber = 0.75;
            object thirdNumber = 2.30;
            PrintAsFixedPoint(firstNumber);
            PrintAsPercent(secondNumber);
            PrintRightAlign(thirdNumber);

            Point firstPoint = new Point(3, -1);
            Point secondPoint = new Point(3, 2.5);

            double distance = firstPoint.CalculateDistanceTo(secondPoint);
            Console.WriteLine("Distance between the two points: " + distance);

            string linePoisition = LinePosition(firstPoint, secondPoint);
            Console.WriteLine("Line position: " + linePoisition);

            Student firstStundent = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");
            Student secondStudent = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "Vidin", "gamer, high results");

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                firstStundent.FirstName,
                secondStudent.FirstName,
                firstStundent.IsOlderThan(secondStudent));
        }
    }
}

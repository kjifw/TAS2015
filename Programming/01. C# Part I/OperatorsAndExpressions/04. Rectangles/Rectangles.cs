// ### Problem 4. Rectangles
// * Write an expression that calculates rectangle’s perimeter and area by given width and height.
// 
// _Examples:_
// 
// | width | height | perimeter | area |
// |:-----:|:------:|:---------:|:----:|
// | 3     | 4      | 14        | 12   |
// | 2.5   | 3      | 11        | 7.5  |
// | 5     | 5      | 20        | 25   |

namespace _04.Rectangles
{
    using System;

    class Rectangles
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double perimeter;
            double area;
            string inputStr;

            Console.Write("rectangle width: ");
            inputStr = Console.ReadLine();
            width = Convert.ToDouble(inputStr);
            Console.Write("rectangle height: ");
            inputStr = Console.ReadLine();
            height = Convert.ToDouble(inputStr);

            perimeter = 2 * (width + height);
            area = width * height;

            Console.WriteLine("rectangle perimeter: {0}", perimeter);
            Console.WriteLine("rectangle area: {0}", area);
        }
    }
}

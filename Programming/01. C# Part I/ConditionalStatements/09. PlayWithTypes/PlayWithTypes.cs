// ### Problem 9. Play with Int, Double and String
// * Write a program that, depending on the user’s choice, inputs an `int`, `double` or `string` variable.
// * If the variable is `int` or `double`, the program increases it by one.
// * If the variable is a `string`, the program appends `*` at the end.
// * Print the result at the console. Use switch statement.
// 
// _Example 1:_                          _Example 2:_
// 
// | program                | user  |    | program                | user |
// |------------------------|-------|    |------------------------|------|
// | Please choose a type:  |       |    | Please choose a type:  |      |
// | 1 --> int              |       |    | 1 --> int              |      |
// | 2 --> double           | 3     |    | 2 --> double           | 2    |
// | 3 --> string           |       |    | 3 --> string           |      |
// |                        |       |    |                        |      |
// | Please enter a string: | hello |    | Please enter a double: | 1.5  |
// |                        |       |    |                        |      |
// | hello*                 |       |    | 2.5                    |      |

namespace _09.PlayWithTypes
{
    using System;

    class PlayWithTypes
    {
        static void Main(string[] args)
        {
            string inputStr;
            int menuChoice;
            string result;

            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            inputStr = Console.ReadLine();
            menuChoice = Convert.ToInt32(inputStr);

            switch (menuChoice)
            {
                case 1:
                    int number;

                    Console.Write("Please enter an integer: ");
                    inputStr = Console.ReadLine();
                    number = Convert.ToInt32(inputStr);

                    number += 1;
                    result = number.ToString();
                    break;
                case 2:
                    double someDouble;

                    Console.Write("Please enter a double: ");
                    inputStr = Console.ReadLine();
                    someDouble = Convert.ToDouble(inputStr);

                    someDouble += 1.0;
                    result = someDouble.ToString();
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    inputStr = Console.ReadLine();

                    result = inputStr + "*";
                    break;
                default:
                    result = "options are 1, 2, 3";
                    break;
            }

            Console.WriteLine(result);
        }
    }
}

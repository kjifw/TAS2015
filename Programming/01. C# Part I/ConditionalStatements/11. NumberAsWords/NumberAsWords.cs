// ### Problem 11.* Number as Words
// * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
// 
// _Examples:_
// 
// | numbers | number as words               | 
// |---------|-------------------------------|-
// | 0       | Zero                          | 
// | 9       | Nine                          | 
// | 10      | Ten                           | 
// | 12      | Twelve                        | 
// | 19      | Nineteen                      | 
// | 25      | Twenty five                   | 
// | 98      | Ninety eight                  | 
// | 98      | Ninety eight                  | 
// | 273     | Two hundred and seventy three | 
// | 400     | Four hundred                  | 
// | 501     | Five hundred and one          | 
// | 617     | Six hundred and seventeen     | 
// | 711     | Seven hundred and eleven      | 
// | 999     | Nine hundred and ninety nine  |

namespace _11.NumberAsWords
{
    using System;

    class NumberAsWords
    {
        static void Main(string[] args)
        {
            int number;
            int leftDigit;
            int middleDigit;
            int rightDigit;
            int special;
          
            string middleString = String.Empty;           
            string leftString = String.Empty;            
            string rightString = String.Empty;            
            string specialString = String.Empty;          

            string inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            leftDigit = number / 100;          
            middleDigit = (number % 100) / 10;  
            rightDigit = number % 10;           
            special = number % 100;            

            switch (rightDigit)
            {
                case 0: rightString = String.Empty; break;
                case 1: rightString = "one"; break;
                case 2: rightString = "two"; break;
                case 3: rightString = "three"; break;
                case 4: rightString = "four"; break;
                case 5: rightString = "five"; break;
                case 6: rightString = "six"; break;
                case 7: rightString = "seven"; break;
                case 8: rightString = "eight"; break;
                case 9: rightString = "nine"; break;
            }

            switch (special)
            {
                case 10: specialString = "ten"; break;
                case 11: specialString = "eleven"; break;
                case 12: specialString = "twelve"; break;
                case 13: specialString = "thirteen"; break;
                case 14: specialString = "fourteen"; break;
                case 15: specialString = "fifteen"; break;
                case 16: specialString = "sixteen"; break;
                case 17: specialString = "seventeen"; break;
                case 18: specialString = "eighteen"; break;
                case 19: specialString = "nineteen"; break;
            }

            switch (middleDigit)
            {
                case 0:
                case 1: middleString = String.Empty; break;
                case 2: middleString = "twenty"; break;
                case 3: middleString = "thirty"; break;
                case 4: middleString = "fourty"; break;
                case 5: middleString = "fifty"; break;
                case 6: middleString = "sixty"; break;
                case 7: middleString = "seventy"; break;
                case 8: middleString = "eighty"; break;
                case 9: middleString = "ninety"; break;
            }

            switch (leftDigit)
            {
                case 0: leftString = String.Empty; break;
                case 1: leftString = "one hundred"; break;
                case 2: leftString = "two hundred"; break;
                case 3: leftString = "three hundred"; break;
                case 4: leftString = "four hundred"; break;
                case 5: leftString = "five hundred"; break;
                case 6: leftString = "six hundred"; break;
                case 7: leftString = "seven hundred"; break;
                case 8: leftString = "eight hundred"; break;
                case 9: leftString = "nine hundred"; break;
            }

            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number > 0 && number < 10)
            {
                Console.WriteLine(rightString);
            }
            else if (number >= 10 && number < 20)
            {
                Console.WriteLine(specialString);
            }
            else if (number >= 20 && number < 100)
            {
                Console.WriteLine(middleString + " " + rightString);
            }
            else if (number >= 100 && number < 1000)
            {
                if (middleDigit == 0 && rightDigit != 0)
                {
                    Console.WriteLine(leftString + " and " + rightString);
                }
                else if (special >= 10 && special < 20)
                {
                    Console.WriteLine(leftString + " and " + specialString);
                }
                else if (middleDigit != 0 && rightDigit == 0)
                {
                    Console.WriteLine(leftString + " and " + middleString);
                }
                else if (rightDigit != 0)
                {
                    Console.WriteLine(leftString + " and " + middleString + " " + rightString);
                }
                else
                {
                    Console.WriteLine(leftString);
                }
            }
            else
            {
                Console.WriteLine("Wrong input! Input number between 0 and 999!");
            }
        }
    }
}

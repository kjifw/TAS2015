// ### Problem 14.* Print the ASCII Table
// * Find online more information about ASCII (American Standard Code for Information Interchange) 
// and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//
// _Note: Some characters have a special purpose and will not be displayed as expected. 
// You may skip them or display them differently._
//
// _Note: You may need to use for-loops (learn in Internet how)._

namespace _14.PrintASCIITable
{
    using System;

    class PrintASCIITable
    {
        static void Main(string[] args)
        {
            for (int i = byte.MinValue; i < byte.MaxValue; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}

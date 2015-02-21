// Problem 1. Say Hello
// * Write a method that asks the user for his name and prints “Hello, <name>”
// * Write a program to test this method.
// 
// Example:
// input 	output
// Peter 	Hello, Peter!

namespace _01.SayHello
{
    using System;

    class SayHello
    {
        static void Main(string[] args)
        {
            string personName;

            personName = Console.ReadLine();

            Hello(personName);
        }

        private static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}

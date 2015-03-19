// Problem 4. Person class
// * Create a class Person with two fields – name and age. 
//   Age can be left unspecified (may contain null value. 
//   Override ToString() to display the information of a person 
//   and if age is not specified – to say so.
// * Write a program to test this functionality.

namespace _04.PersonClass
{
    using System;

    class PersonClassTest
    {
        static void Main(string[] args)
        {
            Person first = new Person("pesho", 24);
            Person second = new Person("gosho");

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}

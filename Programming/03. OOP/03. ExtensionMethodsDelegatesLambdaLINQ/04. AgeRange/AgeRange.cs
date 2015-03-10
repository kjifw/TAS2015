// Problem 4. Age range
// * Write a LINQ query that finds the first name and last 
//   name of all students with age between 18 and 24.

namespace _04.AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AgeRange
    {
        static void Main(string[] args)
        {
            int lowBorder = 18;
            int highBorder = 24;

            List<Student> students = new List<Student>();
            students.Add(new Student("Adam", "Smith", 17));
            students.Add(new Student("Sam", "Johnson", 24));
            students.Add(new Student("Rebecca", "Williamson", 18));
            students.Add(new Student("Julia", "Black", 22));
            students.Add(new Student("Alice", "Andrews", 26));

            var studentsInAgeRange = from stud in students
                                     where stud.Age >= lowBorder && stud.Age <= highBorder
                                     select stud;

            foreach (var item in studentsInAgeRange)
            {
                Console.WriteLine(item);
            }
        }
    }
}

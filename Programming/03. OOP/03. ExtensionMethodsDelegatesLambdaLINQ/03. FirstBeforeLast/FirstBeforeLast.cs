// Problem 3. First before last
// * Write a method that from a given array of students finds all 
//   students whose first name is before its last name alphabetically.
// * Use LINQ query operators.


namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FirstBeforeLast
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Adam", "Smith"));
            students.Add(new Student("Sam", "Johnson"));
            students.Add(new Student("Rebecca", "Williamson"));
            students.Add(new Student("Julia", "Black"));
            students.Add(new Student("Alice", "Andrews"));

            var findFirstLastName = from stud in students
                          where stud.FirstName.CompareTo(stud.LastName) < 0
                          select stud;

            foreach (var item in findFirstLastName)
            {
                Console.WriteLine(item);
            }
        }
    }
}

// Problem 5. Order students
// * Using the extension methods OrderBy() and ThenBy() 
//   with lambda expressions sort the students by first 
//   name and last name in descending order.
// * Rewrite the same with LINQ.

namespace _05.OrderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OrderStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Adam", "Smith", 17));
            students.Add(new Student("Adam", "Hunt", 19));
            students.Add(new Student("Sam", "Johnson", 24));
            students.Add(new Student("Rebecca", "Williamson", 18));
            students.Add(new Student("Julia", "Black", 22));
            students.Add(new Student("Alice", "Andrews", 26));
            students.Add(new Student("Tommy", "Williamson", 17));

            var sortedWithLambda = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var item in sortedWithLambda)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var sortedWithLinq = from stud in students
                                 orderby stud.FirstName ascending,
                                 stud.LastName ascending
                                 select stud;

            foreach (var item in sortedWithLinq)
            {
                Console.WriteLine(item);
            }
        }
    }
}

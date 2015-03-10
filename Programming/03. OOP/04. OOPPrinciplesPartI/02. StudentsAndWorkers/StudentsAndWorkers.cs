// Problem 2. Students and workers
// * Define abstract class Human with first name and last name. 
//   Define new class Student which is derived from Human and has 
//   new field – grade. Define class Worker derived from Human with 
//   new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//   that returns money earned by hour by the worker. Define the proper 
//   constructors and properties for this hierarchy.
// * Initialize a list of 10 students and sort them by grade in ascending 
//   order (use LINQ or OrderBy() extension method).
// * Initialize a list of 10 workers and sort them by money per hour in 
//   descending order.
// * Merge the lists and sort them by first name and last name.

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkers
    {
        static void Main(string[] args)
        {
            List<Human> people = new List<Human>();

            List<Student> students = GenerateStudents();
            List<Worker> workers = GenerateWorkers();

            var sortedStudents = from stud in students
                                 orderby stud.Grade ascending
                                 select stud;

            Console.WriteLine("Students: ");
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            var sortedWorkers = from work in workers
                                orderby work.MoneyPerHour() descending
                                select work;

            Console.WriteLine();
            Console.WriteLine("Workers: ");
            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item);
                Console.WriteLine("salary per hour: {0}", item.MoneyPerHour());
                Console.WriteLine();
            }

            people.AddRange(students);
            people.AddRange(workers);

            var sortedPeople = from person in people
                               orderby person.FirstName,
                               person.LastName
                               select new 
                               {
                                   FullName = person.FirstName + " " + person.LastName
                               };

            Console.WriteLine("People merged and sorted by first and last name");
            foreach (var item in sortedPeople)
            {
                Console.WriteLine(item.FullName);
            }
        }

        private static List<Student> GenerateStudents()
        {
            List<Student> students = new List<Student>();
            
            students.Add(new Student("petar", "petrov", 5));
            students.Add(new Student("georgi", "toshev", 3));
            students.Add(new Student("maria", "pesheva", 4));
            students.Add(new Student("nikolay", "petrov", 6));
            students.Add(new Student("kalina", "kirova", 6));
            students.Add(new Student("ivan", "ivanov", 2));
            students.Add(new Student("petko", "petkov", 2));
            students.Add(new Student("teodora", "todorova", 3));
            students.Add(new Student("dimitar", "dimitrov", 5));
            students.Add(new Student("antonia", "atanasova", 4));

            return students;
        }

        private static List<Worker> GenerateWorkers()
        {
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("evgeni", "dimitrov", 16.2m, 7, 6));
            workers.Add(new Worker("georgi", "georgiev", 19.4m, 6, 7));
            workers.Add(new Worker("petar", "petrov", 20, 8, 5));
            workers.Add(new Worker("monika", "ivanova", 15.5m, 3, 8));
            workers.Add(new Worker("hristina", "dimitrova", 11, 6));
            workers.Add(new Worker("dimitar", "iliev", 12.1m, 10, 4));
            workers.Add(new Worker("emiliq", "georgieva", 16, 5, 6));
            workers.Add(new Worker("kaloqn", "dimitrov", 25.9m, 8, 3));
            workers.Add(new Worker("silviq", "pesheva", 13.6m, 8, 7));
            workers.Add(new Worker("atanas", "nedqlkov", 18, 15, 2));

            return workers;
        }
    }
}

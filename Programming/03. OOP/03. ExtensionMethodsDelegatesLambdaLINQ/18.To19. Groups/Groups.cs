
namespace _18.To19.Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Groups
    {
        static void Main(string[] args)
        {
            // PLEASE READ FIRST
            // IMPORTANT: uncomment the task that is currently tested and comment
            //            all else because of too much information on the console.
            // For tasks conditions please refer to Tasks.txt in the current project. 
            List<Student> students = GenerateStudents();

            // Task 18.
            GroupStudentsLinq(students);

            // Task 19.
            //GroupStudentsLambda(students);
        }

        // Task 18.
        private static void GroupStudentsLinq(List<Student> students)
        {
            // Task 18.
            var groupByGroupNameLinq = from stud in students
                                       group stud by stud.GroupName into newGroup
                                       select newGroup;

            foreach (var group in groupByGroupNameLinq)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine("{0} {1}", student.Name, student.Age);
                }

                Console.WriteLine();
            }
        }

        // Task 19.
        private static void GroupStudentsLambda(List<Student> students)
        {
            // Task 19.
            var groupByGroupNameLambda = students.GroupBy(x => x.GroupName);

            foreach (var group in groupByGroupNameLambda)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine("{0} {1}", student.Name, student.Age);
                }

                Console.WriteLine();
            }
        }

        private static List<Student> GenerateStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Jack Gill", 18, "Math"));
            students.Add(new Student("Alex Moore", 17, "Physics"));
            students.Add(new Student("Eve Marshall", 19, "Biology"));
            students.Add(new Student("Joshua Hamilton", 20, "Chemistry"));
            students.Add(new Student("Olivia Andrews", 18, "Physics"));
            students.Add(new Student("Isabelle Sharp", 17, "Biology"));
            students.Add(new Student("Helena Lancaster", 20, "Math"));
            students.Add(new Student("Edward Pearce", 18, "Chemistry"));
            students.Add(new Student("Jade Rees", 19, "Math"));
            students.Add(new Student("Tyler Miller", 17, "Biology"));

            return students;
        } 
    }
}


namespace _09.To15.StudentsManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class StudentsManipulations
    {
        static void Main(string[] args)
        {
            // PLEASE READ FIRST
            // IMPORTANT: uncomment the task that is currently tested and comment
            //            all else because there is too much information on the console.
            // For tasks conditions please refer to Tasks.txt in the current project. 
            // Total count of students in the list - 8. Feel free to remove or add.
            List<Student> students = GenerateStudents();

            // Task 09.
            FindGroupTwoLinq(students);

            // Task 10.
            //FindGroupTwoLambda(students);

            // Task 11.
            //FindAllAbvMails(students);

            // Task 12.
            //FindAllPhonesInSofia(students);

            // Task 13.
            //FindExcelentStudents(students);

            // Task 14.
            //FindStudentsWithLowMarks(students);

            // Task 15. 
            //FindAllMarksOfStudentsEnroledInYear(students);
        }

        // Task 15.
        private static void FindAllMarksOfStudentsEnroledInYear(List<Student> students)
        {
            string year = "2006";

            var marksOfStudentsInYear = from stud in students
                                        where
                                        Regex.IsMatch(
                                            stud.FacultyNumber.ToString(),
                                            @"\d{4}"+ year.Substring(2, 2) + @"\d+")
                                        select stud.Marks;

            foreach (var studs in marksOfStudentsInYear)
            {
                foreach (var grade in studs)
                {
                    Console.Write(grade + " ");
                }

                Console.WriteLine();
            }
        }

        // Task 14.
        public static void FindStudentsWithLowMarks(List<Student> students)
        {
            // Task 14.
            int lowMark = 2;
            int lowMarkCount = 2;

            var studentsWithLowMarks = students.Where(x => x.Marks.Count(y => y == lowMark) == lowMarkCount);

            PrintCollection(studentsWithLowMarks);
        }

        // Task 13.
        private static void FindExcelentStudents(List<Student> students)
        {
            // Task 13.
            int perfectMark = 6;

            var excelentStudents = from stud in students
                                   where stud.Marks.Contains(perfectMark)
                                   select new
                                   {
                                       FullName = stud.FirstName + " " + stud.LastName,
                                       Marks = stud.Marks
                                   };

            foreach (var item in excelentStudents)
            {
                Console.WriteLine("name: {0}", item.FullName);
                Console.Write("marks: ");

                foreach (var mark in item.Marks)
                {
                    Console.Write("{0} ", mark);
                }

                Console.WriteLine();
            }
        }

        // Task 12.
        private static void FindAllPhonesInSofia(List<Student> students)
        {
            // Task 12.
            string phonePrefix = "3592";

            var phonesInSofia = from stud in students
                                where Regex.IsMatch(stud.PhoneNumber, @"^\+" + phonePrefix + @"(.*?)$")
                                select stud;

            PrintCollection(phonesInSofia);
        }

        // Task 11.
        private static void FindAllAbvMails(List<Student> students)
        {
            // Task 11.
            string abvMail = "abv.bg";

            var studentsWithAbvMails = from stud in students
                                       where Regex.IsMatch(stud.Email, @"(.*?)" + abvMail)
                                       select stud;

            PrintCollection(studentsWithAbvMails);
        }

        // Task 10.
        private static void FindGroupTwoLambda(List<Student> students)
        {
            // Task 10.
            var groupTwoOrderedWithLambda = students
               .Where(x => x.GroupNumber == 2)
               .OrderBy(x => x.FirstName);

            PrintCollection(groupTwoOrderedWithLambda);
        }

        // Task 09.
        private static void FindGroupTwoLinq(List<Student> students)
        {
            // Task 09.
            var groupTwoOrderedWithLinq = from stud in students
                                          where stud.GroupNumber == 2
                                          orderby stud.FirstName ascending
                                          select stud;

            PrintCollection(groupTwoOrderedWithLinq);
        }

        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private static List<Student> GenerateStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(
                "Adam", "Smith", 122206589, "+3593 222 111 222",
                "some@gmail.com", new List<int>(new int[] { 2, 3, 4, 2 }), 1));
            students.Add(new Student(
                "Adam", "Hunt", 122206589, "+3592 123 111 222",
                "some@gmail.com", new List<int>(new int[] { 2, 2, 6, 2 }), 2));
            students.Add(new Student(
                "Sam", "Johnson", 122204589, "+3594 222 111 321",
                "sam@abv.bg", new List<int>(new int[] { 2, 3, 2, 4 }), 3));
            students.Add(new Student(
                "Rebecca", "Williamson", 122205568, "+3592 223 100 222",
                "rebecca@abv.bg", new List<int>(new int[] { 5, 3, 4, 6 }), 4));
            students.Add(new Student(
                "Julia", "Black", 122106589, "+3593 222 320 122",
                "juliaBe@gmail.com", new List<int>(new int[] { 2, 5, 4, 2 }), 2));
            students.Add(new Student(
                "John", "Black", 122103332, "+3591 222 333 122",
                "some@abv.bg", new List<int>(new int[] { 2, 6, 4, 3 }), 3));
            students.Add(new Student(
                "Alice", "Andrews", 122105121, "+3597 222 333 122",
                "some@gmail.com", new List<int>(new int[] { 5, 3, 4, 4 }), 4));
            students.Add(new Student(
                "Tommy", "Williamson", 122106589, "+3599 212 312 112",
                "williamson@abv.bg", new List<int>(new int[] { 2, 6, 4, 6 }), 2));

            return students;
        }
    }
}

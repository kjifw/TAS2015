
namespace _01.To03.StudentClass
{
    using System;
    using System.Collections.Generic;

    class StudentClassTest
    {
        static void Main(string[] args)
        {
            // For tasks conditions please refer to Tasks.txt in the current project. 
            List<Student> students = GenerateStudents();

            // Note: first two item on the list are identical
            PrintHashCodes(students);

            Student first = students[0];
            Student second = students[1];

            bool check = first == second;
            Console.WriteLine("first == second: {0}", check);

            check = first.Equals(first);
            Console.WriteLine("first == first: {0}", check);

            check = first.Equals(second);
            Console.WriteLine("first.Eqauls(second): {0}", check);

            check = second.Equals(first);
            Console.WriteLine("second.Eqauls(first): {0}", check);

            check = first != students[2];
            Console.WriteLine("first != third: {0}", check);

            Student s = students[3].Clone() as Student;
            Console.WriteLine("fourth student hash: {0}", students[3].GetHashCode());
            Console.WriteLine("cloned fourth student hash: {0}", s.GetHashCode());
            Console.WriteLine();

            int result = students[3].CompareTo(students[4]);

            Console.WriteLine("compare fourth and fifth: ");
            if (result == -1)
            {
                Console.WriteLine("fourth BEFORE fifth");
            }
            else
            {
                Console.WriteLine("fourth AFTER fifth", result);
            }

            Console.WriteLine();
            Console.WriteLine("fourth: ");
            Console.WriteLine(students[3]);
            Console.WriteLine("fifth: ");
            Console.WriteLine(students[4]);
        }

        private static void PrintHashCodes(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("student: " + i + " hash code: " + students[i].GetHashCode());
            }

            Console.WriteLine();
        }

        private static List<Student> GenerateStudents()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("pesho", 154345453,
                Specialty.PrognosingAndPlanning,
                Faculty.ComputerScience,
                University.TechnicalUniversityOfSofia));
            students.Add(new Student("pesho", 154345453,
                Specialty.PrognosingAndPlanning,
                Faculty.ComputerScience,
                University.TechnicalUniversityOfSofia));
            students.Add(new Student("gosho", 245345453,
                Specialty.Marketing,
                Faculty.EconomyAndInfrastucture,
                University.UniversityOfNationalAndWorldEconomy));
            students.Add(new Student("tosho", 654321567,
                Specialty.Mathematics,
                Faculty.ComputerScience,
                University.SofiaUniversity));
            students.Add(new Student("tosho", 644321567,
                 Specialty.Mathematics,
                 Faculty.ComputerScience,
                 University.SofiaUniversity));

            return students;
        }
    }
}

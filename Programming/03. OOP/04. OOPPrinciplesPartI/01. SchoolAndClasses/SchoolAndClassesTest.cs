// Problem 1. School classes
// * We are given a school. In the school there are classes of students. 
//   Each class has a set of teachers. Each teacher teaches a set of disciplines. 
//   Students have name and unique class number. Classes have unique text identifier. 
//   Teachers have name. Disciplines have name, number of lectures and number of 
//   exercises. Both teachers and students are people. Students, classes, teachers 
//   and disciplines could have optional comments (free text block).
// * Your task is to identify the classes (in terms of OOP) and their attributes and 
//   operations, encapsulate their fields, define the class hierarchy and create a 
//   class diagram with Visual Studio.

namespace _01.SchoolAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SchoolAndClassesTest
    {
        static void Main(string[] args)
        {
            School currentSchool = new School("Old School");
            SchoolClass firstClass = new SchoolClass("first");
            SchoolClass secondClass = new SchoolClass("second");

            List<Discipline> disciplines = GenerateDisciplines();
            List<Teacher> teachers = new List<Teacher>();

            Teacher currentTeacher = new Teacher("pesho");
            currentTeacher.Disciplines = disciplines;
            teachers.Add(currentTeacher);

            currentTeacher = new Teacher("gosho");
            currentTeacher.Disciplines = disciplines;
            teachers.Add(currentTeacher);

            List<Student> students = new List<Student>();
            students.Add(new Student("krasimir", 42));
            students.Add(new Student("dimitar", 14));
            students.Add(new Student("maria", 36));

            firstClass.Students = students;
            firstClass.Teachers = teachers;
            firstClass.Comment = "optional comment";

            students = new List<Student>();
            students.Add(new Student("boris", 11));
            students.Add(new Student("ivan", 27));
            students.Add(new Student("silvia", 34));

            teachers = new List<Teacher>();
            currentTeacher = new Teacher("tosho");
            currentTeacher.Disciplines = disciplines;
            teachers.Add(currentTeacher);

            currentTeacher = new Teacher("atanas");
            currentTeacher.Disciplines = disciplines;
            teachers.Add(currentTeacher);

            secondClass.Students = students;
            secondClass.Teachers = teachers;
            secondClass.Comment = "optional comment";

            currentSchool.Classes = new List<SchoolClass>(new SchoolClass[] { firstClass, secondClass });

            Console.WriteLine(currentSchool);
        }

        private static List<Discipline> GenerateDisciplines()
        {
            List<Discipline> disciplines = new List<Discipline>();

            Discipline currentDiscipline = new Discipline("Biology");
            currentDiscipline.NumberOfLectures = 6;
            currentDiscipline.NumberOfExercises = 7;
            disciplines.Add(currentDiscipline);

            currentDiscipline = new Discipline("Math");
            currentDiscipline.NumberOfLectures = 4;
            currentDiscipline.NumberOfExercises = 3;
            disciplines.Add(currentDiscipline);

            currentDiscipline = new Discipline("Physics");
            currentDiscipline.NumberOfLectures = 5;
            currentDiscipline.NumberOfExercises = 3;
            disciplines.Add(currentDiscipline);

            currentDiscipline = new Discipline("Programming");
            currentDiscipline.NumberOfLectures = 3;
            currentDiscipline.NumberOfExercises = 6;
            disciplines.Add(currentDiscipline);

            return disciplines;
        }
    }
}

namespace SchoolExample.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolExample;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void Course_InitWithValidData_ShouldReturnCorrectInfo()
        {
            string name = "First Course";
            int numberOfStudents = 0;

            Course currentCourse = new Course(name);

            Assert.AreEqual(name, currentCourse.Name);
            Assert.AreEqual(numberOfStudents, currentCourse.Students.Count);
        }

        [TestMethod]
        public void Course_AddValidStudent_ShouldReturnCorrectInfo()
        {
            string name = "First Course";
            int numberOfStudents = 1;
            Student stud = new Student("Pesho", 12345);

            Course currentCourse = new Course(name);

            currentCourse.AddStudent(stud);

            Assert.AreEqual(name, currentCourse.Name);
            Assert.AreEqual(numberOfStudents, currentCourse.Students.Count);
            Assert.IsTrue(currentCourse.Students.Contains(stud));
        }

        [TestMethod]
        public void Course_RemoveValidStudent_ShouldReturnCorrectInfo()
        {
            string name = "First Course";
            int numberOfStudents = 3;
            Student stud1 = new Student("Pesho 1", 12345);
            Student stud2 = new Student("Pesho 2", 12346);
            Student stud3 = new Student("Pesho 3", 12347);
            Student stud4 = new Student("Pesho 4", 12348);

            Course currentCourse = new Course(name);

            currentCourse.AddStudent(stud1);
            currentCourse.AddStudent(stud2);
            currentCourse.AddStudent(stud3);
            currentCourse.AddStudent(stud4);

            currentCourse.RemoveStudent(stud3);

            Assert.AreEqual(name, currentCourse.Name);
            Assert.AreEqual(numberOfStudents, currentCourse.Students.Count);

            Assert.IsTrue(currentCourse.Students.Contains(stud1));
            Assert.IsTrue(currentCourse.Students.Contains(stud2));
            Assert.IsTrue(currentCourse.Students.Contains(stud4));

            Assert.IsFalse(currentCourse.Students.Contains(stud3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_InitWithEmptyName_ShouldThrow()
        {
            string name = string.Empty;

            Course currentCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_InitWithNullName_ShouldThrow()
        {
            string name = null;

            Course currentCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_InitWithWhiteSpaceName_ShouldThrow()
        {
            string name = new string(' ', 10);

            Course currentCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Course_AddNullStudent_ShouldThrow()
        {
            string name = "First Course";

            Course currentCourse = new Course(name);

            currentCourse.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_AddDuplicateStudent_ShouldThrow()
        {
            string name = "First Course";
            Student stud = new Student("Pesho", 12345);

            Course currentCourse = new Course(name);

            currentCourse.AddStudent(stud);
            currentCourse.AddStudent(stud);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_AddMoreThanMaxStudents_ShouldThrow()
        {
            string name = "First Course";
            int numberOfStudents = 31;

            Course currentCourse = new Course(name);

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student stud = new Student("Pesho " + i + 1, 12345 + i);
                currentCourse.AddStudent(stud);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Course_RemoveNullStudent_ShouldThrow()
        {
            string name = "First Course";

            Course currentCourse = new Course(name);

            currentCourse.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_RemoveNonexistentStudent_ShouldThrow()
        {
            string name = "First Course";
            Student stud = new Student("Pesho", 12345);

            Course currentCourse = new Course(name);

            currentCourse.RemoveStudent(stud);
        }
    }
}

namespace SchoolExample.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolExample;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void Student_InitWithValidData_ShouldReturnCorrectInfo()
        {
            string name = "Pesho";
            int number = 45678;

            Student stud = new Student(name, number);

            Assert.AreEqual(name, stud.Name, "Student name incorrect.");
            Assert.AreEqual(number, stud.UniqueNumber, "Student number incorrect.");
        }

        [TestMethod]
        public void Student_InitWithMaxBorderNumber_ShouldReturnCorrectInfo()
        {
            string name = "Pesho";
            int number = 99999;

            Student stud = new Student(name, number);

            Assert.AreEqual(name, stud.Name, "Student name incorrect.");
            Assert.AreEqual(number, stud.UniqueNumber, "Student number incorrect.");
        }

        [TestMethod]
        public void Student_InitWithMinBorderNumber_ShouldReturnCorrectInfo()
        {
            string name = "Pesho";
            int number = 10000;

            Student stud = new Student(name, number);

            Assert.AreEqual(name, stud.Name, "Student name incorrect.");
            Assert.AreEqual(number, stud.UniqueNumber, "Student number incorrect.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_InitWithEmptyName_ShoulThrow()
        {
            string name = string.Empty;
            int number = 12345;

            Student stud = new Student(name, number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_InitWithNullName_ShoulThrow()
        {
            string name = null;
            int number = 12345;

            Student stud = new Student(name, number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_InitWithWhiteSpaceName_ShoulThrow()
        {
            string name = new string(' ', 10);
            int number = 12345;

            Student stud = new Student(name, number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_InitWithNumberAboveMaxNumber_ShouldThrow()
        {
            string name = "Pesho";
            int number = 100000;

            Student stud = new Student(name, number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_InitWithNumberBeneathMinNumber_ShouldThrow()
        {
            string name = "Pesho";
            int number = 9999;

            Student stud = new Student(name, number);
        }
    }
}

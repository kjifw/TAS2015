namespace SchoolExample.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolExample;
    
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void School_InitWithValidData_ShouldReturnCorrectInfo()
        {
            string name = "First School";
            int numberOfCourses = 0;

            School currentSchool = new School(name);

            Assert.AreEqual(name, currentSchool.Name);
            Assert.AreEqual(numberOfCourses, currentSchool.Courses.Count);
        }

        [TestMethod]
        public void School_AddValidCourse_ShouldReturnCorrectInfo()
        {
            string name = "First School";
            int numberOfCourses = 1;
            Course currentCourse = new Course("Course");

            School currentSchool = new School(name);

            currentSchool.AddCourse(currentCourse);

            Assert.AreEqual(name, currentSchool.Name);
            Assert.AreEqual(numberOfCourses, currentSchool.Courses.Count);
            Assert.IsTrue(currentSchool.Courses.Contains(currentCourse));
        }

        [TestMethod]
        public void School_RemoveValidCourse_ShoulReturnCorrectInfo()
        {
            string name = "First School";
            int numberOfCourses = 3;
            Course currentCourse1 = new Course("Course 1");
            Course currentCourse2 = new Course("Course 2");
            Course currentCourse3 = new Course("Course 3");
            Course currentCourse4 = new Course("Course 4");

            School currentSchool = new School(name);
            
            currentSchool.AddCourse(currentCourse1);
            currentSchool.AddCourse(currentCourse2);
            currentSchool.AddCourse(currentCourse3);
            currentSchool.AddCourse(currentCourse4);

            currentSchool.RemoveCourse(currentCourse3);

            Assert.AreEqual(name, currentSchool.Name);
            Assert.AreEqual(numberOfCourses, currentSchool.Courses.Count);
            Assert.IsTrue(currentSchool.Courses.Contains(currentCourse1));
            Assert.IsTrue(currentSchool.Courses.Contains(currentCourse2));
            Assert.IsTrue(currentSchool.Courses.Contains(currentCourse4));
            Assert.IsFalse(currentSchool.Courses.Contains(currentCourse3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_InitWithNullName_ShouldThrow()
        {
            string name = null;

            School currentSchool = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_InitWithEmptyName_ShouldThrow()
        {
            string name = string.Empty;

            School currentSchool = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_InitWithWhiteSpaceName_ShouldThrow()
        {
            string name = new string(' ', 10);

            School currentSchool = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void School_AddNullCourse_ShouldThrow()
        {
            string name = "First School";
            School currentSchool = new School(name);

            currentSchool.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_AddDuplicateCourse_ShouldThrow()
        {
            string name = "First School";
            School currentSchool = new School(name);
            Course currentCourse = new Course("Course");

            currentSchool.AddCourse(currentCourse);
            currentSchool.AddCourse(currentCourse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void School_RemoveNullCourse_ShouldThrow()
        {
            string name = "First School";
            School currentSchool = new School(name);

            currentSchool.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_RemoveNonexistentCourse_ShouldThrow()
        {
            string name = "First School";
            School currentSchool = new School(name);
            Course currentCourse = new Course("Course");

            currentSchool.RemoveCourse(currentCourse);
        }
    }
}

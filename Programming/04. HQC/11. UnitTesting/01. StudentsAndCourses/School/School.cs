namespace SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private List<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("School name cannot be null, empty or white space only.");
                }

                this.name = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course currentCourse)
        {
            if (currentCourse == null)
            {
                throw new ArgumentNullException("Course cannot be null.");
            }

            if (this.courses.Contains(currentCourse))
            {
                throw new ArgumentException("Course already exsists.");
            }

            this.courses.Add(currentCourse);
        }

        public void RemoveCourse(Course currentCourse)
        {
            if (currentCourse == null)
            {
                throw new ArgumentNullException("Course cannot be null.");
            }

            if (!this.courses.Contains(currentCourse))
            {
                throw new ArgumentException("Course doesn't exsist.");
            }

            this.courses.Remove(currentCourse);
        }
    }
}

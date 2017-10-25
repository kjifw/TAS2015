namespace SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsInCourse = 30;

        private List<Student> students;
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
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
                    throw new ArgumentException("Course name cannot be null, empty or white space only.");
                }

                this.name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student stud)
        {
            if (stud == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (this.students.Count >= MaxStudentsInCourse)
            {
                throw new ArgumentException(
                    string.Format("Cannot add more than {0} students", MaxStudentsInCourse));
            }

            if (this.students.Contains(stud))
            {
                throw new ArgumentException("Student cannot be added twice.");
            }

            this.students.Add(stud);
        }

        public void RemoveStudent(Student stud)
        {
            if (stud == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (!this.students.Contains(stud))
            {
                throw new ArgumentException("Student doesn't exist in the course.");            
            }

            this.students.Remove(stud);
        }
    }
}

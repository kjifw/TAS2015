namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course : ICourse
    {
        private string courseName;
        private string teacherName;
        private ICollection<string> students;

        public Course(string courseName, string teacherName = "")
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.students = new List<string>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course name cannot be null, empty or contain only white spaces.");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Teacher name cannot be null.");
                }

                this.teacherName = value;
            }
        }

        public void AddStudent(string studentName)
        {
            if (string.IsNullOrWhiteSpace(studentName))
            {
                throw new ArgumentException("Invalid student name.");
            }

            this.students.Add(studentName);
        }

        public void AddStudents(ICollection<string> names)
        {
            foreach (var name in names)
            {
                this.AddStudent(name);
            }
        }

        public ICollection<string> GetAllStudents()
        {
            return this.students;
        }

        public override string ToString()
        {
            StringBuilder courseInfo = new StringBuilder();

            courseInfo.AppendFormat("{0} ", this.GetType().Name);
            courseInfo.AppendFormat("{{ Name = {0}", this.CourseName);

            if (this.TeacherName.Length != 0)
            {
                courseInfo.AppendFormat("; Teacher = {0}", this.TeacherName);
            }

            courseInfo.AppendFormat("; Students = {0}", this.GetStudentsAsString());

            return courseInfo.ToString();
        }

        private string GetStudentsAsString()
        {
            string result = "{ }";

            if (this.students != null || this.students.Count != 0)
            {
                result = "{ " + string.Join(", ", this.students) + " }";
            }

            return result;
        }
    }
}


namespace _01.SchoolAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SchoolClass : IComment
    {
        private string id;
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();

        public SchoolClass(string id)
        {
            this.ID = id;
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
        public List<Teacher> Teachers
        {
            get 
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder schoolClassInfo = new StringBuilder();

            schoolClassInfo.AppendLine();
            schoolClassInfo.AppendLine("class id: " + this.ID);
            schoolClassInfo.AppendLine("comments: " + this.Comment);

            schoolClassInfo.AppendLine();
            schoolClassInfo.AppendLine("students: ");
            foreach (var item in this.Students)
            {
                schoolClassInfo.AppendLine(item.ToString());
            }

            schoolClassInfo.AppendLine();
            schoolClassInfo.AppendLine("teachers: ");
            foreach (var item in this.Teachers)
            {
                schoolClassInfo.AppendLine(item.ToString());
            }

            return schoolClassInfo.ToString().TrimEnd();
        }
    }
}

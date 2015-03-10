
namespace _01.SchoolAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : Person, IComment
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher(string name)
            : base(name)
        {

        }

        public List<Discipline> Disciplines 
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }
        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder teacherInfo = new StringBuilder();

            teacherInfo.AppendLine("name: " + this.Name);
            teacherInfo.AppendLine("comments: " + this.Comment);

            teacherInfo.AppendLine("disciplines: ");
            foreach (var item in this.Disciplines)
            {
                teacherInfo.AppendLine(item.ToString());
            }

            return teacherInfo.ToString().TrimEnd();
        }
    }
}

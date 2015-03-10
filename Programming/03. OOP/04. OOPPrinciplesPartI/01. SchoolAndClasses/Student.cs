

namespace _01.SchoolAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : Person, IComment
    {
        private int uniqueId;

        public Student(string name, int id)
            : base(name)
        {
            this.UniqueId = id;
        }

        public int UniqueId 
        {
            get
            {
                return this.uniqueId;
            }
            set
            {
                this.uniqueId = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.AppendLine("name: " + this.Name);
            studentInfo.AppendLine("id: " + this.UniqueId);
            studentInfo.AppendLine("comments: " + this.Comment);

            return studentInfo.ToString().TrimEnd();
        }
    }
}

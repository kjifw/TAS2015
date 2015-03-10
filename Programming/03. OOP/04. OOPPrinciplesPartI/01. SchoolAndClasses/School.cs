

namespace _01.SchoolAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class School
    {
        private string name;
        private List<SchoolClass> classes = new List<SchoolClass>();

        public School(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }

        public override string ToString()
        {
            StringBuilder schoolInfo = new StringBuilder();

            schoolInfo.AppendLine("school name: "+ this.Name);
            schoolInfo.AppendLine();
            schoolInfo.AppendLine("classes: ");
            foreach (var item in this.Classes)
            {
                schoolInfo.AppendLine(item.ToString());
            }

            return schoolInfo.ToString().TrimEnd();
        }
    }
}

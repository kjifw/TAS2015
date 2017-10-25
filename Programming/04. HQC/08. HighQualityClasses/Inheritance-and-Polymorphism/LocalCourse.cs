namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course, ICourse
    {
        private string lab;

        public LocalCourse(string courseName, string teacherName = "", string lab = "")
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Lab name cannot be null.");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder localCourseInfo = new StringBuilder();

            localCourseInfo.Append(base.ToString());

            if (this.Lab.Length != 0)
            {
                localCourseInfo.AppendFormat("; Lab = {0}", this.Lab);
            }

            localCourseInfo.Append(" }");

            return localCourseInfo.ToString();
        }
    }
}

namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course, ICourse
    {
        private string town;

        public OffsiteCourse(string courseName, string teacherName = "", string town = "")
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Town name cannot be null.");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder offsiteCourseInfo = new StringBuilder();

            offsiteCourseInfo.Append(base.ToString());

            if (this.Town.Length != 0)
            {
                offsiteCourseInfo.AppendFormat("; Town = {0}", this.Town);
            }

            offsiteCourseInfo.Append(" }");

            return offsiteCourseInfo.ToString();
        }
    }
}

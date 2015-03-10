
namespace _01.SchoolAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name)
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
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercises 
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }
        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder disciplineInfo = new StringBuilder();

            disciplineInfo.AppendLine("name: " + this.Name);
            disciplineInfo.AppendLine("number of lectures: " + this.NumberOfLectures);
            disciplineInfo.AppendLine("number of exercises: " + this.NumberOfExercises);
            disciplineInfo.AppendLine("comments: " + this.Comment);

            return disciplineInfo.ToString().TrimEnd();
        }
    }
}

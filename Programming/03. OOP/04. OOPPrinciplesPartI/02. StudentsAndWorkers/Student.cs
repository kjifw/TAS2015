
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Text;

    public class Student : Human
    {
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.Append(base.ToString());
            studentInfo.Append(" Grade: " + this.Grade);

            return studentInfo.ToString();
        }
    }
}

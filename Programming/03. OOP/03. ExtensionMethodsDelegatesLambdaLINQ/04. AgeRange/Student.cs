
namespace _04.AgeRange
{
    using System;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            
            studentInfo.Append(this.FirstName + " ");
            studentInfo.Append(this.LastName + " ");
            studentInfo.Append(this.Age);

            return studentInfo.ToString();
        }
    }
}

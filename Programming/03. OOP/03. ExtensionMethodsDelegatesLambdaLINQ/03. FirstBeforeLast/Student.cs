
namespace _03.FirstBeforeLast
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            string fullName = this.FirstName + " " + this.LastName;

            return fullName;
        }
    }
}

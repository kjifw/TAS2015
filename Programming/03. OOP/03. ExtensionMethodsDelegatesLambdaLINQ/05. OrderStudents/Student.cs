
namespace _05.OrderStudents
{
    using System;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be positive");
                }

                this.age = value;
            }
        }

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

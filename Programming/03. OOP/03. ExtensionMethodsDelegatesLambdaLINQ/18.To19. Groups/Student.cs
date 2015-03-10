
namespace _18.To19.Groups
{
    using System;
    using System.Text;

    public class Student
    {
        private string name;
        private int age;
        private string groupName;

        public Student(string name, int age, string groupName)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Age must be positive");
            }

            this.Name = name;
            this.Age = age;
            this.GroupName = groupName;
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
        public string GroupName 
        {
            get
            {
                return this.groupName;
            }
            set
            {
                this.groupName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.Append(this.Name + " ");
            studentInfo.Append(this.Age + " ");
            studentInfo.Append(this.GroupName);

            return studentInfo.ToString();
        }
    }
}

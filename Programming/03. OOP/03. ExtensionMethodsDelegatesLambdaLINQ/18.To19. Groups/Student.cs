
namespace _18.To19.Groups
{
    using System;
    using System.Text;

    public class Student
    {
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

        public string Name { get; set; }
        public int Age { get; set; }
        public string GroupName { get; set; }

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

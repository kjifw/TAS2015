
namespace _09.To15.StudentsManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // Task 09.
    public class Student
    {
        public Student(string firstName,
            string lastName,
            int facultyNumber,
            string phoneNumber, 
            string email,
            List<int> marks,
            int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FacultyNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.AppendFormat("first name: {0}\n", this.FirstName);
            studentInfo.AppendFormat("last name: {0}\n", this.LastName);
            studentInfo.AppendFormat("faculty number: {0}\n", this.FacultyNumber);
            studentInfo.AppendFormat("phone number: {0}\n", this.PhoneNumber);
            studentInfo.AppendFormat("email: {0}\n", this.Email);

            studentInfo.Append("marks: ");
            foreach (var item in Marks)
            {
                studentInfo.Append(item + " ");
            }
            studentInfo.AppendLine();

            studentInfo.AppendFormat("group number: {0}\n", this.GroupNumber);

            return studentInfo.ToString();
        }
    }
}

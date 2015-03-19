
namespace _01.To03.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, int SSN, Specialty specialty, Faculty faculty, University university)
            : this(firstName, string.Empty, string.Empty, SSN, string.Empty,
                    string.Empty, string.Empty, 0, specialty, faculty, university)
        {

        }

        public Student(string firstName, string middleName,
            string lastName, int SSN, string permanentAddress,
            string mobilePhone, string email, int course,
            Specialty specialty, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public override bool Equals(object obj)
        {
            bool areEqual = true;
            Student currentStudent = obj as Student;

            if (obj == null)
            {
                areEqual = false;
            }
            else if ((object)currentStudent == null)
            {
                areEqual = false;
            }
            else
            {
                areEqual = this.FirstName == currentStudent.FirstName;
                areEqual = areEqual && this.MiddleName == currentStudent.MiddleName;
                areEqual = areEqual && this.LastName == currentStudent.LastName;
                areEqual = areEqual && this.SSN == currentStudent.SSN;
                areEqual = areEqual && this.PermanentAddress == currentStudent.PermanentAddress;
                areEqual = areEqual && this.MobilePhone == currentStudent.MobilePhone;
                areEqual = areEqual && this.Email == currentStudent.Email;
                areEqual = areEqual && this.Course == currentStudent.Course;
                areEqual = areEqual && this.Specialty == currentStudent.Specialty;
                areEqual = areEqual && this.University == currentStudent.University;
                areEqual = areEqual && this.Faculty == currentStudent.Faculty;
            }

            return areEqual;
        }

        public static bool operator ==(Student first, Student second)
        {
            bool areEqual = false;

            if (Object.ReferenceEquals(first, second))
            {
                areEqual = true;
            }
            else if (((object)first == null) || ((object)second == null))
            {
                areEqual = false;
            }
            else
            {
                areEqual = first.Equals(second);
            }

            return areEqual;
        }

        public static bool operator !=(Student first, Student second)
        {
            bool areDifferent = true;

            if (Object.ReferenceEquals(first, second))
            {
                areDifferent = false;
            }
            else if (((object)first == null) || ((object)second == null))
            {
                areDifferent = true;
            }
            else
            {
                areDifferent = !(first.Equals(second));
            }

            return areDifferent;
        }

        public override int GetHashCode()
        {
            int hash = 0;

            hash = this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode();
            hash = hash ^ this.LastName.GetHashCode();
            hash = hash ^ this.SSN;
            hash = hash ^ this.PermanentAddress.GetHashCode();
            hash = hash ^ this.MobilePhone.GetHashCode();
            hash = hash ^ this.Email.GetHashCode();
            hash = hash ^ this.Course.GetHashCode();
            hash = hash ^ this.Specialty.GetHashCode();
            hash = hash ^ this.Faculty.GetHashCode();
            hash = hash ^ this.University.GetHashCode();

            return hash;
        }

        public object Clone()
        {
            Student newStudent =
                new Student(
                    this.FirstName,
                    this.MiddleName,
                    this.LastName,
                    this.SSN,
                    this.PermanentAddress,
                    this.MobilePhone,
                    this.Email,
                    this.Course,
                    this.Specialty,
                    this.Faculty,
                    this.University);

            return newStudent;
        }

        public int CompareTo(Student other)
        {
            int compare = 0;

            if (!(this.Equals(other)))
            {
                List<Student> students = new List<Student>();
                students.Add(this);
                students.Add(other);

                var stud = students
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.MiddleName)
                    .ThenBy(x => x.LastName)
                    .ThenBy(x => x.SSN)
                    .First();

                compare = this.Equals(stud) ? -1 : 1;
            }

            return compare;
        }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.AppendLine("first name: " + this.FirstName);
            studentInfo.AppendLine("middle name: " + this.MiddleName);
            studentInfo.AppendLine("last name: " + this.LastName);
            studentInfo.AppendLine("SSN: " + this.SSN);
            studentInfo.AppendLine("permanent address: " + this.PermanentAddress);
            studentInfo.AppendLine("mobile phone: " + this.MobilePhone);
            studentInfo.AppendLine("email: " + this.Email);
            studentInfo.AppendLine("course: " + this.Course);
            studentInfo.AppendLine("specialty: " + this.Specialty);
            studentInfo.AppendLine("university: " + this.University);
            studentInfo.AppendLine("faculty: " + this.Faculty);

            return studentInfo.ToString();
        }
    }
}

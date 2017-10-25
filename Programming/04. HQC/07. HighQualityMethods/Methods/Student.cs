namespace Methods
{
    using System;

    public class Student
    {
        public Student(
            string firstName, 
            string lastName, 
            DateTime birthDate, 
            string town, 
            string additionalInfo = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = birthDate;
            this.Town = town;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Town { get; set; }

        public string AdditionalInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            bool isOlder = this.DateOfBirth > other.DateOfBirth;

            return isOlder;
        }
    }
}

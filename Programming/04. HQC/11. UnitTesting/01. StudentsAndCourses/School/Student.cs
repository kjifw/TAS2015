namespace SchoolExample
{
    using System;

    public class Student
    {
        private const int MinUniqueValue = 10000;
        private const int MaxUniqueValue = 99999;

        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student name cannot be empty or contain only white space");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (value < MinUniqueValue || value > MaxUniqueValue)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Student number must be between {0} and {1}", MinUniqueValue, MaxUniqueValue));
                }

                this.uniqueNumber = value;
            }
        }
    }
}

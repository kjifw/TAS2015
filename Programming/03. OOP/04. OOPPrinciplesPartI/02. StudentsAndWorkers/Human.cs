

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Text;

    public abstract class Human
    {
        public Human(string firstName, string LastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }

        public override string ToString()
        {
            StringBuilder humanInfo = new StringBuilder();

            humanInfo.Append("Name: ");
            humanInfo.Append(this.FirstName + " ");
            humanInfo.Append(this.LastName);

            return humanInfo.ToString();
        }
    }
}

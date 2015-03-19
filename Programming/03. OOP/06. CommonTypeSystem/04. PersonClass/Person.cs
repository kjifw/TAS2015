
namespace _04.PersonClass
{
    using System;
    using System.Text;

    public class Person
    {
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        string Name { get; set; }
        int? Age { get; set; }

        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();
            
            personInfo.AppendLine("name: " + this.Name);
            
            if (this.Age == null)
            {
                personInfo.AppendLine("age: not specified");
            }
            else
            {
                personInfo.AppendLine("age: " + this.Age);
            }

            return personInfo.ToString();
        }
    }
}

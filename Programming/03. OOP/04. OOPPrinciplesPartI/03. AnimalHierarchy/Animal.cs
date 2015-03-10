
namespace _03.AnimalHierarchy
{
    using System;
    using System.Text;

    public abstract class Animal : ISound
    {
        public Animal(string name, int age, bool isMale)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Age must be positive");
            }

            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }

        public abstract string MakeSound();

        public override string ToString()
        {
            StringBuilder animalInfo = new StringBuilder();

            animalInfo.Append("Name " + this.Name + ";");
            animalInfo.Append(" Age " + this.Age + ";");
            animalInfo.Append(" Is male: " + this.IsMale + ";");

            return animalInfo.ToString();
        }
    }
}

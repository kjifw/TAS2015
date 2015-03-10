
namespace _03.AnimalHierarchy
{
    using System;
    using System.Text;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private bool isMale;

        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
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
        public bool IsMale
        {
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
            }
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            StringBuilder animalInfo = new StringBuilder();

            animalInfo.Append("Name " + this.Name + ";");
            animalInfo.Append(" Age " + this.Age + ";");
            animalInfo.Append(" Is male: " + this.IsMale + ";");
            animalInfo.Append(" Animal type: " + this.GetType().Name + ";");

            return animalInfo.ToString();
        }
    }
}

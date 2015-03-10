
namespace _03.AnimalHierarchy
{
    using System;
    using System.Text;

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, false)
        {
 
        }

        public override string MakeSound()
        {
            string kittenSound = "kitten make sound";

            return kittenSound;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}


namespace _03.AnimalHierarchy
{
    using System;
    using System.Text;

    public class Dog : Animal
    {
        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
 
        }

        public override string MakeSound()
        {
            string dogSound = "dog make sound";
            
            return dogSound;
        }
    }
}

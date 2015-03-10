
namespace _03.AnimalHierarchy
{
    using System;
    using System.Text;

    public class Cat : Animal
    {       
        public Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
 
        }

        public override string MakeSound()
        {
            string catSound = "cat make sound";
            
            return catSound;
        }
    }
}

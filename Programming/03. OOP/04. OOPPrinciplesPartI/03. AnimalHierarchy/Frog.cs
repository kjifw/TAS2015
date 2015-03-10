
namespace _03.AnimalHierarchy
{
    using System;
    using System.Text;

    public class Frog : Animal
    {       
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
 
        }

        public override string MakeSound()
        {
            string frogSound = "frog make sound";
            
            return frogSound;
        }
    }
}


namespace _03.AnimalHierarchy
{
    using System;
    using System.Text;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, true)
        {
 
        }

        public override string MakeSound()
        {
            string tomcatSound = "tomcat make sound";

            return tomcatSound;
        }
    }
}

namespace _02.People
{
    using System;

    public class People
    {
        public static void Main(string[] args)
        {
            var person = People.CreateHuman(24);
            Console.WriteLine(person.Name + " " + person.Age + " " + person.Gender); 
            
            person = People.CreateHuman(23);
            Console.WriteLine(person.Name + " " + person.Age + " " + person.Gender);
        }

        public static Human CreateHuman(int age)
        {
            Human person = new Human();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Dude";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Chick";
                person.Gender = Gender.Female;
            }

            return person;
        }
    }
}

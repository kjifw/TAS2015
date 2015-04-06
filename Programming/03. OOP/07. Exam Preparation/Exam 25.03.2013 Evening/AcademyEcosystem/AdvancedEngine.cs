
namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AdvancedEngine : Engine
    {
        protected override void ExecuteBirthCommand(string[] commandWords)
        {
            if (commandWords[1] == "wolf")
            {
                string name = commandWords[2];

                Point position = Point.Parse(commandWords[3]);

                this.AddOrganism(new Wolf(name, position));
            }
            else if (commandWords[1] == "lion")
            {
                string name = commandWords[2];

                Point position = Point.Parse(commandWords[3]);

                this.AddOrganism(new Lion(name, position));
            }
            else if (commandWords[1] == "grass")
            {
                Point position = Point.Parse(commandWords[2]);

                this.AddOrganism(new Grass(position));
            }
            else if (commandWords[1] == "boar")
            {
                string name = commandWords[2];

                Point position = Point.Parse(commandWords[3]);

                this.AddOrganism(new Boar(name, position));
            }
            else if (commandWords[1] == "zombie")
            {
                string name = commandWords[2];

                Point position = Point.Parse(commandWords[3]);

                this.AddOrganism(new Zombie(name, position));
            }
            else
            {
                base.ExecuteBirthCommand(commandWords);
            }
        }
    }
}

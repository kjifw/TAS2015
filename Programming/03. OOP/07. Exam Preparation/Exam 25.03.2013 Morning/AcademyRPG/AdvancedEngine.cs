
namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AdvancedEngine : Engine
    {
        public override void ExecuteCreateObjectCommand(string[] commandWords)
        {
            if (commandWords[1] == "knight")
            {
                string name = commandWords[2];
                Point position = Point.Parse(commandWords[3]);
                int owner = int.Parse(commandWords[4]);

                this.AddObject(new Knight(name, position, owner));
            }
            else if (commandWords[1] == "house")
            {
                Point position = Point.Parse(commandWords[2]);
                int owner = int.Parse(commandWords[3]);

                this.AddObject(new House(position, owner));
            }
            else if (commandWords[1] == "giant")
            {
                string name = commandWords[2];

                Point position = Point.Parse(commandWords[3]);

                this.AddObject(new Giant(name, position));
            }
            else if (commandWords[1] == "rock")
            {
                int hitpoints = Convert.ToInt32(commandWords[2]);

                Point position = Point.Parse(commandWords[3]);

                this.AddObject(new Rock(hitpoints, position));
            }
            else if (commandWords[1] == "ninja")
            {
                string name = commandWords[2];

                Point position = Point.Parse(commandWords[3]);
                int owner = Convert.ToInt32(commandWords[4]);

                this.AddObject(new Ninja(name, position, owner));
            }
            else
            {
                base.ExecuteCreateObjectCommand(commandWords);
            }
        }

    }
}

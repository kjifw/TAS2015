
namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Zombie : Animal
    {
        private int meat;

        public Zombie(string name, Point position)
            : base(name, position, 0)
        {
            this.meat = 10;
        }

        public override int GetMeatFromKillQuantity()
        {
            return this.meat;
        }
    }
}

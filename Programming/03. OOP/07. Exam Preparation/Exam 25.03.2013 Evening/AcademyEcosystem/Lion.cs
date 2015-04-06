
namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Lion : Animal, ICarnivore
    {
        public Lion(string name, Point position)
            : base(name, position, 6)
        {

        }

        public override void Update(int timeElapsed)
        {
            if (this.State == AnimalState.Sleeping)
            {
                if (timeElapsed >= sleepRemaining)
                {
                    this.Awake();
                }
                else
                {
                    this.sleepRemaining -= timeElapsed;
                }
            }

            base.Update(timeElapsed);
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && this.Size >= animal.Size)
            {
                this.Size++;
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }
    }
}

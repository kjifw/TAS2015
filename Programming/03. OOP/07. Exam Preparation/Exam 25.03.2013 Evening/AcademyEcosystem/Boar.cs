
namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private int biteSize;

        public Boar(string name, Point position)
            : base(name, position, 4)
        {
            this.biteSize = 2;
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
            if (animal != null && (this.Size >= animal.Size))
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }

        public int EatPlant(Plant p)
        {
            if (p != null)
            {
                this.Size++;
                return p.GetEatenQuantity(this.biteSize);
            }

            return 0;
        }
    }
}

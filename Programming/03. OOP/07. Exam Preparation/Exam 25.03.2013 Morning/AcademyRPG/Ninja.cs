
namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Ninja : MovingObject, IGatherer, IFighter
    {
        private bool lumberGathered = false;
        private int lumberQuantity = 0;
        private int stoneQuantity = 0;
        private int attackPoints = 0;

        public Ninja(string name, Point position, int owner)
            : base(position, owner)
        {
            this.Name = name;
            this.HitPoints = 1;
        }

        public string Name { get; private set; }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                lumberGathered = true;
                lumberQuantity = resource.Quantity;
                return true;    
            }
            if (resource.Type == ResourceType.Stone)
            {
                lumberGathered = false;
                stoneQuantity = resource.Quantity;
                return true;
            }

            return false;
        }

        public int AttackPoints
        {
            get 
            {
                if (lumberGathered)
                {
                    return this.attackPoints + lumberQuantity;
                }
                else
                {
                    return this.attackPoints + 2 * stoneQuantity;
                }
            }
        }

        public int DefensePoints
        {
            get 
            {
                return int.MaxValue;    
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var objectWithMaxHP = from target in availableTargets
                                  orderby target.HitPoints ascending
                                  select availableTargets.Last();

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner 
                    && availableTargets[i].Owner != 0
                    && availableTargets[i] == objectWithMaxHP)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

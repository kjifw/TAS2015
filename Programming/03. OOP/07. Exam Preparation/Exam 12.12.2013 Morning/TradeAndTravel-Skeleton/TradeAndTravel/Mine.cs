
namespace TradeAndTravel
{
    using System;

    public class Mine : Location, IGatheringLocation
    {
        public Mine(string name)
            : base(name, LocationType.Mine)
        {

        }

        public ItemType GatheredType
        {
            get
            {
                return ItemType.Wood;
            }
        }

        public ItemType RequiredItem
        {
            get 
            {
                return ItemType.Weapon;
            }
        }

        public Item ProduceItem(string name)
        {
            return new Wood(name);
        }
    }
}

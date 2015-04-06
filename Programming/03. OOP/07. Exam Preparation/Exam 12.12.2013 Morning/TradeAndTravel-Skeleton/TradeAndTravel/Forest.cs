
namespace TradeAndTravel
{
    using System;

    public class Forest : Location, IGatheringLocation
    {
        public Forest(string name)
            : base(name, LocationType.Forest)
        {

        }

        public ItemType GatheredType
        {
            get 
            {
                return ItemType.Iron;
            }
        }

        public ItemType RequiredItem
        {
            get 
            {
                return ItemType.Armor;    
            }
        }

        public Item ProduceItem(string name)
        {
            return new Iron(name);
        }
    }
}

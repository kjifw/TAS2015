
namespace TradeAndTravel
{
    using System;

    public class Iron : Item
    {
        private const int GeneralIronValue = 2;

        public Iron(string name, Location location = null)
            : base(name, Iron.GeneralIronValue, ItemType.Iron, location)
        {

        }
    }
}

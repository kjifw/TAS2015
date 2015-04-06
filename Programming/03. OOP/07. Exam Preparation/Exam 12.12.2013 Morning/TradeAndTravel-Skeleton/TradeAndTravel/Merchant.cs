
namespace TradeAndTravel
{
    using System;

    public class Merchant : Shopkeeper, ITraveller
    {
        public Merchant(string personNameString, Location personLocation)
            : base(personNameString, personLocation)
        {

        }

        public virtual void TravelTo(Location location)
        {
            this.Location = location;
        }
    }
}


namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AdvancedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            if (itemTypeString == "weapon")
            {
                return new Weapon(itemNameString, itemLocation);
            }
            else if (itemTypeString == "wood")
            {
                return new Wood(itemNameString, itemLocation);
            }
            else if (itemTypeString == "iron")
            {
                return new Iron(itemNameString, itemLocation);
            }
            else
            {
                return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            if (locationTypeString == "mine")
            {
                return new Mine(locationName);
            }
            else if (locationTypeString == "forest")
            {
                return new Forest(locationName);
            }
            else
            {
                return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            if (personTypeString == "merchant")
            {
                return new Merchant(personNameString, personLocation);
            }
            else
            {
                return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            if (commandWords[1] == "gather")
            {
                string itemNameString = commandWords[2];

                this.HandleGatherInteraction(actor, itemNameString);
            }
            else if (commandWords[1] == "craft")
            {
                string itemTypeString = commandWords[2];
                string itemNameString = commandWords[3];

                this.HandleCraftInteration(actor, itemTypeString, itemNameString);
            }
            else
            {
                base.HandlePersonCommand(commandWords, actor);
            }
        }

        private void HandleGatherInteraction(Person actor, string itemNameString)
        {
            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;

                if (actor.ListInventory().Any(x => x.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemNameString));
                }
            }
        }

        private void HandleCraftInteration(Person actor, string itemTypeString, string itemNameString)
        {
            if (itemTypeString == "weapon")
            {
                this.HandleWeaponCrafting(actor, itemNameString);
            }
            else if (itemTypeString == "armor")
            {
                this.HandleArmorCrafting(actor, itemNameString);
            }
        }

        private void HandleWeaponCrafting(Person actor, string itemNameString)
        {
            if (actor.ListInventory().Any(x => x.ItemType == ItemType.Iron)
                && actor.ListInventory().Any(x => x.ItemType == ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(itemNameString));
            }
        }

        private void HandleArmorCrafting(Person actor, string itemNameString)
        {
            var requiredItems = ItemType.Iron;

            if (actor.ListInventory().Any(x => x.ItemType == requiredItems))
            {
                this.AddToPerson(actor, new Armor(itemNameString));
            }
        }
    }
}

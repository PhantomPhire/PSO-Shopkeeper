using System;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO unit
    /// </summary>
    public class Unit : EquippableItem
    {
        /// <summary>
        /// Initializes a new instance of the Unit class
        /// </summary>
        public Unit()
        {
            Type = ItemType.Unit;
        }

        /// <summary>
        /// Inititializes a new instance of the Unit class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Unit(ItemJSON json) : base(json)
        {
            if (json.Unit == null)
            {
                throw new Exception("Invalid Unit JSON specification!");
            }

            EquipMask = json.Unit.EquipMask;
            setStatsToJSON(json.Unit.Stats);
            setResistancesToJSON(json.Unit.Resistances);
        }

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Unit item = new Unit();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Unit))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
        }
    }
}

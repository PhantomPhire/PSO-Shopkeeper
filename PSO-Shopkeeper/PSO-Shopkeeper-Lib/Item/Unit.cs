using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

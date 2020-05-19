using System;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents an Item that is unkown
    /// </summary>
    public class UnknownItem : Item
    {
        /// <summary>
        /// Initializes a new instance of the UnknownItem class
        /// </summary>
        public UnknownItem()
        {
        }

        /// <summary>
        /// Inititializes a new instance of the Item class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public UnknownItem(ItemJSON json)
        {
        }

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            UnknownItem item = new UnknownItem();
            copyAttributes(item);
            return item;
        }
    }
}

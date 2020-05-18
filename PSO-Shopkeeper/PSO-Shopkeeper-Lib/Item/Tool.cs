using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents  a tool in PSO
    /// </summary>
    public class Tool : Item
    {
        /// <summary>
        /// Initializes a new instance of the Tool class
        /// </summary>
        public Tool()
        {
            Type = ItemType.Tool;
        }

        /// <summary>
        /// Indicates if the Tool is rare
        /// </summary>
        public bool Rare { get; set; } = false;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Tool item = new Tool();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Tool))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            Tool tool = item as Tool;
            tool.Rare = Rare;
        }
    }
}

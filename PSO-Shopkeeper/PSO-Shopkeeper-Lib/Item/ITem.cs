using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO item
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Indicates the name of the item
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// Indicates the hex value of the item
        /// </summary>
        public string Hex { get; set; } = String.Empty;

        /// <summary>
        /// Indicates the type of the item
        /// </summary>
        public ItemType Type { get; set; } = ItemType.INVALID;

        /// <summary>
        /// Indicates the rarity (star rating) of the item
        /// </summary>
        public int Rarity { get; set; } = 0;

        /// <summary>
        /// Indicates the max amount of the item that can be in a stack. Defaults to 1
        /// </summary>
        public int MaxStack { get; set; } = 1;
    }
}

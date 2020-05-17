using PSOShopkeeperLib.Item;
using System;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents an item intended to be serialized to JSON
    /// </summary>
    public class ItemJSON
    {
        /// <summary>
        /// Indicates the name of the item
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the hex value of the item
        /// </summary>
        public string Hex { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the type of the item
        /// </summary>
        public string Type { get; set; } = Enum.GetName(typeof(ItemType), 0);

        /// <summary>
        /// Indicates the rarity (star rating) of the item
        /// </summary>
        public int Rarity { get; set; } = 0;

        /// <summary>
        /// Indicates the max amount of the item that can be in a stack. Defaults to 1
        /// </summary>
        public int MaxStack { get; set; } = 1;

        /// <summary>
        /// Represents the weapon portion of the item, if the item is a weapon
        /// </summary>
        public ItemWeaponJSON Weapon { get; set; } = null;

        /// <summary>
        /// Represents the defense portion of the item, if the item is a defense item
        /// </summary>
        public ItemDefenseJSON Defense { get; set; } = null;

        /// <summary>
        /// Represents the unit portion of the item, if the item is a unit
        /// </summary>
        public ItemUnitJSON Unit { get; set; } = null;

        /// <summary>
        /// Represents the mag portion of the item, if the item is a unit
        /// </summary>
        public ItemMagJSON Mag { get; set; } = null;

        /// <summary>
        /// Represents the technique portion of the item, if the item is a technique
        /// </summary>
        public ItemTechniqueJSON Technique { get; set; } = null;

        /// <summary>
        /// Represents the tool portion of the item, if the item is a tool
        /// </summary>
        public ItemToolJSON Tool { get; set; } = null;
    }
}

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
        /// Indicates the description of the item
        /// </summary>
        public string Description { get; set; } = string.Empty;

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
        /// Indicates the kind of the item
        /// </summary>
        public int Kind { get; set; } = 0;

        /// <summary>
        /// Indicates the skin of the item
        /// </summary>
        public int Skin { get; set; } = 0;

        /// <summary>
        /// Indicates the amount of teampoints of the item
        /// </summary>
        public int Teampoints { get; set; } = 0;

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

        /// <summary>
        /// Creates a deep copy of the item
        /// </summary>
        /// <returns>The copied item</returns>
        public ItemJSON Copy()
        {
            ItemJSON copy = new ItemJSON();
            copy.Name = Name;
            copy.Hex = Hex;
            copy.Description = Description;
            copy.Type = Type;
            copy.Rarity = Rarity;
            copy.MaxStack = MaxStack;
            copy.Kind = Kind;
            copy.Skin = Skin;
            copy.Teampoints = Teampoints;

            if (Weapon != null)
            {
                copy.Weapon = Weapon.Copy();
            }
            if (Defense != null)
            {
                copy.Defense = Defense.Copy();
            }
            if (Unit != null)
            {
                copy.Unit = Unit.Copy();
            }
            if (Mag != null)
            {
                copy.Mag = Mag.Copy();
            }
            if (Technique != null)
            {
                copy.Technique = Technique.Copy();
            }
            if (Tool != null)
            {
                copy.Tool = Tool.Copy();
            }

            return copy;
        }

        /// <summary>
        /// Imports item attributes from another item exported from ItemPMT
        /// </summary>
        /// <param name="item">The item to import</param>
        public void Import(ItemJSON item)
        {
            Name = item.Name;
            Hex = item.Hex;
            Description = item.Description;
            Kind = item.Kind;
            Skin = item.Skin;
            Teampoints = item.Teampoints;

            if (Weapon != null)
            {
                Weapon.Import(item.Weapon);
            }
            if (Defense != null)
            {
                Defense.Import(item.Defense);
            }
        }
    }
}

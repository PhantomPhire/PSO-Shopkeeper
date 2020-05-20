using PSOShopkeeperLib.JSON;
using System;
using System.Collections.Generic;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO item
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Initializes a new instance of the Item class
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Inititializes a new instance of the Item class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Item(ItemJSON json)
        {
            Name = json.Name;
            Hex = json.Hex;
            Type = (ItemType)Enum.Parse(typeof(ItemType), json.Type);
            Rarity = json.Rarity;
            MaxStack = json.MaxStack;
        }

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

        /// <summary>
        /// Indicates the item reader text of the item input
        /// </summary>
        public string ItemReaderText { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the quantity of the item
        /// </summary>
        public int Quantity { get; set; } = 1;

        /// <summary>
        /// Indicates an item's price in PDs
        /// </summary>
        public string PricePDs { get; set; } = string.Empty;

        /// <summary>
        /// Indicates an item's price in Meseta
        /// </summary>
        public string PriceMeseta { get; set; } = string.Empty;

        /// <summary>
        /// Indicates an item's price in custom currency
        /// </summary>
        public string PriceCustom { get; set; } = string.Empty;

        /// <summary>
        /// Indicates a custom currency to price with
        /// </summary>
        public string CustomCurrency { get; set; } = string.Empty;

        /// <summary>
        /// Contains any notes about the item
        /// </summary>
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public abstract Item Copy();

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public virtual string ItemReport()
        {
            return ItemReaderText;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected virtual void copyAttributes(Item item)
        {
            item.Name = Name;
            item.Hex = Hex;
            item.Type = Type;
            item.Rarity = Rarity;
            item.MaxStack = MaxStack;
            item.ItemReaderText = ItemReaderText;
            item.Quantity = Quantity;
            item.PricePDs = PricePDs;
            item.PriceMeseta = PriceMeseta;
            item.PriceCustom = PriceCustom;
            item.CustomCurrency = CustomCurrency;
            item.Notes = Notes;
        }

        /// <summary>
        /// Parses in applicable attributes of the item from item reader input
        /// </summary>
        /// <param name="attributes">The attributes to parse</param>
        public virtual void ParseAttributes(List<string> attributes) { }

        /// <summary>
        /// Returns a string that represents the item
        /// </summary>
        /// <returns>The string representing the item</returns>
        public override string ToString()
        {
            string output = ItemReaderText;

            if (Quantity > 1)
            {
                output += " x" + Quantity.ToString();
            }

            if (PricePDs != string.Empty)
            {
                output += " [B]" + PricePDs + " PD[/B]";
            }
            else if (PriceMeseta != string.Empty)
            {
                output += " [B]" + PriceMeseta + " Meseta[/B]";
            }
            else if (PriceCustom != string.Empty)
            {
                output += " [B]" + PriceCustom + " " +CustomCurrency + "[/B]";
            }

            return output;
        }

        /// <summary>
        /// Creates an Item from an ItemJSON specification
        /// </summary>
        /// <param name="json">The ItemJSON specification to create the item from</param>
        /// <returns>The created item</returns>
        public static Item MakeItemFromJSON(ItemJSON json)
        {
            ItemType itemType = (ItemType)Enum.Parse(typeof(ItemType), json.Type);

            if (itemType == ItemType.Weapon)
            {
                return new Weapon(json);
            }
            else if (itemType == ItemType.Frame || itemType == ItemType.Barrier)
            {
                return new DefenseItem(json);
            }
            else if (itemType == ItemType.Unit)
            {
                return new Unit(json);
            }
            else if (itemType == ItemType.Mag)
            {
                return new Mag(json);
            }
            else if (itemType == ItemType.Technique)
            {
                return new Technique(json);
            }
            else if (itemType == ItemType.Tool)
            {
                return new Tool(json);
            }

            throw new Exception("Unsupported item type!");
        }
    }
}

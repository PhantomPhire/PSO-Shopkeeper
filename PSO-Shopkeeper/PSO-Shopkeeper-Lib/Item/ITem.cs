﻿using PSOShopkeeperLib.JSON;
using System;
using System.Text.RegularExpressions;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO item
    /// </summary>
    public abstract class Item : IComparable<Item>
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
            HexString = json.Hex;
            Description = json.Description;
            Type = (ItemType)Enum.Parse(typeof(ItemType), json.Type);
            Kind = json.Kind;
            Skin = json.Skin;
            Teampoints = json.Teampoints;
            Rarity = json.Rarity;
            MaxStack = json.MaxStack;
        }

        /// <summary>
        /// Indicates the name of the item
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// Backing field for the hex value of the item
        /// </summary>
        private int _hex = 0;

        /// <summary>
        /// Indicates the hex value of the item
        /// </summary>
        public virtual int Hex
        {
            get
            {
                return _hex;
            }
            set
            {
                _hex = value;
            }
        }

        /// <summary>
        /// Indicates the string of hex value of the item
        /// </summary>
        public string HexString
        {
            get
            {
                return string.Format("{0:X}", Hex).PadLeft(6, '0');
            }
            set
            {
                try
                {
                    _hex = Int32.Parse(value, System.Globalization.NumberStyles.HexNumber);
                }
                catch (Exception ex)
                {
                    throw new Exception("Hex value provided for " + Name + " item is not numerical!", ex);
                }
            }
        }

        /// <summary>
        /// Indicates the description of the item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates the type of the item
        /// </summary>
        public ItemType Type { get; set; } = ItemType.INVALID;

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
        /// Indicates the rarity (star rating) of the item
        /// </summary>
        public int Rarity { get; set; } = 0;

        /// <summary>
        /// Indicates the rarity (star rating) of the item, separate from Rarity for weapons that add stars with specials
        /// </summary>
        public int BaseRarity { get { return Rarity; } }

        /// <summary>
        /// Indicates the max amount of the item that can be in a stack. Defaults to 1
        /// </summary>
        public int MaxStack { get; set; } = 1;

        /// <summary>
        /// Indicates the item reader text of the item input
        /// </summary>
        public string ItemReaderText { get; set; } = string.Empty;

        /// <summary>
        /// Gets a pricing ID for differentiating priced items
        /// </summary>
        public string PricingID { get { return constructPricingID(); } }

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
        /// Indicates if the item should be listed
        /// </summary>
        public bool Listed { get; set; } = true;

        /// <summary>
        /// Indicates the amount of the item that should be kept and not listed
        /// </summary>
        public int KeepAmount { get; set; } = -1;

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
            item.HexString = HexString;
            item.Description = Description;
            item.Type = Type;
            item.Kind = Kind;
            item.Skin = Skin;
            item.Teampoints = Teampoints;
            item.Rarity = Rarity;
            item.MaxStack = MaxStack;
            item.ItemReaderText = ItemReaderText;
            item.Quantity = Quantity;
            item.PricePDs = PricePDs;
            item.PriceMeseta = PriceMeseta;
            item.PriceCustom = PriceCustom;
            item.CustomCurrency = CustomCurrency;
            item.Listed = Listed;
            item.KeepAmount = KeepAmount;
            item.Notes = Notes;
        }

        private static Regex quantityFilter = new Regex(@"x(?<quantity>\d+)");

        /// <summary>
        /// Parses in applicable attributes of the item from item reader input
        /// </summary>
        /// <param name="input">The input to parse</param>
        public virtual void ParseAttributes(string input) 
        {
            ItemReaderText = input.Trim();
            if (quantityFilter.IsMatch(input))
            {
                Quantity = int.Parse(quantityFilter.Match(input).Groups["quantity"].Value);
                ItemReaderText = quantityFilter.Replace(input, "").Trim();
            }
        }

        /// <summary>
        /// Returns a string that represents the item
        /// </summary>
        /// <returns>The string representing the item</returns>
        public override string ToString()
        {
            string output = ItemReaderText;

            int effectiveQuantity = Quantity;

            if (KeepAmount != -1)
            {
                effectiveQuantity -= KeepAmount;
            }

            if (effectiveQuantity < 1)
            {
                throw new Exception("Error! Attempted to print item with no quantity (after keep amount applied)!");
            }

            if (effectiveQuantity > 1)
            {
                output += " x" + effectiveQuantity.ToString();
            }

            output += pricePrint();

            return output;
        }

        /// <summary>
        /// Gets the price print output
        /// </summary>
        /// <returns>A string containing the price print</returns>
        protected virtual string pricePrint()
        {
            string output = string.Empty;

            if (TestPrintMode)
            {
                return output;
            }

            if (PricePDs != string.Empty)
            {
                output += " " + boldText(PricePDs + " PD");

                if (!MultiPrice)
                {
                    return output;
                }    

                if ((PriceMeseta != string.Empty) || (PriceCustom != string.Empty))
                {
                    output += " or";
                }
            }
            if (PriceMeseta != string.Empty)
            {
                output += " " + boldText(PriceMeseta + " Meseta");

                if (!MultiPrice)
                {
                    return output;
                }

                if (PriceCustom != string.Empty)
                {
                    output += " or";
                }
            }
            if (PriceCustom != string.Empty)
            {
                output += " " + boldText(PriceCustom + " " + CustomCurrency);
            }

            return output;
        }

        /// <summary>
        /// Applies bolding to a string, if applicable
        /// </summary>
        /// <param name="input">The string to bold</param>
        /// <returns>The resulting string</returns>
        protected static string boldText(string input)
        {
            string output = input;

            if (BoldPrice)
            {
                output = "[B]" + input + "[/B]";
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

        /// <summary>
        /// Pricing ID tag used for item hex value
        /// </summary>
        public const string PricingHexTag = "HEX:";

        /// <summary>
        /// Pricing ID tag used for item name
        /// </summary>
        public const string PricingNameTag = "NAME:";

        /// <summary>
        /// Constructs a pricing ID for the item
        /// </summary>
        /// <returns>Pricing ID string</returns>
        protected virtual string constructPricingID()
        {
            return "[" + PricingHexTag + HexString + "][" + PricingNameTag + Name + "]";
        }

        /// <summary>
        /// Compares Item to another
        /// </summary>
        /// <param name="other"></param>
        /// <returns>0 if the two are equal, -1 if this comes before, 1 if this comes after</returns>
        public int CompareTo(Item other)
        {
            int compare = this.Hex.CompareTo(other.Hex);

            // If items are the same hex, compare them based on other attributes
            if (compare == 0)
            {
                // Try as weapon
                if ((this is Weapon) && (other is Weapon))
                {
                    compare = Weapon.CompareWeapons(this as Weapon, other as Weapon);
                }
                // Try as defense items
                else if ((this is DefenseItem) && (other is DefenseItem))
                {
                    compare = DefenseItem.CompareDefenseItems(this as DefenseItem, other as DefenseItem);
                }
                // Try as mag
                else if ((this is Mag) && (other is Mag))
                {
                    compare = Mag.CompareMags(this as Mag, other as Mag);
                }
                // Try as technique
                else if ((this is Technique) && (other is Technique))
                {
                    compare = Technique.CompareTechs(this as Technique, other as Technique);
                }
            }

            return compare;
        }

        #region settings

        /// <summary>
        /// A setting indicating if the price should be bolded
        /// </summary>
        public static bool BoldPrice { get; set; } = true;

        /// <summary>
        /// A setting indicating if multiple prices should be printed if available
        /// </summary>
        public static bool MultiPrice { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon specials should be colorized
        /// </summary>
        public static bool ColorizeSpecials { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon hit should be colorized
        /// </summary>
        public static bool ColorizeHit { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon percentages should be colorized
        /// </summary>
        public static bool ColorizePercentages { get; set; } = true;

        /// <summary>
        /// A setting allowing the test printing of items without colorization or prices
        /// </summary>
        public static bool TestPrintMode { get; set; } = false;

        /// <summary>
        /// A setting determining the untekk label of items
        /// </summary>
        public static string UntekkLabel { get; set; } = "[U]";

        #endregion
    }
}

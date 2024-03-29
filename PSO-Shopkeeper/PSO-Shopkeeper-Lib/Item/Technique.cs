﻿using System;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a technique disc in PSO
    /// </summary>
    public class Technique : Item
    {
        /// <summary>
        /// Initializes a new instance of the Technique class
        /// </summary>
        public Technique()
        {
            Type = ItemType.Technique;
        }

        /// <summary>
        /// Inititializes a new instance of the Technique class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Technique(ItemJSON json) : base(json)
        {
            if (json.Technique == null)
            {
                throw new Exception("Invalid Technique JSON specification!");
            }

            TechType = (TechniqueType)Enum.Parse(typeof(TechniqueType), json.Technique.TechType);
            RequiredMST = json.Technique.RequirementMST;

            string levelValue = string.Empty;
            int index = Name.Length - 1;

            var nameArr = Name.ToCharArray();
            while (char.IsDigit(nameArr[index]) && index > 0)
            {
                levelValue = nameArr[index] + levelValue;
                index--;
            }

            if (levelValue.Length > 0)
            {
                Level = int.Parse(levelValue);
            }
        }

        /// <summary>
        /// Indicates the technique this disc contains
        /// </summary>
        public TechniqueType TechType { get; set; } = TechniqueType.INVALID;

        /// <summary>
        /// Indicates the level the technique disc has
        /// </summary>
        public int Level { get; set; } = 0;

        /// <summary>
        /// Indicates the amount of MST required to learn the technique
        /// </summary>
        public int RequiredMST { get; set; } = 0;

        private const int techHexOffset = 0x030200;

        /// <summary>
        /// Indicates the hex value of the item
        /// Note: This does not reflect the real hex values of the tech disks, just generated for sorting
        /// </summary>
        public override int Hex
        {
            get
            {
                return techHexOffset + (int)TechType;
            }
            set
            {
                // No op for set
            }
        }

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Technique item = new Technique();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Technique))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            Technique tech = item as Technique;
            tech.TechType = TechType;
            tech.Level = Level;
            tech.RequiredMST = RequiredMST;
        }

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public override string ItemReport()
        {
            string report = ItemReaderText + "\n" + "Hex: " + HexString + "\n\n";

            report += "Type:         " + Enum.GetName(typeof(ItemType), Type) + "\n";
            report += "Technique:    " + Enum.GetName(typeof(TechniqueType), TechType) + "\n";
            report += "Required MST: " + RequiredMST + "\n";

            return report;
        }

        /// <summary>
        /// Compares two techs
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison</param>
        /// <param name="rhs">The right hand side of the comparison</param>
        /// <returns>0 if the two are equal, -1 if lhs comes first, 1 if rhs comes first</returns>
        public static int CompareTechs(Technique lhs, Technique rhs)
        {
            int compare = lhs.Level.CompareTo(rhs.Level);

            return compare;
        }
    }
}

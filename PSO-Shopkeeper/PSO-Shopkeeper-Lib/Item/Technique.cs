﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

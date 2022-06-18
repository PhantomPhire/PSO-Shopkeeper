using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the defense item portion of a JSON item
    /// </summary>
    public class ItemDefenseJSON
    {
        /// <summary>
        /// Indicates the stats of the item
        /// </summary>
        public ItemStatsJSON Stats { get; set; } = new ItemStatsJSON();

        /// <summary>
        /// Indicates the resistances of the item
        /// </summary>
        public ItemResistancesJSON Resistances { get; set; } = new ItemResistancesJSON();

        /// <summary>
        /// A binary mask indicating which classes (in order) can equip this item, if it is equippable. HUmar is LSB
        /// </summary>
        public int EquipMask { get; set; } = 0;

        /// <summary>
        /// This indicates the level required to equip the item, if applicable
        /// </summary>
        public int RequirementLevel { get; set; } = 0;

        /// <summary>
        /// This indicates, if armor or barrier, the maximum DFP the item can  roll with.
        /// This value is added to the base DFP value
        /// </summary>
        public int MaxDFP { get; set; } = 0;

        /// <summary>
        /// This indicates, if armor or barrier, the maximum EVP the item can  roll with.
        /// This value is added to the base EVP value
        /// </summary>
        public int MaxEVP { get; set; } = 0;

        /// <summary>
        /// Indicates the stat boost type of the defensive item
        /// </summary>
        public int StatBoost { get; set; } = 0;

        /// <summary>
        /// Indicates the tech boost type of the defensive item 
        /// </summary>
        public int TechBoost { get; set; } = 0;

        /// <summary>
        /// Creates a deep copy of the defensive item
        /// </summary>
        /// <returns>The copied item</returns>
        public ItemDefenseJSON Copy()
        {
            ItemDefenseJSON copy = new ItemDefenseJSON();

            if (Stats != null)
            {
                copy.Stats = Stats.Copy();
            }
            if (Resistances != null)
            {
                copy.Resistances = Resistances.Copy();
            }
            copy.EquipMask = EquipMask;
            copy.RequirementLevel = RequirementLevel;   
            copy.MaxDFP = MaxDFP;
            copy.MaxEVP = MaxEVP;
            copy.StatBoost = StatBoost;
            copy.TechBoost = TechBoost;

            return copy;
        }

        /// <summary>
        /// Imports item attributes from another item exported from ItemPMT
        /// </summary>
        /// <param name="item">The item to import</param>
        public void Import(ItemDefenseJSON item)
        {
            StatBoost = item.StatBoost;
            TechBoost = item.TechBoost;
        }
    }
}

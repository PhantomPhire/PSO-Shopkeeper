using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the unit component of a JSON item
    /// </summary>
    public class ItemUnitJSON
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
        /// Creates a deep copy of the unit item
        /// </summary>
        /// <returns>The copied item</returns>
        public ItemUnitJSON Copy()
        {
            ItemUnitJSON copy = new ItemUnitJSON();

            if (Stats != null)
            {
                copy.Stats = Stats.Copy();
            }
            if (Resistances != null)
            {
                copy.Resistances = Resistances.Copy();
            }
            copy.EquipMask = EquipMask;

            return copy;
        }
    }
}

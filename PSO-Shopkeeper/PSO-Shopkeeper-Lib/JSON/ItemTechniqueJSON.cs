using System;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the technique portion of a JSON item
    /// </summary>
    public class ItemTechniqueJSON
    {
        /// <summary>
        /// Indicates the technique this disc contains
        /// </summary>
        public string TechType { get; set; } = Enum.GetName(typeof(TechniqueType), 0);

        /// <summary>
        /// Indicates the MST required to equip the item, if applicable
        /// </summary>
        public int RequirementMST { get; set; } = 0;

        /// <summary>
        /// Creates a deep copy of the technique
        /// </summary>
        /// <returns>The copied item</returns>
        public ItemTechniqueJSON Copy()
        {
            ItemTechniqueJSON technique = new ItemTechniqueJSON();
            technique.TechType = TechType;
            technique.RequirementMST = RequirementMST;

            return technique;
        }
    }
}

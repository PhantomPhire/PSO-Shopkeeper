using System;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the mag component of a JSON item
    /// </summary>
    public class ItemMagJSON
    {
        /// <summary>
        /// Indicates the mag PB trigger, if applicable
        /// </summary>
        public string PBTrigger { get; set; } = Enum.GetName(typeof(Mag.TriggerType), 0);

        /// <summary>
        /// Indicates the mag HP trigger, if applicable
        /// </summary>
        public string HPTrigger { get; set; } = Enum.GetName(typeof(Mag.TriggerType), 0);

        /// <summary>
        /// Indicates the mag Boss trigger, if applicable
        /// </summary>
        public string BossTrigger { get; set; } = Enum.GetName(typeof(Mag.TriggerType), 0);

        /// <summary>
        /// Indicates the mag trigger percentage, if applicable
        /// </summary>
        public int TriggerPercentage { get; set; } = 0;

        /// <summary>
        /// Creates a deep copy of the mag
        /// </summary>
        /// <returns>The copied item</returns>
        public ItemMagJSON Copy()
        {
            ItemMagJSON copy = new ItemMagJSON();
            copy.PBTrigger = PBTrigger;
            copy.HPTrigger = HPTrigger;
            copy.BossTrigger = BossTrigger;
            copy.TriggerPercentage = TriggerPercentage;

            return copy;
        }
    }
}

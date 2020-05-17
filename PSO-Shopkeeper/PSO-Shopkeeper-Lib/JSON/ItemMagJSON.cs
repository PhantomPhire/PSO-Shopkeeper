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
    }
}

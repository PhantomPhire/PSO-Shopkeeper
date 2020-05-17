namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the resistances component of a JSON item
    /// </summary>
    public class ItemResistancesJSON
    {
        /// <summary>
        /// Indicates the EFR value the item provides
        /// </summary>
        public int EFR { get; set; } = 0;

        /// <summary>
        /// Indicates the EIC value the item provides
        /// </summary>
        public int EIC { get; set; } = 0;

        /// <summary>
        /// Indicates the ETH value the item provides
        /// </summary>
        public int ETH { get; set; } = 0;

        /// <summary>
        /// Indicates the ELT value the item provides
        /// </summary>
        public int ELT { get; set; } = 0;

        /// <summary>
        /// Indicates the EDK value the item provides
        /// </summary>
        public int EDK { get; set; } = 0;
    }
}

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the stats portion of a JSON item
    /// </summary>
    public class ItemStatsJSON
    {
        /// <summary>
        /// Indicates how much HP this item provies, if applicable
        /// </summary>
        public int HP { get; set; } = 0;

        /// <summary>
        /// Indicates how much TP this item provies, if applicable
        /// </summary>
        public int TP { get; set; } = 0;

        /// <summary>
        /// Indicates how much ATP this item provies, if applicable
        /// </summary>
        public int ATP { get; set; } = 0;

        /// <summary>
        /// Indicates how much DFP this item provies, if applicable
        /// </summary>
        public int DFP { get; set; } = 0;

        /// <summary>
        /// Indicates how much MST this item provies, if applicable
        /// </summary>
        public int MST { get; set; } = 0;

        /// <summary>
        /// Indicates how much ATA this item provies, if applicable
        /// </summary>
        public double ATA { get; set; } = 0;

        /// <summary>
        /// Indicates how much EVP this item provies, if applicable
        /// </summary>
        public int EVP { get; set; } = 0;

        /// <summary>
        /// Indicates how much LCK this item provies, if applicable
        /// </summary>
        public int LCK { get; set; } = 0;

        /// <summary>
        /// Creates a deep copy of the item stats
        /// </summary>
        /// <returns>The copied item stats</returns>
        public ItemStatsJSON Copy()
        {
            ItemStatsJSON copy = new ItemStatsJSON();
            copy.HP = HP; 
            copy.TP = TP;
            copy.ATP = ATP;
            copy.DFP = DFP; 
            copy. MST = MST;
            copy.ATA = ATA;
            copy. EVP = EVP;
            copy. LCK = LCK;
            return copy;
        }
    }
}

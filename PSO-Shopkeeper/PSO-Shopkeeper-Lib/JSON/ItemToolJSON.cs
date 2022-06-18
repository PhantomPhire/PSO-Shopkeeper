namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the tool portion of a JSON item
    /// </summary>
    public class ItemToolJSON
    {
        /// <summary>
        /// Indicates if the item is rare. Mostly used for tools
        /// </summary>
        public bool Rare { get; set; } = false;

        /// <summary>
        /// Creates a deep copy of the tool
        /// </summary>
        /// <returns>The copied item</returns>
        public ItemToolJSON Copy()
        {
            ItemToolJSON copy = new ItemToolJSON();
            copy.Rare = Rare;

            return copy;
        }
    }
}

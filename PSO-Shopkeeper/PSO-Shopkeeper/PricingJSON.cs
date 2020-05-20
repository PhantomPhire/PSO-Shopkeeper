namespace PSOShopkeeper
{
    /// <summary>
    /// A JSON object meant to contain pricing of items
    /// </summary>
    class PricingJSON
    {
        /// <summary>
        /// Indicates the name of the item to match to for prices
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// indicates the price of the item in PDs
        /// </summary>
        public string PricePDs { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the price of the item in Meseta
        /// </summary>
        public string PriceMeseta { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the price of the item in custom currency
        /// </summary>
        public string PriceCustom { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the name of the custom currency
        /// </summary>
        public string CustomCurrency { get; set; } = string.Empty;

        /// <summary>
        /// Contains any notes about the item
        /// </summary>
        public string Notes { get; set; } = string.Empty;
    }
}

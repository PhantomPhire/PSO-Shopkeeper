namespace PSOShopkeeper
{
    /// <summary>
    /// Houses settings for the shop keeper application to JSON-ify
    /// </summary>
    class Settings
    {
        /// <summary>
        /// A setting forcing the combination of like items
        /// </summary>
        public bool CombineItems { get; set; } = true;

        /// <summary>
        /// A setting enabling automatic syntax highlighting in the template
        /// </summary>
        public bool AutoSyntaxHighlighting { get; set; } = false;

        /// <summary>
        /// A setting indicating if the price should be bolded
        /// </summary>
        public bool BoldPrice { get; set; } = true;

        /// <summary>
        /// A setting indicating if multiple prices should be printed if available
        /// </summary>
        public bool MultiPrice { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon specials should be colorized
        /// </summary>
        public bool ColorizeSpecials { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon hit should be colorized
        /// </summary>
        public bool ColorizeHit { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon percentages should be colorized
        /// </summary>
        public bool ColorizePercentages { get; set; } = true;
    }
}

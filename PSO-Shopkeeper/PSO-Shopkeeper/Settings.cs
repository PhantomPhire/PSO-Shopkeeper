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
    }
}

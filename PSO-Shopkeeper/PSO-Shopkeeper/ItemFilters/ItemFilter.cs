using System;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// An encapsulation of all the components of an item filter
    /// </summary>
    public class ItemFilter : IItemFilter
    {
        /// <summary>
        /// Indicates the name of the filter and the syntax to be used in templates
        /// </summary>
        public string Name { get { return FilterName; } }

        /// <summary>
        /// Indicates the name to display for the filter in hints; a name that may not be syntax friendly
        /// </summary>
        public string DisplayName { get { return FilterDisplayName; } }

        /// <summary>
        /// A description of the filter
        /// </summary>
        public string Description { get { return FilterDescription; } }

        /// <summary>
        /// Contains all the args for the filter
        /// </summary>
        public IItemFilterArg[] Args { get { return FilterArgs; } }

        /// <summary>
        /// Contains the function to use for the filter
        /// </summary>
        public Func<Item, string[], bool> Function { get { return FilterFunction; } }

        /// <summary>
        /// Contains an example usage of the filter
        /// </summary>
        public string Example { get { return FilterExample; } }

        /// <summary>
        /// Indicates the name of the filter and the syntax to be used in templates (to be assigned to)
        /// </summary>
        public string FilterName { get; set; }

        /// <summary>
        /// Indicates the name to display for the filter in hints; a name that may not be syntax friendly (to be assigned to)
        /// </summary>
        public string FilterDisplayName { get; set; }

        /// <summary>
        /// A description of the filter (to be assigned to)
        /// </summary>
        public string FilterDescription { get; set; }

        /// <summary>
        /// Contains all the args for the filter (to be assigned to)
        /// </summary>
        public ItemFilterArg[] FilterArgs { get; set; }

        /// <summary>
        /// Contains the function to use for the filter (to be assigned to)
        /// </summary>
        public Func<Item, string[], bool> FilterFunction { get; set; }

        /// <summary>
        /// Contains an example usage of the filter (to be assigned to)
        /// </summary>
        public string FilterExample { get; set; }
    }
}

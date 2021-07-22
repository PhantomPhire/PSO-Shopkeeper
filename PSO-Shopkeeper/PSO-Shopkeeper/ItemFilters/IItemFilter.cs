using System;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// An interface to an ItemFilter
    /// </summary>
    public interface IItemFilter
    {
        /// <summary>
        /// Indicates the name of the filter and the syntax to be used in templates
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Indicates the name to display for the filter in hints; a name that may not be syntax friendly
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// A description of the filter
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Contains all the args for the filter
        /// </summary>
        IItemFilterArg[] Args { get; }

        /// <summary>
        /// Contains the function to use for the filter
        /// </summary>
        Func<Item, string[], bool> Function { get; }

        /// <summary>
        /// Contains an example usage of the filter
        /// </summary>
        string Example { get; }
    }
}

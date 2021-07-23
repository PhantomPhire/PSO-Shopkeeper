namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// Enumerates the argument types of a filter
    /// </summary>
    public enum FilterArgType
    {
        Number,
        String,
        Comparison,
        ItemName
    }

    /// <summary>
    /// An interface to an ItemFilterArg
    /// </summary>
    public interface IItemFilterArg
    {
        /// <summary>
        /// Indicates the name of the arg
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Contains a description of the arg
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Indicates the type of arg
        /// </summary>
        FilterArgType Type { get; }

        /// <summary>
        /// Indicates if the arg is optional
        /// </summary>
        bool Optional { get; }

        /// <summary>
        /// Prints out the arg in string from
        /// </summary>
        /// <returns>The arg in string form</returns>
        string ToString();
    }
}

using System;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// An encapsulation of a single filter argument specification
    /// </summary>
    public class ItemFilterArg : IItemFilterArg
    {
        /// <summary>
        /// Indicates the name of the arg
        /// </summary>
        public string Name { get { return ArgName; } }

        /// <summary>
        /// Contains a description of the arg
        /// </summary>
        public string Description { get { return ArgDescription; } }

        /// <summary>
        /// Indicates the type of arg
        /// </summary>
        public FilterArgType Type { get { return ArgType; } }

        /// <summary>
        /// Indicates if the arg is optional
        /// </summary>
        public bool Optional { get { return ArgIsOptional; } }

        /// <summary>
        /// Indicates if the arg can repeat (must be last arg)
        /// </summary>
        public bool Repeated { get { return ArgCanRepeat; } }

        /// <summary>
        /// Prints out the arg in string from
        /// </summary>
        /// <returns>The arg in string form</returns>
        public override string ToString()
        {
            string argString = Name + " (" + Enum.GetName(typeof(FilterArgType), Type) + ")";
            if (Optional)
            {
                argString += " (Optional) ";
            }
            argString += " - " + Description;

            return argString;
        }

        /// <summary>
        /// Indicates the name of the arg (to be assigned to)
        /// </summary>
        public string ArgName { get; set; }

        /// <summary>
        /// Contains a description of the arg (to be assigned to)
        /// </summary>
        public string ArgDescription { get; set; }

        /// <summary>
        /// Indicates the type of arg (to be assigned to)
        /// </summary>
        public FilterArgType ArgType { get; set; }

        /// <summary>
        /// Indicates if the arg is optional (to be assigned to)
        /// </summary>
        public bool ArgIsOptional { get; set; }

        /// <summary>
        /// Indicates if the arg can repeat (must be last arg) (to be assigned to)
        /// </summary>
        public bool ArgCanRepeat { get; set; }
    };
}

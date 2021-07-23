using System.Collections.Generic;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// Contains all weapon percentage filters
    /// </summary>
    public class WeaponPercentageFilters : ItemFilterCategory
    {
        /// <summary>
        /// Initializes a new instance of the WeaponPercentageFilters class
        /// </summary>
        private WeaponPercentageFilters()
            : base(new List<ItemFilter>
                   {
                        nativePercentageFilter, aBeastPercentageFilter, machinePercentageFilter, darkPercentageFilter,
                        hitPercentageFilter
                   },
                  "Weapon %")
        {
        }

        /// <summary>
        /// The WeaponPercentageFilters instance
        /// </summary>
        private static WeaponPercentageFilters _instance = null;

        /// <summary>
        /// The singleton instance of the WeaponPercentageFilters
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static WeaponPercentageFilters Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WeaponPercentageFilters();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Contains the native percentage filter
        /// </summary>
        private static readonly ItemFilter nativePercentageFilter = new ItemFilter
        {
            FilterName = "Native",
            FilterDisplayName = "Native %",
            FilterDescription = "prints all weapons with a specific native percentage",
            FilterFunction = (Item item, string[] args) =>
            {
                if (!(item is Weapon))
                {
                    return false;
                }

                return FilterHelpers.CompareArgsInt((item as Weapon).NativePercentage, args);
            },
            FilterArgs = new ItemFilterArg[]
            {
                new ItemFilterArg
                {
                    ArgName = "value",
                    ArgDescription = "The value to compare to",
                    ArgType = FilterArgType.Number,
                    ArgIsOptional = false
                },
                new ItemFilterArg
                {
                    ArgName = "comparison",
                    ArgDescription = "The comparison to make(>, >=, <, <=, or =, = by default)",
                    ArgType = FilterArgType.Comparison,
                    ArgIsOptional = true
                }
            },
            FilterExample = "<Native(60,>)> prints all weapons with 60% native or higher"
        };

        /// <summary>
        /// Contains the A Beast percentage filter
        /// </summary>
        private static readonly ItemFilter aBeastPercentageFilter = new ItemFilter
        {
            FilterName = "ABeast",
            FilterDisplayName = "A. Beast %",
            FilterDescription = "prints all weapons with a specific A Beast percentage",
            FilterFunction = (Item item, string[] args) =>
            {
                if (!(item is Weapon))
                {
                    return false;
                }

                return FilterHelpers.CompareArgsInt((item as Weapon).ABeastPercentage, args);
            },
            FilterArgs = new ItemFilterArg[]
            {
                new ItemFilterArg
                {
                    ArgName = "value",
                    ArgDescription = "The value to compare to",
                    ArgType = FilterArgType.Number,
                    ArgIsOptional = false
                },
                new ItemFilterArg
                {
                    ArgName = "comparison",
                    ArgDescription = "The comparison to make(>, >=, <, <=, or =, = by default)",
                    ArgType = FilterArgType.Comparison,
                    ArgIsOptional = true
                }
            },
            FilterExample = "<ABeast(60,>)> prints all weapons with 60% ABeast or higher"
        };

        /// <summary>
        /// Contains the machine percentage filter
        /// </summary>
        private static readonly ItemFilter machinePercentageFilter = new ItemFilter
        {
            FilterName = "Machine",
            FilterDisplayName = "Machine %",
            FilterDescription = "prints all weapons with a specific machine percentage",
            FilterFunction = (Item item, string[] args) =>
            {
                if (!(item is Weapon))
                {
                    return false;
                }

                return FilterHelpers.CompareArgsInt((item as Weapon).MachinePercentage, args);
            },
            FilterArgs = new ItemFilterArg[]
            {
                new ItemFilterArg
                {
                    ArgName = "value",
                    ArgDescription = "The value to compare to",
                    ArgType = FilterArgType.Number,
                    ArgIsOptional = false
                },
                new ItemFilterArg
                {
                    ArgName = "comparison",
                    ArgDescription = "The comparison to make(>, >=, <, <=, or =, = by default)",
                    ArgType = FilterArgType.Comparison,
                    ArgIsOptional = true
                }
            },
            FilterExample = "<Machine(60,>)> prints all weapons with 60% machine or higher"
        };

        /// <summary>
        /// Contains the dark percentage filter
        /// </summary>
        private static readonly ItemFilter darkPercentageFilter = new ItemFilter
        {
            FilterName = "Dark",
            FilterDisplayName = "Dark %",
            FilterDescription = "prints all weapons with a specific dark percentage",
            FilterFunction = (Item item, string[] args) =>
            {
                if (!(item is Weapon))
                {
                    return false;
                }

                return FilterHelpers.CompareArgsInt((item as Weapon).DarkPercentage, args);
            },
            FilterArgs = new ItemFilterArg[]
            {
                new ItemFilterArg
                {
                    ArgName = "value",
                    ArgDescription = "The value to compare to",
                    ArgType = FilterArgType.Number,
                    ArgIsOptional = false
                },
                new ItemFilterArg
                {
                    ArgName = "comparison",
                    ArgDescription = "The comparison to make(>, >=, <, <=, or =, = by default)",
                    ArgType = FilterArgType.Comparison,
                    ArgIsOptional = true
                }
            },
            FilterExample = "<Dark(60,>)> prints all weapons with 60% dark or higher"
        };

        /// <summary>
        /// Contains the hit percentage filter
        /// </summary>
        private static readonly ItemFilter hitPercentageFilter = new ItemFilter
        {
            FilterName = "Hit",
            FilterDisplayName = "Hit %",
            FilterDescription = "prints all weapons with a specific hit percentage",
            FilterFunction = (Item item, string[] args) =>
            {
                if (!(item is Weapon))
                {
                    return false;
                }

                return FilterHelpers.CompareArgsInt((item as Weapon).HitPercentage, args);
            },
            FilterArgs = new ItemFilterArg[]
            {
                new ItemFilterArg
                {
                    ArgName = "value",
                    ArgDescription = "The value to compare to",
                    ArgType = FilterArgType.Number,
                    ArgIsOptional = false
                },
                new ItemFilterArg
                {
                    ArgName = "comparison",
                    ArgDescription = "The comparison to make(>, >=, <, <=, or =, = by default)",
                    ArgType = FilterArgType.Comparison,
                    ArgIsOptional = true
                }
            },
            FilterExample = "<Hit(60,>)> prints all weapons with 60% hit or higher"
        };
    }
}

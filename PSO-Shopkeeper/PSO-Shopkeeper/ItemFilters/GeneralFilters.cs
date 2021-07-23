using System.Collections.Generic;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// Contains general item filters
    /// </summary>
    public class GeneralFilters : ItemFilterCategory
    {
        /// <summary>
        /// Initializes a new instance of the GeneralFilters class
        /// </summary>
        private GeneralFilters()
            : base(new List<ItemFilter>
                   {
                       allFilter, weaponFilter, frameFilter, barrierFilter, defenseFilter, unitFilter, magFilter, techFilter,
                       toolFilter, rareFilter, specificItemFilter, pdValueFilter, starCountFilter
                   },
                  "General")
        {
        }

        /// <summary>
        /// The GeneralFilters instance
        /// </summary>
        private static GeneralFilters _instance = null;

        /// <summary>
        /// The singleton instance of the GeneralFilters
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static GeneralFilters Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GeneralFilters();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Contains the all items filter
        /// </summary>
        private static readonly ItemFilter allFilter = new ItemFilter
        {
            FilterName = "all",
            FilterDisplayName = "All",
            FilterDescription = "Allows items",
            FilterFunction = (Item item, string[] args) => { return true; }
        };

        /// <summary>
        /// Contains the all weapons filter
        /// </summary>
        private static readonly ItemFilter weaponFilter = new ItemFilter
        {
            FilterName = "weapons",
            FilterDisplayName = "Weapons",
            FilterDescription = "Allows weapons",
            FilterFunction = (Item item, string[] args) => { return item.Type == ItemType.Weapon; }
        };

        /// <summary>
        /// Contains the all frames filter
        /// </summary>
        private static readonly ItemFilter frameFilter = new ItemFilter
        {
            FilterName = "frames",
            FilterDisplayName = "Frames/Armor",
            FilterDescription = "Allows frames/armor",
            FilterFunction = (Item item, string[] args) => { return item.Type == ItemType.Frame; }
        };

        /// <summary>
        /// Contains the all barrier filter
        /// </summary>
        private static readonly ItemFilter barrierFilter = new ItemFilter
        {
            FilterName = "barriers",
            FilterDisplayName = "Barriers/Shields",
            FilterDescription = "Allows barriers/shields",
            FilterFunction = (Item item, string[] args) => { return item.Type == ItemType.Barrier; }
        };

        /// <summary>
        /// Contains the all defensive item filter
        /// </summary>
        private static readonly ItemFilter defenseFilter = new ItemFilter
        {
            FilterName = "defense",
            FilterDisplayName = "Defense",
            FilterDescription = "Allows frames/armor and barriers/shields",
            FilterFunction = (Item item, string[] args) => { return (item.Type == ItemType.Frame) || (item.Type == ItemType.Barrier); }
        };

        /// <summary>
        /// Contains the all units filter
        /// </summary>
        private static readonly ItemFilter unitFilter = new ItemFilter
        {
            FilterName = "units",
            FilterDisplayName = "Units",
            FilterDescription = "Allows units",
            FilterFunction = (Item item, string[] args) => { return item.Type == ItemType.Unit; }
        };

        /// <summary>
        /// Contains the all mags filter
        /// </summary>
        private static readonly ItemFilter magFilter = new ItemFilter
        {
            FilterName = "mags",
            FilterDisplayName = "Mags",
            FilterDescription = "Allows mags",
            FilterFunction = (Item item, string[] args) => { return item.Type == ItemType.Mag; }
        };

        /// <summary>
        /// Contains the all techs filter
        /// </summary>
        private static readonly ItemFilter techFilter = new ItemFilter
        {
            FilterName = "techs",
            FilterDisplayName = "Techs",
            FilterDescription = "Allows tech discs",
            FilterFunction = (Item item, string[] args) => { return item.Type == ItemType.Technique; }
        };

        /// <summary>
        /// Contains the all tools filter
        /// </summary>
        private static readonly ItemFilter toolFilter = new ItemFilter
        {
            FilterName = "tools",
            FilterDisplayName = "Tools",
            FilterDescription = "Allows tools",
            FilterFunction = (Item item, string[] args) => { return item.Type == ItemType.Tool; }
        };

        /// <summary>
        /// Contains the all rare items filter
        /// </summary>
        private static readonly ItemFilter rareFilter = new ItemFilter
        {
            FilterName = "rare",
            FilterDisplayName = "Rare Items",
            FilterDescription = "Allows tools",
            FilterFunction = (Item item, string[] args) => { return item.BaseRarity >= 9; }
        };

        /// <summary>
        /// Contains the specific item filter
        /// </summary>
        private static readonly ItemFilter specificItemFilter = new ItemFilter
        {
            FilterName = "item",
            FilterDisplayName = "Specific Item",
            FilterDescription = "Allows a specific item",
            FilterFunction = (Item item, string[] args) =>
            {
                if (args.Length < 1)
                {
                    return false;
                }

                if (item.Name.ToLower() != args[0].Trim().ToLower())
                {
                    return false;
                }

                return ItemDatabase.Instance.FindItem(args[0], args[0]) != null;
            },
            FilterArgs = new ItemFilterArg[]
            {
                new ItemFilterArg
                {
                    ArgName = "name",
                    ArgDescription = "The name of the item to print",
                    ArgType = FilterArgType.ItemName,
                    ArgIsOptional = false
                }
            },
            FilterExample = "<item(Red Sword)> Allows items with the name Red Sword"
        };

        /// <summary>
        /// Contains the pd value filter
        /// </summary>
        private static readonly ItemFilter pdValueFilter = new ItemFilter
        {
            FilterName = "PD",
            FilterDisplayName = "PD Value",
            FilterDescription = "Allows items of a specific PD value",
            FilterFunction = (Item item, string[] args) =>
            {
                if (!double.TryParse(item.PricePDs, out double price))
                {
                    return false;
                }

                return FilterHelpers.CompareArgsDouble(price, args);
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
            FilterExample = "<PD(=,5)> Allows items equal to 5 PD in value"
        };

        /// <summary>
        /// Contains the star count filter
        /// </summary>
        private static readonly ItemFilter starCountFilter = new ItemFilter
        {
            FilterName = "star",
            FilterDisplayName = "Star Count",
            FilterDescription = "Allows items of a specified rarity",
            FilterFunction = (Item item, string[] args) => { return FilterHelpers.CompareArgsInt(item.Rarity, args); },
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
            FilterExample = "<star(9,>)> Allows items greater than 9 stars in rarity"
        };
    }
}

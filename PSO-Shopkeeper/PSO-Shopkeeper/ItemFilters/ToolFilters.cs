using System.Collections.Generic;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// Contains all tool specific filters
    /// </summary>
    class ToolFilters : ItemFilterCategory
    {
        /// <summary>
        /// Initializes a new instance of the WeaponFilters class
        /// </summary>
        private ToolFilters()
            : base(new List<ItemFilter>
                   {
                       commonToolsFilter, grinderFilter, materialFilter, diskFilter, amplifierFilter
                   },
                  "Tool Specific")
        {
        }

        /// <summary>
        /// The ToolFilters instance
        /// </summary>
        private static ToolFilters _instance = null;

        /// <summary>
        /// The singleton instance of the ToolFilters
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static ToolFilters Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ToolFilters();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Lists out common tools that can be bought from the tool shop
        /// </summary>
        private static List<string> commonTools = new List<string>
        {
            "monomate", "dimate", "trimate", "monofluid", "difluid", "trifluid", "sol atomizer", "moon atomizer",
            "star atomizer", "telepipe", "antidote", "antiparalysis", "trap vision"
        };

        /// <summary>
        /// Contains the common tools filter
        /// </summary>
        private static readonly ItemFilter commonToolsFilter = new ItemFilter
        {
            FilterName = "common_tools",
            FilterDisplayName = "Common Tools",
            FilterDescription = "Allows common tools (includes mono/di/tri mates and fluids, sol/moon/star atomizers," + 
                                " telepipes, antidotes, antiparlysis, and trap vision.",
            FilterFunction = (Item item, string[] args) =>
            {
                if ((item is Tool) && commonTools.Contains(item.Name.ToLower()))
                {
                    return true;
                }
                return false;
            }
        };

        /// <summary>
        /// Lists out all grinders
        /// </summary>
        private static List<string> grinders = new List<string>
        {
            "monogrinder", "digrinder", "trigrinder"
        };

        /// <summary>
        /// Contains the grinders filter
        /// </summary>
        private static readonly ItemFilter grinderFilter = new ItemFilter
        {
            FilterName = "grinders",
            FilterDisplayName = "Grinders",
            FilterDescription = "Allows all grinders",
            FilterFunction = (Item item, string[] args) =>
            {
                if ((item is Tool) && grinders.Contains(item.Name.ToLower()))
                {
                    return true;
                }
                return false;
            }
        };

        /// <summary>
        /// Lists out all materials
        /// </summary>
        private static List<string> materials = new List<string>
        {
            "hp material", "tp material", "power material", "mind material", "def material", "evade material", "luck material"
        };

        /// <summary>
        /// Contains the materials filter
        /// </summary>
        private static readonly ItemFilter materialFilter = new ItemFilter
        {
            FilterName = "materials",
            FilterDisplayName = "Materials",
            FilterDescription = "Allows all materials",
            FilterFunction = (Item item, string[] args) =>
            {
                if ((item is Tool) && materials.Contains(item.Name.ToLower()))
                {
                    return true;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the music disk filter
        /// </summary>
        private static readonly ItemFilter diskFilter = new ItemFilter
        {
            FilterName = "music",
            FilterDisplayName = "Music Disks",
            FilterDescription = "Allows all music disks",
            FilterFunction = (Item item, string[] args) =>
            {
                if ((item is Tool) && item.Name.ToLower().Contains("disk vol"))
                {
                    return true;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the tech amplifier filter
        /// </summary>
        private static readonly ItemFilter amplifierFilter = new ItemFilter
        {
            FilterName = "amplifiers",
            FilterDisplayName = "Amplifiers",
            FilterDescription = "Allows all technique amplifiers",
            FilterFunction = (Item item, string[] args) =>
            {
                if ((item is Tool) && item.Name.ToLower().Contains("amplifier of"))
                {
                    return true;
                }
                return false;
            }
        };
    }
}

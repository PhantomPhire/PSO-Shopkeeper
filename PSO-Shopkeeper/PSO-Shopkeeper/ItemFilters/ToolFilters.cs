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
                       commonToolsFilter, grinderFilter, materialFilter, diskFilter, amplifierFilter, enemyPartsFilter, 
                       magCellFilter
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
        private static readonly List<string> commonTools = new List<string>
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
        private static readonly List<string> grinders = new List<string>
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
        private static readonly List<string> materials = new List<string>
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

        /// <summary>
        /// Indicates the first for digits of an enemy part hex string
        /// </summary>
        private const string enemyPartHexFirstFour = "030D";

        /// <summary>
        /// Contains the enemy parts filter
        /// </summary>
        private static readonly ItemFilter enemyPartsFilter = new ItemFilter
        {
            FilterName = "enemy_parts",
            FilterDisplayName = "Enemy Parts",
            FilterDescription = "Allows all enemy parts",
            FilterFunction = (Item item, string[] args) =>
            {
                if ((item is Tool) && (item.HexString.Substring(0, 4).ToUpper() == enemyPartHexFirstFour.ToUpper()))
                {
                    return true;
                }
                return false;
            }
        };

        /// <summary>
        /// Lists out hexes of all mag cells
        /// </summary>
        private static readonly HashSet<string> magCellHexes = new HashSet<string>
        {
            "03180A", // Liberta Kit
            "030E0D", // Heart of Angel
            "030C05", // Heart of Chao
            "030E0B", // Heart of Chu Chu
            "030C01", // Cell of Mag 213
            "030E0E", // Heart of Devil
            "030E15", // Kit of Dreamcast
            "031810", // Heart of YN-0117
            "031809", // D-Photon Core
            "030E13", // Kit of Genesis
            "031800", // Tablet
            "030E0F", // Kit of Hamburger
            "03180E", // Kalki Kit
            "030E26", // Heart of Kapu Kapu
            "03180C", // Mag Kit
            "030E11", // Kit of Mark III
            "030E12", // Kit of Master System
            "031806", // Heart of Morolian
            "030C03", // Heart of Opa Opa
            "030E10", // Panther's Spirit
            "030C04", // Heart of Pian
            "031804", // Pioneer Parts
            "030C00", // Cell of Mag 502
            "031805", // Amite's Memo
            "030C02", // Parts of RoboChao
            "031807", // Rappy's Beak
            "030E14", // Kit of Sega Saturn
            "03180B", // Stealth Kit
            "031803", // Heaven Striker Coat
            "031802", // Dragon Scale
            "03180D", // Varuna Kit
            "03180F", // Vitra Kit
            "031808", // Yahoo's Engine
        };

        /// <summary>
        /// Contains the mag cell filter
        /// </summary>
        private static readonly ItemFilter magCellFilter = new ItemFilter
        {
            FilterName = "mag_cells",
            FilterDisplayName = "Mag Cells",
            FilterDescription = "Allows all mag cells",
            FilterFunction = (Item item, string[] args) =>
            {
                if ((item is Tool) && magCellHexes.Contains(item.HexString.ToUpper()))
                {
                    return true;
                }
                return false;
            }
        };
    }
}

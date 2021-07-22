using System.Collections.Generic;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// Contains all weapon filters
    /// </summary>
    public class WeaponFilters : ItemFilterCategory
    {
        /// <summary>
        /// Initializes a new instance of the WeaponFilters class
        /// </summary>
        private WeaponFilters()
            : base(new List<ItemFilter>
                   {
                       saberFilter, swordFilter, daggerFilter, partisanFilter ,slicerFilter, doubleSaberFilter, clawFilter, katanaFilter,
                       twinSwordFilter, fistFilter, handgunFilter, rifleFilter, mechgunFilter, shotFilter, launcherFilter,
                       caneFilter, rodFilter, wandFilter, caneFilter
                   },
                  "Weapon Types")
        {
        }

        /// <summary>
        /// The WeaponFilters instance
        /// </summary>
        private static WeaponFilters _instance = null;

        /// <summary>
        /// The singleton instance of the WeaponFilters
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static WeaponFilters Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WeaponFilters();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Contains the saber weapon filter
        /// </summary>
        private static readonly ItemFilter saberFilter = new ItemFilter
        {
            FilterName = "sabers",
            FilterDisplayName = "Sabers",
            FilterDescription = "prints all sabers",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Saber;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the sword weapon filter
        /// </summary>
        private static readonly ItemFilter swordFilter = new ItemFilter
        {
            FilterName = "swords",
            FilterDisplayName = "Swords",
            FilterDescription = "prints all swords",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Sword;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the dagger weapon filter
        /// </summary>
        private static readonly ItemFilter daggerFilter = new ItemFilter
        {
            FilterName = "daggers",
            FilterDisplayName = "Daggers",
            FilterDescription = "prints all daggers",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Dagger;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the partisan weapon filter
        /// </summary>
        private static readonly ItemFilter partisanFilter = new ItemFilter
        {
            FilterName = "partisans",
            FilterDisplayName = "Partisans",
            FilterDescription = "prints all partisans",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Partisan;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the slicer weapon filter
        /// </summary>
        private static readonly ItemFilter slicerFilter = new ItemFilter
        {
            FilterName = "slicers",
            FilterDisplayName = "Slicers",
            FilterDescription = "prints all slicers",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Slicer;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the double saber weapon filter
        /// </summary>
        private static readonly ItemFilter doubleSaberFilter = new ItemFilter
        {
            FilterName = "double_sabers",
            FilterDisplayName = "Double Sabers",
            FilterDescription = "prints all double sabers",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.DoubleSaber;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the claw weapon filter
        /// </summary>
        private static readonly ItemFilter clawFilter = new ItemFilter
        {
            FilterName = "claws",
            FilterDisplayName = "Claws",
            FilterDescription = "prints all claws",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Claw;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the katana weapon filter
        /// </summary>
        private static readonly ItemFilter katanaFilter = new ItemFilter
        {
            FilterName = "katanas",
            FilterDisplayName = "Katanas",
            FilterDescription = "prints all katanas",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Katana;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the twin sword weapon filter
        /// </summary>
        private static readonly ItemFilter twinSwordFilter = new ItemFilter
        {
            FilterName = "twin_swords",
            FilterDisplayName = "Twin Swords",
            FilterDescription = "prints all twin swords",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.TwinSword;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the fist weapon filter
        /// </summary>
        private static readonly ItemFilter fistFilter = new ItemFilter
        {
            FilterName = "fists",
            FilterDisplayName = "Fists",
            FilterDescription = "prints all fists",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Fist;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the handgun weapon filter
        /// </summary>
        private static readonly ItemFilter handgunFilter = new ItemFilter
        {
            FilterName = "handguns",
            FilterDisplayName = "Handguns",
            FilterDescription = "prints all handguns",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Handgun;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the rifle weapon filter
        /// </summary>
        private static readonly ItemFilter rifleFilter = new ItemFilter
        {
            FilterName = "rifles",
            FilterDisplayName = "Rifles",
            FilterDescription = "prints all rifles",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Rifle;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the mechgun weapon filter
        /// </summary>
        private static readonly ItemFilter mechgunFilter = new ItemFilter
        {
            FilterName = "mechguns",
            FilterDisplayName = "Mechguns",
            FilterDescription = "prints all mechguns",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Mechgun;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the shot weapon filter
        /// </summary>
        private static readonly ItemFilter shotFilter = new ItemFilter
        {
            FilterName = "shots",
            FilterDisplayName = "Shots",
            FilterDescription = "prints all shots",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Shot;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the launcher weapon filter
        /// </summary>
        private static readonly ItemFilter launcherFilter = new ItemFilter
        {
            FilterName = "launchers",
            FilterDisplayName = "Launchers",
            FilterDescription = "prints all launchers",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Launcher;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the cane weapon filter
        /// </summary>
        private static readonly ItemFilter caneFilter = new ItemFilter
        {
            FilterName = "canes",
            FilterDisplayName = "Canes",
            FilterDescription = "prints all canes",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Cane;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the rod weapon filter
        /// </summary>
        private static readonly ItemFilter rodFilter = new ItemFilter
        {
            FilterName = "rods",
            FilterDisplayName = "Rods",
            FilterDescription = "prints all rods",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Rod;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the wand weapon filter
        /// </summary>
        private static readonly ItemFilter wandFilter = new ItemFilter
        {
            FilterName = "wands",
            FilterDisplayName = "Wands",
            FilterDescription = "prints all wands",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Wand;
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the card weapon filter
        /// </summary>
        private static readonly ItemFilter cardFilter = new ItemFilter
        {
            FilterName = "cards",
            FilterDisplayName = "Cards",
            FilterDescription = "prints all cards",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Weapon weapon)
                {
                    return weapon.WeaponType == WeaponType.Card;
                }
                return false;
            }
        };
    }
}

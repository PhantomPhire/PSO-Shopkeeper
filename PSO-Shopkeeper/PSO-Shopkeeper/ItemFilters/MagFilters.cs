using System.Collections.Generic;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// Contains all mag specific filters
    /// </summary>
    class MagFilters : ItemFilterCategory
    {
        /// <summary>
        /// Initializes a new instance of the MagFilters class
        /// </summary>
        private MagFilters()
            : base(new List<ItemFilter>
                   {
                       babyMagFilter, nonBabyMagFilter
                   },
                  "Mag Specific")
        {
        }

        /// <summary>
        /// The MagFilters instance
        /// </summary>
        private static MagFilters _instance = null;

        /// <summary>
        /// The singleton instance of the MagFilters
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static MagFilters Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MagFilters();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Contains the baby mags filter
        /// </summary>
        private static readonly ItemFilter babyMagFilter = new ItemFilter
        {
            FilterName = "baby_mags",
            FilterDisplayName = "Baby Mags",
            FilterDescription = "Allows mags that are level 5.",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Mag mag)
                {
                    if ((mag.DEF + mag.POW + mag.DEX + mag.MIND) < 6.0)
                    {
                        return true;
                    }
                }
                return false;
            }
        };

        /// <summary>
        /// Contains the non-baby mags filter
        /// </summary>
        private static readonly ItemFilter nonBabyMagFilter = new ItemFilter
        {
            FilterName = "non_baby_mags",
            FilterDisplayName = "Non-Baby Mags",
            FilterDescription = "Allows mags that are greater than level 5.",
            FilterFunction = (Item item, string[] args) =>
            {
                if (item is Mag mag)
                {
                    if ((mag.DEF + mag.POW + mag.DEX + mag.MIND) >= 6.0)
                    {
                        return true;
                    }
                }
                return false;
            }
        };
    }
}

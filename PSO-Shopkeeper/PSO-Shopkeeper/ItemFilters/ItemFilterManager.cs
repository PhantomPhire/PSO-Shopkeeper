using System.Collections.Generic;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// A singleton class contain access to all item filter categories
    /// </summary>
    class ItemFilterManager
    {
        /// <summary>
        /// Contains the full list of filter categories
        /// </summary>
        private List<ItemFilterCategory> _categories;

        /// <summary>
        /// Access to the list of item filter categories
        /// </summary>
        public IEnumerable<ItemFilterCategory> Categories { get { return _categories; } }

        /// <summary>
        /// Contains the full list of filters
        /// </summary>
        private List<IItemFilter> _filters;

        /// <summary>
        /// Access to the list of item filters
        /// </summary>
        public IEnumerable<IItemFilter> Filters { get { return _filters; } }

        /// <summary>
        /// Initializes a new instance of the ItemFilterManager class
        /// </summary>
        private ItemFilterManager()
        {
            _categories = new List<ItemFilterCategory>
            {
                GeneralFilters.Instance, WeaponFilters.Instance, WeaponPercentageFilters.Instance, ToolFilters.Instance,
                MagFilters.Instance
            };
            _filters = new List<IItemFilter>();
            _filters.AddRange(GeneralFilters.Instance.Filters);
            _filters.AddRange(WeaponFilters.Instance.Filters);
            _filters.AddRange(WeaponPercentageFilters.Instance.Filters);
            _filters.AddRange(ToolFilters.Instance.Filters);
            _filters.AddRange(MagFilters.Instance.Filters);
        }

        /// <summary>
        /// The ItemFilterManager instance
        /// </summary>
        private static ItemFilterManager _instance = null;

        /// <summary>
        /// The singleton instance of the WeaponFilters
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static ItemFilterManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ItemFilterManager();
                }

                return _instance;
            }
        }
    }
}

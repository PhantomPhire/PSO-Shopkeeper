using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// The base class for all item filter categories
    /// </summary>
    public class ItemFilterCategory
    {
        /// <summary>
        /// Initializes a new instance of the ItemFilterCategory class
        /// </summary>
        /// <param name="filters">The filters to assign</param>
        /// <param name="caption">The caption to assign</param>
        protected ItemFilterCategory(List<ItemFilter> filters, string caption)
        {
            _filters = filters;
            _caption = caption;
        }

        /// <summary>
        /// The backing field for Filters
        /// </summary>
        private List<ItemFilter> _filters;

        /// <summary>
        /// Contains the filters for the category
        /// </summary>
        public IEnumerable<IItemFilter> Filters { get { return _filters; } }

        /// <summary>
        /// The backing field for Caption
        /// </summary>
        private string _caption;

        /// <summary>
        /// Contains the caption by which the category is represented
        /// </summary>
        public string Caption { get { return _caption;  } }
    }
}

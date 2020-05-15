using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO unit
    /// </summary>
    public class Unit : EquippableItem
    {
        /// <summary>
        /// Initializes a new instance of the Unit class
        /// </summary>
        public Unit()
        {
            Type = ItemType.Unit;
        }
    }
}

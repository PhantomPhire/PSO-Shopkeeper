using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a technique disc in PSO
    /// </summary>
    public class Technique : Item
    {
        /// <summary>
        /// Initializes a new instance of the Technique class
        /// </summary>
        public Technique()
        {
            Type = ItemType.Technique;
        }

        /// <summary>
        /// Indicates the technique this disc contains
        /// </summary>
        public TechniqueType TechType { get; set; } = TechniqueType.INVALID;

        /// <summary>
        /// Indicates the level the technique disc has
        /// </summary>
        public int Level { get; set; }
    }
}

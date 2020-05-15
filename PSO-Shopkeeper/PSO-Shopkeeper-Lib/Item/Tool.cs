using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents  a tool in PSO
    /// </summary>
    public class Tool : Item
    {
        /// <summary>
        /// Initializes a new instance of the Tool class
        /// </summary>
        public Tool()
        {
            Type = ItemType.Tool;
        }
    }
}

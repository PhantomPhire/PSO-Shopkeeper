using System;
using PSOShopkeeperLib.JSON;

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

        /// <summary>
        /// Inititializes a new instance of the Tool class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Tool(ItemJSON json) : base(json)
        {
            if (json.Tool == null)
            {
                throw new Exception("Invalid Tool JSON specification!");
            }

            Rare = json.Tool.Rare;
        }

        /// <summary>
        /// Indicates if the Tool is rare
        /// </summary>
        public bool Rare { get; set; } = false;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Tool item = new Tool();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Tool))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            Tool tool = item as Tool;
            tool.Rare = Rare;
        }

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public override string ItemReport()
        {
            string report = ItemReaderText + "\n\n";

            report += "Type: " + Enum.GetName(typeof(ItemType), Type) + "\n";
            report += "Rare: " + (Rare ? "Yes" : "No") + "\n";

            return report;
        }
    }
}

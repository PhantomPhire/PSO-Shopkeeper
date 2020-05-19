using System;
using PSOShopkeeperLib.JSON;

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
        /// Inititializes a new instance of the Technique class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Technique(ItemJSON json) : base(json)
        {
            if (json.Technique == null)
            {
                throw new Exception("Invalid Technique JSON specification!");
            }

            TechType = (TechniqueType)Enum.Parse(typeof(TechniqueType), json.Technique.TechType);
            RequiredMST = json.Technique.RequirementMST;
        }

        /// <summary>
        /// Indicates the technique this disc contains
        /// </summary>
        public TechniqueType TechType { get; set; } = TechniqueType.INVALID;

        /// <summary>
        /// Indicates the level the technique disc has
        /// </summary>
        public int Level { get; set; } = 0;

        /// <summary>
        /// Indicates the amount of MST required to learn the technique
        /// </summary>
        public int RequiredMST { get; set; } = 0;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Technique item = new Technique();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Technique))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            Technique tech = item as Technique;
            tech.TechType = TechType;
            tech.Level = Level;
            tech.RequiredMST = RequiredMST;
        }

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public override string ItemReport()
        {
            string report = ItemReaderText + "\n\n";

            report += "Type:         " + Enum.GetName(typeof(ItemType), Type) + "\n";
            report += "Technique:    " + Enum.GetName(typeof(TechniqueType), TechType) + "\n";
            report += "Required MST: " + RequiredMST + "\n";

            return report;
        }
    }
}

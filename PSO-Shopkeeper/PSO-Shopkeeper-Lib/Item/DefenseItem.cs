using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents either a PSO Frame or Barrier
    /// </summary>
    public class DefenseItem : EquippableItem
    {
        /// <summary>
        /// Initializes a new instance of the DefenseItem class
        /// </summary>
        /// <param name="frame">Set to true if this item is a frame</param>
        public DefenseItem(bool frame)
        {
            Frame = frame;

            if (Frame)
            {
                Type = ItemType.Frame;
            }
            else
            {
                Type = ItemType.Barrier;
            }
        }

        /// <summary>
        /// Inititializes a new instance of the DefenseItem class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public DefenseItem(ItemJSON json) : base(json)
        {
            if (json.Defense == null)
            {
                throw new Exception("Invalid DefenseItem JSON specification!");
            }

            EquipMask = json.Defense.EquipMask;
            setStatsToJSON(json.Defense.Stats);
            setResistancesToJSON(json.Defense.Resistances);
            RequirementLevel = json.Defense.RequirementLevel;
            MaxDFP = json.Defense.MaxDFP;
            MaxEVP = json.Defense.MaxEVP;
            Frame = Type == ItemType.Frame;
        }

        /// <summary>
        /// This indicates the level required to equip the item, if applicable
        /// </summary>
        public int RequirementLevel { get; set; } = 0;

        /// <summary>
        /// This indicates, if armor or barrier, the maximum DFP the item can  roll with.
        /// This value is added to the base DFP value
        /// </summary>
        public int MaxDFP { get; set; } = 0;

        /// <summary>
        /// This indicates, if armor or barrier, the maximum EVP the item can  roll with.
        /// This value is added to the base EVP value
        /// </summary>
        public int MaxEVP { get; set; } = 0;

        /// <summary>
        /// Indicates if this item is a frame/armor or defensive item that is capable of harboring slots
        /// </summary>
        public bool Frame { get; private set; } = false;

        /// <summary>
        /// Indicates the amount of variable DFP the item has
        /// </summary>
        public int VariableDFP { get; set; } = 0;

        /// <summary>
        /// Indicates the amount of variable EVP the item has
        /// </summary>
        public int VariableEVP { get; set; } = 0;

        /// <summary>
        /// Indicates the amount of slots the armor has, if it is a frame
        /// </summary>
        public int Slots { get; set; } = 0;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            DefenseItem item = new DefenseItem(Frame);
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is DefenseItem))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            DefenseItem dItem = item as DefenseItem;
            dItem.RequirementLevel = RequirementLevel;
            dItem.MaxDFP = MaxDFP;
            dItem.MaxEVP = MaxEVP;
            dItem.VariableDFP = RequirementLevel;
            dItem.VariableEVP = VariableEVP;
            dItem.Slots = Slots;
        }

        /// <summary>
        /// Parses in applicable attributes of the item from item reader input
        /// </summary>
        /// <param name="attributes">The attributes to parse</param>
        public override void ParseAttributes(List<string> attributes)
        {
            foreach (string attribute in attributes)
            {
                if (attribute.Contains("/"))
                {
                    parseStats(attribute);
                }
                else
                {
                    parseSlots(attribute);
                }
            }
        }

        /// <summary>
        /// Parses the stats out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parseStats(string attribute)
        {
            string[] split = attribute.Split('|');

            if ((split.Length != 2) ||
                !split[0].Contains("/") ||
                !split[1].Contains("/"))
            {
                throw new Exception("Ill formatted defense item stats");
            }

            string[] dfpSplit = split[0].Trim().Split('/');
            string[] evpSplit = split[1].Trim().Split('/');

            VariableDFP = int.Parse(dfpSplit[0]);
            VariableEVP = int.Parse(evpSplit[0]);
        }

        /// <summary>
        /// PArses the slots out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parseSlots(string attribute)
        {
            string numberString = Regex.Match(attribute, @"\d+").Value;
            Slots = int.Parse(numberString);
        }
    }
}

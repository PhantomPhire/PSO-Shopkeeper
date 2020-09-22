using System;
using PSOShopkeeperLib.JSON;

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

        /// <summary>
        /// Inititializes a new instance of the Unit class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Unit(ItemJSON json) : base(json)
        {
            if (json.Unit == null)
            {
                throw new Exception("Invalid Unit JSON specification!");
            }

            EquipMask = json.Unit.EquipMask;
            setStatsToJSON(json.Unit.Stats);
            setResistancesToJSON(json.Unit.Resistances);
        }

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Unit item = new Unit();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Unit))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
        }

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public override string ItemReport()
        {
            string report = ItemReaderText + "\n" + "Hex: " + HexString + "\n\n";

            report += "Type: " + Enum.GetName(typeof(ItemType), Type) + "\n";

            report += "\n";

            if (HP != 0)
            {
                report += "HP: " + HP.ToString() + "\n";
            }
            if (TP != 0)
            {
                report += "TP: " + TP.ToString() + "\n";
            }
            if (ATP != 0)
            {
                report += "ATP: " + ATP.ToString() + "\n";
            }
            if (DFP != 0)
            {
                report += "DFP: " + DFP.ToString() + "\n";
            }
            if (MST != 0)
            {
                report += "MST: " + MST.ToString() + "\n";
            }
            if (ATA != 0)
            {
                report += "ATA: " + ATA.ToString() + "\n";
            }
            if (EVP != 0)
            {
                report += "EVP: " + EVP.ToString() + "\n";
            }
            if (LCK != 0)
            {
                report += "LCK: " + LCK.ToString() + "\n";
            }
            if (EFR != 0)
            {
                report += "EFR: " + EFR.ToString() + "\n";
            }
            if (EIC != 0)
            {
                report += "EIC: " + EIC.ToString() + "\n";
            }
            if (ETH != 0)
            {
                report += "ETH: " + ETH.ToString() + "\n";
            }
            if (ELT != 0)
            {
                report += "ELT: " + ELT.ToString() + "\n";
            }
            if (EDK != 0)
            {
                report += "EDK: " + EDK.ToString() + "\n";
            }

            report += "\n";

            report += "HUmar:     " + (((EquipMask & HUmarMask) > 0) ? "x" : "") + "\n";
            report += "HUnewearl: " + (((EquipMask & HUnewearlMask) > 0) ? "x" : "") + "\n";
            report += "HUcast:    " + (((EquipMask & HUcastMask) > 0) ? "x" : "") + "\n";
            report += "HUcaseal:  " + (((EquipMask & HUcasealMask) > 0) ? "x" : "") + "\n";
            report += "RAmar:     " + (((EquipMask & RAmarMask) > 0) ? "x" : "") + "\n";
            report += "RAmarl:    " + (((EquipMask & RAmarlMask) > 0) ? "x" : "") + "\n";
            report += "RAcast:    " + (((EquipMask & RAcastMask) > 0) ? "x" : "") + "\n";
            report += "RAcaseal:  " + (((EquipMask & RAcasealMask) > 0) ? "x" : "") + "\n";
            report += "FOmar:     " + (((EquipMask & FOmarMask) > 0) ? "x" : "") + "\n";
            report += "FOmarl:    " + (((EquipMask & FOmarlMask) > 0) ? "x" : "") + "\n";
            report += "FOnewm:    " + (((EquipMask & FOnewmMask) > 0) ? "x" : "") + "\n";
            report += "FOnewearl: " + (((EquipMask & FOnewearlMask) > 0) ? "x" : "") + "\n";

            return report;
        }
    }
}

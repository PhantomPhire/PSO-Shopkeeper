using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO weapon
    /// </summary>
    public class Weapon : EquippableItem
    {
        /// <summary>
        /// Initializes a new instance of the Weapon class
        /// </summary>
        public Weapon()
        {
            Type = ItemType.Weapon;
        }

        /// <summary>
        /// Inititializes a new instance of the Weapon class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Weapon(ItemJSON json) : base(json)
        {
            if (json.Weapon == null)
            {
                throw new Exception("Invalid Weapon JSON specification!");
            }

            EquipMask = json.Weapon.EquipMask;
            setStatsToJSON(json.Weapon.Stats);
            setResistancesToJSON(json.Weapon.Resistances);
            WeaponType = (WeaponType)Enum.Parse(typeof(WeaponType), json.Weapon.WeaponType);
            Special = (SpecialType)Enum.Parse(typeof(SpecialType), json.Weapon.Special);
            Targets = json.Weapon.Targets;
            MaxGrind = json.Weapon.MaxGrind;
            MinATP = json.Weapon.MinATP;
            MaxATP = json.Weapon.MaxATP;
            RequirementATP = json.Weapon.RequirementATP;
            RequirementATA = json.Weapon.RequirementATA;
            RequirementMST = json.Weapon.RequirementMST;
            SRank = json.Weapon.SRank;
        }

        /// <summary>
        /// Indicates the weapon type of the item, if it is a weapon
        /// </summary>
        public WeaponType WeaponType { get; set; } = WeaponType.Saber;

        /// <summary>
        /// Indicates the type of special this item has
        /// </summary>
        public SpecialType Special { get; set; } = SpecialType.None;

        /// <summary>
        /// Indicates the amount of targets the weapon can acquire, if the item is a weapon
        /// </summary>
        public int Targets { get; set; } = 1;

        /// <summary>
        /// Indicates the grind of the weapon
        /// </summary>
        public int Grind { get; set; } = 0;

        /// <summary>
        /// Indicates the maximum grind allowed for the item, if the item is a weapon
        /// </summary>
        public int MaxGrind { get; set; } = 0;

        /// <summary>
        /// Indicates the minimum ATP, if the item is a weapon
        /// </summary>
        public int MinATP { get; set; } = 0;

        /// <summary>
        /// Indicates the maximum ATP, if the item is a weapon
        /// </summary>
        public int MaxATP { get; set; } = 0;

        /// <summary>
        /// Indicates the ATP required to equip the item, if applicable
        /// </summary>
        public int RequirementATP { get; set; } = 0;

        /// <summary>
        /// Indicates the ATA required to equip the item, if applicable
        /// </summary>
        public int RequirementATA { get; set; } = 0;

        /// <summary>
        /// Indicates the MST required to equip the item, if applicable
        /// </summary>
        public int RequirementMST { get; set; } = 0;

        /// <summary>
        /// Indicates if the weapon is a S-Rank
        /// </summary>
        public bool SRank { get; set; } = false;

        /// <summary>
        /// Indicates the S-Rank's weapon name
        /// </summary>
        public string SRankName { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the Native percentage of the weapon
        /// </summary>
        public int NativePercentage { get; set; } = 0;

        /// <summary>
        /// Indicates the A. Beast percentage of the weapon
        /// </summary>
        public int ABeastPercentage { get; set; } = 0;

        /// <summary>
        /// Indicates the Machine percentage of the weapon
        /// </summary>
        public int MachinePercentage { get; set; } = 0;

        /// <summary>
        /// Indicates the Dark percentage of the weapon
        /// </summary>
        public int DarkPercentage { get; set; } = 0;

        /// <summary>
        /// Indicates the Hit percentage of the weapon
        /// </summary>
        public int HitPercentage { get; set; } = 0;

        /// <summary>
        /// Indicates the kill count of the weapon
        /// </summary>
        public int KillCount { get; set; } = 0;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Weapon item = new Weapon();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Weapon))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            Weapon wep = item as Weapon;
            wep.WeaponType = WeaponType;
            wep.Special = Special;
            wep.Targets = Targets;
            wep.Grind = Grind;
            wep.MaxGrind = MaxGrind;
            wep.MinATP = MinATP;
            wep.MaxATP = MaxATP;
            wep.RequirementATP = RequirementATP;
            wep.RequirementATA = RequirementATA;
            wep.RequirementMST = RequirementMST;
            wep.SRank = SRank;
            wep.SRankName = SRankName;
            wep.NativePercentage = NativePercentage;
            wep.ABeastPercentage = ABeastPercentage;
            wep.MachinePercentage = MachinePercentage;
            wep.DarkPercentage = DarkPercentage;
            wep.HitPercentage = HitPercentage;
            wep.KillCount = KillCount;
        }

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public override string ItemReport()
        {
            string report = ItemReaderText + "\n" + "Hex: " + HexString + "\n\n";

            report += "Type: " + Enum.GetName(typeof(ItemType), Type) + "\n";
            report += "Weapon Type: " + Enum.GetName(typeof(WeaponType), WeaponType) + "\n";

            if (RequirementATP != 0)
            {
                report += "Requirement: " + RequirementATP + " ATP\n";
            }
            else if (RequirementATA != 0)
            {
                report += "Requirement: " + RequirementATA + " ATA\n";
            }
            else if (RequirementMST != 0)
            {
                report += "Requirement: " + RequirementMST + " MST\n";
            }

            report += "Grind: " + Grind.ToString() + "/" + MaxGrind.ToString() + "\n";
            report += "Special: " + Enum.GetName(typeof(SpecialType), Special) + "\n";
            report += "ATP: " + MinATP.ToString() + "-" + MaxATP.ToString() + "\n";
            report += "ATA: " + ATA.ToString() + "\n";

            if (HP != 0)
            {
                report += "HP: " + HP.ToString() + "\n";
            }
            if (TP != 0)
            {
                report += "TP: " + TP.ToString() + "\n";
            }
            if (DFP != 0)
            {
                report += "DFP: " + DFP.ToString() + "\n";
            }
            if (MST != 0)
            {
                report += "MST: " + MST.ToString() + "\n";
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

            report += "Native:   " + NativePercentage.ToString() + "%\n";
            report += "A. Beast: " + ABeastPercentage.ToString() + "%\n";
            report += "Machine:  " + MachinePercentage.ToString() + "%\n";
            report += "Dark:     " + DarkPercentage.ToString() + "%\n";
            report += "Hit:      " + HitPercentage.ToString() + "%\n";

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

        /// <summary>
        /// Parses in applicable attributes of the item from item reader input
        /// </summary>
        /// <param name="attributes">The attributes to parse</param>
        public override void ParseAttributes(List<string> attributes) 
        {
            foreach (string attribute in attributes)
            {
                string numberString = Regex.Match(attribute, @"\d+").Value;

                if (attribute.Contains("/"))
                {
                    parsePercentages(attribute);
                }
                else if (numberString != string.Empty)
                {
                    parseKillCount(attribute);
                }
                else
                {
                    parseSpecial(attribute);
                }
            }

            // Handling edge case for SpecialType.Variable copying over from DB
            if (Special == SpecialType.Variable)
            {
                Special = SpecialType.None;
            }
        }

        /// <summary>
        /// Parses the special out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parseSpecial(string attribute)
        {
            attribute = attribute.Replace("'", "");
            Special = (SpecialType)Enum.Parse(typeof(SpecialType), attribute);
        }

        /// <summary>
        /// Parses the percentages out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parsePercentages(string attribute)
        {
            string[] percentages = attribute.Split('/');

            if ((percentages.Length != 4) || (!percentages[3].Contains("|")))
            {
                throw new Exception("Ill formatted weapon percentages");
            }

            NativePercentage = int.Parse(percentages[0]);
            ABeastPercentage = int.Parse(percentages[1]);
            MachinePercentage = int.Parse(percentages[2]);
            string[] darkHitSplit = percentages[3].Split('|');
            DarkPercentage = int.Parse(darkHitSplit[0]);
            HitPercentage = int.Parse(darkHitSplit[1]);
        }

        /// <summary>
        /// Parses the kill count out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parseKillCount(string attribute)
        {
            KillCount = int.Parse(attribute);
        }

        /// <summary>
        /// Returns a string that represents the item
        /// </summary>
        /// <returns>The string representing the item</returns>
        public override string ToString()
        {
            string output = Name;

            if (Grind > 0)
            {
                output +=  " +" + Grind;
            }

            if ((Special != SpecialType.None) && (Special != SpecialType.Variable) && (Special != SpecialType.Other))
            {
                output += " [";

                if (Item.ColorizeSpecials && !Item.TestPrintMode)
                {
                    Color color = ColorManager.Instance.GetColorFromSpecial(Special);
                    output += "[COLOR=#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + "]";
                    
                }

                output += Enum.GetName(typeof(SpecialType), Special);

                if (Item.ColorizeSpecials && !Item.TestPrintMode)
                {
                    output += "[/COLOR]";
                }

                output += "]";
            }

            output += " " + printPercentages();

            if (Quantity > 1)
            {
                output += " x" + Quantity.ToString();
            }

            output += pricePrint();

            return output;
        }

        /// <summary>
        /// Prints the item's percentages
        /// </summary>
        /// <returns>The item's printed percentages</returns>
        private string printPercentages()
        {
            string output = "[";

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                Color color = ColorManager.Instance.GetColorFromPercentage(NativePercentage);
                output += "[COLOR=#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + "]";
            }

            output += NativePercentage.ToString();

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                output += "[/COLOR]";
            }

            output += "/";

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                Color color = ColorManager.Instance.GetColorFromPercentage(ABeastPercentage);
                output += "[COLOR=#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + "]";
            }

            output += ABeastPercentage.ToString();

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                output += "[/COLOR]";
            }

            output += "/";

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                Color color = ColorManager.Instance.GetColorFromPercentage(MachinePercentage);
                output += "[COLOR=#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + "]";
            }

            output += MachinePercentage.ToString();

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                output += "[/COLOR]";
            }

            output += "/";

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                Color color = ColorManager.Instance.GetColorFromPercentage(DarkPercentage);
                output += "[COLOR=#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + "]";
            }

            output += DarkPercentage.ToString();

            if (Item.ColorizePercentages && !Item.TestPrintMode)
            {
                output += "[/COLOR]";
            }

            output += "|";

            if (Item.ColorizeHit && !Item.TestPrintMode)
            {
                Color color = ColorManager.Instance.GetColorFromPercentage(HitPercentage);
                output += "[COLOR=#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + "]";
            }

            output += HitPercentage.ToString();

            if (Item.ColorizeHit && !Item.TestPrintMode)
            {
                output += "[/COLOR]";
            }

            output += "]";

            return output;
        }
    }
}

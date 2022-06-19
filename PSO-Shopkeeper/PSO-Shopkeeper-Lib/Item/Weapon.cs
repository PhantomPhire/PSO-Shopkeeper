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
            string report = ItemReaderText + "\n" + "Hex: " + HexString + "\n" + "Description: " + Description + "\n\n";

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

        private static Regex weaponFilter = new Regex(@"(?:\[(?<special>\w+\'?\w?)\])?\s?\[(?<native>\-?\d+)/(?<abeast>\-?\d+)/(?<machine>\-?\d+)/(?<dark>\-?\d+)\|(?<hit>\-?\d+)\]\s?\[?(?<kills>\d+)?K?\]?");
        public static Regex grindFilter = new Regex(@"\+(?<grind>\d+)");
        public static Regex skinFilter = new Regex(@"\*\s\-\s(?<skin>[\w|\s|'|/|*|\.|\""|\&|\(|\)\-\:\+]+)");

        /// <summary>
        /// Parses in applicable attributes of the item from item reader input
        /// </summary>
        /// <param name="input">The input to parse</param>
        public override void ParseAttributes(string input) 
        {
            base.ParseAttributes(input);

            input = ItemParsing.UntekFilter.Replace(input, "");

            var match = grindFilter.Match(input);

            if (match.Success)
            {
                Grind = int.Parse(match.Groups["grind"].Value);
            }

            match = weaponFilter.Match(input);

            if (match.Success)
            {
                var groups = match.Groups;

                Special = ParseSpecial(groups["special"].Value);
                NativePercentage = int.Parse(groups["native"].Value);
                ABeastPercentage = int.Parse(groups["abeast"].Value);
                MachinePercentage = int.Parse(groups["machine"].Value);
                DarkPercentage = int.Parse(groups["dark"].Value);
                HitPercentage = int.Parse(groups["hit"].Value);

                if (groups["kills"].Value != string.Empty)
                {
                    KillCount = int.Parse(groups["kills"].Value);
                }
            }
            else
            {
                // Try as S-Rank
                match = ItemParsing.S_RankFilter.Match(input);

                if (!match.Success)
                {
                    throw new FormatException("Weapon \"" + input.Trim() + "\" is badly formatted!");
                }

                var groups = match.Groups;
                Special = ParseSpecial(groups["special"].Value);

                if (ItemParsing.SRankNameIDAssociation.ContainsKey(match.Groups["name"].Value.ToLower()))
                {
                    SRankName = match.Groups["srankname"].Value;
                }
                else if (ItemParsing.SRankNameIDAssociation.ContainsKey(match.Groups["srankname"].Value.ToLower()))
                {
                    SRankName = match.Groups["name"].Value;
                }
                else
                {
                    throw new FormatException("ES Weapon \"" + input.Trim() + "\" is badly formatted!");
                }
            }
        }

        /// <summary>
        /// Parses the special out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        public static SpecialType ParseSpecial(string attribute)
        {
            if ((attribute == String.Empty) ||
                attribute.ToLower().Contains("unchanged"))
            {
                return SpecialType.None;
            }

            attribute = attribute.Replace("'", "");
            return (SpecialType)Enum.Parse(typeof(SpecialType), attribute);
        }

        /// <summary>
        /// Parses the weapon skin of a weapon
        /// </summary>
        /// <param name="name">The name of the skin</param>
        /// <returns>The parsed weapon skin</returns>
        public static WeaponSkin ParseWeaponSkin(string name)
        {
            if (name == String.Empty)
            {
                return WeaponSkin.INVALID;
            }
            name = name.Trim().ToUpper().Replace(' ', '_').Replace('-', '_').Replace("\'", "").Replace(".", "_").Replace('/', '_')
                       .Replace(':', '_').Replace('&', '_').Replace('#', '_').Replace('(', '_').Replace(')', '_').Replace("\"", "");
            WeaponSkin result;
            Enum.TryParse(name, out result);
            return result;
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

        /// <summary>
        /// Maps specials of S-Rank weapons to the last two characters of their hex value
        /// </summary>
        public static readonly Dictionary<string, SpecialType> SRankSpecialMap = new Dictionary<string, SpecialType>
        { { "00", SpecialType.None }, { "01", SpecialType.Jellen }, { "02", SpecialType.Zalure }, { "03", SpecialType.HP_Regeneration },
          { "04", SpecialType.TP_Regeneration }, { "05", SpecialType.Burning }, { "06", SpecialType.Tempest }, { "07", SpecialType.Blizzard },
          { "08", SpecialType.Arrest }, { "09", SpecialType.Chaos }, { "0A", SpecialType.Hell }, { "0B", SpecialType.Spirit },
          { "0C", SpecialType.Berserk }, { "0D", SpecialType.Demons }, { "0E", SpecialType.Gush }, { "0F", SpecialType.Geist },
          { "10", SpecialType.Kings } };

        /// <summary>
        /// Gets a last 2 hex string by finding the hex string associated with the special for ES weapons
        /// </summary>
        /// <param name="special">The special to search with</param>
        /// <returns>The last two of a hex value associated with ES weapons</returns>
        public static string GetSRankSpecialHex(SpecialType special)
        {
            foreach (KeyValuePair<string, SpecialType> pair in SRankSpecialMap)
            {
                if (pair.Value == special)
                {
                    return pair.Key;
                }
            }

            return "";
        }
    }
}

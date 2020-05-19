using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            wep.NativePercentage = NativePercentage;
            wep.ABeastPercentage = ABeastPercentage;
            wep.MachinePercentage = MachinePercentage;
            wep.DarkPercentage = DarkPercentage;
            wep.HitPercentage = HitPercentage;
            wep.KillCount = KillCount;
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
        /// PArses the kill count out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parseKillCount(string attribute)
        {
            KillCount = int.Parse(attribute);
        }
    }
}

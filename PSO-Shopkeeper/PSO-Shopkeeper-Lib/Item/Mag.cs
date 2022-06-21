using System;
using System.Collections.Generic;
using PSOShopkeeperLib.JSON;
using System.Text.RegularExpressions;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO Mag
    /// </summary>
    public class Mag : EquippableItem
    {
        /// <summary>
        /// Initializes a new instance of the Mag class
        /// </summary>
        public Mag()
        {
            Type = ItemType.Mag;
        }

        /// <summary>
        /// Inititializes a new instance of the Mag class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public Mag(ItemJSON json) : base(json)
        {
            if (json.Mag == null)
            {
                throw new Exception("Invalid Mag JSON specification!");
            }

            TriggerPercentage = json.Mag.TriggerPercentage;
            PhotonBlastTrigger = (TriggerType)Enum.Parse(typeof(TriggerType), json.Mag.PBTrigger);
            HPTrigger = (TriggerType)Enum.Parse(typeof(TriggerType), json.Mag.HPTrigger);
            BossTrigger = (TriggerType)Enum.Parse(typeof(TriggerType), json.Mag.BossTrigger);
        }

        /// <summary>
        /// Enumerates the different photon blasts available to mags
        /// </summary>
        public enum PhotonBlast
        {
            None,
            Farlla,
            Estlla,
            Leilla,
            Golla,
            Pilla,
            MyllaAndYoulla
        }

        /// <summary>
        /// Enumerates the different mag trigger types
        /// </summary>
        public enum TriggerType
        {
            None,
            Resta,
            ShiftaAndDeband,
            Invincibility
        }

        /// <summary>
        /// Indicates the level of the mag
        /// </summary>
        public int Level 
        {
            get
            {
                return (int)(Math.Floor(DEF) + Math.Floor(POW) + Math.Floor(DEX) + Math.Floor(MIND));
            }
        }

        /// <summary>
        /// Indicates the DEF of the mag
        /// </summary>
        public double DEF { get; set; } = 0.0;

        /// <summary>
        /// Indicates the POW of the mag
        /// </summary>
        public double POW { get; set; } = 0.0;

        /// <summary>
        /// Indicates the DEX of the mag
        /// </summary>
        public double DEX { get; set; } = 0.0;

        /// <summary>
        /// Indicates the MIND of the mag
        /// </summary>
        public double MIND { get; set; } = 0.0;

        /// <summary>
        /// Indicates the first photon blast of the mag
        /// </summary>
        public PhotonBlast FirstPhotonBlast { get; set; } = PhotonBlast.None;

        /// <summary>
        /// Indicates the second photon blast of the mag
        /// </summary>
        public PhotonBlast SecondPhotonBlast { get; set; } = PhotonBlast.None;

        /// <summary>
        /// Indicates the third photon blast of the mag
        /// </summary>
        public PhotonBlast ThirdPhotonBlast { get; set; } = PhotonBlast.None;

        /// <summary>
        /// Indicates the mag's trigger percentage
        /// </summary>
        public int TriggerPercentage { get; set; } = 0;

        /// <summary>
        /// Indicates the mag's photon blast trigger
        /// </summary>
        public TriggerType PhotonBlastTrigger { get; set; } = TriggerType.None;

        /// <summary>
        /// Indicates the mag's 10% HP trigger
        /// </summary>
        public TriggerType HPTrigger { get; set; } = TriggerType.None;

        /// <summary>
        /// Indicates the mag's boss trigger
        /// </summary>
        public TriggerType BossTrigger { get; set; } = TriggerType.None;

        /// <summary>
        /// Indicates the color of the mag
        /// </summary>
        public string Color { get; set; } = string.Empty;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            Mag item = new Mag();
            copyAttributes(item);
            return item;
        }

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is Mag))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            Mag mag = item as Mag;
            mag.DEF = DEF;
            mag.POW = POW;
            mag.DEX = DEX;
            mag.MIND = MIND;
            mag.FirstPhotonBlast = FirstPhotonBlast;
            mag.SecondPhotonBlast = SecondPhotonBlast;
            mag.ThirdPhotonBlast = ThirdPhotonBlast;
            mag.TriggerPercentage = TriggerPercentage;
            mag.PhotonBlastTrigger = PhotonBlastTrigger;
            mag.HPTrigger = HPTrigger;
            mag.BossTrigger = BossTrigger;
        }

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public override string ItemReport()
        {
            string report = ItemReaderText + "\n" + "Hex: " + HexString + "\n" + "Description: " + Description + "\n\n";

            report += "Type:  " + Enum.GetName(typeof(ItemType), Type) + "\n";
            report += "Color: " + Color + "\n";

            report += "\n";

            report += "DEF:  " + DEF + "\n";
            report += "POW:  " + POW + "\n";
            report += "DEX:  " + DEX + "\n";
            report += "MIND: " + MIND + "\n";

            report += "\n";

            report += "PB 1: " + Enum.GetName(typeof(PhotonBlast), FirstPhotonBlast) + "\n";
            report += "PB 2: " + Enum.GetName(typeof(PhotonBlast), SecondPhotonBlast) + "\n";
            report += "PB 3: " + Enum.GetName(typeof(PhotonBlast), ThirdPhotonBlast) + "\n";

            report += "\n";

            report += "Photon Blast Trigger: " + Enum.GetName(typeof(TriggerType), PhotonBlastTrigger) + "\n";
            report += "HP 10% Trigger:       " + Enum.GetName(typeof(TriggerType), HPTrigger) + "\n";
            report += "Boss Room Trigger:    " + Enum.GetName(typeof(TriggerType), BossTrigger) + "\n";
            report += "Trigger Chance:       " + TriggerPercentage + "%\n";

            return report;
        }

        private static Regex magStatsFilter = new Regex(@"\[(?<def>\d+\.?\d*)/(?<pow>\d+\.?\d*)/(?<dex>\d+\.?\d*)/(?<mind>\d+\.?\d*)\]");
        private static Regex magPBFilter = new Regex(@"\[(?<pb1>[\w\s\&]*)\|(?<pb2>[\w\s\&]*)\|(?<pb3>[\w\s\&]*)\]");
        private static Regex magColorFilter = new Regex(@"\[(?<color>[\w\s]+)\]");

        /// <summary>
        /// Parses in applicable attributes of the item from item reader input
        /// </summary>
        /// <param name="input">The input to parse</param>
        public override void ParseAttributes(string input)
        {
            base.ParseAttributes(input);

            var match = magStatsFilter.Match(input);

            if (match.Success)
            {
                var groups = match.Groups;
                DEF = double.Parse(groups["def"].Value);
                POW = double.Parse(groups["pow"].Value);
                DEX = double.Parse(groups["dex"].Value);
                MIND = double.Parse(groups["mind"].Value);
            }
            else
            {
                throw new Exception("Mag \"" + input.Trim() + "\" is badly formatted!");
            }

            match = magPBFilter.Match(input);

            if (match.Success)
            {
                var groups = match.Groups;
                FirstPhotonBlast = parsePhotonBlast(groups["pb1"].Value);
                SecondPhotonBlast = parsePhotonBlast(groups["pb2"].Value);
                ThirdPhotonBlast = parsePhotonBlast(groups["pb3"].Value);
            }
            else
            {
                throw new Exception("Mag \"" + input.Trim() + "\" is badly formatted!");
            }

            match = magColorFilter.Match(input);

            if (match.Success)
            {
                var groups = match.Groups;
                Color = groups["color"].Value;
            }
            else
            {
                throw new FormatException("Mag \"" + input.Trim() + "\" is badly formatted!");
            }
        }
        
        /// <summary>
        /// Parses a photon blast
        /// </summary>
        /// <param name="input">The input to parse</param>
        /// <returns>The parsed PhotonBlast</returns>
        private PhotonBlast parsePhotonBlast(string input)
        {
            if ((input == "F") || (input == "Farlla"))
            {
                return PhotonBlast.Farlla;
            }
            else if ((input == "E") || (input == "Estlla"))
            {
                return PhotonBlast.Estlla;
            }
            else if ((input == "G") || (input == "Golla"))
            {
                return PhotonBlast.Golla;
            }
            else if ((input == "L") || (input == "Leilla"))
            {
                return PhotonBlast.Leilla;
            }
            else if ((input == "P") || (input == "Pilla"))
            {
                return PhotonBlast.Pilla;
            }
            else if ((input == "M") || (input == "Mylla & Youlla"))
            {
                return PhotonBlast.MyllaAndYoulla;
            }

            return PhotonBlast.None;
        }

        /// <summary>
        /// Constructs a pricing ID for the item
        /// </summary>
        /// <returns>Pricing ID string</returns>
        protected override string constructPricingID()
        {
            return base.constructPricingID() + "[" + DEF + "/" + POW + "/"  + DEX + "/" + MIND + "][" 
                       + Enum.GetName(typeof(PhotonBlast), FirstPhotonBlast) + "|" + Enum.GetName(typeof(PhotonBlast), SecondPhotonBlast) 
                       + "|" + Enum.GetName(typeof(PhotonBlast), ThirdPhotonBlast) + "][" + Color + "]";
        }
    }
}

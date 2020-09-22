using System;
using System.Collections.Generic;
using PSOShopkeeperLib.JSON;

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
            string report = ItemReaderText + "\n" + "Hex: " + HexString + "\n\n";

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
                else if (attribute.Contains("|"))
                {
                    parsePhotonBlasts(attribute);
                }
                else
                {
                    Color = attribute;
                }
            }
        }

        /// <summary>
        /// Parses the stats out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parseStats(string attribute)
        {
            string[] split = attribute.Split('/');

            if (split.Length != 4)
            {
                throw new Exception("Ill formatted mag stats");
            }

            DEF = double.Parse(split[0]);
            POW = double.Parse(split[1]);
            DEX = double.Parse(split[2]);
            MIND = double.Parse(split[3]);
        }

        /// <summary>
        /// PArses the photon blasts out of an attribute
        /// </summary>
        /// <param name="attribute">The attribute to parse</param>
        private void parsePhotonBlasts(string attribute)
        {
            string[] split = attribute.Split('|');

            if (split.Length != 3)
            {
                throw new Exception("Ill formatted mag photon blasts");
            }

            FirstPhotonBlast = pbFromLetter(split[0]);
            SecondPhotonBlast = pbFromLetter(split[1]);
            ThirdPhotonBlast = pbFromLetter(split[2]);
        }
        
        /// <summary>
        /// Parses a photon blast from a letter code
        /// </summary>
        /// <param name="input">The input to parse</param>
        /// <returns>The parsed PhotonBlast</returns>
        private PhotonBlast pbFromLetter(string input)
        {
            if (input == "F")
            {
                return PhotonBlast.Farlla;
            }
            else if (input == "E")
            {
                return PhotonBlast.Estlla;
            }
            else if (input == "G")
            {
                return PhotonBlast.Golla;
            }
            else if (input == "L")
            {
                return PhotonBlast.Leilla;
            }
            else if (input == "P")
            {
                return PhotonBlast.Pilla;
            }
            else if (input == "M")
            {
                return PhotonBlast.MyllaAndYoulla;
            }

            return PhotonBlast.None;
        }
    }
}

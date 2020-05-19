using System;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents a PSO item that is able to be equipped
    /// </summary>
    public abstract class EquippableItem : Item
    {
        #region constants
        /// <summary>
        /// Indicates mask used for HUmar
        /// </summary>
        public const int HUmarMask = 0b1;

        /// <summary>
        /// Indicates mask used for HUnewearl
        /// </summary>
        public const int HUnewearlMask = 0b10;

        /// <summary>
        /// Indicates mask used for HUcast
        /// </summary>
        public const int HUcastMask = 0b100;

        /// <summary>
        /// Indicates mask used for HUcaseal
        /// </summary>
        public const int HUcasealMask = 0b1000;

        /// <summary>
        /// Indicates mask used for RAmar
        /// </summary>
        public const int RAmarMask = 0b10000;

        /// <summary>
        /// Indicates mask used for RAmarl
        /// </summary>
        public const int RAmarlMask = 0b100000;

        /// <summary>
        /// Indicates mask used for RAcast
        /// </summary>
        public const int RAcastMask = 0b1000000;

        /// <summary>
        /// Indicates mask used for RAcaseal
        /// </summary>
        public const int RAcasealMask = 0b10000000;

        /// <summary>
        /// Indicates mask used for FOmar
        /// </summary>
        public const int FOmarMask = 0b100000000;

        /// <summary>
        /// Indicates mask used for FOmarl
        /// </summary>
        public const int FOmarlMask = 0b1000000000;

        /// <summary>
        /// Indicates mask used for FOnewm
        /// </summary>
        public const int FOnewmMask = 0b10000000000;

        /// <summary>
        /// Indicates mask used for FOnewearl
        /// </summary>
        public const int FOnewearlMask = 0b100000000000;
        #endregion

        /// <summary>
        /// Initializes a new instance of  the EquippableItem class
        /// </summary>
        public EquippableItem()
        {
        }

        /// <summary>
        /// Inititializes a new instance of the EquippableItem class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public EquippableItem(ItemJSON json) : base(json)
        {
        }

        /// <summary>
        /// Sets  stats to ItemStatsJSON spec
        /// </summary>
        /// <param name="stats">The JSON spec to use</param>
        public void setStatsToJSON(ItemStatsJSON stats)
        {
            HP = stats.HP;
            TP = stats.TP;
            ATP = stats.ATP;
            DFP = stats.DFP;
            MST = stats.MST;
            ATA = stats.ATA;
            EVP = stats.EVP;
            LCK = stats.LCK;
        }

        /// <summary>
        /// Sets  resistances to ItemStatsJSON spec
        /// </summary>
        /// <param name="resistances">The JSON spec to use</param>
        public void setResistancesToJSON(ItemResistancesJSON resistances)
        {
            EFR = resistances.EFR;
            EIC = resistances.EIC;
            ETH = resistances.ETH;
            ELT = resistances.ELT;
            EDK = resistances.EDK;
        }

        /// <summary>
        /// A binary mask indicating which classes (in order) can equip this item, if it is equippable. HUmar is LSB
        /// </summary>
        public int EquipMask { get; set; } = 0b111111111111;

        /// <summary>
        /// Indicates how much HP this item provies, if applicable
        /// </summary>
        public int HP { get; set; } = 0;

        /// <summary>
        /// Indicates how much TP this item provies, if applicable
        /// </summary>
        public int TP { get; set; } = 0;

        /// <summary>
        /// Indicates how much ATP this item provies, if applicable
        /// </summary>
        public int ATP { get; set; } = 0;

        /// <summary>
        /// Indicates how much DFP this item provies, if applicable
        /// </summary>
        public int DFP { get; set; } = 0;

        /// <summary>
        /// Indicates how much MST this item provies, if applicable
        /// </summary>
        public int MST { get; set; } = 0;

        /// <summary>
        /// Indicates how much ATA this item provies, if applicable
        /// </summary>
        public double ATA { get; set; } = 0.0;

        /// <summary>
        /// Indicates how much EVP this item provies, if applicable
        /// </summary>
        public int EVP { get; set; } = 0;
        
        /// <summary>
        /// Indicates how much LCK this item provies, if applicable
        /// </summary>
        public int LCK { get; set; } = 0;

        /// <summary>
        /// Indicates the EFR value the item provides
        /// </summary>
        public int EFR { get; set; } = 0;

        /// <summary>
        /// Indicates the EIC value the item provides
        /// </summary>
        public int EIC { get; set; } = 0;

        /// <summary>
        /// Indicates the ETH value the item provides
        /// </summary>
        public int ETH { get; set; } = 0;

        /// <summary>
        /// Indicates the ELT value the item provides
        /// </summary>
        public int ELT { get; set; } = 0;

        /// <summary>
        /// Indicates the EDK value the item provides
        /// </summary>
        public int EDK { get; set; } = 0;

        /// <summary>
        /// Copies all attributes of the Item into the passed in Item
        /// </summary>
        /// <param name="item">The Item to copy to</param>
        protected override void copyAttributes(Item item)
        {
            if (!(item is EquippableItem))
            {
                throw new Exception("Item passed into copyAttributes does not match type!");
            }

            base.copyAttributes(item);
            EquippableItem equipItem = item as EquippableItem;
            equipItem.EquipMask = EquipMask;
            equipItem.HP = HP;
            equipItem.TP = TP;
            equipItem.ATP = ATP;
            equipItem.DFP = DFP;
            equipItem.MST = MST;
            equipItem.ATA = ATA;
            equipItem.EVP = EVP;
            equipItem.LCK = LCK;
            equipItem.EFR = EFR;
            equipItem.EIC = EIC;
            equipItem.ETH = ETH;
            equipItem.ELT = ELT;
            equipItem.EDK = EDK;
        }
    }
}

using System;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents the weapon component of a JSON item
    /// </summary>
    public class ItemWeaponJSON
    {
        /// <summary>
        /// Indicates the weapon type of the item, if it is a weapon
        /// </summary>
        public string WeaponType { get; set; } = Enum.GetName(typeof(WeaponType), 0);

        /// <summary>
        /// Indicates the stats of the weapon
        /// </summary>
        public ItemStatsJSON Stats { get; set; } = new ItemStatsJSON();

        /// <summary>
        /// Indicates the resistances of the weapon
        /// </summary>
        public ItemResistancesJSON Resistances { get; set; } = new ItemResistancesJSON();

        /// <summary>
        /// A binary mask indicating which classes (in order) can equip this item, if it is equippable. HUmar is LSB
        /// </summary>
        public int EquipMask { get; set; } = 0;

        /// <summary>
        /// Indicates the type of special this item has, if applicable
        /// </summary>
        public string Special { get; set; } = Enum.GetName(typeof(SpecialType), 0);

        /// <summary>
        /// Indicates the amount of targets the weapon can acquire, if the item is a weapon
        /// </summary>
        public int Targets { get; set; } = 0;

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
        /// Indicates if the weapon is an S-Rank
        /// </summary>
        public bool SRank { get; set; } = false;

        /// <summary>
        /// Indicates the Photon color of the weapon
        /// </summary>
        public int PhotonColor { get; set; } = 0;

        /// <summary>
        /// Indicates the stat boost type of the weapon
        /// </summary>
        public int StatBoost { get; set; } = 0;

        /// <summary>
        /// Indicates the projectile type of the weapon
        /// </summary>
        public int Projectile { get; set; } = 0;

        /// <summary>
        /// Indicates the photon trail 1x of the weapon
        /// </summary>
        public int PhotonTrail1x { get; set; } = 0;

        /// <summary>
        /// Indicates the photon trail 1y of the weapon 
        /// </summary>
        public int PhotonTrail1y { get; set; } = 0;

        /// <summary>
        /// Indicates the photon trail 2x of the weapon 
        /// </summary>
        public int PhotonTrail2x { get; set; } = 0;

        /// <summary>
        /// Indicates the photon trail 2y of the weapon 
        /// </summary>
        public int PhotonTrail2y { get; set; } = 0;

        /// <summary>
        /// Indicates the photon model of the weapon 
        /// </summary>
        public int PhotonModel { get; set; } = 0;

        /// <summary>
        /// Indicates the tech boost type of the weapon 
        /// </summary>
        public int TechBoost { get; set; } = 0;

        /// <summary>
        /// Indicates the combo model of the weapon 
        /// </summary>
        public int ComboModel { get; set; } = 0;

        /// <summary>
        /// Creates a deep copy of the Weapon
        /// </summary>
        /// <returns>The copied item</returns>
        public ItemWeaponJSON Copy()
        {
            ItemWeaponJSON copy = new ItemWeaponJSON();
            copy.WeaponType = WeaponType;

            if (Stats != null)
            {
                copy.Stats = Stats.Copy();
            }
            if (Resistances != null)
            {
                copy.Resistances = Resistances.Copy();
            }

            copy.EquipMask = EquipMask;
            copy.Special = Special;
            copy.Targets = Targets;
            copy.MaxGrind = MaxGrind;
            copy.MinATP = MinATP;
            copy.MaxATP = MaxATP;
            copy.RequirementATP = RequirementATP;
            copy.RequirementATA = RequirementATA;
            copy.RequirementMST = RequirementMST;
            copy.SRank = SRank;
            copy.PhotonColor = PhotonColor;
            copy.StatBoost = StatBoost;
            copy.Projectile = Projectile;
            copy.PhotonTrail1x = PhotonTrail1x;
            copy.PhotonTrail2x = PhotonTrail2x;
            copy.PhotonTrail1y = PhotonTrail1y;
            copy.PhotonTrail2y = PhotonTrail2y;
            copy.PhotonModel = PhotonModel;
            copy.TechBoost = TechBoost;
            copy.ComboModel = ComboModel;

            return copy;
        }

        /// <summary>
        /// Imports item attributes from another item exported from ItemPMT
        /// </summary>
        /// <param name="item">The item to import</param>
        public void Import(ItemWeaponJSON item)
        {
            PhotonColor = item.PhotonColor;
            StatBoost = item.StatBoost;
            Projectile = item.Projectile;
            PhotonTrail1x = item.PhotonTrail1x;
            PhotonTrail2x = item.PhotonTrail2x;
            PhotonTrail1y = item.PhotonTrail1y;
            PhotonTrail2y = item.PhotonTrail2y;
            PhotonModel = item.PhotonModel;
            TechBoost = item.TechBoost;
            ComboModel = item.ComboModel;
        }
    } 
}

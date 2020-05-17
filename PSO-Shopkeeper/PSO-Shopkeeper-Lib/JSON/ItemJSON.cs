using PSOShopkeeperLib.Item;
using System;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// Represents an item intended to be serialized to JSON
    /// </summary>
    public class ItemJSON
    {
        /// <summary>
        /// Indicates the name of the item
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the hex value of the item
        /// </summary>
        public string Hex { get; set; } = string.Empty;

        /// <summary>
        /// Indicates the type of the item
        /// </summary>
        public string Type { get; set; } = Enum.GetName(typeof(ItemType), 0);

        /// <summary>
        /// Indicates the weapon type of the item, if it is a weapon
        /// </summary>
        public string WeaponType { get; set; } = Enum.GetName(typeof(WeaponType), 0);

        /// <summary>
        /// A binary mask indicating which classes (in order) can equip this item, if it is equippable. HUmar is LSB
        /// </summary>
        public int EquipMask { get; set; } = 0;

        /// <summary>
        /// Indicates the rarity (star rating) of the item
        /// </summary>
        public int Rarity { get; set; } = 0;

        /// <summary>
        /// Indicates if the item is rare. Mostly used for tools
        /// </summary>
        public bool Rare { get; set; } = false;

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
        public int ATA { get; set; } = 0;

        /// <summary>
        /// Indicates how much EVP this item provies, if applicable
        /// </summary>
        public int EVP { get; set; } = 0;

        /// <summary>
        /// Indicates how much LCK this item provies, if applicable
        /// </summary>
        public int LCK { get; set; } = 0;

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
        /// Indicates the mag PB trigger, if applicable
        /// </summary>
        public string PBTrigger { get; set; } = Enum.GetName(typeof(Mag.TriggerType), 0);

        /// <summary>
        /// Indicates the mag HP trigger, if applicable
        /// </summary>
        public string HPTrigger { get; set; } = Enum.GetName(typeof(Mag.TriggerType), 0);

        /// <summary>
        /// Indicates the mag Boss trigger, if applicable
        /// </summary>
        public string BossTrigger { get; set; } = Enum.GetName(typeof(Mag.TriggerType), 0);

        /// <summary>
        /// Indicates the mag trigger percentage, if applicable
        /// </summary>
        public int TriggerPercentage { get; set; } = 0;

        /// <summary>
        /// Indicates the max amount of the item that can be in a stack. Defaults to 1
        /// </summary>
        public int MaxStack { get; set; } = 1;

        /// <summary>
        /// Indicates the technique this disc contains
        /// </summary>
        public string TechType { get; set; } = Enum.GetName(typeof(TechniqueType), 0);
    }
}

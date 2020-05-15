using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Indicates the weapon type of the item, if it is a weapon
        /// </summary>
        public WeaponType WeaponType { get; set; } = WeaponType.INVALID;

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
    }
}

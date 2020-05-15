using System;

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
    }
}

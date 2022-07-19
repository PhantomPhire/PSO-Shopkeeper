using System.Collections.Generic;
using System.Drawing;

namespace PSOShopkeeper
{
    /// <summary>
    /// Houses settings for the shop keeper application to JSON-ify
    /// </summary>
    class Settings
    {
        /// <summary>
        /// A setting indicating if the price should be bolded
        /// </summary>
        public bool BoldPrice { get; set; } = true;

        /// <summary>
        /// A setting indicating if multiple prices should be printed if available
        /// </summary>
        public bool MultiPrice { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon specials should be colorized
        /// </summary>
        public bool ColorizeSpecials { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon hit should be colorized
        /// </summary>
        public bool ColorizeHit { get; set; } = true;

        /// <summary>
        /// A setting indicating if weapon percentages should be colorized
        /// </summary>
        public bool ColorizePercentages { get; set; } = true;

        /// <summary>
        /// Settings for how to colorize values
        /// </summary>
        public List<Color> ColorizationSettings { get; set; } = new List<Color>();

        // Used for Autofill Dialog

        /// <summary>
        /// A setting determining the maximum amount of PDs to autofill the meseta box on
        /// </summary>
        public double MaxPDsForAutofill { get; set; } = 1.0;

        /// <summary>
        /// A setting determining the amount of meseta for a single PD
        /// </summary>
        public int MesetaPerPD { get; set; } = 500000;

        /// <summary>
        /// A setting indicating if meseta should be abbrivated with a k for thousands on autofill
        /// </summary>
        public bool AbbreviateMesetaAutofill { get; set; } = true;

        /// <summary>
        /// A setting determining the untekk label of items
        /// </summary>
        public string UntekkLabel { get; set; } = "[U]";
    }
}

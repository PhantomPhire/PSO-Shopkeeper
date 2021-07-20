using System;
using System.Collections.Generic;
using System.Drawing;

namespace PSOShopkeeperLib
{
    /// <summary>
    /// A singleton class used to store colorization information
    /// </summary>
    public class ColorManager
    {
        /// <summary>
        /// Initializes a new instance of the ColorManager class
        /// </summary>
        private ColorManager()
        {
        }

        /// <summary>
        /// The ColorManager instance
        /// </summary>
        private static ColorManager _instance = null;

        /// <summary>
        /// The singleton instance of the ColorManager
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static ColorManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ColorManager();
                }

                return _instance;
            }
        }

        /// <summary>
        /// The backing field for settings on how to colorize items
        /// </summary>
        private List<Color> _colorizationSettings = new List<Color>();

        /// <summary>
        /// The settings on how to colorize items
        /// </summary>
        public List<Color> ColorizationSettings
        {
            get { return _colorizationSettings; }
            set
            {
                _colorizationSettings = value;
            }
        }

        /// <summary>
        /// Contains all percentage thresholds for consideration
        /// </summary>
        public static readonly int[] Percentages = { -5, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

        /// <summary>
        /// Fills  ColorizationSettings with default color settings
        /// </summary>
        public void GenerateDefaultColors()
        {
            _colorizationSettings = new List<Color>();

            foreach (int percentage in Percentages)
            {
                _colorizationSettings.Add(getDefaultPercentageColor(percentage));
            }
        }

        /// <summary>
        /// Gets the color of a percentage
        /// </summary>
        /// <param name="percentage">The percentage to determine the color of</param>
        /// <returns>The color corresponding to the percentage</returns>
        private Color getDefaultPercentageColor(int percentage)
        {
            if (percentage <= 0)
            {
                return Color.Gray;
            }

            int red = (int)Math.Floor((double)(255 / 100)) * percentage;
            int green = (int)Math.Floor((double)(255 / 100)) * (100 - percentage);
            int blue = 0;
            return Color.FromArgb(red, green, blue);
        }

        /// <summary>
        /// Translates a percentage to a Color based on current settings
        /// </summary>
        /// <param name="percentage">The percentage to translate</param>
        /// <returns>The Color retrieved</returns>
        public Color GetColorFromPercentage(int percentage)
        {
            if ((ColorizationSettings == null) || ColorizationSettings.Count < Percentages.Length)
            {
                return Color.FromArgb(0, 0, 0);
            }

            // Colors take up the first slots of the colorization settings
            for (int i = 0; i < Percentages.Length; i++)
            {
                if (percentage <= Percentages[i])
                {
                    return ColorizationSettings[i];
                }
            }

            // Higher than 100?
            return ColorizationSettings[Percentages.Length - 1];
        }
    }
}

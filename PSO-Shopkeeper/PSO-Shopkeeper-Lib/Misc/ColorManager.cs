using System;
using System.Collections.Generic;
using System.Drawing;
using PSOShopkeeperLib.Item;

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
        /// Checks to see if the colorization settings read in are alright
        /// </summary>
        /// <returns>True if the settings are good</returns>
        public bool CheckColorizationSettings()
        {
            bool ok = true;

            // Check potentially null stuff here
            if ((ColorizationSettings == null) || (ColorizationSettings.Count < Percentages.Length))
            {
                _colorizationSettings = new List<Color>();
                generateDefaultColorsForPercentages();
                ok = false;
            }
            if (ColorizationSettings.Count < (otherSpecialLocation + 1))
            {
                generateDefaultColorsForSpecials();
                ok = false;
            }

            return ok;
        }

        /// <summary>
        /// Contains all percentage thresholds for consideration
        /// </summary>
        public static readonly int[] Percentages = { -5, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

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

        /// <summary>
        /// Translates a weapon special to a color based on current settings
        /// </summary>
        /// <param name="special">The special to translate</param>
        /// <returns>The Color retrieved</returns>
        public Color GetColorFromSpecial(SpecialType special)
        {
            if ((ColorizationSettings == null) || ColorizationSettings.Count < (otherSpecialLocation + 1))
            {
                return Color.FromArgb(0, 0, 0);
            }

            if (specialSettingsCorrelation.ContainsKey(special))
            {
                return ColorizationSettings[specialSettingsCorrelation[special]];
            }

            return ColorizationSettings[otherSpecialLocation];
        }

        /// <summary>
        /// Resets all colors to default
        /// </summary>
        public void ResetColorsToDefault()
        {
            ColorizationSettings = null;
            CheckColorizationSettings();
        }

        /// <summary>
        /// Fills  ColorizationSettings with default color settings for percentages
        /// </summary>
        private void generateDefaultColorsForPercentages()
        {
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
        /// Fills  ColorizationSettings with default color settings for specials
        /// </summary>
        private void generateDefaultColorsForSpecials()
        {
            _colorizationSettings.Capacity = otherSpecialLocation + 1;
            foreach (KeyValuePair<SpecialType, int> kvp in specialSettingsCorrelation)
            {
                if (defaultSpecialColors.ContainsKey(kvp.Key))
                {
                    _colorizationSettings.Insert(kvp.Value, defaultSpecialColors[kvp.Key]);
                }
            }

            _colorizationSettings.Insert(otherSpecialLocation, otherSpecialDefault);
        }

        /// <summary>
        /// Maps weapon specials to default colors
        /// </summary>
        private static Dictionary<SpecialType, Color> defaultSpecialColors = new Dictionary<SpecialType, Color>
        {
            {  SpecialType.Draw, Color.FromArgb(0xBF, 0xFD, 0xC4) },
            {  SpecialType.Drain, Color.FromArgb(0x80, 0xFB, 0x8A) },
            {  SpecialType.Fill, Color.FromArgb(0x40, 0xF9, 0x4F) },
            {  SpecialType.Gush, Color.FromArgb(0x00, 0xF7, 0x14) },
            {  SpecialType.Heart, Color.FromArgb(0xBF, 0xE1, 0xFC) },
            {  SpecialType.Mind, Color.FromArgb(0x80, 0xC4, 0xFA) },
            {  SpecialType.Soul, Color.FromArgb(0x40, 0xA6, 0xF7) },
            {  SpecialType.Geist, Color.FromArgb(0x00, 0x88, 0xF4) },
            {  SpecialType.Masters, Color.FromArgb(0xFF, 0xB8, 0xFF) },
            {  SpecialType.Lords, Color.FromArgb(0xFF, 0x72, 0xFF) },
            {  SpecialType.Kings, Color.FromArgb(0xFF, 0x2B, 0xFF) },
            {  SpecialType.Charge, Color.FromArgb(0xEB, 0xEB, 0x00) },
            {  SpecialType.Spirit, Color.FromArgb(0xF7, 0xBB, 0x13) },
            {  SpecialType.Berserk, Color.FromArgb(0xEA, 0xF7, 0x18) },
            {  SpecialType.Ice, Color.FromArgb(0xCB, 0xF2, 0xFF) },
            {  SpecialType.Frost, Color.FromArgb(0x98, 0xE5, 0xFF) },
            {  SpecialType.Freeze, Color.FromArgb(0x64, 0xD8, 0xFF) },
            {  SpecialType.Blizzard, Color.FromArgb(0x31, 0xCB, 0xFF) },
            {  SpecialType.Bind, Color.FromArgb(0xF9, 0xD4, 0xC7) },
            {  SpecialType.Hold, Color.FromArgb(0xF3, 0xAA, 0x90) },
            {  SpecialType.Seize, Color.FromArgb(0xED, 0x80, 0x58) },
            {  SpecialType.Arrest, Color.FromArgb(0xE7, 0x55, 0x21) },
            {  SpecialType.Heat, Color.FromArgb(0xFF, 0xDD, 0xCC) },
            {  SpecialType.Fire, Color.FromArgb(0xFF, 0xBB, 0x9A) },
            {  SpecialType.Flame, Color.FromArgb(0xFF, 0x99, 0x67) },
            {  SpecialType.Burning, Color.FromArgb(0xFF, 0x77, 0x34) },
            {  SpecialType.Shock, Color.FromArgb(0xFB, 0xFB, 0xBF) },
            {  SpecialType.Thunder, Color.FromArgb(0xF7, 0xF7, 0x80) },
            {  SpecialType.Storm, Color.FromArgb(0xF3, 0xF2, 0x40) },
            {  SpecialType.Tempest, Color.FromArgb(0xEF, 0xEE, 0x00) },
            {  SpecialType.Dim, Color.FromArgb(0xF2, 0xC4, 0xFF) },
            {  SpecialType.Shadow, Color.FromArgb(0xE5, 0x88, 0xFF) },
            {  SpecialType.Dark, Color.FromArgb(0xD8, 0x4D, 0xFF) },
            {  SpecialType.Hell, Color.FromArgb(0xCB, 0x11, 0xFF) },
            {  SpecialType.Panic, Color.FromArgb(0xFD, 0xC7, 0xE5) },
            {  SpecialType.Riot, Color.FromArgb(0xFC, 0x8F, 0xCB) },
            {  SpecialType.Havoc, Color.FromArgb(0xFA, 0x57, 0xB2) },
            {  SpecialType.Chaos, Color.FromArgb(0xF9, 0x1F, 0x98) },
            {  SpecialType.Devils, Color.FromArgb(0xD3, 0xBF, 0xF0) },
            {  SpecialType.Demons, Color.FromArgb(0xA6, 0x7F, 0xE0) },
        };

        /// <summary>
        /// Maps weapon specials to their position in the ColorizationSettings
        /// </summary>
        private static Dictionary<SpecialType, int> specialSettingsCorrelation = new Dictionary<SpecialType, int>
        {
            {  SpecialType.Draw, 22 },
            {  SpecialType.Drain, 23 },
            {  SpecialType.Fill, 24 },
            {  SpecialType.Gush, 25 },
            {  SpecialType.Heart, 26 },
            {  SpecialType.Mind, 27 },
            {  SpecialType.Soul, 28 },
            {  SpecialType.Geist, 29 },
            {  SpecialType.Masters, 30 },
            {  SpecialType.Lords, 31 },
            {  SpecialType.Kings, 32 },
            {  SpecialType.Charge, 33 },
            {  SpecialType.Spirit, 34 },
            {  SpecialType.Berserk, 35 },
            {  SpecialType.Ice, 36 },
            {  SpecialType.Frost, 37 },
            {  SpecialType.Freeze, 38 },
            {  SpecialType.Blizzard, 39 },
            {  SpecialType.Bind, 40 },
            {  SpecialType.Hold, 41 },
            {  SpecialType.Seize, 42 },
            {  SpecialType.Arrest, 43 },
            {  SpecialType.Heat, 44 },
            {  SpecialType.Fire, 45 },
            {  SpecialType.Flame, 46 },
            {  SpecialType.Burning, 47 },
            {  SpecialType.Shock, 48 },
            {  SpecialType.Thunder, 49 },
            {  SpecialType.Storm, 50 },
            {  SpecialType.Tempest, 51 },
            {  SpecialType.Dim, 52 },
            {  SpecialType.Shadow, 53 },
            {  SpecialType.Dark, 54 },
            {  SpecialType.Hell, 55 },
            {  SpecialType.Panic, 56 },
            {  SpecialType.Riot, 57 },
            {  SpecialType.Havoc, 58 },
            {  SpecialType.Chaos, 59 },
            {  SpecialType.Devils, 60 },
            {  SpecialType.Demons, 61 },
        };

        /// <summary>
        /// Defines what the default special color for other specials is
        /// </summary>
        private static Color otherSpecialDefault = Color.FromArgb(0xFF, 0x00, 0x00);

        /// <summary>
        /// Indicates where the other special is and where special colorization settings end
        /// </summary>
        private static int otherSpecialLocation = 62;
    }
}

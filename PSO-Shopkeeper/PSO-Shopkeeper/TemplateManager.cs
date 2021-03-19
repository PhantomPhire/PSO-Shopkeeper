using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper
{
    /// <summary>
    /// A singleton class intended to manage the output template
    /// </summary>
    class TemplateManager
    {
        /// <summary>
        /// The path to the template file
        /// </summary>
        private const string templateFileSuffix = "\\PSO_Shopkeeper\\template.txt";

        /// <summary>
        /// Gets the full template path
        /// </summary>
        private string templateFile
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + templateFileSuffix;
            }
        }

        /// <summary>
        /// The template
        /// </summary>
        public string Template { get; set; } = string.Empty;

        /// <summary>
        /// Initializes a new instance of the TemplateManager class
        /// </summary>
        private TemplateManager()
        {
            readIn();
        }

        /// <summary>
        /// Reads in the template
        /// </summary>
        private void readIn()
        {
            if (!File.Exists(templateFile))
            {
                Template = defeaultTemplate;
                Save();
                return;
            }

            Template = File.ReadAllText(templateFile);
        }

        /// <summary>
        /// Writes the template file to memory
        /// </summary>
        public void Save()
        {
            File.WriteAllText(templateFile, Template);
        }

        /// <summary>
        /// Finds the next template tag in a string
        /// </summary>
        /// <param name="input">The text to parse</param>
        /// <param name="startingLocation">The location to start at.</param>
        /// <returns></returns>
        public string FindNextTag(string input, int startingLocation = 0)
        {
            int location = startingLocation;

            while (input.IndexOf('<', location) != -1)
            {
                location = input.IndexOf('<', location);

                if (input.IndexOf('>', location) == -1)
                {
                    return string.Empty;
                }

                int end = input.IndexOf('>', location);
                int nextOpenPar = input.IndexOf('(', location);
                int nextClosePar = input.IndexOf(')', location);

                while ((nextOpenPar <  end) && 
                       (nextOpenPar != -1) && 
                       (nextClosePar != -1))
                {
                    int start = nextClosePar;
                    end = input.IndexOf('>', start);
                    nextOpenPar = input.IndexOf('(', start);
                    
                    if (nextOpenPar != -1)
                    {
                        nextClosePar = input.IndexOf(')', nextOpenPar);
                    }
                }

                string tag = input.Substring(location, end - location + 1);

                if (SeparateTag(tag).Count > 0)
                {
                    return tag;
                }

                location = end;
            }

            return string.Empty;
        }

        /// <summary>
        /// Separates a tag into a list of FilterPairs
        /// </summary>
        /// <param name="input">The input to separate</param>
        /// <returns>The resulting list of filters</returns>
        public List<FilterPair> SeparateTag(string input)
        {
            List<FilterPair> list = new List<FilterPair>();

            if (input.Length < 2)
            {
                return list;
            }

            string trimmed = input;
            if (trimmed[0] == '<')
            {
                trimmed = trimmed.Substring(1);
            }
            if (trimmed[trimmed.Length - 1] == '>')
            {
                trimmed = trimmed.Substring(0, trimmed.Length - 1);
            }

            if (trimmed.Contains('|'))
            {
                string[] split = trimmed.Split('|');
                
                foreach (string tag in split)
                {
                    FilterPair pair = getSingleFilter(tag);

                    if (pair != null)
                    {
                        list.Add(pair);
                    }
                }
            }
            else
            {
                FilterPair pair = getSingleFilter(trimmed);

                if (pair != null)
                {
                    list.Add(pair);
                }
            }

            return list;
        }

        /// <summary>
        /// Gets a single filter from a tag
        /// </summary>
        /// <param name="tag">The tag to parse</param>
        /// <returns>The resulting FilterPair, or null if invalid</returns>
        private FilterPair getSingleFilter(string tag)
        {
            string filterName = tag;
            string argsString = string.Empty;
            string[] args = new string[0];
            bool inverted = false;
            if (tag.Contains('(') &&
                tag.Contains(')') && 
                (tag.IndexOf('(') < tag.IndexOf(')')))
            {
                int beginArgs = tag.IndexOf('(');
                int endArgs = tag.IndexOf(')');
                argsString = tag.Substring(beginArgs + 1, endArgs - beginArgs - 1);
                filterName = filterName.Remove(beginArgs, endArgs - beginArgs + 1);
                args = argsString.Split(',');
            }

            if (filterName.StartsWith("!"))
            {
                inverted = true;
                filterName = filterName.Remove(0, 1);
            }
            
            if (!_templateFilters.ContainsKey(filterName.ToLower()))
            {
                return null;
            }

            return new FilterPair(_templateFilters[filterName.ToLower()], args, inverted);
        }

        /// <summary>
        /// The signleton instance of the class
        /// </summary>
        private static TemplateManager _instance = null;

        /// <summary>
        /// Gets the singleton instance of the template manager
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static TemplateManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TemplateManager();
                }

                return _instance;
            }
        }

        /// <summary>
        /// A wrapper class for a filter and associated args
        /// </summary>
        public class FilterPair
        {
            /// <summary>
            /// Initializes a new instancce of the FilterPair class
            /// </summary>
            /// <param name="filter">The filter to contain</param>
            /// <param name="args">The args to associate</param>
            /// <param name="invert">Determines if the filter is inverted and blocks items</param>
            public FilterPair(Func<Item, string[], bool> filter, string[] args, bool invert = false)
            {
                _filter = filter;
                _args = args;
                _invert = invert;
            }

            /// <summary>
            /// Invokes the filter
            /// </summary>
            /// <param name="item">The item to determine the filter for</param>
            /// <returns>True if the item passes the filter</returns>
            public bool Invoke(Item item)
            {
                if (_invert)
                {
                    return !_filter(item, _args);
                }

                return _filter(item, _args);
            }

            private Func<Item, string[], bool> _filter;
            private string[] _args;
            private bool _invert = false;
        }

        /// <summary>
        /// Indicates the default template to write if there isn't one
        /// </summary>
        private const string defeaultTemplate = "[spoiler=\"Weapons\"]\r\n<weapons>\r\n[/spoiler]\r\n\r\n[spoiler=\"Armor and Units\"]" +
                                                    "\r\n<frames>\r\n<barriers>\r\n<units>\r\n[/spoiler]\r\n\r\n[spoiler=\"Tools\"]\r\n<tools> " +
                                                    "\r\n<techs>\r\n[/spoiler]\r\n\r\n";

        /// <summary>
        /// Contains hints for all template tags
        /// </summary>
        public const string TemplateHints = "Filters input into the field on the left will be replaced with all items that pass the filter check for each filter" +
                                            " upon output generation.\r\nSome filters require an argument list for operation and customization.\r\n" +
                                            "Filters can be combined with the | operator. For example: <sabers|PD(>=, 5)> will print all sabers greater than or" +
                                            " equal to 5 PD in value.\r\n" + 
                                            "Additionally, a filter can be inverted with the ! operator. For example: <!weapons> would print everything that is " +
                                            "not a weapon.\r\n\r\n" +
                                            "General:\r\n" +
                                            "    <all> = prints all items\r\n" +
                                            "    <weapons> = prints all weapons\r\n" +
                                            "    <frames> prints all frames/armor\r\n" +
                                            "    <barriers> prints all barriers/shields\r\n" +
                                            "    <defense> = prints all frames/armor and barriers/shields\r\n" +
                                            "    <units> = prints all units\r\n" +
                                            "    <mags> = prints all mags\r\n" +
                                            "    <techs> = prints all techs\r\n" +
                                            "    <tools> = prints all tools\r\n" +
                                            "    <item(name)> = prints a specific item\r\n" +
                                            "           args:\r\n" +
                                            "               name - The name of the item to print\r\n" +
                                            "           example: <item(Red Sword)> prints all items with the name Red Sword\r\n" +
                                            "    <PD(value, comparison)> = prints all items of a specific PD value\r\n" +
                                            "           args:\r\n" +
                                            "               value - The value to compare to\r\n" +
                                            "               comparison (optional) - The comparison to make(>, >=, <, <=, or =, = by default)\r\n" +
                                            "           example: <PD(=,5)> prints all items equal to 5 PD in value\r\n" +
                                            "   <star(value, comparison)> = prints all items of a specified rarity\r\n" +
                                            "           args:\r\n" +
                                            "               value - The value to compare to\r\n" +
                                            "               comparison (optional) - The comparison to make(>, >=, <, <=, or =, = by default)\r\n" +
                                            "           example: <star(9,>)> prints all items greater than 9 stars in rarity\r\n" +
                                            "\r\n" +
                                            "Weapon Specific:\r\n" +
                                            "    <sabers> = prints all sabers\r\n" +
                                            "    <swords> = prints all swords\r\n" +
                                            "    <daggers> = prints all daggers\r\n" +
                                            "    <partisans> = prints all partisans\r\n" +
                                            "    <slicers> = prints all slicers\r\n" +
                                            "    <double sabers> = prints all double sabers\r\n" +
                                            "    <claws> = prints all claws\r\n" +
                                            "    <katanas> = prints all katanas\r\n" +
                                            "    <twin swords> = prints all twin swords\r\n" +
                                            "    <fists> = prints all fists\r\n" +
                                            "    <handguns> = prints all handguns\r\n" +
                                            "    <rifles> = prints all rifles\r\n" +
                                            "    <mechguns> = prints all katanas\r\n" +
                                            "    <shots> = prints all shots\r\n" +
                                            "    <launchers> = prints all launchers\r\n" +
                                            "    <canes> = prints all canes\r\n" +
                                            "    <rods> = prints all rods\r\n" +
                                            "    <wands> = prints all wands\r\n" +
                                            "    <cards> = prints all cards\r\n" +
                                            "    <Native(value, comparison)> = prints all weapons with a specific native percentage\r\n" +
                                            "           args:\r\n" +
                                            "               value - The value to compare to\r\n" +
                                            "               comparison (optional) - The comparison to make(>, >=, <, <=, or =, = by default)\r\n" +
                                            "           example: <Native(60,>)> prints all weapons with 60% native or higher\r\n" +
                                            "    <ABeast(value, comparison)> = prints all weapons with a specific ABeast percentage\r\n" +
                                            "           args:\r\n" +
                                            "               value - The value to compare to\r\n" +
                                            "               comparison (optional) - The comparison to make(>, >=, <, <=, or =, = by default)\r\n" +
                                            "           example: <ABeast(60,>)> prints all weapons with 60% ABeast or higher\r\n" +
                                            "    <Machine(value, comparison)> = prints all weapons with a specific machine percentage\r\n" +
                                            "           args:\r\n" +
                                            "               value - The value to compare to\r\n" +
                                            "               comparison (optional) - The comparison to make(>, >=, <, <=, or =, = by default)\r\n" +
                                            "           example: <Machine(60,>)> prints all weapons with 60% machine or higher\r\n" +
                                            "    <Dark(value, comparison)> = prints all weapons with a specific dark percentage\r\n" +
                                            "           args:\r\n" +
                                            "               value - The value to compare to\r\n" +
                                            "               comparison (optional) - The comparison to make(>, >=, <, <=, or =, = by default)\r\n" +
                                            "           example: <Dark(60,>)> prints all weapons with 60% dark or higher\r\n" +
                                            "    <Hit(value, comparison)> = prints all weapons with a specific hit percentage\r\n" +
                                            "           args:\r\n" +
                                            "               value - The value to compare to\r\n" +
                                            "               comparison (optional) - The comparison to make(>, >=, <, <=, or =, = by default)\r\n" +
                                            "           example: <Hit(60,>)> prints all weapons with 60% hit or higher\r\n";

        /// <summary>
        /// A map of all filters used for templates and their assocated tags
        /// </summary>
        private Dictionary<string, Func<Item, string[], bool>> _templateFilters = new Dictionary<string, Func<Item, string[], bool>>
        { 
            { "all", (Item item, string[] args) => { return true; } },
            { "weapons", (Item item, string[] args) => { return item.Type == ItemType.Weapon; } },
            { "frames", (Item item, string[] args) => { return item.Type == ItemType.Frame; } },
            { "barriers", (Item item, string[] args) => { return item.Type == ItemType.Barrier; } },
            { "defense", (Item item, string[] args) => { return (item.Type == ItemType.Frame) || (item.Type == ItemType.Barrier); } },
            { "units", (Item item, string[] args) => { return item.Type == ItemType.Unit; } },
            { "mags", (Item item, string[] args) => { return item.Type == ItemType.Mag; } },
            { "techs", (Item item, string[] args) => { return item.Type == ItemType.Technique; } },
            { "tools", (Item item, string[] args) => { return item.Type == ItemType.Tool; } },
            { "sabers", (Item item, string[] args) => 
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Saber;
                                            }
                                            return false; 
                                        } },
            { "swords", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Sword;
                                            }
                                            return false;
                                        } },
            { "daggers", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Dagger;
                                            }
                                            return false;
                                        } },
            { "partisans", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Partisan;
                                            }
                                            return false;
                                        } },
            { "slicers", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Slicer;
                                            }
                                            return false;
                                        } },
            { "double sabers", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.DoubleSaber;
                                            }
                                            return false;
                                        } },
            { "claws", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Claw;
                                            }
                                            return false;
                                        } },
            { "katanas", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Katana;
                                            }
                                            return false;
                                        } },
            { "twin swords", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.TwinSword;
                                            }
                                            return false;
                                        } },
            { "fists", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Fist;
                                            }
                                            return false;
                                        } },
            { "handguns", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Handgun;
                                            }
                                            return false;
                                        } },
            { "rifles", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Rifle;
                                            }
                                            return false;
                                        } },
            { "mechguns", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Mechgun;
                                            }
                                            return false;
                                        } },
            { "shots", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Shot;
                                            }
                                            return false;
                                        } },
            { "launchers", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Launcher;
                                            }
                                            return false;
                                        } },
            { "canes", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Cane;
                                            }
                                            return false;
                                        } },
            { "rods", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Rod;
                                            }
                                            return false;
                                        } },
            { "wands", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Wand;
                                            }
                                            return false;
                                        } },
            { "cards", (Item item, string[] args) =>
                                        {
                                            if (item is Weapon weapon)
                                            {
                                                return weapon.WeaponType == WeaponType.Card;
                                            }
                                            return false;
                                        } },
            { "pd", (Item item, string[] args) =>
                                        {
                                            if(!double.TryParse(item.PricePDs, out double price))
                                            {
                                                return false;
                                            }

                                            return compareArgsDouble(price, args);
                                        } },
            { "star", (Item item, string[] args) => { return compareArgsInt(item.Rarity, args); } },
            { "native", (Item item, string[] args) => 
                                        { 
                                            if (!(item is Weapon))
                                            {
                                                return false;
                                            }

                                            return compareArgsInt((item as Weapon).NativePercentage, args); 
                                        } },
            { "abeast", (Item item, string[] args) =>
                                        {
                                            if (!(item is Weapon))
                                            {
                                                return false;
                                            }

                                            return compareArgsInt((item as Weapon).ABeastPercentage, args);
                                        } },
            { "machine", (Item item, string[] args) =>
                                        {
                                            if (!(item is Weapon))
                                            {
                                                return false;
                                            }

                                            return compareArgsInt((item as Weapon).MachinePercentage, args);
                                        } },
            { "dark", (Item item, string[] args) =>
                                        {
                                            if (!(item is Weapon))
                                            {
                                                return false;
                                            }

                                            return compareArgsInt((item as Weapon).DarkPercentage, args);
                                        } },
            { "hit", (Item item, string[] args) =>
                                        {
                                            if (!(item is Weapon))
                                            {
                                                return false;
                                            }

                                            return compareArgsInt((item as Weapon).HitPercentage, args);
                                        } },
            { "item", (Item item, string[] args) =>
                                        {
                                            if (args.Length < 1)
                                            {
                                                return false;
                                            }

                                            if (item.Name.ToLower() != args[0].Trim().ToLower())
                                            {
                                                return false;
                                            }

                                            return ItemDatabase.Instance.FindItem(args[0], args[0]) != null;
                                        } },
        };

        // NOTE: Cannot use generic function here due to needing a specific parse type
        /// <summary>
        /// A generic version for the comparison lambdas to use.
        /// </summary>
        /// <param name="value">The value to compare against</param>
        /// <param name="args">The args to use for comparison</param>
        /// <returns>True if the comparsion filter succeeds</returns>
        private static bool compareArgsInt(int value, string[] args)
        {
            if (args.Length < 1)
            {
                return false;
            }

            if (!int.TryParse(args[0], out int argsValue))
            {
                return false;
            }

            string comparison = string.Empty;
            if (args.Length > 1)
            {
                comparison = args[1].Trim();
            }

            if (((args.Length < 2) && (value == argsValue)) ||
                ((comparison == ">") && (value == argsValue)) ||
                ((comparison == ">=") && (value >= argsValue)) ||
                ((comparison == "<") && (value < argsValue)) ||
                ((comparison == "<=") && (value <= argsValue)) ||
                ((comparison == "=") && (value == argsValue)))
            {
                return true;
            }

            return false;
        }

        // NOTE: Cannot use generic function here due to needing a specific parse type
        /// <summary>
        /// A generic version for the comparison lambdas to use.
        /// </summary>
        /// <param name="value">The value to compare against</param>
        /// <param name="args">The args to use for comparison</param>
        /// <returns>True if the comparsion filter succeeds</returns>
        private static bool compareArgsDouble(double value, string[] args)
        {
            if (args.Length < 1)
            {
                return false;
            }

            if (!double.TryParse(args[0], out double argsValue))
            {
                return false;
            }

            string comparison = string.Empty;
            if (args.Length > 1)
            {
                comparison = args[1].Trim();
            }

            if (((args.Length < 2) && (value == argsValue)) ||
                ((comparison == ">") && (value == argsValue)) ||
                ((comparison == ">=") && (value >= argsValue)) ||
                ((comparison == "<") && (value < argsValue)) ||
                ((comparison == "<=") && (value <= argsValue)) ||
                ((comparison == "=") && (value == argsValue)))
            {
                return true;
            }

            return false;
        }
    }
}

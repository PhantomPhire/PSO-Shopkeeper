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
                    nextClosePar = input.IndexOf(')', start);
                }

                return input.Substring(location, end - location + 1);
            }

            return string.Empty;
        }

        /// <summary>
        /// Separates a tag int a list of FilterPairs
        /// </summary>
        /// <param name="input">The input to separate</param>
        /// <returns>The resulting list of filters</returns>
        public List<FilterPair> SeparateTag(string input)
        {
            if (input.Length < 2)
            {
                return null;
            }

            List<FilterPair> list = new List<FilterPair>();

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
            
            if (!_templateFilters.ContainsKey(filterName))
            {
                return null;
            }

            return new FilterPair(_templateFilters[filterName], args);
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
            public FilterPair(Func<Item, string[], bool> filter, string[] args)
            {
                _filter = filter;
                _args = args;
            }

            /// <summary>
            /// Invokes the filter
            /// </summary>
            /// <param name="item">The item to determine the filter for</param>
            /// <returns>True if the item passes the filter</returns>
            public bool Invoke(Item item)
            {
                return _filter(item, _args);
            }

            private Func<Item, string[], bool> _filter;
            private string[] _args;
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
        public const string TemplateHints = "General:\n" +
                                            "    <all> = prints all items\n" +
                                            "    <weapons> = prints all weapons\n" +
                                            "    <frames> prints all frames/armor\n" +
                                            "    <barriers> prints all barriers/shields\n" +
                                            "    <defense> = prints all frames/armor and barriers/shields\n" +
                                            "    <units> = prints all units\n" +
                                            "    <mags> = prints all mags\n" +
                                            "    <techs> = prints all techs\n" +
                                            "    <tools> = prints all tools\n" +
                                            "\n" +
                                            "Weapon Specific:\n" +
                                            "    <sabers> = prints all sabers\n" +
                                            "    <swords> = prints all swords\n" +
                                            "    <daggers> = prints all daggers\n" +
                                            "    <partisans> = prints all partisans\n" +
                                            "    <slicers> = prints all slicers\n" +
                                            "    <double sabers> = prints all double sabers\n" +
                                            "    <claws> = prints all claws\n" +
                                            "    <katanas> = prints all katanas\n" +
                                            "    <twin swords> = prints all twin swords\n" +
                                            "    <fists> = prints all fists\n" +
                                            "    <handguns> = prints all handguns\n" +
                                            "    <rifles> = prints all rifles\n" +
                                            "    <mechguns> = prints all katanas\n" +
                                            "    <shots> = prints all shots\n" +
                                            "    <launchers> = prints all launchers\n" +
                                            "    <canes> = prints all canes\n" +
                                            "    <rods> = prints all rods\n" +
                                            "    <wands> = prints all wands\n" +
                                            "    <cards> = prints all cards\n";

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
            { "PD", (Item item, string[] args) =>
                                        {
                                            if (args.Length < 2)
                                            {
                                                return false;
                                            }

                                            if (!double.TryParse(args[1], out double value)|| 
                                                !double.TryParse(item.PricePDs, out double price))
                                            {
                                                return false;
                                            }

                                            if (((args[0] == ">") && (price > value)) ||
                                                ((args[0] == ">=") && (price >= value)) ||
                                                ((args[0] == "<") && (price < value)) ||
                                                ((args[0] == "<=") && (price <= value)) ||
                                                ((args[0] == "=") && (price == value)))
                                            {
                                                return true;
                                            }

                                            return false;
                                        } },
        };
    }
}

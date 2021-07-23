using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PSOShopkeeperLib.Item;
using PSOShopkeeper.ItemFilters;

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
            // Construct template hints
            foreach (ItemFilterCategory category in ItemFilterManager.Instance.Categories)
            {
                _templateHints += "\r\n\r\n  " + category.Caption;
                foreach (IItemFilter filter in category.Filters)
                {
                    _templateHints += "\r\n    <" + filter.Name + "> " + filter.Description;
                    if (filter.Args != null)
                    {
                        _templateHints += "\r\n      Args:";
                        foreach (IItemFilterArg arg in filter.Args)
                        {
                            _templateHints += "\r\n        " + arg;
                        }
                    }

                    if ((filter.Example != null) && (filter.Example != string.Empty))
                    {
                        _templateHints += "\r\n      Example Usage: " + filter.Example;
                    }
                }
            }

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
        /// Indicates the default template to write if there isn't one
        /// </summary>
        private const string defeaultTemplate = "[spoiler=\"Weapons\"]\r\n<weapons>\r\n[/spoiler]\r\n\r\n[spoiler=\"Armor and Units\"]" +
                                                    "\r\n<frames>\r\n<barriers>\r\n<units>\r\n[/spoiler]\r\n\r\n[spoiler=\"Tools\"]\r\n<tools> " +
                                                    "\r\n<techs>\r\n[/spoiler]\r\n\r\n";

        /// <summary>
        /// Gets a string containing hints for all template tags
        /// </summary>
        public static string TemplateHints { get { return _templateHints; } }

        /// <summary>
        /// Contains hints for all template tags
        /// </summary>
        private static string _templateHints = "Filters input into the field on the left will be replaced with all items that pass the filter check for each filter" +
                                               " upon output generation.\r\nSome filters require an argument list for operation and customization.\r\n" +
                                               "Filters can be combined with the | operator. For example: <sabers|PD(>=, 5)> will print all sabers greater than or" +
                                               " equal to 5 PD in value.\r\n" + 
                                               "Additionally, a filter can be inverted with the ! operator. For example: <!weapons> would print everything that is " +
                                               "not a weapon.\r\n\r\n" +
                                               "Please use the filter construction tool in the next tab to aid with filter creation!\r\n\r\n" +
                                               "The following categories and filters are available:";
    }
}

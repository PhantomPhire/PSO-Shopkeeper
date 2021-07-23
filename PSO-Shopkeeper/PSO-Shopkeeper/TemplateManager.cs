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
        private static string _templateHints = "ON FILTERS\r\n\r\nFilters input into the field on the left will be replaced with all items that pass the filter check for each filter" +
                                               " upon output generation.\r\nSome filters require an argument list for operation and customization.\r\n" +
                                               "Filters can be combined with the | operator. For example: <sabers|PD(>=, 5)> will print all sabers greater than or" +
                                               " equal to 5 PD in value.\r\n" + 
                                               "Additionally, a filter can be inverted with the ! operator. For example: <!weapons> would print everything that is " +
                                               "not a weapon.\r\nAs a complex example, <sabers|Hit(50,>=)|!ABeast(0,>)> would allow only sabers with at least 50% Hit and no A. Beast to" +
                                               " be printed.\r\n\r\n" +
                                               "FILTER CONSTRUCTION TOOL\r\n\r\n" +
                                               "There's two types of filter buttons under \"Available Filters\", filters that require arguments to work, and those that do not. For the" + 
                                               "latter, if you click them, the filter will be added and the button will turn green and add the filter to \"Applied Filters\". Clicking it " +
                                               "again will turn the button red and invert the filter added. Clicking it a third time will reset the button and remove the filter (the filter " +
                                               "can also be removed by press it under \"Applied Filters\".\r\n\r\n" +
                                               "For filters that require arguments, there's an extra step. Once pressing the button, a pop-up will show allowing you to populate the arguments. " +
                                               "If the arguments you enter are invalid, the text box will turn red. Pressing \"Ok\" once you've added valid arguments will add the filter to " +
                                               "\"Applied Filters\". The button will not change colors for this however, since argument filters can be applied multiple times(in different " +
                                               "permutations). Similar to the non-argument filters, clicking the filter under \"Applied Filters\" will remove the filter from the display above." +
                                               "\r\n\r\nThe following categories and filters are available:";
    }
}

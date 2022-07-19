using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;
using PSOShopkeeperLib;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper
{
    /// <summary>
    /// A singleton class used to store the state of the item shop
    /// </summary>
    class ItemShop
    {
        /// <summary>
        /// Initializes a new instance of the ItemShop class
        /// </summary>
        private ItemShop()
        {
            readInSettings();
        }

        /// <summary>
        /// The current item list for the shop
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// The current item list for the shop with duplicates collapsed into the list
        /// </summary>
        private List<Item> _itemsDuplicatesCollapsed = new List<Item>();

        /// <summary>
        /// The list of items created for the purpose of collapsing duplicates
        /// </summary>
        private List<Item> _duplicateItems = new List<Item>();

        /// <summary>
        /// The map of all unique items
        /// </summary>
        private Dictionary<string, Item> _itemMap = new Dictionary<string, Item>();

        /// <summary>
        /// The map of all duplicate items
        /// </summary>
        private Dictionary<string, Item> _duplicateItemMap = new Dictionary<string, Item>();

        /// <summary>
        /// Gets the list of items in the shop
        /// </summary>
        public IEnumerable<Item> Items
        {
            get
            {
                return _itemsDuplicatesCollapsed;
            }
        }

        /// <summary>
        /// Delegate to be fired when database  is updated
        /// </summary>
        public Action Updated { get; set; }

        /// <summary>
        /// Reads in and parses a text file of item listings. Input is intended to be output of an item reader save
        /// </summary>
        /// <param name="filePath">The path to the item file</param>
        public void ReadInItemFile(string filePath)
        {
            string fileText = File.ReadAllText(filePath);
            string[] itemList = fileText.Split('\n');

            foreach (string itemText in itemList)
            {
                if (itemText == String.Empty)
                {
                    continue;
                }

                Item item = null;

                try
                {
                    item = ItemParsing.ParseItem(itemText);
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                    {
                        item = new UnknownItem("A format exception occurred when parsing this item: \n" + ex.Message);
                    }
                    else
                    {
                        item = new UnknownItem("An exception occurred when parsing this item: \n" + ex.Message);
                        item.ItemReaderText = itemText;
                    }
                }

                if (item != null)
                {
                    addItemToLists(item);
                }
            }

            ApplyPrices();
            Updated?.Invoke();
        }

        /// <summary>
        /// Adds item to applicable lists
        /// </summary>
        private void addItemToLists(Item item)
        {
            _items.Add(item);

            if (!_itemMap.ContainsKey(item.ItemReaderText))
            {
                _itemMap.Add(item.ItemReaderText, item);
                _itemsDuplicatesCollapsed.Add(item);
            }
            else
            {
                if (_duplicateItemMap.ContainsKey(item.ItemReaderText))
                {
                    _duplicateItemMap[item.ItemReaderText].Quantity += item.Quantity;
                }
                else
                {
                    Item itemToCopy = _itemMap[item.ItemReaderText];
                    Item duplicateItem = itemToCopy.Copy();
                    duplicateItem.Quantity = itemToCopy.Quantity + item.Quantity;
                    _duplicateItems.Add(duplicateItem);
                    _duplicateItemMap.Add(duplicateItem.ItemReaderText, duplicateItem);

                    if (_itemsDuplicatesCollapsed.Contains(itemToCopy))
                    {
                        _itemsDuplicatesCollapsed.Remove(itemToCopy);
                    }
                    _itemsDuplicatesCollapsed.Add(duplicateItem);
                }
            }
        }

        /// <summary>
        /// Sorts all items by hex
        /// </summary>
        public void SortItemsByHex()
        {
            _items.Sort(compareItems);
            _itemsDuplicatesCollapsed.Sort(compareItems);
            _duplicateItems.Sort(compareItems);
        }

        /// <summary>
        /// Clears all current item entries
        /// </summary>
        public void ClearItems()
        {
            _items.Clear();
            _itemsDuplicatesCollapsed.Clear();
            _duplicateItems.Clear();
            _duplicateItemMap.Clear();
            _itemMap.Clear();
            Updated?.Invoke();
        }

        /// <summary>
        /// Applies prices for all items
        /// </summary>
        public void ApplyPrices()
        {
            foreach (Item item in _items)
            {
                PricingManager.Instance.ApplyPricing(item);
            }
            foreach (Item item in _duplicateItems)
            {
                PricingManager.Instance.ApplyPricing(item);
            }
            PricingManager.Instance.Save();
        }

        /// <summary>
        /// Updates prices for all items
        /// </summary>
        public void UpdatePrices()
        {
            foreach (Item item in _items)
            {
                PricingManager.Instance.UpdatePricing(item);
            }
            foreach (Item item in _duplicateItems)
            {
                PricingManager.Instance.UpdatePricing(item);
            }
            PricingManager.Instance.Save();
        }

        /// <summary>
        /// Resolves an unknown item and removes it from the lists gracefull
        /// </summary>
        /// <param name="itemToResolve">The item to resolve</param>
        /// <param name="resolution">The resolution to the unknown item</param>
        public void ResolveUnknownItem(UnknownItem itemToResolve, Item resolution)
        {
            if (itemToResolve.ItemReaderText != resolution.ItemReaderText)
            {
                throw new Exception("Trying to resolve unknown item with unrelated item!");
            }

            Predicate<Item> filter = (Item item) =>
            {
                if ((item is UnknownItem) && (item.ItemReaderText == itemToResolve.ItemReaderText))
                {
                    return true;
                }

                return false;
            };

            _items.RemoveAll(filter);
            _duplicateItems.RemoveAll(filter);
            _itemsDuplicatesCollapsed.RemoveAll(filter);
            _itemMap.Remove(itemToResolve.ItemReaderText);
            _duplicateItemMap.Remove(itemToResolve.ItemReaderText);

            resolution.Quantity = itemToResolve.Quantity;
            addItemToLists(resolution);
        }

        /// <summary>
        /// Gets the sum of all item prices, in PDs
        /// </summary>
        /// <returns>The sum of all item prices, in PDs</returns>
        public double CalculateSum()
        {
            double sum = 0.0;
            foreach (Item item in _items)
            {
                double result = 0.0;
                bool succeeded = double.TryParse(item.PricePDs, out result);
                if (succeeded)
                {
                    sum += result;
                }
            }

            return sum;
        }

        /// <summary>
        /// Autofills the meseta field for each item type
        /// </summary>
        public void AutoFillMeseta()
        {
            foreach (Item item in _items)
            {
                autofillItemMeseta(item);
            }
            foreach (Item item in _duplicateItems)
            {
                autofillItemMeseta(item);
            }

            Updated?.Invoke();
            UpdatePrices();
        }

        /// <summary>
        /// Autofills a single item's meseta field
        /// </summary>
        /// <param name="item">The item to autofill for</param>
        private void autofillItemMeseta(Item item)
        {
            //item.PriceMeseta = string.Empty;

            if (double.TryParse(item.PricePDs, out double pricePD) && (pricePD < MaxPDsForAutofill))
            {
                int priceMeseta = (int)(pricePD * MesetaPerPD);
                item.PriceMeseta = priceMeseta.ToString();

                if (AbbreviateMesetaAutofill && (priceMeseta >= 1000))
                {
                    item.PriceMeseta = item.PriceMeseta.Substring(0, item.PriceMeseta.Length - 3) + "k";
                }
            }
        }

        /// <summary>
        /// Compares two items 
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison</param>
        /// <param name="rhs">The right hand side of the comparison</param>
        /// <returns></returns>
        private int compareItems(Item lhs, Item rhs)
        {
            return lhs.CompareTo(rhs);
        }

        /// <summary>
        /// The ItemShop instance
        /// </summary>
        private static ItemShop _instance = null;

        /// <summary>
        /// The singleton instance of the ItemShop
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static ItemShop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ItemShop();
                }

                return _instance;
            }
        }

        #region settings

        /// <summary>
        /// Indicates the settings path
        /// </summary>
        private const string settingsPathSuffix = "\\PSO_Shopkeeper\\settings.json";

        /// <summary>
        /// Gets the full settings path
        /// </summary>
        private string settingsPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + settingsPathSuffix;
            }
        }

        /// <summary>
        /// Locks settings write out
        /// </summary>
        private bool _settingsLock = false;

        /// <summary>
        /// Reads in settings file
        /// </summary>
        private void readInSettings()
        { 
            if (File.Exists(settingsPath))
            {
                try
                {
                    _settingsLock = true;
                    Settings settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsPath));
                    BoldPrice = settings.BoldPrice;
                    MultiPrice = settings.MultiPrice;
                    ColorizeSpecials = settings.ColorizeSpecials;
                    ColorizeHit = settings.ColorizeHit;
                    ColorizedPercentages = settings.ColorizePercentages;
                    ColorizationSettings = settings.ColorizationSettings;
                    MaxPDsForAutofill = settings.MaxPDsForAutofill;
                    MesetaPerPD = settings.MesetaPerPD;
                    AbbreviateMesetaAutofill = settings.AbbreviateMesetaAutofill;
                    UntekkLabel = settings.UntekkLabel;
                    _settingsLock = false;

                    // Check potentially null stuff here
                    if (!ColorManager.Instance.CheckColorizationSettings())
                    {
                        writeOutSettings();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to read in settings file");
                }
            }
            else
            {
                writeOutSettings();
            }
        }

        /// <summary>
        /// Saves the current settings
        /// </summary>
        public void SaveSettings()
        {
            writeOutSettings();
        }

        /// <summary>
        /// Writes out settings file
        /// </summary>
        private void writeOutSettings()
        {
            if (_settingsLock)
            {
                return;
            }

            Settings settings = new Settings();
            settings.BoldPrice = BoldPrice;
            settings.MultiPrice = MultiPrice;
            settings.ColorizeSpecials = ColorizeSpecials;
            settings.ColorizeHit = ColorizeHit;
            settings.ColorizePercentages = ColorizedPercentages;
            settings.ColorizationSettings = ColorizationSettings;
            settings.MaxPDsForAutofill = MaxPDsForAutofill;
            settings.MesetaPerPD = MesetaPerPD;
            settings.AbbreviateMesetaAutofill = AbbreviateMesetaAutofill;
            settings.UntekkLabel = UntekkLabel;
            File.WriteAllText(settingsPath, JsonConvert.SerializeObject(settings));
        }

        /// <summary>
        /// A setting indicating if the price should be bolded
        /// </summary>
        public bool BoldPrice
        {
            get { return Item.BoldPrice; }
            set
            {
                Item.BoldPrice = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// A setting indicating if multiple prices should be printed if available
        /// </summary>
        public bool MultiPrice
        {
            get { return Item.MultiPrice; }
            set
            {
                Item.MultiPrice = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// A setting indicating if weapon specials should be colorized
        /// </summary>
        public bool ColorizeSpecials
        {
            get { return Item.ColorizeSpecials; }
            set
            {
                Item.ColorizeSpecials = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// A setting indicating if weapon hit should be colorized
        /// </summary>
        public bool ColorizeHit
        {
            get { return Item.ColorizeHit; }
            set
            {
                Item.ColorizeHit = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// A setting indicating if weapon percentage should be colorized
        /// </summary>
        public bool ColorizedPercentages
        {
            get { return Item.ColorizePercentages; }
            set
            {
                Item.ColorizePercentages = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// The settings on how to colorize items
        /// </summary>
        public List<Color> ColorizationSettings
        {
            get { return ColorManager.Instance.ColorizationSettings; }
            set
            {
                ColorManager.Instance.ColorizationSettings = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// A setting determining the untekk label of items
        /// </summary>
        public string UntekkLabel
        {
            get { return Item.UntekkLabel; }
            set
            {
                Item.UntekkLabel = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// The backing field for a determining the maximum amount of PDs to autofill the meseta box on
        /// </summary>
        private double _maxPDsForAutofill = 1.0;

        /// <summary>
        /// A setting determining the maximum amount of PDs to autofill the meseta box on
        /// </summary>
        public double MaxPDsForAutofill 
        {
            get { return _maxPDsForAutofill; }
            set
            {
                _maxPDsForAutofill = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// The backing field for a setting determining the amount of meseta for a single PD
        /// </summary>
        private int _mesetaPerPD = 500000;

        /// <summary>
        /// A setting determining the amount of meseta for a single PD
        /// </summary>
        public int MesetaPerPD
        {
            get { return _mesetaPerPD; }
            set
            {
                _mesetaPerPD = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        /// <summary>
        /// The backing field for a setting indicating if meseta should be abbrivated with a k for thousands on autofill
        /// </summary>
        private bool _abbreviateMesetaAutofill = true;

        /// <summary>
        /// A setting indicating if meseta should be abbrivated with a k for thousands on autofill
        /// </summary>
        public bool AbbreviateMesetaAutofill
        {
            get { return _abbreviateMesetaAutofill; }
            set
            {
                _abbreviateMesetaAutofill = value;

                if (!_settingsLock)
                {
                    writeOutSettings();
                    Updated?.Invoke();
                }
            }
        }

        #endregion
    }
}

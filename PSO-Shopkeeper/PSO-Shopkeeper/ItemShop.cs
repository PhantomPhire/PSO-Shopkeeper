using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
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
                if (CombineItems)
                {
                    return _itemsDuplicatesCollapsed;
                }

                return _items;
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
                Item item = ItemParsing.ParseItem(itemText);

                if (item != null)
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
            }

            ApplyPrices();
            Updated();
        }

        /// <summary>
        /// Clears all current item entries
        /// </summary>
        public void ClearItems()
        {
            _items.Clear();
            _itemsDuplicatesCollapsed.Clear();
            _duplicateItems.Clear();
            _itemMap.Clear();
            Updated();
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
        /// Reads in settings file
        /// </summary>
        private void readInSettings()
        { 
            if (File.Exists(settingsPath))
            {
                try
                {
                    Settings settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsPath));
                    CombineItems = settings.CombineItems;
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
        /// Writes out settings file
        /// </summary>
        private void writeOutSettings()
        {
            Settings settings = new Settings();
            settings.CombineItems = CombineItems;
            File.WriteAllText(settingsPath, JsonConvert.SerializeObject(settings));
        }

        /// <summary>
        /// A setting forcing the combination of like items
        /// </summary>
        private bool _combineItems = true;

        /// <summary>
        /// A setting forcing the combination of like items
        /// </summary>
        public bool CombineItems 
        { 
            get { return _combineItems; }
            set
            {
                _combineItems = value;
                writeOutSettings();
                
                if (Updated != null)
                {
                    Updated();
                }
            }
        }

        #endregion
    }
}

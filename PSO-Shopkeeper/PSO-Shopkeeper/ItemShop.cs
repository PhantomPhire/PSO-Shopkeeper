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
    /// A singleton class used to store the state of the item shop
    /// </summary>
    class ItemShop
    {
        /// <summary>
        /// The current item list for the shop
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Gets the list of items in the shop
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
        }

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
                }
            }
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
    }
}

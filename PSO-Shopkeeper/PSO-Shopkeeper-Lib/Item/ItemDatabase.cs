using System;
using System.Collections.Generic;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// A singleton object that maintains a repository of items
    /// </summary>
    public class ItemDatabase
    {
        /// <summary>
        /// Signifies what category to search in
        /// </summary>
        public enum Category
        {
            Weapon,
            Armor,
            Barrier,
            Mag,
            Tech,
            Other,
            All
        }

        /// <summary>
        /// Signifies what key to search by
        /// </summary>
        public enum SearchType
        {
            ByName,
            ByHex
        }

        /// <summary>
        /// Encapsulates a single Item Dictary state, with multiple items per key
        /// </summary>
        // Treated like a struct
        private class ItemDictionary
        {
            public Dictionary<string, List<Item>> State = new Dictionary<string, List<Item>>();
        }

        /// <summary>
        /// Finds an item in the DB and returns a copy of it, to be used as a base
        /// </summary>
        /// <param name="key">The key to search by</param>
        /// <param name="category">The category of items to seach by</param>
        /// <param name="searchType">The key type to seach by</param>
        /// <returns>A copy of the item found</returns>
        public List<Item> FindItem(string key, Category category, SearchType searchType)
        {
            List<Item> items = new List<Item>();

            if (_database[category][searchType].State.ContainsKey(key))
            {
                foreach (Item item in _database[category][searchType].State[key])
                {
                    items.Add(item.Copy());
                }
            }

            if ((items.Count < 1) && (category != Category.All))
            {
                return FindItem(key, Category.All, searchType);
            }

            return items;
        }

        /// <summary>
        /// The database itself
        /// </summary>
        private Dictionary<Category, Dictionary<SearchType, ItemDictionary>> _database = new Dictionary<Category, Dictionary<SearchType, ItemDictionary>>();

        /// <summary>
        /// Initializes a new instance of the ItemDatabase class
        /// </summary>
        private ItemDatabase()
        {
            ItemDatabaseJSON.Instance.Updated += allocateDatabase;
            allocateDatabase();
        }

        /// <summary>
        /// Clears and allocates the item database based on JSON input
        /// </summary>
        private void allocateDatabase()
        {
            foreach (Category cat in (Category[])Enum.GetValues(typeof(Category)))
            {
                _database[cat] = new Dictionary<SearchType, ItemDictionary>();

                foreach (SearchType searchType in (SearchType[])Enum.GetValues(typeof(SearchType)))
                {
                    _database[cat][searchType] = new ItemDictionary();
                }
            }

            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                Item item = Item.MakeItemFromJSON(kvp.Value);

                if (item != null)
                {
                    Category cat = Category.Other;

                    if (item is Weapon)
                    {
                        cat = Category.Weapon;
                    }
                    else if (item is DefenseItem def)
                    {
                        if (def.Frame)
                        {
                            cat = Category.Armor;
                        }
                        else
                        {
                            cat = Category.Barrier;
                        }
                    }
                    else if (item is Mag)
                    {
                        cat = Category.Mag;
                    }
                    else if (item is Technique)
                    {
                        cat = Category.Tech;
                    }

                    string name = item.Name.Trim().ToLower();
                    string hex = item.Hex.ToString("X").PadLeft(6, '0');

                    if (!_database[cat][SearchType.ByName].State.ContainsKey(name))
                    {
                        _database[cat][SearchType.ByName].State[name] = new List<Item>();
                    }

                    _database[cat][SearchType.ByName].State[name].Add(item);

                    if (!_database[cat][SearchType.ByHex].State.ContainsKey(hex))
                    {
                        _database[cat][SearchType.ByHex].State[hex] = new List<Item>();
                    }

                    _database[cat][SearchType.ByHex].State[hex].Add(item);

                    if (!_database[Category.All][SearchType.ByName].State.ContainsKey(name))
                    {
                        _database[Category.All][SearchType.ByName].State[name] = new List<Item>();
                    }

                    _database[Category.All][SearchType.ByName].State[name].Add(item);

                    if (!_database[Category.All][SearchType.ByHex].State.ContainsKey(hex))
                    {
                        _database[Category.All][SearchType.ByHex].State[hex] = new List<Item>();
                    }

                    _database[Category.All][SearchType.ByHex].State[hex].Add(item);
                }
            }
        }

        private static ItemDatabase _instance = null;

        /// <summary>
        /// Gets the singleton instance of the item DB
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static ItemDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ItemDatabase();
                }

                return _instance;
            }
        }
    }
}

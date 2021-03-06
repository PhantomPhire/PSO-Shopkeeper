﻿using System.Collections.Generic;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// A singleton object that maintains a repository of items
    /// </summary>
    public class ItemDatabase
    {
        /// <summary>
        /// The name of the Dragon's Claw weapon, used in an exception case
        /// </summary>
        private const string dragonsClawName = "Dragon's Claw";

        /// <summary>
        /// The name of the Dragon's Claw tool, used in an exception case
        /// </summary>
        private const string dragonsClawToolName = "Dragon's Claw*";

        /// <summary>
        /// Finds an item in the DB and returns a copy of it, to be used as a base
        /// </summary>
        /// <param name="key">The key to search by</param>
        /// <param name="fullItemText" >The full text of the item, used to resolve conflictsy</param>
        /// <returns>A copy of the item found</returns>
        public Item FindItem(string key, string fullItemText)
        {
            // Parse out exception cases, where the names of two items match
            if (key == dragonsClawName)
            {
                if (!fullItemText.Contains("["))
                {
                    key = dragonsClawToolName;
                }
            }    

            if (_database.ContainsKey(key.Trim().ToLower()))
            {
                return _database[key.Trim().ToLower()].Copy();
            }

            return null;
        }

        /// <summary>
        /// The database itself
        /// </summary>
        private Dictionary<string, Item> _database = new Dictionary<string, Item>();

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
            _database.Clear();
            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                Item item = Item.MakeItemFromJSON(kvp.Value);

                if (item != null)
                {
                    _database.Add(item.Name.Trim().ToLower(), item);
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

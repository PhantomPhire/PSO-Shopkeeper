using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// A singleton object that maintains a repository of database items and automatically update upon adding
    /// </summary>
    public class ItemDatabaseJSON
    {
        private const string ItemDBFile = @"./itemDB.json";

        private Dictionary<string, ItemJSON> _database = new Dictionary<string, ItemJSON>();

        public ICollection<KeyValuePair<string, ItemJSON>> Database
        {
            get
            {
                return _database;
            }
        }

        /// <summary>
        /// Adds an item to the JSON database
        /// </summary>
        /// <param name="item">The item to add</param>
        public void AddItem(ItemJSON item)
        {
            if (!_database.ContainsKey(item.Name))
            {
                _database.Add(item.Name, item);
                writeOut();
            }
        }

        /// <summary>
        /// Replaces a single item
        /// </summary>
        /// <param name="item">The item to replace</param>
        public void ReplaceItem(ItemJSON item)
        {
            if (_database.ContainsKey(item.Name))
            {
                _database.Remove(item.Name);
                _database.Add(item.Name, item);
                writeOut();
            }
        }

        /// <summary>
        /// Removes a single item
        /// </summary>
        /// <param name="item">The item to replace</param>
        public void RemoveItem(ItemJSON item)
        {
            if (_database.ContainsKey(item.Name))
            {
                _database.Remove(item.Name);
                writeOut();
            }
        }

        private ItemDatabaseJSON()
        {
            readIn();
        }
        
        private void readIn()
        {
            if (!File.Exists(ItemDBFile))
            {
                return;
            }

            // read file into a string and deserialize JSON to a type
            _database = JsonConvert.DeserializeObject<Dictionary<string, ItemJSON>>(File.ReadAllText(ItemDBFile));
        }

        private void writeOut()
        {
            File.WriteAllText(ItemDBFile, JsonConvert.SerializeObject(_database));
        }

        private static ItemDatabaseJSON _instance = null;

        /// <summary>
        /// Gets the singleton instance of the item DB
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static ItemDatabaseJSON Instance 
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ItemDatabaseJSON();
                }

                return _instance;
            } 
        }
    }
}

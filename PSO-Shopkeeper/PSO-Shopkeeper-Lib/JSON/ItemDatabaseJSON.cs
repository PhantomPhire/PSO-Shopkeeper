using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace PSOShopkeeperLib.JSON
{
    /// <summary>
    /// A singleton object that maintains a repository of items (in their JSON form) and automatically update upon adding
    /// </summary>
    public class ItemDatabaseJSON
    {
        /// <summary>
        /// The location of the database JSON file
        /// </summary>
        private const string ItemDBFile = @"./itemDB.json";

        /// <summary>
        /// The database itself
        /// </summary>
        private Dictionary<string, ItemJSON> _database = new Dictionary<string, ItemJSON>();

        /// <summary>
        /// Gets an interface to the contained database
        /// </summary>
        public IEnumerable<KeyValuePair<string, ItemJSON>> Database
        {
            get
            {
                return _database;
            }
        }

        /// <summary>
        /// Delegate to be fired when database  is updated
        /// </summary>
        public Action Updated { get; set; }

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
                Updated();
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
                Updated();
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
                Updated();
            }
        }

        /// <summary>
        /// Initializes a new instance of the ItemDatabaseJSON class
        /// </summary>
        private ItemDatabaseJSON()
        {
            readIn();
        }

        /// <summary>
        /// Reads in the database
        /// </summary>
        private void readIn()
        {
            if (!File.Exists(ItemDBFile))
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Stream stream = assembly.GetManifestResourceStream("PSO_Shopkeeper_Lib.itemDB.json");
                StreamReader reader = new StreamReader(stream);
                _database = JsonConvert.DeserializeObject<Dictionary<string, ItemJSON>>(reader.ReadToEnd());
                return;
            }

            // read file into a string and deserialize JSON to a type
            _database = JsonConvert.DeserializeObject<Dictionary<string, ItemJSON>>(File.ReadAllText(ItemDBFile));
        }

        /// <summary>
        /// Writes out the database
        /// </summary>
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

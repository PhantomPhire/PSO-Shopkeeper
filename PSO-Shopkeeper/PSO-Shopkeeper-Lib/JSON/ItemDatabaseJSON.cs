using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using PSOShopkeeperLib.Item;

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
                _database.Add(item.Hex, item);
                writeOut();
                Updated?.Invoke();
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
                _database.Add(item.Hex, item);
                writeOut();
                Updated?.Invoke();
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
                Updated?.Invoke();
            }
        }

        /// <summary>
        /// Validates the database vs a list output by a specialialized addon
        /// </summary>
        /// <param name="validationItems">The items to validate against</param>
        /// <returns>A summary of changes made</returns>
        public void Validate(List<ItemJSON> validationItems)
        {
            foreach (var item in validationItems)
            {
                if ((item.Hex == "000000") || (item.Name == "????") || 
                    (item.Name.Trim() == "") || item.Name.Contains("Unused Weapon") ||
                    item.Name.Contains("Unused Item"))
                {
                    continue;
                }

                if (!_database.ContainsKey(item.Hex))
                {
                    bool itemFound = false;

                    // If it's a skinned item, then we'll find its basis
                    if (item.Name.Contains("*"))
                    {
                        string tempName = item.Name.Replace("*", "").Trim();
                        ItemJSON itemBase = null;
                        foreach (var kvp in _database)
                        {
                            if (kvp.Value.Name == tempName)
                            {
                                itemBase = kvp.Value.Copy();
                                break;
                            }
                        }

                        if (itemBase == null)
                        {
                            Console.WriteLine("Error: Could not find base item for skinned item " + item.Name);
                            continue;
                        }

                        Console.WriteLine("Found new skinned item! " + item.Name + " " + item.Hex + " Making new item...");
                        itemBase.Import(item);
                        _database.Add(itemBase.Hex, itemBase);
                        itemFound = true;
                    }
                    else if (item.Weapon != null && item.Weapon.SRank)
                    {
                        if (item.Hex.Substring(4, 2) == "00")
                        {
                            Console.WriteLine("Found new S-Rank base!" + item.Name + " " + item.Hex + " Making new item...");
                            _database.Add(item.Hex, item);
                        }
                        else
                        {
                            if (!_database.ContainsKey(item.Hex.Substring(0, 4) + "00"))
                            {
                                Console.WriteLine("Error: Could not find base item for S-Rank item " + item.Name + " with Hex " + item.Hex);
                                continue;
                            }

                            Console.WriteLine("Found new S-Rank! " + item.Name + " " + item.Hex + " Making new item...");
                            ItemJSON itemBase = _database[item.Hex.Substring(0, 4) + "00"].Copy();
                            itemBase.Import(item);
                            itemBase.Weapon.Special = Enum.GetName(typeof(SpecialType), Weapon.SRankSpecialMap[item.Hex.Substring(4, 2)]);
                            _database.Add(itemBase.Hex, itemBase);
                        }
                        itemFound = true;
                    }

                    if (!itemFound)
                    {
                        Console.WriteLine("Hex " + item.Hex + " for item " + item.Name + " not found in database! Making new item...");

                        if (item.Type == "Tool")
                        {
                            item.Tool = new ItemToolJSON();
                            item.Tool.Rare = true;
                        }
                        else if (item.Type == "Unit")
                        {
                            item.Unit = new ItemUnitJSON();
                        }
                        else if (item.Type == "Mag")
                        {
                            item.Mag = new ItemMagJSON();
                        }

                        _database.Add(item.Hex, item);
                    }
                }
                else
                {
                    _database[item.Hex].Import(item);
                }
            }

            writeOut();
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper
{
    /// <summary>
    /// A singleton class intended to to keep track of prices for different items
    /// </summary>
    class PricingManager
    {
        /// <summary>
        /// The location of the pricing JSON file
        /// </summary>
        private const string pricingFileSuffix = "\\PSO_Shopkeeper\\pricing.json";

        /// <summary>
        /// Gets the full p pricingath
        /// </summary>
        private string pricingFile
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + pricingFileSuffix;
            }
        }

        /// <summary>
        /// Initializes a new instance of the PricingManager class
        /// </summary>
        private PricingManager()
        {
            readIn();
        }

        /// <summary>
        /// The repository of prices
        /// </summary>
        private Dictionary<string, PricingJSON> _prices = new Dictionary<string, PricingJSON>();

        /// <summary>
        /// Checks the pricing listing and applies it to the item input
        /// </summary>
        /// <param name="item">The item to check the price for</param>
        public void ApplyPricing(Item item)
        {
            if (_prices.ContainsKey(item.PricingID))
            {
                PricingJSON json = _prices[item.PricingID];
                item.PricePDs = json.PricePDs;
                item.PriceMeseta = json.PriceMeseta;
                item.PriceCustom = json.PriceCustom;
                item.CustomCurrency = json.CustomCurrency;
                item.Notes = json.Notes;
            }
            else
            {
                PricingJSON json = new PricingJSON();
                json.Name = item.PricingID;
                json.PricePDs = item.PricePDs;
                json.PriceMeseta = item.PriceMeseta;
                json.PriceCustom = item.PriceCustom;
                json.CustomCurrency = item.CustomCurrency;
                json.Notes = item.Notes;
                _prices.Add(json.Name, json);
            }
        }

        /// <summary>
        /// Updates the pricing listing of an item
        /// </summary>
        /// <param name="item">The item to update the price for</param>
        public void UpdatePricing(Item item)
        {
            PricingJSON json = null;
            if (_prices.ContainsKey(item.PricingID))
            {
                json = _prices[item.PricingID];
            }
            else
            {
                json = new PricingJSON();
                json.Name = item.PricingID;
                _prices.Add(json.Name, json);
            }

            json.PricePDs = item.PricePDs;
            json.PriceMeseta = item.PriceMeseta;
            json.PriceCustom = item.PriceCustom;
            json.CustomCurrency = item.CustomCurrency;
            json.Notes = item.Notes;
        }

        /// <summary>
        /// Saves all current pricing data
        /// </summary>
        public void Save()
        {
            File.WriteAllText(pricingFile, JsonConvert.SerializeObject(_prices));
        }

        /// <summary>
        /// Reads in the pricing data
        /// </summary>
        private void readIn()
        {
            if (!File.Exists(pricingFile))
            {
                return;
            }

            // read file into a string and deserialize JSON to a type
            _prices = JsonConvert.DeserializeObject<Dictionary<string, PricingJSON>>(File.ReadAllText(pricingFile));

            // Do a simple check on if we need to upgrade
            if ((_prices.Count > 0) && !_prices.First().Value.Name.Contains(Item.PricingHexTag))
            {
                upgrade();
            }
        }

        /// <summary>
        /// Upgrades pricing database to be app agnostic
        /// </summary>
        private void upgrade()
        {
            Dictionary<string, PricingJSON> newDb = new Dictionary<string, PricingJSON>();

            foreach (KeyValuePair<string, PricingJSON> itemPrice in _prices)
            {
                Item item = null;

                try
                {
                    item = ItemParsing.ParseItem(itemPrice.Value.Name);
                }
                catch (Exception ex)
                {
                    item = new UnknownItem("An exception occurred when parsing this item: \n" + ex.Message);
                    item.ItemReaderText = itemPrice.Value.Name;
                }

                if ((item != null) && !newDb.ContainsKey(item.PricingID))
                {
                    PricingJSON json = new PricingJSON { Name = item.PricingID, 
                                                         CustomCurrency = itemPrice.Value.CustomCurrency,
                                                         Notes = itemPrice.Value.Notes,
                                                         PriceCustom = itemPrice.Value.PriceCustom,
                                                         PriceMeseta = itemPrice.Value.PriceMeseta,
                                                         PricePDs = itemPrice.Value.PricePDs };
                    newDb.Add(item.PricingID, json);
                }
            }

            _prices = newDb;
            Save();
        }

        /// <summary>
        /// The signleton instance of the class
        /// </summary>
        private static PricingManager _instance = null;

        /// <summary>
        /// Gets the singleton instance of the pricing manager
        /// Warning: This function uses lazy initialization and is not intended to be thread safe
        /// </summary>
        public static PricingManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PricingManager();
                }

                return _instance;
            }
        }
    }
}

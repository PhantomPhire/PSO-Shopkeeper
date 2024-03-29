﻿using System;
using System.Collections.Generic;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// Represents an Item that is unkown
    /// </summary>
    public class UnknownItem : Item
    {
        /// <summary>
        /// Initializes a new instance of the UnknownItem class
        /// </summary>
        public UnknownItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnknownItem class
        /// </summary>
        /// <param name="possibleItems">A list of possible items this item could be</param>
        public UnknownItem(List<Item> possibleItems)
        {
            _possibleItems = possibleItems;
        }

        /// <summary>
        /// Initializes a new instance of the UnknownItem class
        /// </summary>
        /// <param name="exceptionText">The exception that occurred while parsing the item</param>
        public UnknownItem(string exceptionText)
        {
            ExceptionText = exceptionText;
        }

        /// <summary>
        /// Inititializes a new instance of the Item class from a JSON specification
        /// </summary>
        /// <param name="json">The JSON specification to initialize from.</param>
        public UnknownItem(ItemJSON json)
        {
        }

        private List<Item> _possibleItems = null;

        /// <summary>
        /// Gets a list of items that this item possibly is
        /// </summary>
        public IEnumerable<Item> PossibleItems { get { return _possibleItems; } }

        /// <summary>
        /// Adds an item to the possible item list
        /// </summary>
        /// <param name="item">The item to add</param>
        void AddPossibleItem(Item item)
        {
            if (_possibleItems == null)
            {
                _possibleItems = new List<Item>();
            }

            _possibleItems.Add(item);
        }

        /// <summary>
        /// Contains potential exception text with parsing the item
        /// </summary>
        public string ExceptionText { get; private set; } = null;

        /// <summary>
        /// Copies the Item
        /// </summary>
        /// <returns>A copy of the item</returns>
        public override Item Copy()
        {
            UnknownItem item = new UnknownItem();
            copyAttributes(item);

            item.ExceptionText = ExceptionText;

            if (_possibleItems != null)
            {
                foreach (Item possibleItem in _possibleItems)
                {
                    item.AddPossibleItem(possibleItem.Copy());
                }
            }    

            return item;
        }

        /// <summary>
        /// Parses in applicable attributes of the item from item reader input
        /// </summary>
        /// <param name="input">The input to parse</param>
        public override void ParseAttributes(string input)
        {
            base.ParseAttributes(input);

            if (_possibleItems != null)
            {
                foreach (var possibleItem in _possibleItems)
                {
                    possibleItem.ParseAttributes(input);
                }    
            }
        }

        /// <summary>
        /// Prints the item report
        /// </summary>
        /// <returns>The item report</returns>
        public override string ItemReport()
        {
            if (ExceptionText == null)
            {
                return ItemReaderText;
            }
            else
            {
                return ItemReaderText + "\n\n" + ExceptionText;
            }
        }

        /// <summary>
        /// Pricing ID tag used for unknown item
        /// </summary>
        public const string PricingUnknownItemTag = "UNKNOWNITEM:";

        /// <summary>
        /// Constructs a pricing ID for the item
        /// </summary>
        /// <returns>Pricing ID string</returns>
        protected override string constructPricingID()
        {
            return base.constructPricingID() + "[" + PricingUnknownItemTag + ItemReaderText + "]";
        }
    }
}

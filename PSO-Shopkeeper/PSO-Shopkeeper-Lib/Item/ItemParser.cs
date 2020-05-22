using System;
using System.Collections.Generic;
using System.Linq;

namespace PSOShopkeeperLib.Item
{
    /// <summary>
    /// A utility class intended to handle parsing items from item reader output
    /// </summary>
    public static class ItemParsing
    {
        /// <summary>
        /// Parses a single item from item reader output
        /// </summary>
        /// <param name="input">The item text to parse from</param>
        /// <returns>The parsed item</returns>
        public static Item ParseItem(string input)
        {
            input = input.Trim();
            string remainder = input;
            Item item = null;

            if (input == string.Empty)
            {
                return null;
            }

            try
            {
                List<string> attributeSections = new List<string>();

                while (remainder.Contains('['))
                {
                    if (!remainder.Contains(']'))
                    {
                        throw new Exception("No matching end bracket.");
                    }

                    int start = remainder.IndexOf('[');
                    int end = remainder.IndexOf(']', start);
                    attributeSections.Add(remainder.Substring(start + 1, end - start - 1));
                    remainder = remainder.Remove(start, end - start + 1);
                }

                bool quantityFound = false;
                int grind = parseGrind(ref remainder);
                int quantity = parseQuantity(ref remainder, out quantityFound);
                string sRankName = parseSRankName(ref remainder);

                // What remains should be the name of the item
                remainder = remainder.Trim();
                item = ItemDatabase.Instance.FindItem(remainder, input);

                if (item == null)
                {
                    throw new Exception("Item not found!");
                }

                item.Quantity = quantity;
                item.ParseAttributes(attributeSections);

                if (item is Weapon weapon)
                {
                    weapon.Grind = grind;
                    weapon.SRankName = sRankName;
                }

                item.ItemReaderText = input;
                if (quantityFound)
                {
                    item.ItemReaderText = item.ItemReaderText.Replace("x" + quantity.ToString(), "").Trim();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.ToString());
                item = new UnknownItem();
                item.ItemReaderText = input;
            }

            return item;
        }

        /// <summary>
        /// Parses out the grind value from a string
        /// </summary>
        /// <param name="input">The input to parse</param>
        /// <returns>The grind of the item</returns>
        private static int parseGrind(ref string input)
        {
            int counter = 0;
            while (input.Substring(counter).Contains('+'))
            {
                counter = input.IndexOf('+', counter);

                if ((counter != 0) && 
                    char.IsWhiteSpace(input[counter - 1]) &&
                    (input.Length > counter + 1) &&
                    char.IsDigit(input[counter + 1]))
                {
                    string numberString = "";
                    int subCounter = counter + 1;

                    while ((input.Length > subCounter) &&
                           (char.IsDigit(input[subCounter]) || char.IsWhiteSpace(input[subCounter])))
                    {
                        if (char.IsWhiteSpace(input[subCounter]))
                        {
                            input = input.Remove(counter, subCounter - counter);
                            return int.Parse(numberString);
                        }

                        numberString += input[subCounter++];
                    }
                }

                counter++;
            }

            return 0;
        }

        /// <summary>
        /// Parses out the quantity value from a string
        /// </summary>
        /// <param name="input">The input to parse</param>
        /// <param name="quantityFound">Indicates that a quantity string has been found in the item.</param>
        /// <returns>The parsed quantity</returns>
        private static int parseQuantity(ref string input, out bool quantityFound)
        {
            int counter = 0;
            while (input.Substring(counter).Contains('x'))
            {
                counter = input.IndexOf('x', counter);

                if ((counter != 0) &&
                    char.IsWhiteSpace(input[counter - 1]) &&
                    (input.Length > counter + 1) &&
                    char.IsDigit(input[counter + 1]))
                {
                    string numberString = "";
                    int subCounter = counter + 1;

                    while ((input.Length > subCounter) &&
                           (char.IsDigit(input[subCounter]) || char.IsWhiteSpace(input[subCounter])))
                    {
                        if (char.IsWhiteSpace(input[subCounter]))
                        {
                            input = input.Remove(counter, subCounter - counter);
                            quantityFound = true;
                            return int.Parse(numberString);
                        }

                        numberString += input[subCounter++];
                    }

                    if (input.Length <= subCounter)
                    {
                        input = input.Remove(counter, subCounter - counter);
                        quantityFound = true;
                        return int.Parse(numberString);
                    }
                }

                counter++;
            }

            quantityFound = false;
            return 1;
        }
        
        /// <summary>
        /// Parses out the S-Rank name from a string
        /// </summary>
        /// <param name="input">The input to parse</param>
        /// <returns>The S-Rank string, if applicable</returns>
        private static string parseSRankName(ref string input)
        {
            if (input.ToUpper().Contains("S-RANK"))
            {
                input = input.Trim();
                string[] split = input.Split(' ');

                if (split.Length == 3)
                {
                    input = input.Replace(split[2], "");
                    return split[2];
                }
            }

            return string.Empty;
        }
    }
}

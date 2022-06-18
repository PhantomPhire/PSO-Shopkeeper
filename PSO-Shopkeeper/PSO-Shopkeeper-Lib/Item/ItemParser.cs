﻿using System;
using System.Text.RegularExpressions;
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
        /// Parses out bank slots
        /// </summary>
        public static Regex BankSlotFilter = new Regex(@", Slot:\s\b\w+\b\sBank");

        /// <summary>
        /// Parses out untek data
        /// </summary>
        public static Regex UntekFilter = new Regex(@"^((?:\[[U|\?]\])|(?:\?+))");

        /// <summary>
        /// Parses out quantity data
        /// </summary>
        public static Regex QuantityFilter = new Regex(@"x\d+\s*$");

        /// <summary>
        /// Parses out grind data
        /// </summary>
        public static Regex GrindFilter = new Regex(@"\+\d+");

        /// <summary>
        /// Parses out skin data
        /// </summary>
        public static Regex SkinFilter = new Regex(@"\s\-\s[\w|\s|'|/|*|\.|\""|&|\(|\)\-\:\+]+");

        /// <summary>
        /// Verifies item is a weapon by way of percents
        /// </summary>
        public static Regex WeaponFilter = new Regex(@"\[(\-?\d+)/(\-?\d+)/(\-?\d+)/(\-?\d+)\|(\-?\d+)\]");

        /// <summary>
        /// Verifies item is a armor by way of slots
        /// </summary>
        public static Regex ArmorFilter = new Regex(@"\[\dS\]");

        /// <summary>
        /// Verifies item is a barrier by way of slots
        /// </summary>
        public static Regex BarrierFilter = new Regex(@"\[\d+/\d+\s?\|\s?\d+/\d+\]");

        /// <summary>
        /// Verifies item as mag by way of mag stats
        /// </summary>
        public static Regex MagFilter = new Regex(@"\[\d+\.?\d*/\d+\.?\d*/\d+\.?\d*/\d+\.?\d*\]");

        /// <summary>
        /// Verifies item as tech by way of level
        /// </summary>
        public static Regex TechFilter = new Regex(@"^(\w+)\s+[L|l][V|v](\d+)\s?(?:Disk)?\s*$");

        /// <summary>
        /// Verifies S-Rank by way of S-rank string
        /// </summary>
        public static Regex S_RankFilter = new Regex(@"^S-RANK\s(?<name>[\w|\-]+)\s[\w|\-]+\s(?:\+\d+\s)?\[?(?<special>\w+\'?\w?)?\]?");

        /// <summary>
        /// Gets item name from beginning of string
        /// </summary>
        public static Regex ItemNameFilter = new Regex(@"^(?<name>[\w|\s|'|/|*|\.|\""|&|\(|\)\-\:\+]+)");

        /// <summary>
        /// Associates S-Rank weapon names with the first 4 characters in their hex ID
        /// </summary>
        public static readonly Dictionary<string, string> SRankNameIDAssociation = new Dictionary<string, string>
        {
            { "saber", "0070" }, { "sword", "0071" }, { "blade", "0072" }, { "partisan", "0073" }, { "slicer", "0074" },
            { "gun", "0075" }, { "rifle", "0076" }, { "mechgun", "0077" }, { "shot", "0078" }, { "cane", "0079" },
            { "rod", "007A" }, { "wand", "007B" }, { "twin", "007C" }, { "claw", "007D" }, { "bazooka", "007E" },
            { "needle", "007F" }, { "scythe", "0080" }, { "hammer", "0081" }, { "moon", "082" }, { "psychogun", "0083" },
            { "punch", "0084" }, { "windmill", "0085" }, { "harisen", "0086" }, { "katana", "0087" }, { "j-cutter", "0088" },
            { "swords", "00A5" }, { "launcher", "00A6" }, { "cards", "00A7" }, { "knuckle", "00A8" }, { "axe", "00A9" }
        };

        /// <summary>
        /// Parses a single item from item reader output
        /// </summary>
        /// <param name="baseInput">The item text to parse from</param>
        /// <returns>The parsed item</returns>
        public static Item ParseItem(string baseInput)
        {
            string input = BankSlotFilter.Replace(baseInput, "");
            string rawInput = input; 
            input = UntekFilter.Replace(input, "").Trim();
            string name = "";
            ItemDatabase.Category cat = ItemDatabase.Category.All;
            ItemDatabase.SearchType searchType = ItemDatabase.SearchType.ByName;

            // Absolutely no meseta
            if (input.ToLower().Contains("meseta"))
            {
                return null;
            }

            // Try as weapon
            if (WeaponFilter.IsMatch(input))
            {
                name = ItemNameFilter.Match(input).Groups["name"].Value;
                name = GrindFilter.Replace(name, "");
                name = SkinFilter.Replace(name, "");
                cat = ItemDatabase.Category.Weapon;
            }
            // Try as S-Rank
            else if (S_RankFilter.IsMatch(input))
            {
                Match match = S_RankFilter.Match(input);
                name = SRankNameIDAssociation[match.Groups["name"].Value.ToLower()];
                cat = ItemDatabase.Category.Weapon;
                searchType = ItemDatabase.SearchType.ByHex;

                if (match.Groups["special"].Value != String.Empty)
                {
                    name += Weapon.GetSRankSpecialHex(Weapon.ParseSpecial(match.Groups["special"].Value));
                }
                else
                {
                    name += "00";
                }
            }
            // Try as armor
            else if (ArmorFilter.IsMatch(input))
            {
                name = ItemNameFilter.Match(input).Groups["name"].Value;
                cat = ItemDatabase.Category.Armor;
            }
            // Try as barrier
            else if (BarrierFilter.IsMatch(input))
            {
                name = ItemNameFilter.Match(input).Groups["name"].Value;
                cat = ItemDatabase.Category.Barrier;
            }
            // Try as mag
            else if (MagFilter.IsMatch(input))
            {
                name = ItemNameFilter.Match(input).Groups["name"].Value;
                cat = ItemDatabase.Category.Mag;
            }
            // Try as tech
            else if (TechFilter.IsMatch(input))
            {
                name = ItemNameFilter.Match(input).Groups["name"].Value;
                cat = ItemDatabase.Category.Tech;
            }
            else if (ItemNameFilter.IsMatch(input))
            {
                name = ItemNameFilter.Match(input).Groups["name"].Value;
                name = QuantityFilter.Replace(name, "");
                cat = ItemDatabase.Category.Other;
            }
            else
            {
                name = ItemNameFilter.Match(input).Groups["name"].Value;
                name = input;
            }

            if (searchType == ItemDatabase.SearchType.ByName)
            {
                name = name.ToLower();
            }
            var items = ItemDatabase.Instance.FindItem(name.Trim(), cat, searchType);
            Item item = null;

            if (items.Count > 1)
            {
                item = new UnknownItem(items);
            }
            else if (items.Count == 0)
            {
                item = new UnknownItem();
            }
            else
            {
                item = items[0];
            }

            item.ParseAttributes(rawInput);

            return item;
        }
    }
}

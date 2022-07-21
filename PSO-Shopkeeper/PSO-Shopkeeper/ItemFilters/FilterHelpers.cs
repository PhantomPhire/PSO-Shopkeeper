using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper.ItemFilters
{
    /// <summary>
    /// Contains helper functions and classes for filters
    /// </summary>
    public static class FilterHelpers
    {
        /// <summary>
        /// Finds the next template tag in a string
        /// </summary>
        /// <param name="input">The text to parse</param>
        /// <param name="startingLocation">The location to start at.</param>
        /// <returns></returns>
        public static string FindNextFilter(string input, int startingLocation = 0)
        {
            int location = startingLocation;

            while (input.IndexOf('<', location) != -1)
            {
                location = input.IndexOf('<', location);

                if (input.IndexOf('>', location) == -1)
                {
                    return string.Empty;
                }

                int end = input.IndexOf('>', location);
                int nextOpenPar = input.IndexOf('(', location);
                int nextClosePar = input.IndexOf(')', location);

                while ((nextOpenPar < end) &&
                       (nextOpenPar != -1) &&
                       (nextClosePar != -1))
                {
                    int start = nextClosePar;
                    end = input.IndexOf('>', start);
                    nextOpenPar = input.IndexOf('(', start);

                    if (nextOpenPar != -1)
                    {
                        nextClosePar = input.IndexOf(')', nextOpenPar);
                    }
                }

                string tag = input.Substring(location, end - location + 1);

                if (SeparateFilters(tag).Count > 0)
                {
                    return tag;
                }

                location = end;
            }

            return string.Empty;
        }

        /// <summary>
        /// Separates a tag into a list of FilterPairs
        /// </summary>
        /// <param name="input">The input to separate</param>
        /// <returns>The resulting list of filters</returns>
        public static List<FilterPair> SeparateFilters(string input)
        {
            List<FilterPair> list = new List<FilterPair>();

            if (input.Length < 2)
            {
                return list;
            }

            string trimmed = input;
            if (trimmed[0] == '<')
            {
                trimmed = trimmed.Substring(1);
            }
            if (trimmed[trimmed.Length - 1] == '>')
            {
                trimmed = trimmed.Substring(0, trimmed.Length - 1);
            }

            if (trimmed.Contains('|'))
            {
                string[] split = trimmed.Split('|');

                foreach (string tag in split)
                {
                    FilterPair pair = getSingleFilter(tag);

                    if (pair != null)
                    {
                        list.Add(pair);
                    }
                }
            }
            else
            {
                FilterPair pair = getSingleFilter(trimmed);

                if (pair != null)
                {
                    list.Add(pair);
                }
            }

            return list;
        }

        /// <summary>
        /// Gets a single filter from a tag
        /// </summary>
        /// <param name="tag">The tag to parse</param>
        /// <returns>The resulting FilterPair, or null if invalid</returns>
        private static FilterPair getSingleFilter(string tag)
        {
            string filterName = tag;
            string argsString = string.Empty;
            string[] args = new string[0];
            bool inverted = false;
            if (tag.Contains('(') &&
                tag.Contains(')') &&
                (tag.IndexOf('(') < tag.IndexOf(')')))
            {
                int beginArgs = tag.IndexOf('(');
                int endArgs = tag.IndexOf(')');
                argsString = tag.Substring(beginArgs + 1, endArgs - beginArgs - 1);
                filterName = filterName.Remove(beginArgs, endArgs - beginArgs + 1);
                args = argsString.Split(',');
            }

            if (filterName.StartsWith("!"))
            {
                inverted = true;
                filterName = filterName.Remove(0, 1);
            }

            var filterResults = ItemFilterManager.Instance.Filters.Where((IItemFilter filter) => { return filter.Name.ToLower() == filterName.ToLower(); });

            if (filterResults.Count() == 0)
            {
                return null;
            }

            return new FilterPair(filterResults.First(), args, inverted);
        }

        /// <summary>
        /// A wrapper class for a filter and associated args
        /// </summary>
        public class FilterPair
        {
            /// <summary>
            /// Initializes a new instancce of the FilterPair class
            /// </summary>
            /// <param name="filter">The filter to contain</param>
            /// <param name="args">The args to associate</param>
            /// <param name="invert">Determines if the filter is inverted and blocks items</param>
            public FilterPair(IItemFilter filter, string[] args, bool invert = false)
            {
                _filter = filter;
                _args = args;
                _invert = invert;
            }

            /// <summary>
            /// Invokes the filter
            /// </summary>
            /// <param name="item">The item to determine the filter for</param>
            /// <returns>True if the item passes the filter</returns>
            public bool Invoke(Item item)
            {
                if (_invert)
                {
                    return !_filter.Function(item, _args);
                }

                return _filter.Function(item, _args);
            }

            /// <summary>
            /// Gets the filter from the pair
            /// </summary>
            public IItemFilter Filter { get { return _filter; } }

            /// <summary>
            /// Gets and sets the flag specifying if the FilterPair is inverted
            /// </summary>
            public bool Inverted
            {
                get { return _invert; }
                set { _invert = value; }
            }

            private IItemFilter _filter;
            private string[] _args;
            private bool _invert = false;

            /// <summary>
            /// Gets this filter as a string
            /// </summary>
            /// <returns>The filter as a string</returns>
            public override string ToString()
            {
                string filterString = Filter.Name;

                if (_invert)
                {
                    filterString = "!" + Filter.Name;
                }

                if (_args != null)
                {
                    filterString += "(";
                    for (int i = 0; i < _args.Length; i++)
                    {
                        if (i != 0)
                        {
                            filterString += ",";
                        }
                        filterString += _args[i];
                    }
                    filterString += ")";
                }

                return filterString;
            }
        }

        // NOTE: Cannot use generic function here due to needing a specific parse type
        /// <summary>
        /// A generic version for the comparison lambdas to use.
        /// </summary>
        /// <param name="value">The value to compare against</param>
        /// <param name="args">The args to use for comparison</param>
        /// <returns>True if the comparsion filter succeeds</returns>
        public static bool CompareArgsInt(int value, string[] args)
        {
            if (args.Length < 1)
            {
                return false;
            }

            if (!int.TryParse(args[0], out int argsValue))
            {
                return false;
            }

            string comparison = string.Empty;
            if (args.Length > 1)
            {
                comparison = args[1].Trim();
            }

            if (((args.Length < 2) && (value == argsValue)) ||
                ((comparison == ">") && (value == argsValue)) ||
                ((comparison == ">=") && (value >= argsValue)) ||
                ((comparison == "<") && (value < argsValue)) ||
                ((comparison == "<=") && (value <= argsValue)) ||
                ((comparison == "=") && (value == argsValue)))
            {
                return true;
            }

            return false;
        }

        // NOTE: Cannot use generic function here due to needing a specific parse type
        /// <summary>
        /// A generic version for the comparison lambdas to use.
        /// </summary>
        /// <param name="value">The value to compare against</param>
        /// <param name="args">The args to use for comparison</param>
        /// <returns>True if the comparsion filter succeeds</returns>
        public static bool CompareArgsDouble(double value, string[] args)
        {
            if (args.Length < 1)
            {
                return false;
            }

            if (!double.TryParse(args[0], out double argsValue))
            {
                return false;
            }

            string comparison = string.Empty;
            if (args.Length > 1)
            {
                comparison = args[1].Trim();
            }

            if (((args.Length < 2) && (value == argsValue)) ||
                ((comparison == ">") && (value == argsValue)) ||
                ((comparison == ">=") && (value >= argsValue)) ||
                ((comparison == "<") && (value < argsValue)) ||
                ((comparison == "<=") && (value <= argsValue)) ||
                ((comparison == "=") && (value == argsValue)))
            {
                return true;
            }

            return false;
        }
    }
}

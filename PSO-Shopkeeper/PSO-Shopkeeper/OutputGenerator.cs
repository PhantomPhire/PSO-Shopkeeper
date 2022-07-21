using System.Collections.Generic;
using PSOShopkeeper.ItemFilters;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper
{
    /// <summary>
    /// A static class responsible for generating PSO shop output
    /// </summary>
    static class OutputGenerator
    {
        /// <summary>
        /// Generates the shop output
        /// </summary>
        /// <returns></returns>
        public static string GenerateOutput()
        {
            string output = TemplateManager.Instance.Template;

            string nextTag = FilterHelpers.FindNextFilter(output);
            while (nextTag != string.Empty)
            {
                List<FilterHelpers.FilterPair> filters = FilterHelpers.SeparateFilters(nextTag);

                string itemPrint = "";

                foreach (Item item in ItemShop.Instance.Items)
                {
                    if (!item.Listed || 
                        ((item.KeepAmount != -1) && ((item.Quantity - item.KeepAmount) < 1)))
                    {
                        continue;
                    }

                    bool passed = true;
                    foreach (FilterHelpers.FilterPair filter in filters)
                    {
                        if (!filter.Invoke(item))
                        {
                            passed = false;
                        }
                    }

                    if (passed)
                    {
                        if (itemPrint.Length != 0 && itemPrint[itemPrint.Length - 1] != '\n')
                        {
                            itemPrint += "\n";
                        }
                        itemPrint += item.ToString();
                    }
                }

                output = output.Replace(nextTag, itemPrint);
                nextTag = FilterHelpers.FindNextFilter(output);
            }

            return output;
        }
    }
}

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

            string nextTag = TemplateManager.Instance.FindNextTag(output);
            while (nextTag != string.Empty)
            {
                var filter = TemplateManager.Instance.GetFilterFromTag(nextTag);

                string itemPrint = "";

                foreach (Item item in ItemShop.Instance.Items)
                {
                    if (filter(item))
                    {
                        if (itemPrint.Length != 0 && itemPrint[itemPrint.Length - 1] != '\n')
                        {
                            itemPrint += "\n";
                        }
                        itemPrint += item.ToString();
                    }
                }

                output = output.Replace(nextTag, itemPrint);
                nextTag = TemplateManager.Instance.FindNextTag(output);
            }

            return output;
        }
    }
}

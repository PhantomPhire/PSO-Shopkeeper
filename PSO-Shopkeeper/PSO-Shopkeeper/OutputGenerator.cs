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
                        itemPrint += item.ToString() + "\r\n";
                    }
                }

                output = output.Replace(nextTag, itemPrint);
                nextTag = TemplateManager.Instance.FindNextTag(output);
            }

            return output;
        }
    }
}

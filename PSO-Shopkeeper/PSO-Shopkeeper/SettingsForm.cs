using System;
using System.Windows.Forms;

namespace PSOShopkeeper
{
    /// <summary>
    /// Used asa settings form for the PSO shopkeeper app
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the SettingsForm class
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
            _combineItemsCheck.Checked = ItemShop.Instance.CombineItems;
        }

        /// <summary>
        /// Data binding for CombineItems check clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCombineItemsChecked(object sender, EventArgs e)
        {
            ItemShop.Instance.CombineItems = _combineItemsCheck.Checked;
        }
    }
}

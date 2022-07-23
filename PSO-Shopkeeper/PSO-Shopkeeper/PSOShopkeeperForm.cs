using System;
using System.Drawing;
using System.Windows.Forms;

namespace PSOShopkeeper
{
    public partial class PSOShopkeeperForm : Form
    {
        // Sub-forms

        /// <summary>
        /// Form in charge of listing items and pricing
        /// </summary>
        private PSOShopkeeperItemList _itemList = null;

        /// <summary>
        /// Form in charge of managing templates
        /// </summary>
        private PSOShopkeeperTemplateManagement _templateManager = null;

        /// <summary>
        /// Form in charge of managing output
        /// </summary>
        private PSOShopkeeperOutputManagement _outputManager = null;

        /// <summary>
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            InitializeComponent();

            _itemList = new PSOShopkeeperItemList();
            _templateManager = new PSOShopkeeperTemplateManagement();
            _outputManager = new PSOShopkeeperOutputManagement();
            _itemListView.Controls.Add(_itemList);
            _templateTab.Controls.Add(_templateManager);
            _outputTab.Controls.Add(_outputManager);
        }

        /// <summary>
        /// A helper function to stylize a button to standard styling
        /// </summary>
        /// <param name="button">The button to stylize</param>
        public static void StylizeButton(Button button)
        {
            button.Font = new Font("Tahoma", 8.5F, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = Color.Silver;
            button.FlatAppearance.MouseDownBackColor = Color.Black;
            button.BackColor = Color.FromArgb(100, 0, 0, 0);
            button.ForeColor = Color.White;
        }

        #region dataBindings

        /// <summary>
        /// Data binding for Open button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onOpenClicked(object sender, EventArgs e)
        {
            _itemList.AddItems();
        }

        /// <summary>
        /// Data binding for Save button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSaveClicked(object sender, EventArgs e)
        {
            if (_tabs.SelectedTab == _itemListView)
            {
                _itemList.SavePricing();
            }
            else if (_tabs.SelectedTab == _templateTab)
            {
                TemplateManager.Instance.Save();
            }
        }

        /// <summary>
        /// Data binding for exit menu button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onExitButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}

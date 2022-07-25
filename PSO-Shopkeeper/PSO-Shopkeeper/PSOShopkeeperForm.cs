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

        private const int tabOffset = 100;

        /// <summary>
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            InitializeComponent();

            _itemList = new PSOShopkeeperItemList();
            _itemList.Location = new Point(0, tabOffset);
            _templateManager = new PSOShopkeeperTemplateManagement();
            _templateManager.Location = new Point(0, tabOffset);
            _outputManager = new PSOShopkeeperOutputManagement();
            _outputManager.Location = new Point(0, tabOffset);
            _bgPanel.Controls.Add(_itemList);
            _bgPanel.Controls.Add(_templateManager);
            _bgPanel.Controls.Add(_outputManager);
            _itemList.Visible = false;
            _templateManager.Visible = false;
            _outputManager.Visible = false;

            Resize += onPSOShopkeeperFormResize;
            onPSOShopkeeperFormResize(this, EventArgs.Empty);
            onItemTabButtonClicked(this, EventArgs.Empty);
        }

        #region callbacks

        /// <summary>
        /// Callback for form resized
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onPSOShopkeeperFormResize(object sender, EventArgs e)
        {
            _itemTabButton.Location = new Point((Width / 4) - (_itemTabButton.Width / 2), _itemTabButton.Location.Y);
            _templateTabButton.Location = new Point(2 * (Width / 4) - (_itemTabButton.Width / 2), _itemTabButton.Location.Y);
            _outputTabButton.Location = new Point(3 * (Width / 4) - (_itemTabButton.Width / 2), _itemTabButton.Location.Y);
        }

        /// <summary>
        /// Callback for Item tab button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemTabButtonClicked(object sender, EventArgs e)
        {
            _itemList.Visible = true;
            _templateManager.Visible = false;
            _outputManager.Visible = false;
            _itemTabButton.Active = true;
            _templateTabButton.Active = false;
            _outputTabButton.Active = false;
        }

        /// <summary>
        /// Callback for Template tab button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onTemplateTabButtonClicked(object sender, EventArgs e)
        {
            _itemList.Visible = false;
            _templateManager.Visible = true;
            _outputManager.Visible = false;
            _itemTabButton.Active = false;
            _templateTabButton.Active = true;
            _outputTabButton.Active = false;
        }

        /// <summary>
        /// Callback for Output tab button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onOutputTabButtonClicked(object sender, EventArgs e)
        {
            _itemList.Visible = false;
            _templateManager.Visible = false;
            _outputManager.Visible = true;
            _itemTabButton.Active = false;
            _templateTabButton.Active = false;
            _outputTabButton.Active = true;
        }

        /// <summary>
        /// Callback for Open button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onOpenClicked(object sender, EventArgs e)
        {
            _itemList.AddItems();
        }

        /// <summary>
        /// Callback for Save button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSaveClicked(object sender, EventArgs e)
        {
            if (_itemList.Visible)
            {
                _itemList.SavePricing();
            }
            else if (_templateManager.Visible)
            {
                TemplateManager.Instance.Save();
            }
        }

        /// <summary>
        /// Callback for exit menu button clicked
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

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
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            InitializeComponent();

            _itemList = new PSOShopkeeperItemList();
            _templateManager = new PSOShopkeeperTemplateManagement();
            _itemListView.Controls.Add(_itemList);
            _templateTab.Controls.Add(_templateManager);

            _boldPriceCheck.Checked = ItemShop.Instance.BoldPrice;
            _multiPriceCheck.Checked = ItemShop.Instance.MultiPrice;
            _colorizeSpecialsCheck.Checked = ItemShop.Instance.ColorizeSpecials;
            _colorizeHitCheck.Checked = ItemShop.Instance.ColorizeHit;
            _colorizePercentages.Checked = ItemShop.Instance.ColorizedPercentages;
            _untekkText.Text = ItemShop.Instance.UntekkLabel;

            // Call resize just to make sure things are correct size
            Resize += onFormResize;
            onFormResize(null, null);
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
        /// Data binding for Generate Output button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onGenerateOutputClicked(object sender, EventArgs e)
        {
            _outputBox.Text = OutputGenerator.GenerateOutput();
        }

        /// <summary>
        /// Data binding for Clear Output button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onClearOutputClicked(object sender, EventArgs e)
        {
            _outputBox.Text = string.Empty;
        }

        /// <summary>
        /// Data binding for Clipoard button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onClipboardButtonPressed(object sender, EventArgs e)
        {
            Clipboard.SetText(_outputBox.Text);
        }

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
        /// Data binding for Bold Price checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onBoldPriceChecked(object sender, EventArgs e)
        {
            ItemShop.Instance.BoldPrice = _boldPriceCheck.Checked;
        }

        /// <summary>
        /// Data binding for Multi Price checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onMultiPriceChecked(object sender, EventArgs e)
        {
            ItemShop.Instance.MultiPrice = _multiPriceCheck.Checked;
        }

        /// <summary>
        /// Data binding for Colorize Specials checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onColorizeSpecialsChecked(object sender, EventArgs e)
        {
            ItemShop.Instance.ColorizeSpecials = _colorizeSpecialsCheck.Checked;
        }

        /// <summary>
        /// Data binding for untekk text changed
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onUntekkTextChanged(object sender, EventArgs e)
        {
            ItemShop.Instance.UntekkLabel = _untekkText.Text;
        }

        /// <summary>
        /// Data binding for Colorize Hit checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onColorizeHitChecked(object sender, EventArgs e)
        {
            ItemShop.Instance.ColorizeHit = _colorizeHitCheck.Checked;
        }

        /// <summary>
        /// Data binding for Colorize Percentages checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onColorizePercentagesChecked(object sender, EventArgs e)
        {
            ItemShop.Instance.ColorizedPercentages = _colorizePercentages.Checked;
        }

        /// <summary>
        /// Data binding for Edit Colors button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onEditColorsClicked(object sender, EventArgs e)
        {
            ColorEditForm form = new ColorEditForm();
            form.Show();
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

        /// <summary>
        /// Data binding for form resize
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFormResize(object sender, EventArgs e)
        {
            //_itemList.Size = _tabs.Size;
        }

        #endregion
    }
}

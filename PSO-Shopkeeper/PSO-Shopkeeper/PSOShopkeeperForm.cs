using System;
using System.Drawing;
using System.Windows.Forms;
using PSOShopkeeper.ItemFilters;
using FastColoredTextBoxNS;

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
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            lockPages();
            InitializeComponent();
            unlockPages();

            _itemList = new PSOShopkeeperItemList();
            _itemListView.Controls.Add(new PSOShopkeeperItemList());
            
            _templateBox.Text = TemplateManager.Instance.Template;
            updateTemplateFormatting();

            _boldPriceCheck.Checked = ItemShop.Instance.BoldPrice;
            _multiPriceCheck.Checked = ItemShop.Instance.MultiPrice;
            _colorizeSpecialsCheck.Checked = ItemShop.Instance.ColorizeSpecials;
            _colorizeHitCheck.Checked = ItemShop.Instance.ColorizeHit;
            _colorizePercentages.Checked = ItemShop.Instance.ColorizedPercentages;
            _untekkText.Text = ItemShop.Instance.UntekkLabel;

            setupFilterConstructionUI();

            // Call resize just to make sure things are correct size
            Resize += onFormResize;
            onFormResize(null, null);
        }

        /// <summary>
        /// Allows controls to be locked so that values are not overridden during ininitalization
        /// </summary>
        bool _controlLock = false;

        /// <summary>
        /// Locks pages so they don't respond to data  bindings
        /// </summary>
        private void lockPages()
        {
            _controlLock = true;
        }

        /// <summary>
        /// Unlocks pages to respond to data bindings
        /// </summary>
        private void unlockPages()
        {
            _controlLock = false;
        }

        TextStyle _validStyle = new TextStyle(Brushes.LightGreen, null, FontStyle.Regular);

        /// <summary>
        /// Updates formatting and highlighting of template
        /// </summary>
        private void updateTemplateFormatting()
        {
            _templateBox.GetRange(0, _templateBox.Text.Length - 1).ClearStyle(_validStyle);
            string text = _templateBox.Text;
            int position = 0;

            string nextTag = FilterHelpers.FindNextFilter(text, position);
            while (nextTag != string.Empty)
            {
                position = text.IndexOf(nextTag, position);
                _templateBox.GetRange(position, position + nextTag.Length).SetStyle(_validStyle);
                position += nextTag.Length;
                nextTag = FilterHelpers.FindNextFilter(_templateBox.Text, position);
            }
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
        /// Data binding for Save Template button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSaveTemplateClicked(object sender, EventArgs e)
        {
            TemplateManager.Instance.Save();
        }

        /// <summary>
        /// Data binding for when template text changes
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onTemplateTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_controlLock)
            {
                TemplateManager.Instance.Template = _templateBox.Text;
                updateTemplateFormatting();
            }
        }

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
            _filterPreview.MaximumSize = new Size(_filterPreviewScrollPanel.Width - 20, 0);
            _itemList.Size = _tabs.Size;
        }

        #endregion
    }
}

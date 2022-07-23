using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSOShopkeeper
{
    public partial class PSOShopkeeperOutputManagement : UserControl
    {
        /// <summary>
        /// initializes a new instance of the PSOShopkeeperOutputManagement class
        /// </summary>
        public PSOShopkeeperOutputManagement()
        {
            InitializeComponent();

            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _boldPriceCheck.Checked = ItemShop.Instance.BoldPrice;
            _multiPriceCheck.Checked = ItemShop.Instance.MultiPrice;
            _colorizeSpecialsCheck.Checked = ItemShop.Instance.ColorizeSpecials;
            _colorizeHitCheck.Checked = ItemShop.Instance.ColorizeHit;
            _colorizePercentages.Checked = ItemShop.Instance.ColorizedPercentages;
            _untekkText.Text = ItemShop.Instance.UntekkLabel;
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

        #endregion
    }
}

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
    public partial class MesetaConversionForm : Form
    {
        /// <summary>
        /// initializes a new instance of the MesetaConversionForm class
        /// </summary>
        public MesetaConversionForm()
        {
            InitializeComponent();
            _pdValueTextBox.Text = ItemShop.Instance.MaxPDsForAutofill.ToString();
            _mesetaPerPDTextBox.Text = ItemShop.Instance.MesetaPerPD.ToString();
            _abbrivateThousdandsCheck.Checked = ItemShop.Instance.AbbreviateMesetaAutofill;
        }

        /// <summary>
        /// Data binding for Go button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onGoClicked(object sender, EventArgs e)
        {
            // Save settings first
            if (double.TryParse(_pdValueTextBox.Text, out double pdResult))
            {
                ItemShop.Instance.MaxPDsForAutofill = pdResult;
            }
            if (int.TryParse(_mesetaPerPDTextBox.Text, out int mesetaReult))
            {
                ItemShop.Instance.MesetaPerPD = mesetaReult;
            }
            ItemShop.Instance.AbbreviateMesetaAutofill = _abbrivateThousdandsCheck.Checked;

            // Invoke autofill
            ItemShop.Instance.AutoFillMeseta();
            this.Dispose();
        }

        /// <summary>
        /// Data binding for Cancel button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCancelClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

using PSOShopkeeper;
using PSOShopkeeperLib.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO_Shopkeeper
{
    public partial class PSOShopkeeperForm : Form
    {
        /// <summary>
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Data binding for Add Items button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onAddItemsClicked(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dialog.FileNames)
                {
                    ItemShop.Instance.ReadInItemFile(file);
                }
            }
        }
    }
}

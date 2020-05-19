using PSOShopkeeper;
using PSOShopkeeperLib.Item;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOShopkeeper
{
    public partial class PSOShopkeeperForm : Form
    {
        ItemListView _itemList = null;

        /// <summary>
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            InitializeComponent();
            _itemList = new ItemListView(_itemListPanel, _itemInformation);
        }

        private void lockPages()
        {
            _itemList.Lock = true;
        }

        private void unlockPages()
        {
            _itemList.Lock = false;
        }

        private void updatedPages()
        {
            _itemList.UpdatePage();
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
                lockPages();
                foreach (string file in dialog.FileNames)
                {
                    ItemShop.Instance.ReadInItemFile(file);
                }
                unlockPages();
                updatedPages();
            }
        }

        /// <summary>
        /// Data binding for Clear Items button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onClearItemsClicked(object sender, EventArgs e)
        {
            // TODO: Add confirmation box
            ItemShop.Instance.ClearItems();
        }

        /// <summary>
        /// Data binding for cell clicked on item info
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            _itemList.UpdateItemInfo();
        }
    }
}

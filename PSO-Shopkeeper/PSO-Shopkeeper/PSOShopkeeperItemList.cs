using System;
using System.Drawing;
using System.Windows.Forms;

namespace PSOShopkeeper
{
    public partial class PSOShopkeeperItemList : UserControl
    {
        /// <summary>
        /// The object responsible for maintaining the item list
        /// </summary>
        ItemListView _itemList = null;

        /// <summary>
        /// initializes a new instance of the PSOShopkeeperItemList class
        /// </summary>
        public PSOShopkeeperItemList()
        {
            lockPages();
            InitializeComponent();
            unlockPages();

            BackColor = Color.Transparent;

            _itemList = new ItemListView(_itemListPanel, _itemInformationLabel, _itemInformationPanel);

            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _itemListPanel.CellBeginEdit += onItemListViewPanelCellBeginEdit;
            _itemListPanel.CellEndEdit += onItemListViewPanelCellEndEdit;

            // Call resize just to make sure things are correct size
            Resize += onFormResize;
            onFormResize(null, null);
        }

        /// <summary>
        /// Opens dialogue to let user select input item files
        /// </summary>
        public void AddItems()
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
                ItemShop.Instance.SortItemsByHex();
                unlockPages();
                updatePages();
            }
        }

        /// <summary>
        /// Saves the current state of pricing in the _itemListPanel
        /// </summary>
        public void SavePricing()
        {
            _itemList.SavePricing();
        }

        /// <summary>
        /// Locks pages so they don't respond to data  bindings
        /// </summary>
        private void lockPages()
        {
            if (_itemList != null)
            {
                _itemList.Lock = true;
            }
        }

        /// <summary>
        /// Unlocks pages to respond to data bindings
        /// </summary>
        private void unlockPages()
        {
            if (_itemList != null)
            {
                _itemList.Lock = false;
            }
        }

        /// <summary>
        /// Updates pages
        /// </summary>
        private void updatePages()
        {
            _itemList.UpdatePage();
        }

        /// <summary>
        /// Caches the right clicked column
        /// </summary>
        private int _rightClickedColumn = -1;

        #region callbacks

        /// <summary>
        /// Callback for Add Items button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onAddItemsClicked(object sender, EventArgs e)
        {
            AddItems();
        }

        /// <summary>
        /// Callback for Clear Items button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onClearItemsClicked(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear all items?",
                                                "Clear All?",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                ItemShop.Instance.ClearItems();
            }
        }

        /// <summary>
        /// Callback for cell clicked on item info
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            _itemList.UpdateItemInfo();
        }

        /// <summary>
        /// Callback for cell right clicked on item info
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCellRightClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    _itemListPanel.ClearSelection();
                    _itemListPanel.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    _itemContextMenu.Show(MousePosition);
                }
                else
                {
                    _rightClickedColumn = e.ColumnIndex;

                    _itemListPanel.ClearSelection();
                    if (e.ColumnIndex == 2)
                    {
                        _headerContextMenuPDs.Show(MousePosition);
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        _headerContextMenuMeseta.Show(MousePosition);
                    }
                    else
                    {
                        _headerContextMenuBasic.Show(MousePosition);
                    }
                }
            }
        }

        /// <summary>
        /// Callback for Save Prices button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSavePricesClicked(object sender, EventArgs e)
        {
            _itemList.SavePricing();
        }

        /// <summary>
        /// Callback for when a cell is changed
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args</param>
        private void onCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            _itemList.NotifyCellValueChanged(e.RowIndex, e.ColumnIndex);
        }

        /// <summary>
        /// Callback for Cut checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCutClicked(object sender, EventArgs e)
        {
            copyCells();

            foreach (DataGridViewCell cell in _itemListPanel.SelectedCells)
            {
                cell.Value = string.Empty;
            }
        }

        /// <summary>
        /// Callback for Copy checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCopyClicked(object sender, EventArgs e)
        {
            copyCells();
        }

        /// <summary>
        /// Callback for Paste checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onPasteClicked(object sender, EventArgs e)
        {
            pasteCells();
        }

        /// <summary>
        /// Callback for cell key pressed
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCellKeyPressed(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.C) && (e.Modifiers == Keys.Control))
            {
                if (_itemListPanel.SelectedCells.Count > 0)
                {
                    copyCells();
                }
            }
            else if ((e.KeyCode == Keys.X) && (e.Modifiers == Keys.Control))
            {
                if (_itemListPanel.SelectedCells.Count > 0)
                {
                    copyCells();

                    foreach (DataGridViewCell cell in _itemListPanel.SelectedCells)
                    {
                        cell.Value = string.Empty;
                    }
                }
            }
            if ((e.KeyCode == Keys.V) && (e.Modifiers == Keys.Control))
            {
                if (_itemListPanel.SelectedCells.Count > 0)
                {
                    pasteCells();
                }
            }
        }

        /// <summary>
        /// Callback for clear column clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onClearColumnClicked(object sender, EventArgs e)
        {
            if (_rightClickedColumn < 2)
            {
                return;
            }

            foreach (DataGridViewRow row in _itemListPanel.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == _rightClickedColumn)
                    {
                        cell.Value = string.Empty;
                        _itemList.NotifyCellValueChanged(row.Index, cell.ColumnIndex);
                    }
                }
            }
        }

        /// <summary>
        /// Callback for Get Sum button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSumItemsClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Item price sum: " + ItemShop.Instance.CalculateSum() + " PDs",
                            "Sum",
                            MessageBoxButtons.OK);
        }

        /// <summary>
        /// Callback for Autofill button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onAutofillClicked(object sender, EventArgs e)
        {
            MesetaConversionForm form = new MesetaConversionForm();
            form.Show();
        }

        /// <summary>
        /// Callback for item search text changed
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemSearchBarTextChanged(object sender, EventArgs e)
        {
            if (_itemList.UpdateSearchQuery(_itemSearchBar.Text))
            {
                _itemSearchBar.BackColor = Color.White;
            }
            else
            {
                _itemSearchBar.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Callback for Unpriced items only button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onUpricedButtonClicked(object sender, EventArgs e)
        {
            _itemList.FilterUnpriced = !_itemList.FilterUnpriced;
            _unpricedButton.Active = _itemList.FilterUnpriced;
        }

        /// <summary>
        /// Callback for beginning of editing a cell in the item list view panel
        /// </summary>
        /// <param name="sender">The object initiating the event</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemListViewPanelCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _itemListPanel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }

        /// <summary>
        /// Callback for ending of editing a cell in the item list view panel
        /// </summary>
        /// <param name="sender">The object initiating the event</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemListViewPanelCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _itemListPanel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
        }

        /// <summary>
        /// Callback for form resize
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFormResize(object sender, EventArgs e)
        {
            _itemInformationLabel.MaximumSize = new Size(_itemInformationPanel.Width - 20, 0);
        }

        #endregion

        #region clipboard

        /// <summary>
        /// Copies selected cells
        /// </summary>
        private void copyCells()
        {
            DataObject data = _itemListPanel.GetClipboardContent();

            if (data != null)
            {
                Clipboard.SetDataObject(data);
            }
        }

        /// <summary>
        /// Pastes into selected cells
        /// </summary>
        private void pasteCells()
        {
            if (_itemListPanel.SelectedCells.Count != 1)
            {
                return;
            }

            _itemListPanel.SelectedCells[0].Value = Clipboard.GetText();
        }

        #endregion
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Threading;
using PSOShopkeeper.ItemFilters;
using FastColoredTextBoxNS;

namespace PSOShopkeeper
{
    public partial class PSOShopkeeperForm : Form
    {
        /// <summary>
        /// The object responsible for maintaining the item list
        /// </summary>
        ItemListView _itemList = null;

        /// <summary>
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            lockPages();
            InitializeComponent();
            unlockPages();
            _itemList = new ItemListView(_itemListPanel, _itemInformationPanel);
            _templateBox.Text = TemplateManager.Instance.Template;
            updateTemplateFormatting();

            _boldPriceCheck.Checked = ItemShop.Instance.BoldPrice;
            _multiPriceCheck.Checked = ItemShop.Instance.MultiPrice;
            _colorizeSpecialsCheck.Checked = ItemShop.Instance.ColorizeSpecials;
            _colorizeHitCheck.Checked = ItemShop.Instance.ColorizeHit;
            _colorizePercentages.Checked = ItemShop.Instance.ColorizedPercentages;
            _untekkText.Text = ItemShop.Instance.UntekkLabel;

            setupFilterConstructionUI();
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
            if (_itemList != null)
            {
                _itemList.Lock = true;
            }
            _controlLock = true;
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
            _controlLock = false;
        }

        /// <summary>
        /// Updates pages
        /// </summary>
        private void updatePages()
        {
            _itemList.UpdatePage();
        }

        TextStyle _blueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

        /// <summary>
        /// Updates formatting and highlighting of template
        /// </summary>
        private void updateTemplateFormatting()
        {
            _templateBox.GetRange(0, _templateBox.Text.Length - 1).ClearStyle(_blueStyle);
            string text = _templateBox.Text;
            int position = 0;

            string nextTag = FilterHelpers.FindNextFilter(text, position);
            while (nextTag != string.Empty)
            {
                position = text.IndexOf(nextTag, position);
                _templateBox.GetRange(position, position + nextTag.Length).SetStyle(_blueStyle);
                position += nextTag.Length;
                nextTag = FilterHelpers.FindNextFilter(_templateBox.Text, position);
            }
        }

        /// <summary>
        /// Caches the right clicked column
        /// </summary>
        private int _rightClickedColumn = -1;

        #region dataBindings

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
                ItemShop.Instance.SortItemsByHex();
                unlockPages();
                updatePages();
            }
        }

        /// <summary>
        /// Data binding for Clear Items button clicked
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
        /// Data binding for cell clicked on item info
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            _itemList.UpdateItemInfo();
        }

        /// <summary>
        /// Data binding for cell right clicked on item info
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCellRightClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
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
        /// Data binding for Save Prices button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSavePricesClicked(object sender, EventArgs e)
        {
            _itemList.SavePricing();
        }

        /// <summary>
        /// Data binding for when a cell is changed
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args</param>
        private void onCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            _itemList.NotifyCellValueChanged(e.RowIndex, e.ColumnIndex);
        }

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
        /// Data binding for Cut checkbox clicked
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
        /// Data binding for Copy checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onCopyClicked(object sender, EventArgs e)
        {
            copyCells();
        }

        /// <summary>
        /// Data binding for Paste checkbox clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onPasteClicked(object sender, EventArgs e)
        {
            pasteCells();
        }

        /// <summary>
        /// Data binding for cell key pressed
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
        /// Data binding for clear column clicked
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
        /// Data binding for Get Sum button clicked
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
        /// Data binding for Autofill button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onAutofillClicked(object sender, EventArgs e)
        {
            MesetaConversionForm form = new MesetaConversionForm();
            form.Show();
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
        /// Data binding for item search text changed
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
        /// Data binding for Unpriced items only button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onUpricedButtonClicked(object sender, EventArgs e)
        {
            _itemList.FilterUnpriced = !_itemList.FilterUnpriced;
            _unpricedButton.BackColor = _itemList.FilterUnpriced ? Color.Green : Color.White;
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

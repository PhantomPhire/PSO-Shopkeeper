using PSOShopkeeperLib.Item;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Threading;

namespace PSOShopkeeper
{
    public partial class PSOShopkeeperForm : Form
    {
        /// <summary>
        /// The object responsible for maintaining the item list
        /// </summary>
        ItemListView _itemList = null;

        /// <summary>
        /// The timer driving the syntax highlighting
        /// </summary>
        DispatcherTimer _syntaxHighlightTimer = new DispatcherTimer();

        /// <summary>
        /// initializes a new instance of the PSOShopkeeperForm class
        /// </summary>
        public PSOShopkeeperForm()
        {
            InitializeComponent();
            _itemList = new ItemListView(_itemListPanel, _itemInformation);
            _templateBox.Text = TemplateManager.Instance.Template;
            _templateHints.Text = TemplateManager.TemplateHints;
            updateTemplateFormatting();

            _syntaxHighlightTimer.Tick += onSyntaxTimerTimeout;
            _syntaxHighlightTimer.Interval = new TimeSpan(0, 0, 1);
            _boldPriceCheck.Checked = ItemShop.Instance.BoldPrice;
            _multiPriceCheck.Checked = ItemShop.Instance.MultiPrice;
            _colorizeSpecialsCheck.Checked = ItemShop.Instance.ColorizeSpecials;
            _colorizeHitCheck.Checked = ItemShop.Instance.ColorizeHit;
            _colorizePercentages.Checked = ItemShop.Instance.ColorizedPercentages;
        }

        /// <summary>
        /// Locks pages so they don't respond to data  bindings
        /// </summary>
        private void lockPages()
        {
            _itemList.Lock = true;
        }

        /// <summary>
        /// Unlocks pages to respond to data bindings
        /// </summary>
        private void unlockPages()
        {
            _itemList.Lock = false;
        }

        /// <summary>
        /// Updates pages
        /// </summary>
        private void updatedPages()
        {
            _itemList.UpdatePage();
        }

        /// <summary>
        /// Updates formatting and highlighting of template
        /// </summary>
        private void updateTemplateFormatting()
        {
            int savedPosition = _templateBox.SelectionStart;
            _templateBox.SelectAll();
            _templateBox.SelectionColor = Color.Black;
            string text = _templateBox.Text;
            int position = 0;

            string nextTag = TemplateManager.Instance.FindNextTag(text, position);
            while (nextTag != string.Empty)
            {
                position = text.IndexOf(nextTag);
                _templateBox.Select(position, nextTag.Length);
                _templateBox.SelectionColor = Color.Blue;
                position += nextTag.Length;
                nextTag = TemplateManager.Instance.FindNextTag(_templateBox.Text, position);
            }

            _templateBox.Select(savedPosition, 0);
        }

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
            _itemList.NotifyCellValueChanged(e.RowIndex);
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
        private void onTemplateTextChanged(object sender, EventArgs e)
        {
            TemplateManager.Instance.Template = _templateBox.Text;

            if (ItemShop.Instance.AutoSyntaxHighlighting)
            {
                _syntaxHighlightTimer.Start();
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
        /// Data binding for Settings button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSettingsButtonClicked(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        /// <summary>
        /// Data binding for timer on timoeut
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSyntaxTimerTimeout(object sender, EventArgs e)
        {
            updateTemplateFormatting();
            _syntaxHighlightTimer.Stop();
        }

        /// <summary>
        /// Data binding for Validate button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onValidateClicked(object sender, EventArgs e)
        {
            updateTemplateFormatting();
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
        /// Data binding for Get Sum checkbox clicked
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

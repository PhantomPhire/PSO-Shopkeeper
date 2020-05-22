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
                _templateBox.Select(position, nextTag.Length + 1);
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

        #endregion
    }
}

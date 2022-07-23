using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using PSOShopkeeper.Controls;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper
{
    /// <summary>
    /// Maintains UI elements for the PSO Shopkeeper item list view
    /// </summary>
    class ItemListView
    {
        /// <summary>
        /// The table this class is maintaining
        /// </summary>
        private DataTable _table = new DataTable();
        
        /// <summary>
        /// The view to the table
        /// </summary>
        private DataGridView _tableView = null;

        /// <summary>
        /// The label displaying information about the selected item
        /// </summary>
        private Label _itemInformation = null;

        /// <summary>
        /// The panel containing the label displaying information about the selected item
        /// </summary>
        private Panel _itemInformationPanel = null;

        /// <summary>
        /// Maintains an association with items and rows
        /// </summary>
        private Dictionary<string, Item> _itemAssociation = new Dictionary<string, Item>();

        /// <summary>
        /// Gets and sets a lock for updating the page
        /// </summary>
        public bool Lock { get; set; } = false;

        /// <summary>
        /// Contains controls created for resolving item information ambiguities
        /// </summary>
        public List<Component> _itemInformationControls = new List<Component>();

        /// <summary>
        /// Defines indices of columns
        /// </summary>
        public const int NumberColumnIndex         = 0;
        public const int NameColumnIndex           = 1;
        public const int PDPriceColumnIndex        = 2;
        public const int MesetaPriceColumnIndex    = 3;
        public const int CustomPriceColumnIndex    = 4;
        public const int CustomCurrencyColumnIndex = 5;
        public const int ListedColumnIndex         = 6;
        public const int KeepAmountColumnIndex     = 7;
        public const int NotesColumnIndex          = 8;

        /// <summary>
        /// Initializes a new instance of the ItemListView class
        /// </summary>
        /// <param name="tableView">The table this object will maintain</param>
        /// <param name="itemInfo">The label to display item info</param>
        /// <param name="itemInfoPanel">The panel containing the label to display item info</param>
        public ItemListView(DataGridView tableView, Label itemInfo, Panel itemInfoPanel)
        {
            _tableView = tableView;
            _tableView.DataSource = _table;
            _itemInformation = itemInfo;
            _itemInformationPanel = itemInfoPanel;
            ItemShop.Instance.Updated += UpdatePage;
            _table.Columns.Clear();
            _table.Columns.Add(new DataColumn("#"));
            _tableView.Columns[NumberColumnIndex].Width = 40;
            _table.Columns[NumberColumnIndex].ReadOnly = true;
            _table.Columns.Add(new DataColumn("Name"));
            _tableView.Columns[NameColumnIndex].Width = 300;
            _table.Columns[NameColumnIndex].ReadOnly = true;
            _table.Columns.Add(new DataColumn("PD Price"));
            _tableView.Columns[PDPriceColumnIndex].Width = 60;
            _table.Columns.Add(new DataColumn("Meseta Price"));
            _tableView.Columns[MesetaPriceColumnIndex].Width = 80;
            _table.Columns.Add(new DataColumn("Custom Price"));
            _tableView.Columns[CustomPriceColumnIndex].Width = 80;
            _table.Columns.Add(new DataColumn("Custom Currency"));
            _tableView.Columns[CustomCurrencyColumnIndex].Width = 80;
            _table.Columns.Add("Listed?", typeof(bool));
            _tableView.Columns[ListedColumnIndex].Width = 60;
            _table.Columns.Add(new DataColumn("Amount to Keep"));
            _tableView.Columns[KeepAmountColumnIndex].Width = 60;
            _table.Columns.Add(new DataColumn("Notes"));
            _tableView.Columns[NotesColumnIndex].Width = 150;
            _tableView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _tableView.MultiSelect = false;
        }

        private const int verticalSpacing = 40;

        /// <summary>
        /// Updates page with all items
        /// </summary>
        public void UpdatePage()
        {
            if (Lock)
            {
                return;
            }

            _table.Rows.Clear();
            _itemAssociation.Clear();

            int index = 1;

            foreach (Item item in ItemShop.Instance.Items)
            {
                string itemText = item.ItemReaderText;

                if (item.Quantity > 1)
                {
                    itemText += " x" + item.Quantity.ToString();
                }

                string keepAmount = "";

                if (item.KeepAmount != -1)
                {
                    keepAmount = item.KeepAmount.ToString();
                }

                object[] rowValues = { index.ToString(), itemText, item.PricePDs.ToString(), item.PriceMeseta.ToString(),
                                       item.PriceCustom.ToString(), item.CustomCurrency, item.Listed, keepAmount, item.Notes };
                DataRow row = _table.Rows.Add(rowValues);
                _itemAssociation[index.ToString()] = item;

                index++;
            }

            filterRows();
        }

        /// <summary>
        /// Updates the item info to match selected item
        /// </summary>
        public void UpdateItemInfo()
        {

            _itemInformation.Text = string.Empty;
            
            if (_tableView.SelectedCells.Count < 1)
            {
                return;
            }
            string index;
            Item item = getItemFromRow(_tableView.SelectedCells[0].OwningRow, out index);
            if (item == null)
            {
                return;
            }

            foreach (Component component in _itemInformationControls)
            { 
                if (component is Control control)
                {
                    _itemInformationPanel.Controls.Remove(control);
                    control.Parent = null;
                }
                component.Dispose();
            }
            _itemInformationControls.Clear();

            if ((item is UnknownItem) && 
               ((item as UnknownItem).PossibleItems != null) &&
               ((item as UnknownItem).ExceptionText == null))
            {
                UnknownItem unknown = item as UnknownItem;

                _itemInformation.Text = "We found multiple items for the input \"" + item.ItemReaderText.Trim() 
                                        + "\", please choose the correct item (mouse over button for tooltips):\n\n";

                int yOffset = 200;
                foreach (Item possibleItem in unknown.PossibleItems)
                {
                    PSOShopkeeperButton button = new PSOShopkeeperButton();
                    button.Text = possibleItem.Name;
                    button.Parent = _itemInformationPanel;
                    button.Location = new Point(25, yOffset);
                    button.Size = new Size(_itemInformationPanel.Width - 50, 50);
                    button.Click += (object sender, EventArgs e) =>
                    {
                        ItemShop.Instance.ResolveUnknownItem(unknown, possibleItem);
                        _itemAssociation[index] = possibleItem;
                        UpdateItemInfo();
                    };
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(button, possibleItem.ItemReport());
                    _itemInformationControls.Add(button);
                    _itemInformationControls.Add(toolTip);
                    _itemInformationPanel.Controls.Add(button);

                    yOffset += 50;
                }
            }
            else
            {
                _itemInformation.Text = item.ItemReport();
            }
        }

        /// <summary>
        /// Saves pricing and updates item info
        /// </summary>
        public void SavePricing()
        {
            PricingManager.Instance.Save();
            ItemShop.Instance.ApplyPrices();
            UpdatePage();
        }

        /// <summary>
        /// Notifies the list that an item value has changed
        /// </summary>
        /// <param name="rowNumber">The row of the item that has changed</param>
        /// <param name="columnNumber">The column of the item that has changed</param>
        public void NotifyCellValueChanged(int rowNumber, int columnNumber)
        {
            try
            {
                DataGridViewRow row = _tableView.Rows[rowNumber];
                string index;
                Item item = getItemFromRow(row, out index);

                // Update data source
                int realRowIndex = int.Parse(_tableView.Rows[rowNumber].Cells[NumberColumnIndex].Value as string);
                _table.Rows[realRowIndex][columnNumber] = _tableView.Rows[rowNumber].Cells[columnNumber].Value;

                if (item == null)
                {
                    return;
                }

                if (row.Cells[PDPriceColumnIndex].Value == null)
                {
                    item.PricePDs = string.Empty;
                }
                else
                {
                    item.PricePDs = row.Cells[PDPriceColumnIndex].Value.ToString();
                }
                if (row.Cells[MesetaPriceColumnIndex].Value == null)
                {
                    item.PriceMeseta = string.Empty;
                }
                else
                {
                    item.PriceMeseta = row.Cells[MesetaPriceColumnIndex].Value.ToString();
                }
                if (row.Cells[CustomPriceColumnIndex].Value == null)
                {
                    item.PriceCustom = string.Empty;
                }
                else
                {
                    item.PriceCustom = row.Cells[CustomPriceColumnIndex].Value.ToString();
                }
                if (row.Cells[CustomCurrencyColumnIndex].Value == null)
                {
                    item.CustomCurrency = string.Empty;
                }
                else
                {
                    item.CustomCurrency = row.Cells[CustomCurrencyColumnIndex].Value.ToString();
                }
                if (row.Cells[ListedColumnIndex].Value == null)
                {
                    item.Listed = true;
                }
                else
                {
                    item.Listed = (bool)row.Cells[ListedColumnIndex].Value;
                }
                if (row.Cells[KeepAmountColumnIndex].Value == null)
                {
                    item.KeepAmount = -1;
                }
                else
                {
                    int amount = -1;

                    if (int.TryParse(row.Cells[KeepAmountColumnIndex].Value.ToString(), out amount))
                    {
                        item.KeepAmount = amount;
                    }
                    else
                    {
                        item.KeepAmount = -1;
                    }
                }
                if (row.Cells[NotesColumnIndex].Value == null)
                {
                    item.Notes = string.Empty;
                }
                else
                {
                    item.Notes = row.Cells[NotesColumnIndex].Value.ToString();
                }

                PricingManager.Instance.UpdatePricing(item);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not update price for row {0}.", rowNumber);
            }
        }

        /// <summary>
        /// Gets an item associated with a row
        /// </summary>
        /// <param name="row">The row to use</param>
        /// <param name="index">Output of index to use</param>
        /// <returns>The item associated with the row or null if invalid</returns>
        private Item getItemFromRow(DataGridViewRow row, out string index)
        {
            index = row.Cells[0].Value as string;
            if ((index != null) && _itemAssociation.ContainsKey(index))
            {
                return _itemAssociation[index];
            }
            return null;
        }

        /// <summary>
        /// Applies current filter to all rows
        /// </summary>
        private void filterRows()
        {
            var rows = from row in _table.AsEnumerable()
                       where filterRow(row)
                       select row;

            if (rows.Count() > 0)
            {
                _tableView.DataSource = rows.CopyToDataTable();
            }
            else
            {
                _tableView.DataSource = null;
            }

            _resultsCount = rows.Count();
        }

        /// <summary>
        /// Stores the current results count of filtering
        /// </summary>
        private int _resultsCount = 0;

        /// <summary>
        /// The cached search query of the item view
        /// </summary>
        private string _searchQuery = "";

        /// <summary>
        /// Updates the search query of the item table
        /// </summary>
        /// <param name="query">The text to search by</param>
        public bool UpdateSearchQuery(string query)
        {
            _searchQuery = query;

            filterRows();

            if ((_resultsCount == 0) && (_itemAssociation.Count > 0))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// The backing field for FilterUnpriced
        /// </summary>
        private bool _filterUnpriced;

        /// <summary>
        /// Gets and sets a flag determining if filtering should 
        /// </summary>
        public bool FilterUnpriced
        {
            get { return _filterUnpriced; }
            set 
            { 
                _filterUnpriced = value;
                filterRows();
            }
        }

        /// <summary>
        /// Filters a row based on its attributes and application settings
        /// </summary>
        /// <param name="row">The row to filter</param>
        /// <returns>True if the row passes the filter</returns>
        private bool filterRow(DataRow row)
        {
            bool returnValue = true;

            if (!row[NameColumnIndex].ToString().ToLower().Contains(_searchQuery.ToLower()) &&
                !row[NotesColumnIndex].ToString().ToLower().Contains(_searchQuery.ToLower()))
            {
                returnValue = false;
            }

            if (_filterUnpriced)
            {
                if (row[PDPriceColumnIndex].ToString() != String.Empty ||
                    row[MesetaPriceColumnIndex].ToString() != String.Empty ||
                    row[CustomPriceColumnIndex].ToString() != String.Empty)
                {
                    returnValue = false;
                }
            }

            return returnValue;
        }
    }
}

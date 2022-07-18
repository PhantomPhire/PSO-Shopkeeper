using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
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
        /// The panel displaying information about the selected item
        /// </summary>
        private Panel _itemInformation = null;

        /// <summary>
        /// The label displaying information about the selected item
        /// </summary>
        private Label _itemInformationLabel = null;

        /// <summary>
        /// Gets and sets a lock for updating the page
        /// </summary>
        public bool Lock { get; set; } = false;

        /// <summary>
        /// Contains controls created for resolving item information ambiguities
        /// </summary>
        public List<Component> _itemInformationControls = new List<Component>();

        /// <summary>
        /// Initializes a new instance of the ItemListView class
        /// </summary>
        /// <param name="tableView">The table this object will maintain</param>
        /// <param name="itemInfoPanel">The label to display item info</param>
        public ItemListView(DataGridView tableView, Panel itemInfo)
        {
            _tableView = tableView;
            _tableView.DataSource = _table;
            _itemInformation = itemInfo;
            _itemInformationLabel = new Label();
            _itemInformationLabel.Parent = _itemInformation;
            _itemInformationLabel.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _itemInformationLabel.Size = _itemInformation.Size;
            ItemShop.Instance.Updated += UpdatePage;
            _table.Columns.Clear();
            _table.Columns.Add(new DataColumn("Name"));
            _tableView.Columns[0].Width = 300;
            _table.Columns[0].ReadOnly = true;
            _table.Columns.Add(new DataColumn("PD Price"));
            _table.Columns.Add(new DataColumn("Meseta Price"));
            _table.Columns.Add(new DataColumn("Custom Price"));
            _table.Columns.Add(new DataColumn("Custom Currency"));
            _table.Columns.Add(new DataColumn("Notes"));
            _tableView.Columns[5].Width = 180;
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

            foreach (Item item in ItemShop.Instance.Items)
            {
                string itemText = item.ItemReaderText;

                if (item.Quantity > 1)
                {
                    itemText += " x" + item.Quantity.ToString();
                }

                string[] rowValues = { itemText, item.PricePDs.ToString(), item.PriceMeseta.ToString(),
                                       item.PriceCustom.ToString(), item.CustomCurrency, item.Notes };
                DataRow row = _table.Rows.Add(rowValues);
                _tableView.Rows[_table.Rows.IndexOf(row)].Tag = item;
            }
        }

        /// <summary>
        /// Updates the item info to match selected item
        /// </summary>
        public void UpdateItemInfo()
        {
            _itemInformationLabel.Text = string.Empty;
            if ((_tableView.SelectedCells.Count < 1) || 
                (_tableView.SelectedCells[0].OwningRow.Tag == null) || 
                !(_tableView.SelectedCells[0].OwningRow.Tag is Item))
            {
                return;
            }

            foreach (Component component in _itemInformationControls)
            { 
                if (component is Control control)
                {
                    control.Parent = null;
                }
                component.Dispose();
            }
            _itemInformationControls.Clear();

            Item item = (_tableView.SelectedCells[0].OwningRow.Tag as Item);

            if ((item is UnknownItem) && 
               ((item as UnknownItem).PossibleItems != null) &&
               ((item as UnknownItem).ExceptionText == null))
            {
                UnknownItem unknown = item as UnknownItem;

                _itemInformationLabel.Visible = false;

                Label label = new Label();
                label.Text = "We found multiple items for the input \"" + item.ItemReaderText.Trim() 
                             + "\", please choose the correct item (mouse over button for tooltips):\n\n";
                label.Parent = _itemInformation;
                label.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                label.Location = new Point(0, 0);
                label.Size = new Size(_itemInformation.Width, 100);
                _itemInformationControls.Add(label);

                int yOffset = 100;
                foreach (Item possibleItem in unknown.PossibleItems)
                {
                    Button button = new Button();
                    button.Text = possibleItem.Name;
                    button.Parent = _itemInformation;
                    button.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    button.Location = new Point(0, yOffset);
                    button.Size = new Size(_itemInformation.Width, 50);
                    button.Click += (object sender, EventArgs e) =>
                    {
                        ItemShop.Instance.ResolveUnknownItem(unknown, possibleItem);
                        _tableView.SelectedCells[0].OwningRow.Tag = possibleItem;
                        UpdateItemInfo();
                    };
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(button, possibleItem.ItemReport());
                    _itemInformationControls.Add(button);
                    _itemInformationControls.Add(toolTip);

                    yOffset += 50;
                }
            }
            else
            {
                _itemInformationLabel.Visible = true;
                _itemInformationLabel.Text = item.ItemReport();
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
        public void NotifyCellValueChanged(int rowNumber)
        {
            try
            {
                DataGridViewRow row = _tableView.Rows[rowNumber];
                Item item = row.Tag as Item;

                if (item == null)
                {
                    return;
                }

                if (row.Cells[1].Value == null)
                {
                    item.PricePDs = string.Empty;
                }
                else
                {
                    item.PricePDs = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value == null)
                {
                    item.PriceMeseta = string.Empty;
                }
                else
                {
                    item.PriceMeseta = row.Cells[2].Value.ToString();
                }
                if (row.Cells[3].Value == null)
                {
                    item.PriceCustom = string.Empty;
                }
                else
                {
                    item.PriceCustom = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value == null)
                {
                    item.CustomCurrency = string.Empty;
                }
                else
                {
                    item.CustomCurrency = row.Cells[4].Value.ToString();
                }
                if (row.Cells[5].Value == null)
                {
                    item.Notes = string.Empty;
                }
                else
                {
                    item.Notes = row.Cells[5].Value.ToString();
                }

                PricingManager.Instance.UpdatePricing(item);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not update price for row {0}.", rowNumber);
            }
        }
    }
}

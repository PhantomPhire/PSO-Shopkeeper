﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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
        private DataGridView _table = null;

        /// <summary>
        /// The label display information about the selected item
        /// </summary>
        private Label _itemInformation = null;

        /// <summary>
        /// Gets and sets a lock for updating the page
        /// </summary>
        public bool Lock { get; set; } = false;

        /// <summary>
        /// Initializes a new instance of the ItemListView class
        /// </summary>
        /// <param name="table">The table this object will maintain</param>
        /// <param name="itemInfo">The label to display item info</param>
        public ItemListView(DataGridView table, Label itemInfo)
        {
            _table = table;
            _itemInformation = itemInfo;
            ItemShop.Instance.Updated += UpdatePage;
            _table.Columns.Clear();
            _table.ColumnCount = 6;
            _table.Columns[0].Name = "Name";
            _table.Columns[0].Width = 300;
            _table.Columns[0].ReadOnly = true;
            _table.Columns[1].Name = "PD Price";
            _table.Columns[2].Name = "Meseta Price";
            _table.Columns[3].Name = "Custom Price";
            _table.Columns[4].Name = "Custom Currency";
            _table.Columns[5].Name = "Notes";
            _table.Columns[5].Width = 180;
            _table.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _table.MultiSelect = false;
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
                string[] row = { item.ItemReaderText, item.PricePDs.ToString(), item.PriceMeseta.ToString(), 
                                 item.PriceCustom.ToString(), item.CustomCurrency };
                int index = _table.Rows.Add(row);
                _table.Rows[index].Tag = item;
            }
        }

        /// <summary>
        /// Updates the item info to match selected item
        /// </summary>
        public void UpdateItemInfo()
        {
            _itemInformation.Text = string.Empty;
            if ((_table.SelectedCells.Count < 1) || 
                (_table.SelectedCells[0].OwningRow.Tag == null) || 
                !(_table.SelectedCells[0].OwningRow.Tag is Item))
            {
                return;
            }

            _itemInformation.Text = (_table.SelectedCells[0].OwningRow.Tag as Item).ItemReport();
        }
    }
}

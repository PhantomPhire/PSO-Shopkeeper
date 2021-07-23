using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PSOShopkeeper.ItemFilters;
using PSOShopkeeperLib.Item;

namespace PSOShopkeeper
{
    public partial class PSOShopkeeperForm
    {
        /// <summary>
        /// Contains the filter dialog
        /// </summary>
        private FilterDialog _filterDialog = new FilterDialog();

        /// <summary>
        /// Checks the rows and columns of a table and increments if needed
        /// </summary>
        /// <param name="table">The table to check for</param>
        /// <param name="row">The current row count</param>
        /// <param name="col">The current column count</param>
        private void checkTableDimensions(TableLayoutPanel table, ref int row, ref int col)
        {
            if (col >= table.ColumnCount)
            {
                col = 0;
                row++;
            }
            if (row >= table.RowCount)
            {
                table.RowCount++;
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
                table.Size = new Size(table.Width, table.Height + 30);
                col = 0;
            }
        }

        /// <summary>
        /// A wrapper of a filter and a button
        /// </summary>
        private class FilterButtonInfo
        {
            /// <summary>
            /// The filter associated with the pair
            /// </summary>
            public FilterHelpers.FilterPair AssociatedFilter { get; set; }

            /// <summary>
            /// The button associated with the pair
            /// </summary>
            public Button AssociatedButton { get; set; }
        };

        /// <summary>
        /// Contains the applied filter buttons
        /// </summary>
        private FilterButtonInfo[][] _appliedFilterButtons;

        /// <summary>
        /// Contains all the buttons created by the filters
        /// </summary>
        private List<List<Button>> _filterButtons = new List<List<Button>>();

        /// <summary>
        /// Sets up the dynamic filter construction UI
        /// </summary>
        private void setupFilterConstructionUI()
        {
            int row = 0;
            int col = 0;
            _filterButtons.Capacity = ItemFilterManager.Instance.Categories.Count();
            foreach (ItemFilterCategory category in ItemFilterManager.Instance.Categories)
            {
                checkTableDimensions(_filterToggles, ref row, ref col);

                Label categoryLabel = new Label();
                categoryLabel.Text = category.Caption;
                categoryLabel.TextAlign = ContentAlignment.MiddleCenter;
                _filterToggles.Controls.Add(categoryLabel, _filterToggles.ColumnCount / 2, row);

                row++;
                _filterButtons.Add(new List<Button>());
                foreach (IItemFilter filter in category.Filters)
                {
                    checkTableDimensions(_filterToggles, ref row, ref col);

                    Button filterButton = new Button();
                    filterButton.Text = filter.DisplayName;
                    filterButton.AutoSize = true;
                    filterButton.Font = new Font(FontFamily.GenericMonospace, 8.5F);
                    filterButton.Click += onFilterButtonClicked;
                    _filterToggles.Controls.Add(filterButton, col, row);
                    _filterButtons[_filterButtons.Count - 1].Add(filterButton);

                    // set tooltip for button
                    string toolTip = filter.Name + ": " + filter.Description;
                    if (filter.Args != null)
                    {
                        toolTip += "\nArgs:";
                        foreach (IItemFilterArg arg in filter.Args)
                        {
                            toolTip += "\n    " + arg.ToString();
                        }
                    }
                    _toolTip.SetToolTip(filterButton, toolTip);

                    col++;
                }

                row++;
                col = 0;
            }

            _appliedFilterButtons = new FilterButtonInfo[_appliedFilters.RowCount][];
            for (int i = 0; i < _appliedFilters.RowCount; i++)
            {
                _appliedFilterButtons[i] = new FilterButtonInfo[_appliedFilters.ColumnCount];
            }
        }

        /// <summary>
        /// Refreshes the filter display at the top of the page
        /// </summary>
        private void refreshFilterDisplay()
        {
            _currentFilter.Text = getFullFilterString();

            Item.TestPrintMode = true;

            string itemPrint = "The following items will be printed with the current filters:\r\n";

            foreach (Item item in ItemShop.Instance.Items)
            {
                bool passed = true;
                for (int i = 0; i < _appliedFilterButtons.Length; i++)
                {
                    for (int j = 0; j < _appliedFilterButtons[i].Length; j++)
                    {
                        if (_appliedFilterButtons[i][j] != null)
                        {
                            if (!_appliedFilterButtons[i][j].AssociatedFilter.Invoke(item))
                            {
                                passed = false;
                            }
                        }
                    }
                }

                if (passed)
                {
                    if (itemPrint.Length != 0 && itemPrint[itemPrint.Length - 1] != '\n')
                    {
                        itemPrint += "\r\n";
                    }
                    itemPrint += item.ToString();
                }
            }

            _filterPreview.Text = itemPrint;
            Item.TestPrintMode = false;
        }

        /// <summary>
        /// Gets the full filter string from compiled filters
        /// </summary>
        /// <returns>The full filter string</returns>
        private string getFullFilterString()
        {
            if (_appliedFilterButtons[0][0] == null)
            {
                return string.Empty;
            }

            string totalFilter = "<";
            bool first = true;

            for (int row = 0; row < _appliedFilterButtons.Length; row++)
            {
                if (_appliedFilterButtons[row][0] == null)
                {
                    break;
                }
                for (int col = 0; col < _appliedFilterButtons[row].Length; col++)
                {
                    if (_appliedFilterButtons[row][col] == null)
                    {
                        break;
                    }

                    if (!first)
                    {
                        totalFilter += "|";
                    }

                    totalFilter += _appliedFilterButtons[row][col].AssociatedFilter.ToString();
                    first = false;
                }
            }

            totalFilter += ">";

            return totalFilter;
        }

        /// <summary>
        /// Adds a filter to the applied filter buttons
        /// </summary>
        /// <param name="filterInfo">The info about the filter to add</param>
        private void addFilter(FilterButtonInfo filterInfo)
        {
            for (int row = 0; row < _appliedFilterButtons.Length; row++)
            {
                for (int col = 0; col < _appliedFilterButtons[row].Length; col++)
                {
                    if (_appliedFilterButtons[row][col] == null)
                    {
                        _appliedFilterButtons[row][col] = filterInfo;
                        _appliedFilters.Controls.Add(filterInfo.AssociatedButton, col, row);
                        refreshFilterDisplay();
                        return;
                    }
                }
            }

            MessageBox.Show("Too many filters!", "The filter limit has been reached!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Refreshes the applied filter buttons in the table
        /// </summary>
        private void refreshAppliedFilterButtons()
        {
            _appliedFilters.Controls.Clear();

            for (int row = 0; row < _appliedFilterButtons.Length; row++)
            {
                if (_appliedFilterButtons[row][0] == null)
                {
                    break;
                }

                for (int col = 0; col < _appliedFilterButtons[row].Length; col++)
                {
                    if (_appliedFilterButtons[row][col] == null)
                    {
                        break;
                    }

                    _appliedFilters.Controls.Add(_appliedFilterButtons[row][col].AssociatedButton, col, row);
                }
            }
        }

        /// <summary>
        /// Removes a filter from the applied filter buttons
        /// </summary>
        /// <param name="row">The row to remove</param>
        /// <param name="col">The column to remove</param>
        private void removeFilter(int row, int col)
        {
            for (; row < _appliedFilterButtons.Length; row++)
            {
                if (_appliedFilterButtons[row][0] == null)
                {
                    break;
                }

                for (; col < _appliedFilterButtons[row].Length; col++)
                {
                    if (_appliedFilterButtons[row][col] == null)
                    {
                        break;
                    }

                    FilterButtonInfo next = null;
                    int nextRow = 0;
                    int nextCol = 0;

                    if ((col + 1) == _appliedFilterButtons[row].Length)
                    {
                        if ((row + 1) != _appliedFilterButtons.Length)
                        {
                            next = _appliedFilterButtons[row + 1][0];
                            nextRow = row + 1;
                            nextCol = 0;
                        }
                    }
                    else
                    {
                        next = _appliedFilterButtons[row][col + 1];
                        nextRow = row;
                        nextCol = col + 1;
                    }

                    _appliedFilterButtons[row][col] = null;

                    if (next != null)
                    {
                        _appliedFilterButtons[row][col] = _appliedFilterButtons[nextRow][nextCol];
                    }
                }
            }

            refreshAppliedFilterButtons();
            refreshFilterDisplay();
        }

        /// <summary>
        /// Toggles a filter with no arguments 
        /// </summary>
        /// <param name="filter">The filter to apply</param>
        /// <param name="button">The button initiating the filter</param>
        private void toggleNoArgFilter(IItemFilter filter, Button button)
        {
            // Find the filter
            bool found = false;
            int row = 0;
            int col = 0;

            for (row = 0; row < _appliedFilterButtons.Length; row++)
            {
                for (col = 0; col < _appliedFilterButtons[row].Length; col++)
                {
                    if ((_appliedFilterButtons[row][col] != null) &&
                        (_appliedFilterButtons[row][col].AssociatedFilter.Filter == filter))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (found)
            {
                FilterButtonInfo filterInfo = _appliedFilterButtons[row][col];

                if (filterInfo.AssociatedFilter.Inverted)
                {
                    button.BackColor = Color.FromArgb(0, 0, 0, 0);
                    removeFilter(row, col);
                }
                else
                {
                    filterInfo.AssociatedFilter.Inverted = true;
                    button.BackColor = Color.FromArgb(255, 0, 0);
                    filterInfo.AssociatedButton.Text = "<" + filterInfo.AssociatedFilter.ToString() + ">";
                    refreshFilterDisplay();
                }
            }
            else
            {
                FilterHelpers.FilterPair pair = new FilterHelpers.FilterPair(filter, null, false);
                FilterButtonInfo filterInfo = new FilterButtonInfo
                {
                    AssociatedFilter = pair,
                    AssociatedButton = new Button()
                };
                filterInfo.AssociatedButton.Text = "<" + pair + ">";
                filterInfo.AssociatedButton.AutoSize = true;
                filterInfo.AssociatedButton.Click += onAppliedFilterButtonClicked;
                filterInfo.AssociatedButton.Font = new Font(FontFamily.GenericMonospace, 8.5F);
                addFilter(filterInfo);
                button.BackColor = Color.FromArgb(0, 255, 0);
            }
        }

        /// <summary>
        /// Handles a filter with arguments
        /// </summary>
        /// <param name="filter">The filter to apply</param>
        private void handleArgFilter(IItemFilter filter)
        {
            _filterDialog.SetFilter(filter);
            DialogResult res = _filterDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                if (!_filterDialog.Valid)
                {
                    MessageBox.Show("Invalid arguments!", "One or more arguments given are invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FilterHelpers.FilterPair pair = new FilterHelpers.FilterPair(filter, _filterDialog.Results.ToArray(), _filterDialog.Inverted);
                    FilterButtonInfo filterInfo = new FilterButtonInfo
                    {
                        AssociatedFilter = pair,
                        AssociatedButton = new Button()
                    };
                    filterInfo.AssociatedButton.Text = "<" + pair + ">";
                    filterInfo.AssociatedButton.AutoSize = true;
                    filterInfo.AssociatedButton.Font = new Font(FontFamily.GenericMonospace, 8.5F);
                    filterInfo.AssociatedButton.Click += onAppliedFilterButtonClicked;
                    addFilter(filterInfo);
                }
            }
        }

        /// <summary>
        /// Finds the filter location in the category table by matching it with a button
        /// </summary>
        /// <param name="button">The button to match</param>
        /// <param name="category">Gets the category the filter is at</param>
        /// <param name="filterIndex">Gets the filter index the filter is at</param>
        /// <returns></returns>
        private bool findFilterLocationByButton(Button button, ref int category, ref int filterIndex)
        {
            for (category = 0; category < _filterButtons.Count; category++)
            {
                for (filterIndex = 0; filterIndex < _filterButtons[category].Count; filterIndex++)
                {
                    if (button == _filterButtons[category][filterIndex])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Finds the button location in the category table by matching it with a filter
        /// </summary>
        /// <param name="filter">The filter to match</param>
        /// <param name="category">Gets the category the filter is at</param>
        /// <param name="filterIndex">Gets the filter index the filter is at</param>
        /// <returns></returns>
        private bool findButtonLocationByFilter(IItemFilter filter, ref int category, ref int filterIndex)
        {
            for (category = 0; category < ItemFilterManager.Instance.Categories.Count(); category++)
            {
                for (filterIndex = 0; filterIndex < ItemFilterManager.Instance.Categories.ElementAt(category).Filters.Count(); filterIndex++)
                {
                    if (filter == ItemFilterManager.Instance.Categories.ElementAt(category).Filters.ElementAt(filterIndex))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Finds the applied filter location in the applied filter table by matching it with a button
        /// </summary>
        /// <param name="button">The button to match</param>
        /// <param name="row">Gets the row the applied filter is at</param>
        /// <param name="col">Gets the column the applied filter is at</param>
        /// <returns></returns>
        private bool findAppliedFilterLocationByButton(Button button, ref int row, ref int col)
        {
            for (row = 0; row < _appliedFilterButtons.Length; row++)
            {
                for (col = 0; col < _appliedFilterButtons[row].Length; col++)
                {
                    if (button == _appliedFilterButtons[row][col].AssociatedButton)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Data binding for a filter button clicked
        /// </summary>
        /// <param name="sender">The button initiating the event</param>
        /// <param name="e">The event args (unused)</param>
        private void onFilterButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int i = 0;
            int j = 0;

            // Find the button
            findFilterLocationByButton(button, ref i, ref j);

            Debug.Assert((i <= _filterButtons.Count) && (j <= _filterButtons[i].Count));

            IItemFilter filter = ItemFilterManager.Instance.Categories.ElementAt(i).Filters.ElementAt(j);

            if (filter.Args == null)
            {
                toggleNoArgFilter(filter, button);
            }
            else
            {
                handleArgFilter(filter);
            }
        }

        /// <summary>
        /// Data binding for an applied filter button clicked
        /// </summary>
        /// <param name="sender">The button initiating the event</param>
        /// <param name="e">The event args (unused)</param>
        private void onAppliedFilterButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int row = 0;
            int col = 0;

            // Find the button
            bool found = findAppliedFilterLocationByButton(button, ref row, ref col);

            Debug.Assert(found);

            FilterButtonInfo info = _appliedFilterButtons[row][col];

            int i = 0;
            int j = 0;

            findButtonLocationByFilter(info.AssociatedFilter.Filter, ref i, ref j);
            Button catButton = _filterButtons[i][j];

            removeFilter(row, col);
            catButton.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        /// <summary>
        /// Data binding for add filter button clicked
        /// </summary>
        /// <param name="sender">The button initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onAddFilterClicked(object sender, EventArgs e)
        {
            string filterString = getFullFilterString();
            _templateBox.Text = _templateBox.Text.Insert(_templateBox.SelectionStart, filterString);
        }

        /// <summary>
        /// Data binding for clear filters button clicked
        /// </summary>
        /// <param name="sender">The button initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onClearFilterClicked(object sender, EventArgs e)
        {
            for (int i = 0; i < _appliedFilterButtons.Length; i++)
            {
                for (int j = 0; j < _appliedFilterButtons[i].Length; j++)
                {
                    _appliedFilterButtons[i][j] = null;
                }
            }

            refreshAppliedFilterButtons();
            refreshFilterDisplay();

            for (int i = 0; i < _filterButtons.Count; i++)
            {
                for (int j = 0; j < _filterButtons[i].Count; j++)
                {
                    _filterButtons[i][j].BackColor = Color.FromArgb(0, 0, 0, 0);
                }
            }
        }

        /// <summary>
        /// Data binding for template help button clicked
        /// </summary>
        /// <param name="sender">The button initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onTemplateHelpClicked(object sender, EventArgs e)
        {
            TemplateHelpForm form = new TemplateHelpForm();
            form.Show();
        }
    }
}

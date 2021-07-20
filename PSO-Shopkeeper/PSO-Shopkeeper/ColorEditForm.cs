using PSOShopkeeper;
using PSOShopkeeperLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO_Shopkeeper
{
    public partial class ColorEditForm : Form
    {
        private List<Button> _buttons;

        public ColorEditForm()
        {
            InitializeComponent();

            _buttons = new List<Button> { _negativeFivePercentButton, _zeroPercentButton, _fivePercentButton, _tenPercentButton,
                                          _fiteenPercentButton, _twentyPercentButton, _twentyFivePercentButton, _thirtyPercentButton,
                                          _thirtyFivePercentButton, _fortyPercentButton, _fortyFivePercentButton, _fiftyPercentButton,
                                          _fiftyFivePercentButton, _sixtyPercentButton, _sixtyFivePercentButton, _seventyPercentButton,
                                          _seventyFivePercentButton, _eightyPercentButton, _eightyFivePercentButton, _ninetyPercentButton,
                                          _ninetyFivePercentButton, _oneHundredPercentButton };

            Debug.Assert(_buttons.Count == ColorManager.Percentages.Length);

            refreshButtonDisplay();
        }

        private int _currentEditIndex = 0;

        private void launchColorForm()
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AnyColor = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorManager.Instance.ColorizationSettings[_currentEditIndex] = dialog.Color;
                refreshButtonDisplay();
                ItemShop.Instance.SaveSettings();
            }
        }

        private void refreshButtonDisplay()
        {
            for (int i = 0; i < ColorManager.Instance.ColorizationSettings.Count; i++)
            {
                Color color = ColorManager.Instance.GetColorFromPercentage(ColorManager.Percentages[i]);
                _buttons[i].BackColor = color;
                //_buttons[i].ForeColor = color;
                //_buttons[i].Font = new Font(_buttons[i].Font.FontFamily, 6);
                //_buttons[i].Text = "(" + color.R + ", " + color.G + ", " + color.B + ")";
            }
        }

        #region DataBindings

        /// <summary>
        /// Data binding for -5% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onNegativeFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 0;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 0% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onZeroPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 1;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 5% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 2;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 10% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onTenPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 3;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 15% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFifteenPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 4;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 20% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onTwentyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 5;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 25% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onTwentyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 6;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 30% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onThirtyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 7;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 35% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onThirtyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 8;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 40% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFortyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 9;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 45% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFortyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 10;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 50% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFiftyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 11;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 55% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFiftyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 12;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 60% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSixtyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 13;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 65% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSixtyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 14;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 70% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSeventyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 15;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 75% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSeventyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 16;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 80% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onEightyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 17;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 85% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onEightyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 18;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 90% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onNinetyPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 19;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 95% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onNinetyFivePercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 20;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for 100% button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onOneHundredPercentButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 21;
            launchColorForm();
        }

        #endregion
    }
}

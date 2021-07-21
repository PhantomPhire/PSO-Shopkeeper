﻿using PSOShopkeeper;
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
                                          _ninetyFivePercentButton, _oneHundredPercentButton, _drawButton, _drainButton, _fillButton,
                                          _gushButton, _heartButton, _mindButton, _soulButton, _geistButton, _mastersButton, _lordsButton,
                                          _kingsButton, _chargeButton, _spiritButton, _berserkButton, _iceButton, _frostButton, _freezeButton,
                                          _blizzardButton, _bindButton, _holdButton, _seizeButton, _arrestButton, _heatButton, _fireButton,
                                          _flameButton, _burningButton, _shockButton, _thunderButton, _stormButton, _tempestButton,
                                          _dimButton, _shadowButton, _darkButton, _hellButton, _panicButton, _riotButton, _havocButton,
                                          _chaosButton, _devilsButton, _demonsButton, _otherButton };

            refreshButtonDisplay();
        }

        /// <summary>
        /// The current index being edited
        /// </summary>
        private int _currentEditIndex = 0;

        /// <summary>
        /// Launches the color dialog to allow the user to select a color
        /// </summary>
        private void launchColorForm()
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AnyColor = true;
            dialog.FullOpen = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorManager.Instance.ColorizationSettings[_currentEditIndex] = dialog.Color;
                refreshButtonDisplay();
                ItemShop.Instance.SaveSettings();
            }
        }

        /// <summary>
        /// Refreshes all button colors
        /// </summary>
        private void refreshButtonDisplay()
        {
            for (int i = 0; i < ColorManager.Instance.ColorizationSettings.Count; i++)
            {
                Color color = ColorManager.Instance.ColorizationSettings[i];
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

        /// <summary>
        /// Data binding for draw button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onDrawButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 22;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for drain button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onDrainButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 23;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for fill button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFillButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 24;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for gush button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onGushButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 25;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for heart button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onHeartButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 26;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for mind button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onMindButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 27;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for soul button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSoulButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 28;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for geist button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onGeistButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 29;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for masters button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onMastersButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 30;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for lords button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onLordsButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 31;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for kings button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onKingsButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 32;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for charge button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onChargeButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 33;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for spirit button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSpiritButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 34;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for berserk button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onBerserkButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 35;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for ice button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onIceButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 36;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for frost button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFrostButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 37;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for freeze button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFreezeButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 38;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for blizzard button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onBlizzardButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 39;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for bind button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onBindButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 40;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for hold button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onHoldButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 41;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for seize button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onSeizeButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 42;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for arrest button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onArrestButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 43;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for heat button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onHeatButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 44;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for fire button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFireButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 45;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for flame button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onFlameButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 46;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for burning button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onBurningButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 47;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for shock button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onShockButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 48;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for thunder button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onThunderButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 49;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for storm button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onStormButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 50;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for tempest button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onTempestButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 51;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for dim button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onDimButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 52;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for shadow button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onShadowButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 53;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for dark button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onDarkButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 54;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for hell button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onHellButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 55;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for panic button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onPanicButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 56;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for riot button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onRiotButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 57;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for havoc button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onHavocButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 58;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for chaos button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onChaosButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 59;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for devils button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onDevilsButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 60;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for demons button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onDemonsButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 61;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for other button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onOtherButtonClicked(object sender, EventArgs e)
        {
            _currentEditIndex = 62;
            launchColorForm();
        }

        /// <summary>
        /// Data binding for other button clicked
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onResetButtonClicked(object sender, EventArgs e)
        {
            ColorManager.Instance.ResetColorsToDefault();
            refreshButtonDisplay();
            ItemShop.Instance.SaveSettings();
        }

        #endregion
    }
}
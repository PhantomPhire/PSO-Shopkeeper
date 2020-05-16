using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PSOShopkeeperLib.Item;
using PSOShopkeeperLib.JSON;

namespace PSODBHelper
{
    /// <summary>
    /// Form used to aid in construction with PSO item database
    /// </summary>
    public partial class PSODBForm : Form
    {
        /// <summary>
        /// Indicates the form has been initialized. Prevents usage of combo boxes before they are populated
        /// </summary>
        private bool _initialized = false;

        /// <summary>
        /// Indicates that the form is in replace item mode. In this mode, items will be replaced instead of adding to the item list
        /// </summary>
        private bool _replaceItem = false;

        /// <summary>
        /// A simple lock used to prevent infinite recursion if an item with data bindings is interacted with in a function
        /// </summary>
        private bool _lock = false;

        /// <summary>
        /// Initializes a new instance of the PSODBForm class
        /// </summary>
        public PSODBForm()
        {
            InitializeComponent();
            populateComboBoxes();
            _initialized = true;
            refreshEntryList();
        }

        /// <summary>
        /// Populates combo boxes with their enumerated values
        /// </summary>
        private void populateComboBoxes()
        {
            foreach (ItemType itemType in Enum.GetValues(typeof(ItemType)))
            {
                if ((int)itemType == 0)
                {
                    continue;
                }

                _itemTypeCombo.Items.Add(Enum.GetName(typeof(ItemType), itemType));
            }
            _itemTypeCombo.SelectedIndex = 0;

            foreach (WeaponType weaponType in Enum.GetValues(typeof(WeaponType)))
            {
                if ((int)weaponType == 0)
                {
                    continue;
                }

                _weaponTypeCombo.Items.Add(Enum.GetName(typeof(WeaponType), weaponType));
            }
            _weaponTypeCombo.SelectedIndex = 0;

            foreach (SpecialType special in Enum.GetValues(typeof(SpecialType)))
            {
                _specialCombo.Items.Add(Enum.GetName(typeof(SpecialType), special));
            }
            _specialCombo.SelectedIndex = 0;

            foreach (TechniqueType techType in Enum.GetValues(typeof(TechniqueType)))
            {
                if ((int)techType == 0)
                {
                    continue;
                }

                _techTypeCombo.Items.Add(Enum.GetName(typeof(TechniqueType), techType));
            }
            _techTypeCombo.SelectedIndex = 0;

            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                _pbTriggerCombo.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            _pbTriggerCombo.SelectedIndex = 0;

            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                _hpTriggerCombo.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            _hpTriggerCombo.SelectedIndex = 0;

            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                _bossTriggerCombo.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            _bossTriggerCombo.SelectedIndex = 0;
        }

        /// <summary>
        /// Sets default values for applicble items
        /// </summary>
        private void setItemDefaults()
        {
            ItemType itemType = (ItemType)(_itemTypeCombo.SelectedIndex + 1);

            switch (itemType)
            {
                case ItemType.Weapon:
                    setWeaponDefaults();
                    break;
                case ItemType.Frame:
                case ItemType.Barrier:
                    setDefenseDefaults();
                    break;
                case ItemType.Unit:
                    setUnitDefaults();
                    break;
                case ItemType.Mag:
                    setMagDefaults();
                    break;
                case ItemType.Technique:
                    setTechniqueDefaults();
                    break;
                case ItemType.Tool:
                    setToolDefaults();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sets default values applicable to weapons
        /// </summary>
        private void setWeaponDefaults()
        {
            _weaponsBox.Enabled = true;
            _statsBox.Enabled = true;
            _equipsBox.Enabled = true;
            _magBox.Enabled = false;
            _frameBox.Enabled = false;
            _resistancesBox.Enabled = false;
            _techBox.Enabled = false;
            _toolBox.Enabled = false;
            setDefaultValues();
        }

        /// <summary>
        /// Sets default values applicable to defense items
        /// </summary>
        private void setDefenseDefaults()
        {
            _weaponsBox.Enabled = false;
            _statsBox.Enabled = true;
            _equipsBox.Enabled = true;
            _magBox.Enabled = false;
            _frameBox.Enabled = true;
            _resistancesBox.Enabled = true;
            _techBox.Enabled = false;
            _toolBox.Enabled = false;
            setDefaultValues();
        }

        /// <summary>
        /// Sets default values applicable to units
        /// </summary>
        private void setUnitDefaults()
        {
            _weaponsBox.Enabled = false;
            _statsBox.Enabled = true;
            _equipsBox.Enabled = true;
            _magBox.Enabled = false;
            _frameBox.Enabled = false;
            _resistancesBox.Enabled = true;
            _techBox.Enabled = false;
            _toolBox.Enabled = false;
            setDefaultValues();
        }

        /// <summary>
        /// Sets default values applicable to mag
        /// </summary>
        private void setMagDefaults()
        {
            _weaponsBox.Enabled = false;
            _statsBox.Enabled = false;
            _equipsBox.Enabled = false;
            _magBox.Enabled = true;
            _frameBox.Enabled = false;
            _resistancesBox.Enabled = false;
            _techBox.Enabled = false;
            _toolBox.Enabled = false;
            setDefaultValues();
        }

        /// <summary>
        /// Sets default values applicable to technique discs
        /// </summary>
        private void setTechniqueDefaults()
        {
            _weaponsBox.Enabled = false;
            _statsBox.Enabled = false;
            _equipsBox.Enabled = false;
            _magBox.Enabled = false;
            _frameBox.Enabled = false;
            _resistancesBox.Enabled = true;
            _techBox.Enabled = true;
            _toolBox.Enabled = false;
            setDefaultValues();
        }

        /// <summary>
        /// Sets default values applicable to tools
        /// </summary>
        private void setToolDefaults()
        {
            _weaponsBox.Enabled = false;
            _statsBox.Enabled = false;
            _equipsBox.Enabled = false;
            _magBox.Enabled = false;
            _frameBox.Enabled = false;
            _resistancesBox.Enabled = true;
            _techBox.Enabled = false;
            _toolBox.Enabled = true;
            setDefaultValues();
        }

        /// <summary>
        /// Sets default values applicable to all items
        /// </summary>
        private void setDefaultValues()
        {
            _hexText.Text = "000000";
            _rarityText.Text = "0";
            _rareCheck.Checked = false;
            _maxStackText.Text = "1";
            _hpText.Text = "0";
            _tpText.Text = "0";
            _atpText.Text = "0";
            _dfpText.Text = "0";
            _mstText.Text = "0";
            _ataText.Text = "0";
            _evpText.Text = "0";
            _lckText.Text = "0";
            _HUmarCheck.Checked = true;
            _HUnewearlCheck.Checked = true;
            _HUcastCheck.Checked = true;
            _HUcasealCheck.Checked = true;
            _RAmarCheck.Checked = true;
            _RAmarlCheck.Checked = true;
            _RAcastCheck.Checked = true;
            _RAcasealCheck.Checked = true;
            _FOmarCheck.Checked = true; 
            _FOmarlCheck.Checked = true;
            _FOnewmCheck.Checked = true;
            _FOnewearlCheck.Checked = true;
            _triggerPercentageText.Text = "0";
            _targetsText.Text = "1";
            _maxGrindText.Text = "0";
            _minATPText.Text = "0";
            _maxATPText.Text = "0";
            _requirementATPText.Text = "0";
            _requirementATAText.Text = "0";
            _requirementMSTText.Text = "0";
            _requirementLevelText.Text = "0";
            _maxDFPText.Text = "0";
            _maxEVPText.Text = "0";
            _efrText.Text = "0";
            _eicText.Text = "0";
            _ethText.Text = "0";
            _eltText.Text = "0";
            _edkText.Text = "0";

            if (_initialized)
            {
                _pbTriggerCombo.SelectedIndex = 0;
                _hpTriggerCombo.SelectedIndex = 0;
                _bossTriggerCombo.SelectedIndex = 0;
                _specialCombo.SelectedIndex = 0;
                _techTypeCombo.SelectedIndex = 0;
            }

            if (_entryCombo.SelectedIndex != _entryCombo.Items.Count - 1)
            {
                setToItemJSON();
            }
        }

        /// <summary>
        /// Adds item to database based on current state of form
        /// </summary>
        private void addItem()
        {
            ItemJSON item = formToJSON();

            if (item != null)
            {
                ItemDatabaseJSON.Instance.AddItem(item);
                _nameText.Text = String.Empty;
                refreshEntryList();
            }
        }

        /// <summary>
        /// Replaces item in database based on form
        /// </summary>
        private void replaceItem()
        {
            ItemJSON item = formToJSON();

            if (item != null)
            {
                ItemDatabaseJSON.Instance.ReplaceItem(item);
            }
        }

        /// <summary>
        /// Sets the form to add item mode
        /// </summary>
        private void setAddItemMode()
        {
            _replaceItem = false;
            _addItemButton.Text = "Add Item";
        }

        /// <summary>
        /// Sets the form to replace item mode
        /// </summary>
        private void setReplaceItemMode()
        {
            _replaceItem = true;
            _addItemButton.Text = "Replace Item";
        }

        /// <summary>
        /// Refreshes entry list to the current state of the database
        /// </summary>
        private void refreshEntryList()
        {
            if (_lock)
            {
                return;
            }

            _lock = true;

            _entryCombo.Items.Clear();
            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                _entryCombo.Items.Add(kvp.Key);
            }
            _entryCombo.Items.Add("<NEW>");
            _entryCombo.SelectedIndex = _entryCombo.Items.Count - 1;

            _lock = false;
        }

        /// <summary>
        /// Converts the current state of the form to an ItemJSON object
        /// </summary>
        /// <returns>An ItemJSON object based on the current state of the form</returns>
        private ItemJSON formToJSON()
        {
            ItemJSON item = new ItemJSON();
            ItemType itemType = (ItemType)(_itemTypeCombo.SelectedIndex + 1);

            try
            {
                item.Type = Enum.GetName(typeof(ItemType), _itemTypeCombo.SelectedIndex + 1);
                item.Name = _nameText.Text;
                item.Hex = _hexText.Text;
                item.Rarity = int.Parse(_rarityText.Text);
                item.Rare = _rareCheck.Checked;
                item.MaxStack = int.Parse(_maxStackText.Text);
                item.HP = int.Parse(_hpText.Text);
                item.TP = int.Parse(_tpText.Text);
                item.ATP = int.Parse(_atpText.Text);
                item.DFP = int.Parse(_dfpText.Text);
                item.MST = int.Parse(_mstText.Text);
                item.ATA = int.Parse(_ataText.Text);
                item.EVP = int.Parse(_evpText.Text);
                item.LCK = int.Parse(_lckText.Text);
                item.EFR = int.Parse(_efrText.Text);
                item.EIC = int.Parse(_eicText.Text);
                item.ETH = int.Parse(_ethText.Text);
                item.ELT = int.Parse(_eltText.Text);
                item.EDK = int.Parse(_edkText.Text);

                item.EquipMask = 0;

                if (_HUmarCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUmarMask;
                }
                if (_HUnewearlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUnewearlMask;
                }
                if (_HUcastCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUcastMask;
                }
                if (_HUcasealCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUcasealMask;
                }
                if (_RAmarCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAmarMask;
                }
                if (_RAmarlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAmarlMask;
                }
                if (_RAcastCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAcastMask;
                }
                if (_RAcasealCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAcasealMask;
                }
                if (_FOmarCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOmarMask;
                }
                if (_FOmarlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOmarlMask;
                }
                if (_FOnewmCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOnewmMask;
                }
                if (_FOnewearlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOnewearlMask;
                }

                if (itemType == ItemType.Weapon)
                {
                    item.WeaponType = Enum.GetName(typeof(WeaponType), _weaponTypeCombo.SelectedIndex + 1);
                    item.Special = Enum.GetName(typeof(SpecialType), _specialCombo.SelectedIndex);
                    item.Targets = int.Parse(_targetsText.Text);
                    item.MaxGrind = int.Parse(_maxGrindText.Text);
                    item.MinATP = int.Parse(_minATPText.Text);
                    item.MaxATP = int.Parse(_maxATPText.Text);
                    item.RequirementATP = int.Parse(_requirementATPText.Text);
                    item.RequirementATA = int.Parse(_requirementATAText.Text);
                    item.RequirementMST = int.Parse(_requirementMSTText.Text);
                }
                else if (itemType == ItemType.Frame || itemType == ItemType.Barrier)
                {
                    item.RequirementLevel = int.Parse(_requirementLevelText.Text);
                    item.MaxDFP = int.Parse(_maxDFPText.Text);
                    item.MaxEVP = int.Parse(_maxEVPText.Text);
                }
                else if (itemType == ItemType.Mag)
                {
                    item.PBTrigger = Enum.GetName(typeof(Mag.TriggerType), _pbTriggerCombo.SelectedIndex);
                    item.HPTrigger = Enum.GetName(typeof(Mag.TriggerType), _hpTriggerCombo.SelectedIndex);
                    item.BossTrigger = Enum.GetName(typeof(Mag.TriggerType), _bossTriggerCombo.SelectedIndex);
                    item.TriggerPercentage = int.Parse(_triggerPercentageText.Text);
                }
                else if (itemType == ItemType.Technique)
                {
                    item.TechType = Enum.GetName(typeof(TechniqueType), _techTypeCombo.SelectedIndex + 1);
                }

                return item;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! One or more fields not formatted properly!\n\n" + ex.ToString(),
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Sets the form values based on an ItemJSON object
        /// </summary>
        private void setToItemJSON()
        {
            ItemJSON item = null;

            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                if (kvp.Key == _nameText.Text)
                {
                    item = kvp.Value;
                    break;
                }
            }

            if (item == null)
            {
                return;
            }

            try
            {
                _itemTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(ItemType), item.Type) - 1;
                _nameText.Text = item.Name;
                _hexText.Text = item.Hex;
                _rarityText.Text = item.Rarity.ToString();
                _rareCheck.Checked = item.Rare;
                _maxStackText.Text = item.MaxStack.ToString();
                _hpText.Text = item.HP.ToString();
                _tpText.Text = item.TP.ToString();
                _atpText.Text = item.ATP.ToString();
                _dfpText.Text = item.DFP.ToString();
                _mstText.Text = item.MST.ToString();
                _ataText.Text = item.ATA.ToString();
                _evpText.Text = item.EVP.ToString();
                _lckText.Text = item.LCK.ToString();
                _efrText.Text = item.EFR.ToString();
                _eicText.Text = item.EIC.ToString();
                _ethText.Text = item.ETH.ToString();
                _eltText.Text = item.ELT.ToString();
                _edkText.Text = item.EDK.ToString();
                _HUmarCheck.Checked = (item.EquipMask & EquippableItem.HUmarMask) > 0;
                _HUnewearlCheck.Checked = (item.EquipMask & EquippableItem.HUnewearlMask) > 0;
                _HUcastCheck.Checked = (item.EquipMask & EquippableItem.HUcastMask) > 0;
                _HUcasealCheck.Checked = (item.EquipMask & EquippableItem.HUcasealMask) > 0;
                _RAmarCheck.Checked = (item.EquipMask & EquippableItem.RAmarMask) > 0;
                _RAmarlCheck.Checked = (item.EquipMask & EquippableItem.RAmarlMask) > 0;
                _RAcastCheck.Checked = (item.EquipMask & EquippableItem.RAcastMask) > 0;
                _RAcasealCheck.Checked = (item.EquipMask & EquippableItem.RAcasealMask) > 0;
                _FOmarCheck.Checked = (item.EquipMask & EquippableItem.FOmarMask) > 0;
                _FOmarlCheck.Checked = (item.EquipMask & EquippableItem.FOmarlMask) > 0;
                _FOnewmCheck.Checked = (item.EquipMask & EquippableItem.FOnewmMask) > 0;
                _FOnewearlCheck.Checked = (item.EquipMask & EquippableItem.FOnewearlMask) > 0;
                _weaponTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(WeaponType), item.WeaponType) - 1;
                _specialCombo.SelectedIndex = (int)Enum.Parse(typeof(SpecialType), item.Special);
                _targetsText.Text = item.Targets.ToString();
                _maxGrindText.Text = item.MaxGrind.ToString();
                _minATPText.Text = item.MinATP.ToString();
                _maxATPText.Text = item.MaxATP.ToString();
                _requirementATPText.Text = item.RequirementATP.ToString();
                _requirementATAText.Text = item.RequirementATA.ToString();
                _requirementMSTText.Text = item.RequirementMST.ToString();
                _requirementLevelText.Text = item.RequirementLevel.ToString();
                _maxDFPText.Text = item.MaxDFP.ToString();
                _maxEVPText.Text = item.MaxEVP.ToString();
                _pbTriggerCombo.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.PBTrigger);
                _hpTriggerCombo.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.HPTrigger);
                _bossTriggerCombo.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.BossTrigger);
                _triggerPercentageText.Text = item.TriggerPercentage.ToString();
                _techTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(TechniqueType), item.TechType) - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Ill-formatted data!\n\n" + ex.ToString(),
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #region DataBindings

        /// <summary>
        /// Data binding for Add Item/Replace Item button click
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onAddItemClicked(object sender, EventArgs e)
        {
            if (!_replaceItem)
            {
                addItem();
            }
            else
            {
                replaceItem();
            }
        }

        /// <summary>
        /// Data binding for Remove Item button click
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onRemoveClicked(object sender, EventArgs e)
        {
            ItemJSON item = formToJSON();

            if (item != null)
            {
                ItemDatabaseJSON.Instance.RemoveItem(item);
                refreshEntryList();
            }
        }

        /// <summary>
        /// Data binding for item type combo box on change
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onItemTypeSelected(object sender, EventArgs e)
        {
            setItemDefaults();
        }

        /// <summary>
        /// Data binding for entry selection combo box on change
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onEntryComboChanged(object sender, EventArgs e)
        {
            if (_lock)
            {
                return;
            }

            _lock = true;

            ItemJSON item = null;

            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                if (kvp.Key == _entryCombo.Text)
                {
                    item = kvp.Value;
                    _itemTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(ItemType), item.Type) - 1;
                    _nameText.Text = item.Name;
                    break;
                }
            }

            if (item == null)
            {
                setAddItemMode();
            }
            else
            {
                setReplaceItemMode();
            }

            setItemDefaults();

            _lock = false;
        }

        /// <summary>
        /// Data binding for name text box on change
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onNameTextChanged(object sender, EventArgs e)
        {
            if (_lock)
            {
                return;
            }

            _lock = true;

            ItemJSON item = null;

            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                if (kvp.Key.ToLower() == _nameText.Text.ToLower())
                {
                    item = kvp.Value;
                    _itemTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(ItemType), item.Type) - 1;
                    _nameText.Text = item.Name;

                    for (int i = 0; i < _entryCombo.Items.Count; i++)
                    {
                        if (_entryCombo.Items[i].ToString().ToLower() == kvp.Key.ToLower())
                        {
                            _entryCombo.SelectedIndex = i;
                            break;
                        }    
                    }

                    break;
                }
            }

            if (item == null)
            {
                setAddItemMode();
                _entryCombo.SelectedIndex = _entryCombo.Items.Count - 1;
            }
            else
            {
                setReplaceItemMode();
            }

            setItemDefaults();

            _lock = false;
        }

        #endregion
    }
}

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
            _itemTypeCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _itemTypeCombo.AutoCompleteMode = AutoCompleteMode.Append;
            foreach (ItemType itemType in Enum.GetValues(typeof(ItemType)))
            {
                if ((int)itemType == 0)
                {
                    continue;
                }

                _itemTypeCombo.Items.Add(Enum.GetName(typeof(ItemType), itemType));
                _itemTypeCombo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(ItemType), itemType));
            }
            _itemTypeCombo.SelectedIndex = 0;

            _weaponTypeCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _weaponTypeCombo.AutoCompleteMode = AutoCompleteMode.Append;
            foreach (WeaponType weaponType in Enum.GetValues(typeof(WeaponType)))
            {
                _weaponTypeCombo.Items.Add(Enum.GetName(typeof(WeaponType), weaponType));
                _weaponTypeCombo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(WeaponType), weaponType));
            }
            _weaponTypeCombo.SelectedIndex = 0;

            _specialCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _specialCombo.AutoCompleteMode = AutoCompleteMode.Append;
            foreach (SpecialType special in Enum.GetValues(typeof(SpecialType)))
            {
                _specialCombo.Items.Add(Enum.GetName(typeof(SpecialType), special));
                _specialCombo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(SpecialType), special));
            }
            _specialCombo.SelectedIndex = 0;

            _techTypeCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _techTypeCombo.AutoCompleteMode = AutoCompleteMode.Append;
            foreach (TechniqueType techType in Enum.GetValues(typeof(TechniqueType)))
            {
                if ((int)techType == 0)
                {
                    continue;
                }

                _techTypeCombo.Items.Add(Enum.GetName(typeof(TechniqueType), techType));
                _techTypeCombo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(TechniqueType), techType));
            }
            _techTypeCombo.SelectedIndex = 0;

            _pbTriggerCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _pbTriggerCombo.AutoCompleteMode = AutoCompleteMode.Append;
            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                _pbTriggerCombo.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
                _pbTriggerCombo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            _pbTriggerCombo.SelectedIndex = 0;

            _hpTriggerCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _hpTriggerCombo.AutoCompleteMode = AutoCompleteMode.Append;
            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                _hpTriggerCombo.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
                _hpTriggerCombo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            _hpTriggerCombo.SelectedIndex = 0;

            _bossTriggerCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _bossTriggerCombo.AutoCompleteMode = AutoCompleteMode.Append;
            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                _bossTriggerCombo.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
                _bossTriggerCombo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            _bossTriggerCombo.SelectedIndex = 0;

            _entryCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _entryCombo.AutoCompleteMode = AutoCompleteMode.Append;
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
            _resistancesBox.Enabled = true;
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
            _resistancesBox.Enabled = false;
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
            _resistancesBox.Enabled = false;
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
            _sRankCheck.Checked = false;
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
            }

            if (_entryCombo.SelectedIndex != _entryCombo.Items.Count - 1)
            {
                setFormToItemJSON();
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
                //_nameText.Text = String.Empty;
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
            _entryCombo.AutoCompleteCustomSource.Clear();
            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                _entryCombo.Items.Add(kvp.Key);
                _entryCombo.AutoCompleteCustomSource.Add(kvp.Key);
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
                ItemStatsJSON stats = null;
                ItemResistancesJSON resistances = null;
 
                item.Type = Enum.GetName(typeof(ItemType), _itemTypeCombo.SelectedIndex + 1);
                item.Name = _nameText.Text;
                item.Hex = _hexText.Text;
                item.Rarity = int.Parse(_rarityText.Text);
                item.MaxStack = int.Parse(_maxStackText.Text);

                if (itemType == ItemType.Weapon)
                {
                    item.Weapon = new ItemWeaponJSON();
                    item.Weapon.WeaponType = Enum.GetName(typeof(WeaponType), _weaponTypeCombo.SelectedIndex);
                    item.Weapon.Special = Enum.GetName(typeof(SpecialType), _specialCombo.SelectedIndex);
                    item.Weapon.Targets = int.Parse(_targetsText.Text);
                    item.Weapon.MaxGrind = int.Parse(_maxGrindText.Text);
                    item.Weapon.MinATP = int.Parse(_minATPText.Text);
                    item.Weapon.MaxATP = int.Parse(_maxATPText.Text);
                    item.Weapon.RequirementATP = int.Parse(_requirementATPText.Text);
                    item.Weapon.RequirementATA = int.Parse(_requirementATAText.Text);
                    item.Weapon.RequirementMST = int.Parse(_requirementMSTText.Text);
                    item.Weapon.SRank = _sRankCheck.Checked;
                    stats = item.Weapon.Stats;
                    resistances = item.Weapon.Resistances;
                    item.Weapon.EquipMask = getEquipMask();
                }
                else if (itemType == ItemType.Frame || itemType == ItemType.Barrier)
                {
                    item.Defense = new ItemDefenseJSON();
                    item.Defense.RequirementLevel = int.Parse(_requirementLevelText.Text);
                    item.Defense.MaxDFP = int.Parse(_maxDFPText.Text);
                    item.Defense.MaxEVP = int.Parse(_maxEVPText.Text);
                    stats = item.Defense.Stats;
                    resistances = item.Defense.Resistances;
                    item.Defense.EquipMask = getEquipMask();
                }
                else if (itemType == ItemType.Unit)
                {
                    item.Unit = new ItemUnitJSON();
                    stats = item.Unit.Stats;
                    resistances = item.Unit.Resistances;
                    item.Unit.EquipMask = getEquipMask();
                }
                else if (itemType == ItemType.Mag)
                {
                    item.Mag = new ItemMagJSON();
                    item.Mag.PBTrigger = Enum.GetName(typeof(Mag.TriggerType), _pbTriggerCombo.SelectedIndex);
                    item.Mag.HPTrigger = Enum.GetName(typeof(Mag.TriggerType), _hpTriggerCombo.SelectedIndex);
                    item.Mag.BossTrigger = Enum.GetName(typeof(Mag.TriggerType), _bossTriggerCombo.SelectedIndex);
                    item.Mag.TriggerPercentage = int.Parse(_triggerPercentageText.Text);
                }
                else if (itemType == ItemType.Technique)
                {
                    item.Technique = new ItemTechniqueJSON();
                    item.Technique.TechType = Enum.GetName(typeof(TechniqueType), _techTypeCombo.SelectedIndex + 1);
                    item.Technique.RequirementMST = int.Parse(_techMSTRequired.Text);
                }
                else if (itemType == ItemType.Tool)
                {
                    item.Tool = new ItemToolJSON();
                    item.Tool.Rare = _rareCheck.Checked;
                }

                if (stats != null)
                {
                    stats.HP = int.Parse(_hpText.Text);
                    stats.TP = int.Parse(_tpText.Text);
                    stats.ATP = int.Parse(_atpText.Text);
                    stats.DFP = int.Parse(_dfpText.Text);
                    stats.MST = int.Parse(_mstText.Text);
                    stats.ATA = double.Parse(_ataText.Text);
                    stats.EVP = int.Parse(_evpText.Text);
                    stats.LCK = int.Parse(_lckText.Text);
                }
                if (resistances != null)
                {
                    resistances.EFR = int.Parse(_efrText.Text);
                    resistances.EIC = int.Parse(_eicText.Text);
                    resistances.ETH = int.Parse(_ethText.Text);
                    resistances.ELT = int.Parse(_eltText.Text);
                    resistances.EDK = int.Parse(_edkText.Text);
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
        /// Gets the equip mask based on the current state of check boxes
        /// </summary>
        /// <returns>The current equip mask</returns>
        private int getEquipMask()
        {
            int mask = 0;

            if (_HUmarCheck.Checked)
            {
                mask |= EquippableItem.HUmarMask;
            }
            if (_HUnewearlCheck.Checked)
            {
                mask |= EquippableItem.HUnewearlMask;
            }
            if (_HUcastCheck.Checked)
            {
                mask |= EquippableItem.HUcastMask;
            }
            if (_HUcasealCheck.Checked)
            {
                mask |= EquippableItem.HUcasealMask;
            }
            if (_RAmarCheck.Checked)
            {
                mask |= EquippableItem.RAmarMask;
            }
            if (_RAmarlCheck.Checked)
            {
                mask |= EquippableItem.RAmarlMask;
            }
            if (_RAcastCheck.Checked)
            {
                mask |= EquippableItem.RAcastMask;
            }
            if (_RAcasealCheck.Checked)
            {
                mask |= EquippableItem.RAcasealMask;
            }
            if (_FOmarCheck.Checked)
            {
                mask |= EquippableItem.FOmarMask;
            }
            if (_FOmarlCheck.Checked)
            {
                mask |= EquippableItem.FOmarlMask;
            }
            if (_FOnewmCheck.Checked)
            {
                mask |= EquippableItem.FOnewmMask;
            }
            if (_FOnewearlCheck.Checked)
            {
                mask |= EquippableItem.FOnewearlMask;
            }

            return mask;
        }

        /// <summary>
        /// Sets the form values based on an ItemJSON object
        /// </summary>
        private void setFormToItemJSON()
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
                _maxStackText.Text = item.MaxStack.ToString();

                if (item.Weapon != null)
                {
                    _weaponTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(WeaponType), item.Weapon.WeaponType);
                    _specialCombo.SelectedIndex = (int)Enum.Parse(typeof(SpecialType), item.Weapon.Special);
                    _targetsText.Text = item.Weapon.Targets.ToString();
                    _maxGrindText.Text = item.Weapon.MaxGrind.ToString();
                    _minATPText.Text = item.Weapon.MinATP.ToString();
                    _maxATPText.Text = item.Weapon.MaxATP.ToString();
                    _requirementATPText.Text = item.Weapon.RequirementATP.ToString();
                    _requirementATAText.Text = item.Weapon.RequirementATA.ToString();
                    _requirementMSTText.Text = item.Weapon.RequirementMST.ToString();
                    _sRankCheck.Checked = item.Weapon.SRank;
                    setStatsToItemJSON(item.Weapon.Stats);
                    setResistancesToItemJSON(item.Weapon.Resistances);
                    setEquipsToItemJSON(item.Weapon.EquipMask);
                }
                else if (item.Defense != null)
                {
                    _requirementLevelText.Text = item.Defense.RequirementLevel.ToString();
                    _maxDFPText.Text = item.Defense.MaxDFP.ToString();
                    _maxEVPText.Text = item.Defense.MaxEVP.ToString();
                    setStatsToItemJSON(item.Defense.Stats);
                    setResistancesToItemJSON(item.Defense.Resistances);
                    setEquipsToItemJSON(item.Defense.EquipMask);
                }
                else if (item.Unit != null)
                {
                    setStatsToItemJSON(item.Unit.Stats);
                    setResistancesToItemJSON(item.Unit.Resistances);
                    setEquipsToItemJSON(item.Unit.EquipMask);
                }
                else if (item.Mag != null)
                {
                    _pbTriggerCombo.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.Mag.PBTrigger);
                    _hpTriggerCombo.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.Mag.HPTrigger);
                    _bossTriggerCombo.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.Mag.BossTrigger);
                    _triggerPercentageText.Text = item.Mag.TriggerPercentage.ToString();
                }
                else if (item.Technique != null)
                {
                    _techTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(TechniqueType), item.Technique.TechType) - 1;
                    _techMSTRequired.Text = item.Technique.RequirementMST.ToString();
                }
                else if (item.Tool != null)
                {
                    _rareCheck.Checked = item.Tool.Rare;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Ill-formatted data!\n\n" + ex.ToString(),
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets the form's stats to item JSON
        /// </summary>
        /// <param name="stats">The stats to set to</param>
        private void setStatsToItemJSON(ItemStatsJSON stats)
        {
            _hpText.Text = stats.HP.ToString();
            _tpText.Text = stats.TP.ToString();
            _atpText.Text = stats.ATP.ToString();
            _dfpText.Text = stats.DFP.ToString();
            _mstText.Text = stats.MST.ToString();
            _ataText.Text = stats.ATA.ToString();
            _evpText.Text = stats.EVP.ToString();
            _lckText.Text = stats.LCK.ToString();
        }

        /// <summary>
        /// Sets the form's resistances to item JSON
        /// </summary>
        /// <param name="resistances">The resistances to set to</param>
        private void setResistancesToItemJSON(ItemResistancesJSON resistances)
        {
            _efrText.Text = resistances.EFR.ToString();
            _eicText.Text = resistances.EIC.ToString();
            _ethText.Text = resistances.ETH.ToString();
            _eltText.Text = resistances.ELT.ToString();
            _edkText.Text = resistances.EDK.ToString();
        }

        /// <summary>
        /// Sets the form's equips to item JSON
        /// </summary>
        /// <param name="equip">The equip mask to set to</param>
        private void setEquipsToItemJSON(int equip)
        {
            _HUmarCheck.Checked = (equip & EquippableItem.HUmarMask) > 0;
            _HUnewearlCheck.Checked = (equip & EquippableItem.HUnewearlMask) > 0;
            _HUcastCheck.Checked = (equip & EquippableItem.HUcastMask) > 0;
            _HUcasealCheck.Checked = (equip & EquippableItem.HUcasealMask) > 0;
            _RAmarCheck.Checked = (equip & EquippableItem.RAmarMask) > 0;
            _RAmarlCheck.Checked = (equip & EquippableItem.RAmarlMask) > 0;
            _RAcastCheck.Checked = (equip & EquippableItem.RAcastMask) > 0;
            _RAcasealCheck.Checked = (equip & EquippableItem.RAcasealMask) > 0;
            _FOmarCheck.Checked = (equip & EquippableItem.FOmarMask) > 0;
            _FOmarlCheck.Checked = (equip & EquippableItem.FOmarlMask) > 0;
            _FOnewmCheck.Checked = (equip & EquippableItem.FOnewmMask) > 0;
            _FOnewearlCheck.Checked = (equip & EquippableItem.FOnewearlMask) > 0;
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

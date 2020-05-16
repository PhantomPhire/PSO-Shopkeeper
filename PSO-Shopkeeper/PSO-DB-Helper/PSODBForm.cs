using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSOShopkeeperLib.Item;
using PSOShopkeeperLib.JSON;

namespace PSO_DB_Helper
{
    public partial class PSODBForm : Form
    {
        private bool _initialized = false;

        public PSODBForm()
        {
            InitializeComponent();
            populateItems();
            _initialized = true;
            refreshEntryList();
        }

        private void populateItems()
        {
            foreach (ItemType itemType in Enum.GetValues(typeof(ItemType)))
            {
                if ((int)itemType == 0)
                {
                    continue;
                }

                ItemTypeCombo.Items.Add(Enum.GetName(typeof(ItemType), itemType));
            }
            ItemTypeCombo.SelectedIndex = 0;

            foreach (WeaponType weaponType in Enum.GetValues(typeof(WeaponType)))
            {
                if ((int)weaponType == 0)
                {
                    continue;
                }

                WeaponTypeCombo.Items.Add(Enum.GetName(typeof(WeaponType), weaponType));
            }
            WeaponTypeCombo.SelectedIndex = 0;

            foreach (SpecialType special in Enum.GetValues(typeof(SpecialType)))
            {
                SpecialCombo.Items.Add(Enum.GetName(typeof(SpecialType), special));
            }
            SpecialCombo.SelectedIndex = 0;

            foreach (TechniqueType techType in Enum.GetValues(typeof(TechniqueType)))
            {
                if ((int)techType == 0)
                {
                    continue;
                }

                TechTypeBox.Items.Add(Enum.GetName(typeof(TechniqueType), techType));
            }
            TechTypeBox.SelectedIndex = 0;

            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                PBTriggerBox.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            PBTriggerBox.SelectedIndex = 0;

            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                HPTriggerBox.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            HPTriggerBox.SelectedIndex = 0;

            foreach (Mag.TriggerType triggerType in Enum.GetValues(typeof(Mag.TriggerType)))
            {
                BossTriggerBox.Items.Add(Enum.GetName(typeof(Mag.TriggerType), triggerType));
            }
            BossTriggerBox.SelectedIndex = 0;
        }

        private void ItemTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            setItemDefaults();
        }

        private void setItemDefaults()
        {
            ItemType itemType = (ItemType)(ItemTypeCombo.SelectedIndex + 1);

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

        private void setWeaponDefaults()
        {
            weaponsBox.Enabled = true;
            statsBox.Enabled = true;
            equipsBox.Enabled = true;
            MagBox.Enabled = false;
            FrameBox.Enabled = false;
            ResistancesBox.Enabled = false;
            TechBox.Enabled = false;
            setDefaultValues();
        }

        private void setDefenseDefaults()
        {
            weaponsBox.Enabled = false;
            statsBox.Enabled = true;
            equipsBox.Enabled = true;
            MagBox.Enabled = false;
            FrameBox.Enabled = true;
            ResistancesBox.Enabled = true;
            TechBox.Enabled = false;
            setDefaultValues();
        }

        private void setUnitDefaults()
        {
            weaponsBox.Enabled = false;
            statsBox.Enabled = true;
            equipsBox.Enabled = true;
            MagBox.Enabled = false;
            FrameBox.Enabled = false;
            ResistancesBox.Enabled = true;
            TechBox.Enabled = false;
            setDefaultValues();
        }

        private void setMagDefaults()
        {
            weaponsBox.Enabled = false;
            statsBox.Enabled = false;
            equipsBox.Enabled = false;
            MagBox.Enabled = true;
            FrameBox.Enabled = false;
            ResistancesBox.Enabled = false;
            TechBox.Enabled = false;
            setDefaultValues();
        }

        private void setTechniqueDefaults()
        {
            weaponsBox.Enabled = false;
            statsBox.Enabled = false;
            equipsBox.Enabled = false;
            MagBox.Enabled = false;
            FrameBox.Enabled = false;
            ResistancesBox.Enabled = true;
            TechBox.Enabled = true;
            setDefaultValues();
        }

        private void setToolDefaults()
        {
            weaponsBox.Enabled = false;
            statsBox.Enabled = false;
            equipsBox.Enabled = false;
            MagBox.Enabled = false;
            FrameBox.Enabled = false;
            ResistancesBox.Enabled = true;
            TechBox.Enabled = false;
            setDefaultValues();
        }

        private void setDefaultValues()
        {
            HexText.Text = "000000";
            RarityText.Text = "0";
            MaxStackText.Text = "1";
            HPText.Text = "0";
            TPText.Text = "0";
            ATPText.Text = "0";
            DFPText.Text = "0";
            MSTText.Text = "0";
            ATAText.Text = "0";
            EVPText.Text = "0";
            LCKText.Text = "0";
            HUmarCheck.Checked = true;
            HUnewearlCheck.Checked = true;
            HUcastCheck.Checked = true;
            HUcasealCheck.Checked = true;
            RAmarCheck.Checked = true;
            RAmarlCheck.Checked = true;
            RAcastCheck.Checked = true;
            RAcasealCheck.Checked = true;
            FOmarCheck.Checked = true; 
            FOmarlCheck.Checked = true;
            FOnewmCheck.Checked = true;
            FOnewearlCheck.Checked = true;
            TriggerPercentageText.Text = "0";
            TargetsText.Text = "1";
            MaxGrindText.Text = "0";
            MinATPText.Text = "0";
            MaxATPText.Text = "0";
            RequirementATPText.Text = "0";
            RequirementATAText.Text = "0";
            RequirementMSTText.Text = "0";
            LevelRequirementText.Text = "0";
            MaxDFPText.Text = "0";
            MaxEVPText.Text = "0";
            EFRText.Text = "0";
            EICText.Text = "0";
            ETHText.Text = "0";
            ELTText.Text = "0";
            EDKText.Text = "0";

            if (_initialized)
            {
                PBTriggerBox.SelectedIndex = 0;
                HPTriggerBox.SelectedIndex = 0;
                BossTriggerBox.SelectedIndex = 0;
                SpecialCombo.SelectedIndex = 0;
                TechTypeBox.SelectedIndex = 0;
            }

            if (EntryCombo.SelectedIndex != EntryCombo.Items.Count - 1)
            {
                setToItemJSON();
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
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

        private void addItem()
        {
            ItemJSON item = formToJSON();

            if (item != null)
            {
                ItemDatabaseJSON.Instance.AddItem(item);
                NameText.Text = String.Empty;
                refreshEntryList();
            }
        }

        private void replaceItem()
        {
            ItemJSON item = formToJSON();

            if (item != null)
            {
                ItemDatabaseJSON.Instance.ReplaceItem(item);
            }
        }

        private ItemJSON formToJSON()
        {
            ItemJSON item = new ItemJSON();
            ItemType itemType = (ItemType)(ItemTypeCombo.SelectedIndex + 1);

            try
            {
                item.Type = Enum.GetName(typeof(ItemType), ItemTypeCombo.SelectedIndex + 1);
                item.Name = NameText.Text;
                item.Hex = HexText.Text;
                item.Rarity = int.Parse(RarityText.Text);
                item.MaxStack = int.Parse(MaxStackText.Text);
                item.HP = int.Parse(HPText.Text);
                item.TP = int.Parse(TPText.Text);
                item.ATP = int.Parse(ATPText.Text);
                item.DFP = int.Parse(DFPText.Text);
                item.MST = int.Parse(MSTText.Text);
                item.ATA = int.Parse(ATAText.Text);
                item.EVP = int.Parse(EVPText.Text);
                item.LCK = int.Parse(LCKText.Text);
                item.EFR = int.Parse(EFRText.Text);
                item.EIC = int.Parse(EICText.Text);
                item.ETH = int.Parse(ETHText.Text);
                item.ELT = int.Parse(ELTText.Text);
                item.EDK = int.Parse(EDKText.Text);

                item.EquipMask = 0;

                if (HUmarCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUmarMask;
                }
                if (HUnewearlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUnewearlMask;
                }
                if (HUcastCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUcastMask;
                }
                if (HUcasealCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.HUcasealMask;
                }
                if (RAmarCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAmarMask;
                }
                if (RAmarlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAmarlMask;
                }
                if (RAcastCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAcastMask;
                }
                if (RAcasealCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.RAcasealMask;
                }
                if (FOmarCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOmarMask;
                }
                if (FOmarlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOmarlMask;
                }
                if (FOnewmCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOnewmMask;
                }
                if (FOnewearlCheck.Checked)
                {
                    item.EquipMask |= EquippableItem.FOnewearlMask;
                }

                if (itemType == ItemType.Weapon)
                {
                    item.WeaponType = Enum.GetName(typeof(WeaponType), WeaponTypeCombo.SelectedIndex + 1);
                    item.Special = Enum.GetName(typeof(SpecialType), SpecialCombo.SelectedIndex);
                    item.Targets = int.Parse(TargetsText.Text);
                    item.MaxGrind = int.Parse(MaxGrindText.Text);
                    item.MinATP = int.Parse(MinATPText.Text);
                    item.MaxATP = int.Parse(MaxATPText.Text);
                    item.RequirementATP = int.Parse(RequirementATPText.Text);
                    item.RequirementATA = int.Parse(RequirementATAText.Text);
                    item.RequirementMST = int.Parse(RequirementMSTText.Text);
                }
                else if (itemType == ItemType.Frame || itemType == ItemType.Barrier)
                {
                    item.RequirementLevel = int.Parse(LevelRequirementText.Text);
                    item.MaxDFP = int.Parse(MaxDFPText.Text);
                    item.MaxEVP = int.Parse(MaxEVPText.Text);
                }
                else if (itemType == ItemType.Mag)
                {
                    item.PBTrigger = Enum.GetName(typeof(Mag.TriggerType), PBTriggerBox.SelectedIndex);
                    item.HPTrigger = Enum.GetName(typeof(Mag.TriggerType), HPTriggerBox.SelectedIndex);
                    item.BossTrigger = Enum.GetName(typeof(Mag.TriggerType), BossTriggerBox.SelectedIndex);
                    item.TriggerPercentage = int.Parse(TriggerPercentageText.Text);
                }
                else if (itemType == ItemType.Technique)
                {
                    item.TechType = Enum.GetName(typeof(TechniqueType), TechTypeBox.SelectedIndex + 1);
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

        private bool _lock = false;

        private void setToItemJSON()
        {
            ItemJSON item = null;

            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                if (kvp.Key == NameText.Text)
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
                ItemTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(ItemType), item.Type) - 1;
                NameText.Text = item.Name;
                HexText.Text = item.Hex;
                RarityText.Text = item.Rarity.ToString();
                MaxStackText.Text = item.MaxStack.ToString();
                HPText.Text = item.HP.ToString();
                TPText.Text = item.TP.ToString();
                ATPText.Text = item.ATP.ToString();
                DFPText.Text = item.DFP.ToString();
                MSTText.Text = item.MST.ToString();
                ATAText.Text = item.ATA.ToString();
                EVPText.Text = item.EVP.ToString();
                LCKText.Text = item.LCK.ToString();
                EFRText.Text = item.EFR.ToString();
                EICText.Text = item.EIC.ToString();
                ETHText.Text = item.ETH.ToString();
                ELTText.Text = item.ELT.ToString();
                EDKText.Text = item.EDK.ToString();
                HUmarCheck.Checked = (item.EquipMask & EquippableItem.HUmarMask) > 0;
                HUnewearlCheck.Checked = (item.EquipMask & EquippableItem.HUnewearlMask) > 0;
                HUcastCheck.Checked = (item.EquipMask & EquippableItem.HUcastMask) > 0;
                HUcasealCheck.Checked = (item.EquipMask & EquippableItem.HUcasealMask) > 0;
                RAmarCheck.Checked = (item.EquipMask & EquippableItem.RAmarMask) > 0;
                RAmarlCheck.Checked = (item.EquipMask & EquippableItem.RAmarlMask) > 0;
                RAcastCheck.Checked = (item.EquipMask & EquippableItem.RAcastMask) > 0;
                RAcasealCheck.Checked = (item.EquipMask & EquippableItem.RAcasealMask) > 0;
                FOmarCheck.Checked = (item.EquipMask & EquippableItem.FOmarMask) > 0;
                FOmarlCheck.Checked = (item.EquipMask & EquippableItem.FOmarlMask) > 0;
                FOnewmCheck.Checked = (item.EquipMask & EquippableItem.FOnewmMask) > 0;
                FOnewearlCheck.Checked = (item.EquipMask & EquippableItem.FOnewearlMask) > 0;
                WeaponTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(WeaponType), item.WeaponType) - 1;
                SpecialCombo.SelectedIndex = (int)Enum.Parse(typeof(SpecialType), item.Special);
                TargetsText.Text = item.Targets.ToString();
                MaxGrindText.Text = item.MaxGrind.ToString();
                MinATPText.Text = item.MinATP.ToString();
                MaxATPText.Text = item.MaxATP.ToString();
                RequirementATPText.Text = item.RequirementATP.ToString();
                RequirementATAText.Text = item.RequirementATA.ToString();
                RequirementMSTText.Text = item.RequirementMST.ToString();
                LevelRequirementText.Text = item.RequirementLevel.ToString();
                MaxDFPText.Text = item.MaxDFP.ToString();
                MaxEVPText.Text = item.MaxEVP.ToString();
                PBTriggerBox.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.PBTrigger);
                HPTriggerBox.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.HPTrigger);
                BossTriggerBox.SelectedIndex = (int)Enum.Parse(typeof(Mag.TriggerType), item.BossTrigger);
                TriggerPercentageText.Text = item.TriggerPercentage.ToString();
                TechTypeBox.SelectedIndex = (int)Enum.Parse(typeof(TechniqueType), item.TechType) - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Ill-formatted data!\n\n" + ex.ToString(),
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void EntryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lock)
            {
                return;
            }

            _lock = true;

            ItemJSON item = null;

            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                if (kvp.Key == EntryCombo.Text)
                {
                    item = kvp.Value;
                    ItemTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(ItemType), item.Type) - 1;
                    NameText.Text = item.Name;
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

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            if (_lock)
            {
                return;
            }

            _lock = true;

            ItemJSON item = null;

            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                if (kvp.Key.ToLower() == NameText.Text.ToLower())
                {
                    item = kvp.Value;
                    ItemTypeCombo.SelectedIndex = (int)Enum.Parse(typeof(ItemType), item.Type) - 1;
                    NameText.Text = item.Name;

                    for (int i = 0; i < EntryCombo.Items.Count; i++)
                    {
                        if (EntryCombo.Items[i].ToString().ToLower() == kvp.Key.ToLower())
                        {
                            EntryCombo.SelectedIndex = i;
                            break;
                        }    
                    }

                    break;
                }
            }

            if (item == null)
            {
                setAddItemMode();
                EntryCombo.SelectedIndex = EntryCombo.Items.Count - 1;
            }
            else
            {
                setReplaceItemMode();
            }

            setItemDefaults();

            _lock = false;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            ItemJSON item = formToJSON();

            if (item != null)
            {
                ItemDatabaseJSON.Instance.RemoveItem(item);
                refreshEntryList();
            }
        }

        private bool _replaceItem = false;

        private void setAddItemMode()
        {
            _replaceItem = false;
            AddItemButton.Text = "Add Item";
        }

        private void setReplaceItemMode()
        {
            _replaceItem = true;
            AddItemButton.Text = "Replace Item";
        }

        private void refreshEntryList()
        {
            if (_lock)
            {
                return;
            }

            _lock = true;

            EntryCombo.Items.Clear();
            foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
            {
                EntryCombo.Items.Add(kvp.Key);
            }
            EntryCombo.Items.Add("<NEW>");
            EntryCombo.SelectedIndex = EntryCombo.Items.Count - 1;

            _lock = false;
        }
    }
}

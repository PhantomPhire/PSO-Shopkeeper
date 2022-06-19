namespace PSOShopkeeper
{
    partial class PSOShopkeeperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSOShopkeeperForm));
            this._addItemsButton = new System.Windows.Forms.Button();
            this._outputTab = new System.Windows.Forms.TabPage();
            this._editColorsButton = new System.Windows.Forms.Button();
            this._colorizePercentages = new System.Windows.Forms.CheckBox();
            this._colorizeHitCheck = new System.Windows.Forms.CheckBox();
            this._colorizeSpecialsCheck = new System.Windows.Forms.CheckBox();
            this.UReplacementText = new System.Windows.Forms.TextBox();
            this._replaceUCheck = new System.Windows.Forms.CheckBox();
            this._multiPriceCheck = new System.Windows.Forms.CheckBox();
            this._boldPriceCheck = new System.Windows.Forms.CheckBox();
            this._clearButton = new System.Windows.Forms.Button();
            this._clipboardButton = new System.Windows.Forms.Button();
            this._outputBox = new System.Windows.Forms.RichTextBox();
            this._generateOutputButton = new System.Windows.Forms.Button();
            this._itemListView = new System.Windows.Forms.TabPage();
            this._itemInformationPanel = new System.Windows.Forms.Panel();
            this._clearItemsButton = new System.Windows.Forms.Button();
            this._savePricingButton = new System.Windows.Forms.Button();
            this._itemListPanel = new System.Windows.Forms.DataGridView();
            this._tabs = new System.Windows.Forms.TabControl();
            this._templateTab = new System.Windows.Forms.TabPage();
            this._templateHelpButton = new System.Windows.Forms.Button();
            this._clearFiltersButton = new System.Windows.Forms.Button();
            this._addFilterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._appliedFilters = new System.Windows.Forms.TableLayoutPanel();
            this._currentFilter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._filterToggles = new System.Windows.Forms.TableLayoutPanel();
            this._filterPreview = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._validateTemplateButton = new System.Windows.Forms.Button();
            this._templateBox = new System.Windows.Forms.RichTextBox();
            this._saveTemplateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._settingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this._itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._cutCells = new System.Windows.Forms.ToolStripMenuItem();
            this._copyCells = new System.Windows.Forms.ToolStripMenuItem();
            this._pasteCells = new System.Windows.Forms.ToolStripMenuItem();
            this._headerContextMenuBasic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._clearColumnButton = new System.Windows.Forms.ToolStripMenuItem();
            this._headerContextMenuPDs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sumItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._headerContextMenuMeseta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sumItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._outputTab.SuspendLayout();
            this._itemListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).BeginInit();
            this._tabs.SuspendLayout();
            this._templateTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this._itemContextMenu.SuspendLayout();
            this._headerContextMenuBasic.SuspendLayout();
            this._headerContextMenuPDs.SuspendLayout();
            this._headerContextMenuMeseta.SuspendLayout();
            this.SuspendLayout();
            // 
            // _addItemsButton
            // 
            this._addItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addItemsButton.Location = new System.Drawing.Point(613, 603);
            this._addItemsButton.Name = "_addItemsButton";
            this._addItemsButton.Size = new System.Drawing.Size(104, 45);
            this._addItemsButton.TabIndex = 1;
            this._addItemsButton.Text = "Add Items";
            this._addItemsButton.UseVisualStyleBackColor = true;
            this._addItemsButton.Click += new System.EventHandler(this.onAddItemsClicked);
            // 
            // _outputTab
            // 
            this._outputTab.Controls.Add(this._editColorsButton);
            this._outputTab.Controls.Add(this._colorizePercentages);
            this._outputTab.Controls.Add(this._colorizeHitCheck);
            this._outputTab.Controls.Add(this._colorizeSpecialsCheck);
            this._outputTab.Controls.Add(this.UReplacementText);
            this._outputTab.Controls.Add(this._replaceUCheck);
            this._outputTab.Controls.Add(this._multiPriceCheck);
            this._outputTab.Controls.Add(this._boldPriceCheck);
            this._outputTab.Controls.Add(this._clearButton);
            this._outputTab.Controls.Add(this._clipboardButton);
            this._outputTab.Controls.Add(this._outputBox);
            this._outputTab.Controls.Add(this._generateOutputButton);
            this._outputTab.Location = new System.Drawing.Point(4, 36);
            this._outputTab.Name = "_outputTab";
            this._outputTab.Padding = new System.Windows.Forms.Padding(3);
            this._outputTab.Size = new System.Drawing.Size(1348, 654);
            this._outputTab.TabIndex = 1;
            this._outputTab.Text = "Output";
            this._outputTab.UseVisualStyleBackColor = true;
            // 
            // _editColorsButton
            // 
            this._editColorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editColorsButton.Location = new System.Drawing.Point(1190, 210);
            this._editColorsButton.Name = "_editColorsButton";
            this._editColorsButton.Size = new System.Drawing.Size(140, 44);
            this._editColorsButton.TabIndex = 12;
            this._editColorsButton.Text = "Edit Colors";
            this._editColorsButton.UseVisualStyleBackColor = true;
            this._editColorsButton.Click += new System.EventHandler(this.onEditColorsClicked);
            // 
            // _colorizePercentages
            // 
            this._colorizePercentages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._colorizePercentages.AutoSize = true;
            this._colorizePercentages.Location = new System.Drawing.Point(1180, 170);
            this._colorizePercentages.Name = "_colorizePercentages";
            this._colorizePercentages.Size = new System.Drawing.Size(165, 17);
            this._colorizePercentages.TabIndex = 11;
            this._colorizePercentages.Text = "Colorize Non-Hit Percentages";
            this._colorizePercentages.UseVisualStyleBackColor = true;
            this._colorizePercentages.CheckedChanged += new System.EventHandler(this.onColorizePercentagesChecked);
            // 
            // _colorizeHitCheck
            // 
            this._colorizeHitCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._colorizeHitCheck.AutoSize = true;
            this._colorizeHitCheck.Location = new System.Drawing.Point(1180, 147);
            this._colorizeHitCheck.Name = "_colorizeHitCheck";
            this._colorizeHitCheck.Size = new System.Drawing.Size(142, 17);
            this._colorizeHitCheck.TabIndex = 10;
            this._colorizeHitCheck.Text = "Colorize Hit Percentages";
            this._colorizeHitCheck.UseVisualStyleBackColor = true;
            this._colorizeHitCheck.CheckedChanged += new System.EventHandler(this.onColorizeHitChecked);
            // 
            // _colorizeSpecialsCheck
            // 
            this._colorizeSpecialsCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._colorizeSpecialsCheck.AutoSize = true;
            this._colorizeSpecialsCheck.Location = new System.Drawing.Point(1180, 123);
            this._colorizeSpecialsCheck.Name = "_colorizeSpecialsCheck";
            this._colorizeSpecialsCheck.Size = new System.Drawing.Size(150, 17);
            this._colorizeSpecialsCheck.TabIndex = 9;
            this._colorizeSpecialsCheck.Text = "Colorize Weapon Specials";
            this._colorizeSpecialsCheck.UseVisualStyleBackColor = true;
            this._colorizeSpecialsCheck.CheckedChanged += new System.EventHandler(this.onColorizeSpecialsChecked);
            // 
            // UReplacementText
            // 
            this.UReplacementText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UReplacementText.Location = new System.Drawing.Point(1180, 567);
            this.UReplacementText.Name = "UReplacementText";
            this.UReplacementText.Size = new System.Drawing.Size(151, 20);
            this.UReplacementText.TabIndex = 8;
            // 
            // _replaceUCheck
            // 
            this._replaceUCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._replaceUCheck.AutoSize = true;
            this._replaceUCheck.Location = new System.Drawing.Point(1180, 543);
            this._replaceUCheck.Name = "_replaceUCheck";
            this._replaceUCheck.Size = new System.Drawing.Size(108, 17);
            this._replaceUCheck.TabIndex = 7;
            this._replaceUCheck.Text = "Replace [U] with:";
            this._replaceUCheck.UseVisualStyleBackColor = true;
            // 
            // _multiPriceCheck
            // 
            this._multiPriceCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._multiPriceCheck.AutoSize = true;
            this._multiPriceCheck.Location = new System.Drawing.Point(1180, 495);
            this._multiPriceCheck.Name = "_multiPriceCheck";
            this._multiPriceCheck.Size = new System.Drawing.Size(151, 17);
            this._multiPriceCheck.TabIndex = 6;
            this._multiPriceCheck.Text = "Print Price in Multiple Units";
            this._multiPriceCheck.UseVisualStyleBackColor = true;
            this._multiPriceCheck.CheckedChanged += new System.EventHandler(this.onMultiPriceChecked);
            // 
            // _boldPriceCheck
            // 
            this._boldPriceCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._boldPriceCheck.AutoSize = true;
            this._boldPriceCheck.Location = new System.Drawing.Point(1180, 472);
            this._boldPriceCheck.Name = "_boldPriceCheck";
            this._boldPriceCheck.Size = new System.Drawing.Size(74, 17);
            this._boldPriceCheck.TabIndex = 5;
            this._boldPriceCheck.Text = "Bold Price";
            this._boldPriceCheck.UseVisualStyleBackColor = true;
            this._boldPriceCheck.CheckedChanged += new System.EventHandler(this.onBoldPriceChecked);
            // 
            // _clearButton
            // 
            this._clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._clearButton.Location = new System.Drawing.Point(591, 607);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(140, 44);
            this._clearButton.TabIndex = 4;
            this._clearButton.Text = "Clear";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this.onClearOutputClicked);
            // 
            // _clipboardButton
            // 
            this._clipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._clipboardButton.Location = new System.Drawing.Point(737, 607);
            this._clipboardButton.Name = "_clipboardButton";
            this._clipboardButton.Size = new System.Drawing.Size(140, 44);
            this._clipboardButton.TabIndex = 3;
            this._clipboardButton.Text = "Copy to Clipboard";
            this._clipboardButton.UseVisualStyleBackColor = true;
            this._clipboardButton.Click += new System.EventHandler(this.onClipboardButtonPressed);
            // 
            // _outputBox
            // 
            this._outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._outputBox.Location = new System.Drawing.Point(4, 0);
            this._outputBox.Name = "_outputBox";
            this._outputBox.Size = new System.Drawing.Size(1170, 603);
            this._outputBox.TabIndex = 2;
            this._outputBox.Text = "";
            // 
            // _generateOutputButton
            // 
            this._generateOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._generateOutputButton.Location = new System.Drawing.Point(445, 607);
            this._generateOutputButton.Name = "_generateOutputButton";
            this._generateOutputButton.Size = new System.Drawing.Size(140, 44);
            this._generateOutputButton.TabIndex = 1;
            this._generateOutputButton.Text = "Generate";
            this._generateOutputButton.UseVisualStyleBackColor = true;
            this._generateOutputButton.Click += new System.EventHandler(this.onGenerateOutputClicked);
            // 
            // _itemListView
            // 
            this._itemListView.AutoScroll = true;
            this._itemListView.Controls.Add(this._clearItemsButton);
            this._itemListView.Controls.Add(this._savePricingButton);
            this._itemListView.Controls.Add(this._addItemsButton);
            this._itemListView.Controls.Add(this._itemInformationPanel);
            this._itemListView.Controls.Add(this._itemListPanel);
            this._itemListView.Location = new System.Drawing.Point(4, 36);
            this._itemListView.Name = "_itemListView";
            this._itemListView.Padding = new System.Windows.Forms.Padding(3);
            this._itemListView.Size = new System.Drawing.Size(1348, 654);
            this._itemListView.TabIndex = 0;
            this._itemListView.Text = "Item List";
            this._itemListView.UseVisualStyleBackColor = true;
            // 
            // _itemInformationPanel
            // 
            this._itemInformationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._itemInformationPanel.Location = new System.Drawing.Point(948, 0);
            this._itemInformationPanel.Name = "_itemInformationPanel";
            this._itemInformationPanel.Size = new System.Drawing.Size(392, 648);
            this._itemInformationPanel.TabIndex = 1;
            // 
            // _clearItemsButton
            // 
            this._clearItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._clearItemsButton.Location = new System.Drawing.Point(837, 603);
            this._clearItemsButton.Name = "_clearItemsButton";
            this._clearItemsButton.Size = new System.Drawing.Size(108, 45);
            this._clearItemsButton.TabIndex = 2;
            this._clearItemsButton.Text = "Clear Items";
            this._clearItemsButton.UseVisualStyleBackColor = true;
            this._clearItemsButton.Click += new System.EventHandler(this.onClearItemsClicked);
            // 
            // _savePricingButton
            // 
            this._savePricingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._savePricingButton.Location = new System.Drawing.Point(723, 603);
            this._savePricingButton.Name = "_savePricingButton";
            this._savePricingButton.Size = new System.Drawing.Size(108, 45);
            this._savePricingButton.TabIndex = 2;
            this._savePricingButton.Text = "Save Prices";
            this._savePricingButton.UseVisualStyleBackColor = true;
            this._savePricingButton.Click += new System.EventHandler(this.onSavePricesClicked);
            // 
            // _itemListPanel
            // 
            this._itemListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._itemListPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._itemListPanel.Location = new System.Drawing.Point(0, 3);
            this._itemListPanel.Name = "_itemListPanel";
            this._itemListPanel.Size = new System.Drawing.Size(942, 594);
            this._itemListPanel.TabIndex = 0;
            this._itemListPanel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            this._itemListPanel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            this._itemListPanel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.onCellRightClicked);
            this._itemListPanel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellChanged);
            this._itemListPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onCellKeyPressed);
            // 
            // _tabs
            // 
            this._tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabs.Controls.Add(this._itemListView);
            this._tabs.Controls.Add(this._templateTab);
            this._tabs.Controls.Add(this._outputTab);
            this._tabs.Location = new System.Drawing.Point(-4, 28);
            this._tabs.Name = "_tabs";
            this._tabs.Padding = new System.Drawing.Point(206, 10);
            this._tabs.SelectedIndex = 0;
            this._tabs.Size = new System.Drawing.Size(1356, 694);
            this._tabs.TabIndex = 0;
            // 
            // _templateTab
            // 
            this._templateTab.Controls.Add(this._templateHelpButton);
            this._templateTab.Controls.Add(this._clearFiltersButton);
            this._templateTab.Controls.Add(this._addFilterButton);
            this._templateTab.Controls.Add(this.panel2);
            this._templateTab.Controls.Add(this._currentFilter);
            this._templateTab.Controls.Add(this.panel1);
            this._templateTab.Controls.Add(this._filterPreview);
            this._templateTab.Controls.Add(this.label2);
            this._templateTab.Controls.Add(this.label1);
            this._templateTab.Controls.Add(this._validateTemplateButton);
            this._templateTab.Controls.Add(this._templateBox);
            this._templateTab.Controls.Add(this._saveTemplateButton);
            this._templateTab.Location = new System.Drawing.Point(4, 36);
            this._templateTab.Name = "_templateTab";
            this._templateTab.Padding = new System.Windows.Forms.Padding(3);
            this._templateTab.Size = new System.Drawing.Size(1348, 654);
            this._templateTab.TabIndex = 2;
            this._templateTab.Text = "Template";
            this._templateTab.UseVisualStyleBackColor = true;
            // 
            // _templateHelpButton
            // 
            this._templateHelpButton.Location = new System.Drawing.Point(973, 29);
            this._templateHelpButton.Name = "_templateHelpButton";
            this._templateHelpButton.Size = new System.Drawing.Size(113, 23);
            this._templateHelpButton.TabIndex = 17;
            this._templateHelpButton.Text = "Help";
            this._templateHelpButton.UseVisualStyleBackColor = true;
            this._templateHelpButton.Click += new System.EventHandler(this.onTemplateHelpClicked);
            // 
            // _clearFiltersButton
            // 
            this._clearFiltersButton.Location = new System.Drawing.Point(536, 29);
            this._clearFiltersButton.Name = "_clearFiltersButton";
            this._clearFiltersButton.Size = new System.Drawing.Size(113, 23);
            this._clearFiltersButton.TabIndex = 16;
            this._clearFiltersButton.Text = "Clear Filters";
            this._clearFiltersButton.UseVisualStyleBackColor = true;
            this._clearFiltersButton.Click += new System.EventHandler(this.onClearFilterClicked);
            // 
            // _addFilterButton
            // 
            this._addFilterButton.Location = new System.Drawing.Point(417, 29);
            this._addFilterButton.Name = "_addFilterButton";
            this._addFilterButton.Size = new System.Drawing.Size(113, 23);
            this._addFilterButton.TabIndex = 15;
            this._addFilterButton.Text = "Add Filter";
            this._addFilterButton.UseVisualStyleBackColor = true;
            this._addFilterButton.Click += new System.EventHandler(this.onAddFilterClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._appliedFilters);
            this.panel2.Location = new System.Drawing.Point(422, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 221);
            this.panel2.TabIndex = 14;
            // 
            // _appliedFilters
            // 
            this._appliedFilters.ColumnCount = 5;
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.Location = new System.Drawing.Point(4, 3);
            this._appliedFilters.Name = "_appliedFilters";
            this._appliedFilters.RowCount = 7;
            this._appliedFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._appliedFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._appliedFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._appliedFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._appliedFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._appliedFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._appliedFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._appliedFilters.Size = new System.Drawing.Size(660, 210);
            this._appliedFilters.TabIndex = 0;
            // 
            // _currentFilter
            // 
            this._currentFilter.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currentFilter.Location = new System.Drawing.Point(417, 6);
            this._currentFilter.Name = "_currentFilter";
            this._currentFilter.ReadOnly = true;
            this._currentFilter.Size = new System.Drawing.Size(672, 23);
            this._currentFilter.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this._filterToggles);
            this.panel1.Location = new System.Drawing.Point(419, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 296);
            this.panel1.TabIndex = 11;
            // 
            // _filterToggles
            // 
            this._filterToggles.ColumnCount = 5;
            this._filterToggles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filterToggles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filterToggles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filterToggles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filterToggles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filterToggles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filterToggles.Location = new System.Drawing.Point(3, 13);
            this._filterToggles.Name = "_filterToggles";
            this._filterToggles.RowCount = 2;
            this._filterToggles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._filterToggles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._filterToggles.Size = new System.Drawing.Size(638, 60);
            this._filterToggles.TabIndex = 1;
            // 
            // _filterPreview
            // 
            this._filterPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterPreview.Location = new System.Drawing.Point(1095, 2);
            this._filterPreview.Multiline = true;
            this._filterPreview.Name = "_filterPreview";
            this._filterPreview.ReadOnly = true;
            this._filterPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._filterPreview.Size = new System.Drawing.Size(245, 593);
            this._filterPreview.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Applied Filters (click to remove)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Available Filters";
            // 
            // _validateTemplateButton
            // 
            this._validateTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._validateTemplateButton.Location = new System.Drawing.Point(236, 605);
            this._validateTemplateButton.Name = "_validateTemplateButton";
            this._validateTemplateButton.Size = new System.Drawing.Size(123, 43);
            this._validateTemplateButton.TabIndex = 4;
            this._validateTemplateButton.Text = "Validate";
            this._validateTemplateButton.UseVisualStyleBackColor = true;
            this._validateTemplateButton.Click += new System.EventHandler(this.onValidateClicked);
            // 
            // _templateBox
            // 
            this._templateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._templateBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateBox.Location = new System.Drawing.Point(0, 1);
            this._templateBox.Name = "_templateBox";
            this._templateBox.Size = new System.Drawing.Size(411, 594);
            this._templateBox.TabIndex = 3;
            this._templateBox.Text = "";
            this._templateBox.TextChanged += new System.EventHandler(this.onTemplateTextChanged);
            // 
            // _saveTemplateButton
            // 
            this._saveTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._saveTemplateButton.Location = new System.Drawing.Point(365, 605);
            this._saveTemplateButton.Name = "_saveTemplateButton";
            this._saveTemplateButton.Size = new System.Drawing.Size(123, 43);
            this._saveTemplateButton.TabIndex = 1;
            this._saveTemplateButton.Text = "Save Template";
            this._saveTemplateButton.UseVisualStyleBackColor = true;
            this._saveTemplateButton.Click += new System.EventHandler(this.onSaveTemplateClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1352, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this._settingsButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.onAddItemsClicked);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.onSaveClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // _settingsButton
            // 
            this._settingsButton.Name = "_settingsButton";
            this._settingsButton.Size = new System.Drawing.Size(116, 22);
            this._settingsButton.Text = "Settings";
            this._settingsButton.Click += new System.EventHandler(this.onSettingsButtonClicked);
            // 
            // _itemContextMenu
            // 
            this._itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cutCells,
            this._copyCells,
            this._pasteCells});
            this._itemContextMenu.Name = "_itemContextMenu";
            this._itemContextMenu.Size = new System.Drawing.Size(103, 70);
            // 
            // _cutCells
            // 
            this._cutCells.Name = "_cutCells";
            this._cutCells.Size = new System.Drawing.Size(102, 22);
            this._cutCells.Text = "Cut";
            this._cutCells.Click += new System.EventHandler(this.onCutClicked);
            // 
            // _copyCells
            // 
            this._copyCells.Name = "_copyCells";
            this._copyCells.Size = new System.Drawing.Size(102, 22);
            this._copyCells.Text = "Copy";
            this._copyCells.Click += new System.EventHandler(this.onCopyClicked);
            // 
            // _pasteCells
            // 
            this._pasteCells.Name = "_pasteCells";
            this._pasteCells.Size = new System.Drawing.Size(102, 22);
            this._pasteCells.Text = "Paste";
            this._pasteCells.Click += new System.EventHandler(this.onPasteClicked);
            // 
            // _headerContextMenuBasic
            // 
            this._headerContextMenuBasic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._clearColumnButton});
            this._headerContextMenuBasic.Name = "_headerContextMenuBasic";
            this._headerContextMenuBasic.Size = new System.Drawing.Size(148, 26);
            // 
            // _clearColumnButton
            // 
            this._clearColumnButton.Name = "_clearColumnButton";
            this._clearColumnButton.Size = new System.Drawing.Size(147, 22);
            this._clearColumnButton.Text = "Clear Column";
            this._clearColumnButton.Click += new System.EventHandler(this.onClearColumnClicked);
            // 
            // _headerContextMenuPDs
            // 
            this._headerContextMenuPDs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumItemsToolStripMenuItem,
            this.clearColumnToolStripMenuItem});
            this._headerContextMenuPDs.Name = "_headerContextMenuPDs";
            this._headerContextMenuPDs.Size = new System.Drawing.Size(148, 48);
            // 
            // sumItemsToolStripMenuItem
            // 
            this.sumItemsToolStripMenuItem.Name = "sumItemsToolStripMenuItem";
            this.sumItemsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sumItemsToolStripMenuItem.Text = "Sum Items";
            this.sumItemsToolStripMenuItem.Click += new System.EventHandler(this.onSumItemsClicked);
            // 
            // clearColumnToolStripMenuItem
            // 
            this.clearColumnToolStripMenuItem.Name = "clearColumnToolStripMenuItem";
            this.clearColumnToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.clearColumnToolStripMenuItem.Text = "Clear Column";
            this.clearColumnToolStripMenuItem.Click += new System.EventHandler(this.onClearColumnClicked);
            // 
            // _headerContextMenuMeseta
            // 
            this._headerContextMenuMeseta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumItemsToolStripMenuItem1,
            this.clearColumnsToolStripMenuItem});
            this._headerContextMenuMeseta.Name = "_headerContextMenuMeseta";
            this._headerContextMenuMeseta.Size = new System.Drawing.Size(153, 48);
            // 
            // sumItemsToolStripMenuItem1
            // 
            this.sumItemsToolStripMenuItem1.Name = "sumItemsToolStripMenuItem1";
            this.sumItemsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sumItemsToolStripMenuItem1.Text = "Autofill";
            this.sumItemsToolStripMenuItem1.Click += new System.EventHandler(this.onAutofillClicked);
            // 
            // clearColumnsToolStripMenuItem
            // 
            this.clearColumnsToolStripMenuItem.Name = "clearColumnsToolStripMenuItem";
            this.clearColumnsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearColumnsToolStripMenuItem.Text = "Clear Columns";
            this.clearColumnsToolStripMenuItem.Click += new System.EventHandler(this.onClearColumnClicked);
            // 
            // PSOShopkeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 721);
            this.Controls.Add(this._tabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PSOShopkeeperForm";
            this.Text = "PSO Shopkeeper";
            this._outputTab.ResumeLayout(false);
            this._outputTab.PerformLayout();
            this._itemListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).EndInit();
            this._tabs.ResumeLayout(false);
            this._templateTab.ResumeLayout(false);
            this._templateTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._itemContextMenu.ResumeLayout(false);
            this._headerContextMenuBasic.ResumeLayout(false);
            this._headerContextMenuPDs.ResumeLayout(false);
            this._headerContextMenuMeseta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _addItemsButton;
        private System.Windows.Forms.TabPage _outputTab;
        private System.Windows.Forms.TabPage _itemListView;
        private System.Windows.Forms.TabControl _tabs;
        private System.Windows.Forms.Button _clearItemsButton;
        private System.Windows.Forms.DataGridView _itemListPanel;
        private System.Windows.Forms.TabPage _templateTab;
        private System.Windows.Forms.Button _savePricingButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button _saveTemplateButton;
        private System.Windows.Forms.RichTextBox _templateBox;
        private System.Windows.Forms.Button _generateOutputButton;
        private System.Windows.Forms.RichTextBox _outputBox;
        private System.Windows.Forms.Button _clipboardButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _settingsButton;
        private System.Windows.Forms.Button _validateTemplateButton;
        private System.Windows.Forms.CheckBox _multiPriceCheck;
        private System.Windows.Forms.CheckBox _boldPriceCheck;
        private System.Windows.Forms.TextBox UReplacementText;
        private System.Windows.Forms.CheckBox _replaceUCheck;
        private System.Windows.Forms.CheckBox _colorizePercentages;
        private System.Windows.Forms.CheckBox _colorizeHitCheck;
        private System.Windows.Forms.CheckBox _colorizeSpecialsCheck;
        private System.Windows.Forms.ContextMenuStrip _itemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _cutCells;
        private System.Windows.Forms.ToolStripMenuItem _copyCells;
        private System.Windows.Forms.ToolStripMenuItem _pasteCells;
        private System.Windows.Forms.ContextMenuStrip _headerContextMenuBasic;
        private System.Windows.Forms.ToolStripMenuItem _clearColumnButton;
        private System.Windows.Forms.ContextMenuStrip _headerContextMenuPDs;
        private System.Windows.Forms.ToolStripMenuItem sumItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearColumnToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _headerContextMenuMeseta;
        private System.Windows.Forms.ToolStripMenuItem sumItemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearColumnsToolStripMenuItem;
        private System.Windows.Forms.Button _editColorsButton;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.Button _clearFiltersButton;
        private System.Windows.Forms.Button _addFilterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel _appliedFilters;
        private System.Windows.Forms.TextBox _currentFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel _filterToggles;
        private System.Windows.Forms.TextBox _filterPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _templateHelpButton;
        private System.Windows.Forms.Panel _itemInformationPanel;
    }
}


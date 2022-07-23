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
            this._outputTab = new System.Windows.Forms.TabPage();
            this._itemListView = new System.Windows.Forms.TabPage();
            this._tabs = new System.Windows.Forms.TabControl();
            this._templateTab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._templateBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._filterPreviewTitleBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._filterPreviewTitle = new System.Windows.Forms.Label();
            this._filterPreviewBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._filterPreviewScrollPanel = new System.Windows.Forms.Panel();
            this._filterPreview = new System.Windows.Forms.Label();
            this._templateHelpButton = new System.Windows.Forms.Button();
            this._templateTitleBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._templateTitleLabel = new System.Windows.Forms.Label();
            this._filterTogglesHeaderBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._currentFilter = new System.Windows.Forms.Label();
            this._currentFilterLabel = new System.Windows.Forms.Label();
            this._templateEntryBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._templateBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this._filterTogglesBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._filterTogglesScrollPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._filterToggles = new PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel();
            this._saveTemplateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._appliedFilters = new PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel();
            this._clearFiltersButton = new System.Windows.Forms.Button();
            this._addFilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._outputBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._outputBoxTitleBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._outputBoxTitle = new System.Windows.Forms.Label();
            this._outputBoxBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._outputBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this._generateOutputButton = new System.Windows.Forms.Button();
            this._clearButton = new System.Windows.Forms.Button();
            this._clipboardButton = new System.Windows.Forms.Button();
            this._outputTabControlsBGPanel1 = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._colorizeSpecialsCheck = new System.Windows.Forms.CheckBox();
            this._colorizeHitCheck = new System.Windows.Forms.CheckBox();
            this._colorizePercentages = new System.Windows.Forms.CheckBox();
            this._editColorsButton = new System.Windows.Forms.Button();
            this._outputTabControlsBGPanel2 = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._boldPriceCheck = new System.Windows.Forms.CheckBox();
            this._multiPriceCheck = new System.Windows.Forms.CheckBox();
            this._untekkText = new System.Windows.Forms.TextBox();
            this._untekkTextLabel = new System.Windows.Forms.Label();
            this._outputTab.SuspendLayout();
            this._tabs.SuspendLayout();
            this._templateTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this._templateBGPanel.SuspendLayout();
            this._filterPreviewTitleBG.SuspendLayout();
            this._filterPreviewBG.SuspendLayout();
            this._filterPreviewScrollPanel.SuspendLayout();
            this._templateTitleBG.SuspendLayout();
            this._filterTogglesHeaderBG.SuspendLayout();
            this._templateEntryBGPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._templateBox)).BeginInit();
            this._filterTogglesBGPanel.SuspendLayout();
            this._filterTogglesScrollPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this._outputBGPanel.SuspendLayout();
            this._outputBoxTitleBG.SuspendLayout();
            this._outputBoxBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._outputBox)).BeginInit();
            this._outputTabControlsBGPanel1.SuspendLayout();
            this._outputTabControlsBGPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _outputTab
            // 
            this._outputTab.Controls.Add(this._outputBGPanel);
            this._outputTab.Location = new System.Drawing.Point(4, 36);
            this._outputTab.Name = "_outputTab";
            this._outputTab.Padding = new System.Windows.Forms.Padding(3);
            this._outputTab.Size = new System.Drawing.Size(1354, 654);
            this._outputTab.TabIndex = 1;
            this._outputTab.Text = "Output";
            this._outputTab.UseVisualStyleBackColor = true;
            // 
            // _itemListView
            // 
            this._itemListView.AutoScroll = true;
            this._itemListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._itemListView.Location = new System.Drawing.Point(4, 36);
            this._itemListView.Name = "_itemListView";
            this._itemListView.Padding = new System.Windows.Forms.Padding(3);
            this._itemListView.Size = new System.Drawing.Size(1354, 654);
            this._itemListView.TabIndex = 0;
            this._itemListView.Text = "Item List";
            this._itemListView.UseVisualStyleBackColor = true;
            // 
            // _tabs
            // 
            this._tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabs.Controls.Add(this._itemListView);
            this._tabs.Controls.Add(this._templateTab);
            this._tabs.Controls.Add(this._outputTab);
            this._tabs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabs.Location = new System.Drawing.Point(-4, 28);
            this._tabs.Name = "_tabs";
            this._tabs.Padding = new System.Drawing.Point(206, 10);
            this._tabs.SelectedIndex = 0;
            this._tabs.Size = new System.Drawing.Size(1362, 694);
            this._tabs.TabIndex = 0;
            // 
            // _templateTab
            // 
            this._templateTab.Controls.Add(this._templateBGPanel);
            this._templateTab.Location = new System.Drawing.Point(4, 36);
            this._templateTab.Name = "_templateTab";
            this._templateTab.Padding = new System.Windows.Forms.Padding(3);
            this._templateTab.Size = new System.Drawing.Size(1354, 654);
            this._templateTab.TabIndex = 2;
            this._templateTab.Text = "Template";
            this._templateTab.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.onOpenClicked);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.onSaveClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.onExitButtonClicked);
            // 
            // _templateBGPanel
            // 
            this._templateBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._templateBGPanel.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Shop_BG;
            this._templateBGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._templateBGPanel.Controls.Add(this._filterPreviewTitleBG);
            this._templateBGPanel.Controls.Add(this._filterPreviewBG);
            this._templateBGPanel.Controls.Add(this._templateHelpButton);
            this._templateBGPanel.Controls.Add(this._templateTitleBG);
            this._templateBGPanel.Controls.Add(this._filterTogglesHeaderBG);
            this._templateBGPanel.Controls.Add(this._currentFilter);
            this._templateBGPanel.Controls.Add(this._currentFilterLabel);
            this._templateBGPanel.Controls.Add(this._templateEntryBGPanel);
            this._templateBGPanel.Controls.Add(this._filterTogglesBGPanel);
            this._templateBGPanel.Controls.Add(this._saveTemplateButton);
            this._templateBGPanel.Controls.Add(this.panel2);
            this._templateBGPanel.Controls.Add(this._clearFiltersButton);
            this._templateBGPanel.Controls.Add(this._addFilterButton);
            this._templateBGPanel.Controls.Add(this.label2);
            this._templateBGPanel.Location = new System.Drawing.Point(0, 0);
            this._templateBGPanel.Name = "_templateBGPanel";
            this._templateBGPanel.Size = new System.Drawing.Size(1354, 658);
            this._templateBGPanel.TabIndex = 19;
            // 
            // _filterPreviewTitleBG
            // 
            this._filterPreviewTitleBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Title_BG_2;
            this._filterPreviewTitleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._filterPreviewTitleBG.Controls.Add(this._filterPreviewTitle);
            this._filterPreviewTitleBG.Location = new System.Drawing.Point(1115, 15);
            this._filterPreviewTitleBG.Name = "_filterPreviewTitleBG";
            this._filterPreviewTitleBG.Size = new System.Drawing.Size(169, 44);
            this._filterPreviewTitleBG.TabIndex = 22;
            // 
            // _filterPreviewTitle
            // 
            this._filterPreviewTitle.AutoSize = true;
            this._filterPreviewTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filterPreviewTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._filterPreviewTitle.Location = new System.Drawing.Point(18, 11);
            this._filterPreviewTitle.Name = "_filterPreviewTitle";
            this._filterPreviewTitle.Size = new System.Drawing.Size(142, 23);
            this._filterPreviewTitle.TabIndex = 10;
            this._filterPreviewTitle.Text = "Filter Preview";
            // 
            // _filterPreviewBG
            // 
            this._filterPreviewBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterPreviewBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Vertical_Text_BG;
            this._filterPreviewBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._filterPreviewBG.Controls.Add(this._filterPreviewScrollPanel);
            this._filterPreviewBG.Location = new System.Drawing.Point(1101, 31);
            this._filterPreviewBG.Name = "_filterPreviewBG";
            this._filterPreviewBG.Size = new System.Drawing.Size(253, 620);
            this._filterPreviewBG.TabIndex = 24;
            // 
            // _filterPreviewScrollPanel
            // 
            this._filterPreviewScrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterPreviewScrollPanel.AutoScroll = true;
            this._filterPreviewScrollPanel.Controls.Add(this._filterPreview);
            this._filterPreviewScrollPanel.Location = new System.Drawing.Point(24, 34);
            this._filterPreviewScrollPanel.Name = "_filterPreviewScrollPanel";
            this._filterPreviewScrollPanel.Size = new System.Drawing.Size(226, 560);
            this._filterPreviewScrollPanel.TabIndex = 0;
            // 
            // _filterPreview
            // 
            this._filterPreview.AutoSize = true;
            this._filterPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filterPreview.ForeColor = System.Drawing.SystemColors.Control;
            this._filterPreview.Location = new System.Drawing.Point(0, 0);
            this._filterPreview.Name = "_filterPreview";
            this._filterPreview.Size = new System.Drawing.Size(0, 16);
            this._filterPreview.TabIndex = 0;
            // 
            // _templateHelpButton
            // 
            this._templateHelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._templateHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._templateHelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._templateHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._templateHelpButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateHelpButton.ForeColor = System.Drawing.SystemColors.Control;
            this._templateHelpButton.Location = new System.Drawing.Point(970, 29);
            this._templateHelpButton.Name = "_templateHelpButton";
            this._templateHelpButton.Size = new System.Drawing.Size(113, 23);
            this._templateHelpButton.TabIndex = 17;
            this._templateHelpButton.Text = "Help";
            this._templateHelpButton.UseVisualStyleBackColor = true;
            this._templateHelpButton.Click += new System.EventHandler(this.onTemplateHelpClicked);
            // 
            // _templateTitleBG
            // 
            this._templateTitleBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Title_BG_2;
            this._templateTitleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._templateTitleBG.Controls.Add(this._templateTitleLabel);
            this._templateTitleBG.Location = new System.Drawing.Point(28, 9);
            this._templateTitleBG.Name = "_templateTitleBG";
            this._templateTitleBG.Size = new System.Drawing.Size(134, 44);
            this._templateTitleBG.TabIndex = 23;
            // 
            // _templateTitleLabel
            // 
            this._templateTitleLabel.AutoSize = true;
            this._templateTitleLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._templateTitleLabel.Location = new System.Drawing.Point(18, 11);
            this._templateTitleLabel.Name = "_templateTitleLabel";
            this._templateTitleLabel.Size = new System.Drawing.Size(99, 23);
            this._templateTitleLabel.TabIndex = 10;
            this._templateTitleLabel.Text = "Template";
            // 
            // _filterTogglesHeaderBG
            // 
            this._filterTogglesHeaderBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Title_BG_2;
            this._filterTogglesHeaderBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._filterTogglesHeaderBG.Controls.Add(this.label1);
            this._filterTogglesHeaderBG.Location = new System.Drawing.Point(444, 298);
            this._filterTogglesHeaderBG.Name = "_filterTogglesHeaderBG";
            this._filterTogglesHeaderBG.Size = new System.Drawing.Size(193, 44);
            this._filterTogglesHeaderBG.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Available Filters";
            // 
            // _currentFilter
            // 
            this._currentFilter.AutoSize = true;
            this._currentFilter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currentFilter.ForeColor = System.Drawing.SystemColors.Control;
            this._currentFilter.Location = new System.Drawing.Point(570, 8);
            this._currentFilter.Name = "_currentFilter";
            this._currentFilter.Size = new System.Drawing.Size(0, 19);
            this._currentFilter.TabIndex = 20;
            // 
            // _currentFilterLabel
            // 
            this._currentFilterLabel.AutoSize = true;
            this._currentFilterLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currentFilterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._currentFilterLabel.Location = new System.Drawing.Point(412, 3);
            this._currentFilterLabel.Name = "_currentFilterLabel";
            this._currentFilterLabel.Size = new System.Drawing.Size(159, 25);
            this._currentFilterLabel.TabIndex = 19;
            this._currentFilterLabel.Text = "Current Filter:";
            // 
            // _templateEntryBGPanel
            // 
            this._templateEntryBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._templateEntryBGPanel.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Vertical_Text_BG;
            this._templateEntryBGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._templateEntryBGPanel.Controls.Add(this._templateBox);
            this._templateEntryBGPanel.Location = new System.Drawing.Point(4, 29);
            this._templateEntryBGPanel.Name = "_templateEntryBGPanel";
            this._templateEntryBGPanel.Size = new System.Drawing.Size(412, 566);
            this._templateEntryBGPanel.TabIndex = 18;
            // 
            // _templateBox
            // 
            this._templateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._templateBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this._templateBox.AutoScrollMinSize = new System.Drawing.Size(0, 15);
            this._templateBox.BackBrush = null;
            this._templateBox.BackColor = System.Drawing.Color.Transparent;
            this._templateBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._templateBox.CharHeight = 15;
            this._templateBox.CharWidth = 7;
            this._templateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._templateBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._templateBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this._templateBox.ForeColor = System.Drawing.SystemColors.Control;
            this._templateBox.IsReplaceMode = false;
            this._templateBox.Location = new System.Drawing.Point(35, 42);
            this._templateBox.Name = "_templateBox";
            this._templateBox.Paddings = new System.Windows.Forms.Padding(0);
            this._templateBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._templateBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_templateBox.ServiceColors")));
            this._templateBox.ShowLineNumbers = false;
            this._templateBox.Size = new System.Drawing.Size(372, 497);
            this._templateBox.TabIndex = 3;
            this._templateBox.WordWrap = true;
            this._templateBox.Zoom = 100;
            this._templateBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.onTemplateTextChanged);
            // 
            // _filterTogglesBGPanel
            // 
            this._filterTogglesBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._filterTogglesBGPanel.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Filters_BG;
            this._filterTogglesBGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._filterTogglesBGPanel.Controls.Add(this._filterTogglesScrollPanel);
            this._filterTogglesBGPanel.Location = new System.Drawing.Point(417, 319);
            this._filterTogglesBGPanel.Name = "_filterTogglesBGPanel";
            this._filterTogglesBGPanel.Size = new System.Drawing.Size(672, 276);
            this._filterTogglesBGPanel.TabIndex = 17;
            // 
            // _filterTogglesScrollPanel
            // 
            this._filterTogglesScrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterTogglesScrollPanel.AutoScroll = true;
            this._filterTogglesScrollPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._filterTogglesScrollPanel.Controls.Add(this._filterToggles);
            this._filterTogglesScrollPanel.Location = new System.Drawing.Point(5, 3);
            this._filterTogglesScrollPanel.Name = "_filterTogglesScrollPanel";
            this._filterTogglesScrollPanel.Size = new System.Drawing.Size(664, 246);
            this._filterTogglesScrollPanel.TabIndex = 11;
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
            this._filterToggles.Location = new System.Drawing.Point(19, 26);
            this._filterToggles.Name = "_filterToggles";
            this._filterToggles.RowCount = 2;
            this._filterToggles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._filterToggles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._filterToggles.Size = new System.Drawing.Size(625, 60);
            this._filterToggles.TabIndex = 1;
            // 
            // _saveTemplateButton
            // 
            this._saveTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._saveTemplateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._saveTemplateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._saveTemplateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._saveTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._saveTemplateButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saveTemplateButton.ForeColor = System.Drawing.SystemColors.Control;
            this._saveTemplateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._saveTemplateButton.Location = new System.Drawing.Point(150, 601);
            this._saveTemplateButton.Name = "_saveTemplateButton";
            this._saveTemplateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._saveTemplateButton.Size = new System.Drawing.Size(123, 43);
            this._saveTemplateButton.TabIndex = 1;
            this._saveTemplateButton.Text = "Save Template";
            this._saveTemplateButton.UseVisualStyleBackColor = false;
            this._saveTemplateButton.Click += new System.EventHandler(this.onSaveTemplateClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._appliedFilters);
            this.panel2.Location = new System.Drawing.Point(422, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 221);
            this.panel2.TabIndex = 14;
            // 
            // _appliedFilters
            // 
            this._appliedFilters.ColumnCount = 4;
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._appliedFilters.Location = new System.Drawing.Point(7, 7);
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
            // _clearFiltersButton
            // 
            this._clearFiltersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._clearFiltersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._clearFiltersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._clearFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._clearFiltersButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clearFiltersButton.ForeColor = System.Drawing.SystemColors.Control;
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
            this._addFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._addFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._addFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._addFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addFilterButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addFilterButton.ForeColor = System.Drawing.SystemColors.Control;
            this._addFilterButton.Location = new System.Drawing.Point(417, 29);
            this._addFilterButton.Name = "_addFilterButton";
            this._addFilterButton.Size = new System.Drawing.Size(113, 23);
            this._addFilterButton.TabIndex = 15;
            this._addFilterButton.Text = "Add Filter";
            this._addFilterButton.UseVisualStyleBackColor = true;
            this._addFilterButton.Click += new System.EventHandler(this.onAddFilterClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(655, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Applied Filters (click to remove)";
            // 
            // _outputBGPanel
            // 
            this._outputBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputBGPanel.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Shop_BG;
            this._outputBGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputBGPanel.Controls.Add(this._outputBoxTitleBG);
            this._outputBGPanel.Controls.Add(this._outputBoxBG);
            this._outputBGPanel.Controls.Add(this._generateOutputButton);
            this._outputBGPanel.Controls.Add(this._clearButton);
            this._outputBGPanel.Controls.Add(this._clipboardButton);
            this._outputBGPanel.Controls.Add(this._outputTabControlsBGPanel1);
            this._outputBGPanel.Controls.Add(this._outputTabControlsBGPanel2);
            this._outputBGPanel.Location = new System.Drawing.Point(3, 0);
            this._outputBGPanel.Name = "_outputBGPanel";
            this._outputBGPanel.Size = new System.Drawing.Size(1355, 658);
            this._outputBGPanel.TabIndex = 13;
            // 
            // _outputBoxTitleBG
            // 
            this._outputBoxTitleBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Title_BG_2;
            this._outputBoxTitleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputBoxTitleBG.Controls.Add(this._outputBoxTitle);
            this._outputBoxTitleBG.Location = new System.Drawing.Point(32, 5);
            this._outputBoxTitleBG.Name = "_outputBoxTitleBG";
            this._outputBoxTitleBG.Size = new System.Drawing.Size(134, 44);
            this._outputBoxTitleBG.TabIndex = 16;
            // 
            // _outputBoxTitle
            // 
            this._outputBoxTitle.AutoSize = true;
            this._outputBoxTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._outputBoxTitle.Location = new System.Drawing.Point(28, 12);
            this._outputBoxTitle.Name = "_outputBoxTitle";
            this._outputBoxTitle.Size = new System.Drawing.Size(77, 23);
            this._outputBoxTitle.TabIndex = 0;
            this._outputBoxTitle.Text = "Output";
            // 
            // _outputBoxBG
            // 
            this._outputBoxBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputBoxBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Output_BG;
            this._outputBoxBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputBoxBG.Controls.Add(this._outputBox);
            this._outputBoxBG.Location = new System.Drawing.Point(1, 17);
            this._outputBoxBG.Name = "_outputBoxBG";
            this._outputBoxBG.Size = new System.Drawing.Size(1152, 581);
            this._outputBoxBG.TabIndex = 15;
            // 
            // _outputBox
            // 
            this._outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this._outputBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this._outputBox.BackBrush = null;
            this._outputBox.BackColor = System.Drawing.Color.Transparent;
            this._outputBox.CharHeight = 14;
            this._outputBox.CharWidth = 8;
            this._outputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._outputBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._outputBox.ForeColor = System.Drawing.SystemColors.Control;
            this._outputBox.IsReplaceMode = false;
            this._outputBox.Location = new System.Drawing.Point(24, 35);
            this._outputBox.Name = "_outputBox";
            this._outputBox.Paddings = new System.Windows.Forms.Padding(0);
            this._outputBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._outputBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_outputBox.ServiceColors")));
            this._outputBox.ShowLineNumbers = false;
            this._outputBox.Size = new System.Drawing.Size(1114, 512);
            this._outputBox.TabIndex = 0;
            this._outputBox.WordWrap = true;
            this._outputBox.Zoom = 100;
            // 
            // _generateOutputButton
            // 
            this._generateOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._generateOutputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._generateOutputButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._generateOutputButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._generateOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._generateOutputButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._generateOutputButton.ForeColor = System.Drawing.SystemColors.Control;
            this._generateOutputButton.Location = new System.Drawing.Point(721, 604);
            this._generateOutputButton.Name = "_generateOutputButton";
            this._generateOutputButton.Size = new System.Drawing.Size(140, 44);
            this._generateOutputButton.TabIndex = 1;
            this._generateOutputButton.Text = "Generate";
            this._generateOutputButton.UseVisualStyleBackColor = true;
            this._generateOutputButton.Click += new System.EventHandler(this.onGenerateOutputClicked);
            // 
            // _clearButton
            // 
            this._clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._clearButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this._clearButton.Location = new System.Drawing.Point(867, 604);
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
            this._clipboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._clipboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._clipboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._clipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._clipboardButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clipboardButton.ForeColor = System.Drawing.SystemColors.Control;
            this._clipboardButton.Location = new System.Drawing.Point(1013, 604);
            this._clipboardButton.Name = "_clipboardButton";
            this._clipboardButton.Size = new System.Drawing.Size(140, 44);
            this._clipboardButton.TabIndex = 3;
            this._clipboardButton.Text = "Copy to Clipboard";
            this._clipboardButton.UseVisualStyleBackColor = true;
            this._clipboardButton.Click += new System.EventHandler(this.onClipboardButtonPressed);
            // 
            // _outputTabControlsBGPanel1
            // 
            this._outputTabControlsBGPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._outputTabControlsBGPanel1.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Vertical_Text_Short_BG;
            this._outputTabControlsBGPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputTabControlsBGPanel1.Controls.Add(this._colorizeSpecialsCheck);
            this._outputTabControlsBGPanel1.Controls.Add(this._colorizeHitCheck);
            this._outputTabControlsBGPanel1.Controls.Add(this._colorizePercentages);
            this._outputTabControlsBGPanel1.Controls.Add(this._editColorsButton);
            this._outputTabControlsBGPanel1.Location = new System.Drawing.Point(1159, 113);
            this._outputTabControlsBGPanel1.Name = "_outputTabControlsBGPanel1";
            this._outputTabControlsBGPanel1.Size = new System.Drawing.Size(192, 166);
            this._outputTabControlsBGPanel1.TabIndex = 13;
            // 
            // _colorizeSpecialsCheck
            // 
            this._colorizeSpecialsCheck.AutoSize = true;
            this._colorizeSpecialsCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._colorizeSpecialsCheck.ForeColor = System.Drawing.SystemColors.Control;
            this._colorizeSpecialsCheck.Location = new System.Drawing.Point(15, 11);
            this._colorizeSpecialsCheck.Name = "_colorizeSpecialsCheck";
            this._colorizeSpecialsCheck.Size = new System.Drawing.Size(169, 17);
            this._colorizeSpecialsCheck.TabIndex = 9;
            this._colorizeSpecialsCheck.Text = "Colorize Weapon Specials";
            this._colorizeSpecialsCheck.UseVisualStyleBackColor = true;
            this._colorizeSpecialsCheck.CheckedChanged += new System.EventHandler(this.onColorizeSpecialsChecked);
            // 
            // _colorizeHitCheck
            // 
            this._colorizeHitCheck.AutoSize = true;
            this._colorizeHitCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._colorizeHitCheck.ForeColor = System.Drawing.SystemColors.Control;
            this._colorizeHitCheck.Location = new System.Drawing.Point(15, 34);
            this._colorizeHitCheck.Name = "_colorizeHitCheck";
            this._colorizeHitCheck.Size = new System.Drawing.Size(143, 17);
            this._colorizeHitCheck.TabIndex = 10;
            this._colorizeHitCheck.Text = "Colorize Hit Percents";
            this._colorizeHitCheck.UseVisualStyleBackColor = true;
            this._colorizeHitCheck.CheckedChanged += new System.EventHandler(this.onColorizeHitChecked);
            // 
            // _colorizePercentages
            // 
            this._colorizePercentages.AutoSize = true;
            this._colorizePercentages.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._colorizePercentages.ForeColor = System.Drawing.SystemColors.Control;
            this._colorizePercentages.Location = new System.Drawing.Point(14, 57);
            this._colorizePercentages.Name = "_colorizePercentages";
            this._colorizePercentages.Size = new System.Drawing.Size(169, 17);
            this._colorizePercentages.TabIndex = 11;
            this._colorizePercentages.Text = "Colorize Non-Hit Percents";
            this._colorizePercentages.UseVisualStyleBackColor = true;
            this._colorizePercentages.CheckedChanged += new System.EventHandler(this.onColorizePercentagesChecked);
            // 
            // _editColorsButton
            // 
            this._editColorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._editColorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._editColorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._editColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._editColorsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editColorsButton.ForeColor = System.Drawing.SystemColors.Control;
            this._editColorsButton.Location = new System.Drawing.Point(24, 92);
            this._editColorsButton.Name = "_editColorsButton";
            this._editColorsButton.Size = new System.Drawing.Size(140, 44);
            this._editColorsButton.TabIndex = 12;
            this._editColorsButton.Text = "Edit Colors";
            this._editColorsButton.UseVisualStyleBackColor = true;
            this._editColorsButton.Click += new System.EventHandler(this.onEditColorsClicked);
            // 
            // _outputTabControlsBGPanel2
            // 
            this._outputTabControlsBGPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._outputTabControlsBGPanel2.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Vertical_Text_Short_BG;
            this._outputTabControlsBGPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputTabControlsBGPanel2.Controls.Add(this._boldPriceCheck);
            this._outputTabControlsBGPanel2.Controls.Add(this._multiPriceCheck);
            this._outputTabControlsBGPanel2.Controls.Add(this._untekkText);
            this._outputTabControlsBGPanel2.Controls.Add(this._untekkTextLabel);
            this._outputTabControlsBGPanel2.Location = new System.Drawing.Point(1160, 438);
            this._outputTabControlsBGPanel2.Name = "_outputTabControlsBGPanel2";
            this._outputTabControlsBGPanel2.Size = new System.Drawing.Size(188, 165);
            this._outputTabControlsBGPanel2.TabIndex = 14;
            // 
            // _boldPriceCheck
            // 
            this._boldPriceCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._boldPriceCheck.AutoSize = true;
            this._boldPriceCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._boldPriceCheck.ForeColor = System.Drawing.SystemColors.Control;
            this._boldPriceCheck.Location = new System.Drawing.Point(18, 34);
            this._boldPriceCheck.Name = "_boldPriceCheck";
            this._boldPriceCheck.Size = new System.Drawing.Size(81, 17);
            this._boldPriceCheck.TabIndex = 5;
            this._boldPriceCheck.Text = "Bold Price";
            this._boldPriceCheck.UseVisualStyleBackColor = true;
            this._boldPriceCheck.CheckedChanged += new System.EventHandler(this.onBoldPriceChecked);
            // 
            // _multiPriceCheck
            // 
            this._multiPriceCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._multiPriceCheck.AutoSize = true;
            this._multiPriceCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._multiPriceCheck.ForeColor = System.Drawing.SystemColors.Control;
            this._multiPriceCheck.Location = new System.Drawing.Point(18, 48);
            this._multiPriceCheck.Name = "_multiPriceCheck";
            this._multiPriceCheck.Size = new System.Drawing.Size(145, 30);
            this._multiPriceCheck.TabIndex = 6;
            this._multiPriceCheck.Text = "Print Price in Multiple\r\nUnits";
            this._multiPriceCheck.UseVisualStyleBackColor = true;
            this._multiPriceCheck.CheckedChanged += new System.EventHandler(this.onMultiPriceChecked);
            // 
            // _untekkText
            // 
            this._untekkText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._untekkText.Location = new System.Drawing.Point(23, 120);
            this._untekkText.Name = "_untekkText";
            this._untekkText.Size = new System.Drawing.Size(151, 21);
            this._untekkText.TabIndex = 8;
            this._untekkText.TextChanged += new System.EventHandler(this.onUntekkTextChanged);
            // 
            // _untekkTextLabel
            // 
            this._untekkTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._untekkTextLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._untekkTextLabel.ForeColor = System.Drawing.SystemColors.Control;
            this._untekkTextLabel.Location = new System.Drawing.Point(20, 103);
            this._untekkTextLabel.Name = "_untekkTextLabel";
            this._untekkTextLabel.Size = new System.Drawing.Size(143, 23);
            this._untekkTextLabel.TabIndex = 0;
            this._untekkTextLabel.Text = "Untekk Identifier:";
            // 
            // PSOShopkeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1358, 721);
            this.Controls.Add(this._tabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PSOShopkeeperForm";
            this.Text = "PSO Shopkeeper";
            this._outputTab.ResumeLayout(false);
            this._tabs.ResumeLayout(false);
            this._templateTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._templateBGPanel.ResumeLayout(false);
            this._templateBGPanel.PerformLayout();
            this._filterPreviewTitleBG.ResumeLayout(false);
            this._filterPreviewTitleBG.PerformLayout();
            this._filterPreviewBG.ResumeLayout(false);
            this._filterPreviewScrollPanel.ResumeLayout(false);
            this._filterPreviewScrollPanel.PerformLayout();
            this._templateTitleBG.ResumeLayout(false);
            this._templateTitleBG.PerformLayout();
            this._filterTogglesHeaderBG.ResumeLayout(false);
            this._filterTogglesHeaderBG.PerformLayout();
            this._templateEntryBGPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._templateBox)).EndInit();
            this._filterTogglesBGPanel.ResumeLayout(false);
            this._filterTogglesScrollPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this._outputBGPanel.ResumeLayout(false);
            this._outputBoxTitleBG.ResumeLayout(false);
            this._outputBoxTitleBG.PerformLayout();
            this._outputBoxBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._outputBox)).EndInit();
            this._outputTabControlsBGPanel1.ResumeLayout(false);
            this._outputTabControlsBGPanel1.PerformLayout();
            this._outputTabControlsBGPanel2.ResumeLayout(false);
            this._outputTabControlsBGPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage _outputTab;
        private System.Windows.Forms.TabPage _itemListView;
        private System.Windows.Forms.TabControl _tabs;
        private System.Windows.Forms.TabPage _templateTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button _saveTemplateButton;
        private System.Windows.Forms.Button _generateOutputButton;
        private System.Windows.Forms.Button _clipboardButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox _multiPriceCheck;
        private System.Windows.Forms.CheckBox _boldPriceCheck;
        private System.Windows.Forms.TextBox _untekkText;
        private System.Windows.Forms.CheckBox _colorizePercentages;
        private System.Windows.Forms.CheckBox _colorizeHitCheck;
        private System.Windows.Forms.CheckBox _colorizeSpecialsCheck;  
        private System.Windows.Forms.Button _editColorsButton;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.Button _clearFiltersButton;
        private System.Windows.Forms.Button _addFilterButton;
        private System.Windows.Forms.Panel panel2;
        private PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel _appliedFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _templateHelpButton;
        private System.Windows.Forms.Label _untekkTextLabel;
        private FastColoredTextBoxNS.FastColoredTextBox _templateBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _filterTogglesScrollPanel;
        private PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel _filterToggles;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _templateBGPanel;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _filterTogglesBGPanel;
        private Controls.DoubleBufferedPanel _templateEntryBGPanel;
        private Controls.DoubleBufferedPanel _outputBGPanel;
        private Controls.DoubleBufferedPanel _outputTabControlsBGPanel1;
        private System.Windows.Forms.Label _currentFilter;
        private System.Windows.Forms.Label _currentFilterLabel;
        private Controls.DoubleBufferedPanel _filterTogglesHeaderBG;
        private Controls.DoubleBufferedPanel _templateTitleBG;
        private System.Windows.Forms.Label _templateTitleLabel;
        private Controls.DoubleBufferedPanel _filterPreviewBG;
        private System.Windows.Forms.Label _filterPreview;
        private Controls.DoubleBufferedPanel _filterPreviewTitleBG;
        private System.Windows.Forms.Label _filterPreviewTitle;
        private System.Windows.Forms.Panel _filterPreviewScrollPanel;
        private Controls.DoubleBufferedPanel _outputTabControlsBGPanel2;
        private Controls.DoubleBufferedPanel _outputBoxBG;
        private FastColoredTextBoxNS.FastColoredTextBox _outputBox;
        private Controls.DoubleBufferedPanel _outputBoxTitleBG;
        private System.Windows.Forms.Label _outputBoxTitle;
    }
}


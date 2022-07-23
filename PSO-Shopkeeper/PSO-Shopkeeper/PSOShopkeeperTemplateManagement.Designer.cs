﻿namespace PSOShopkeeper
{
    partial class PSOShopkeeperTemplateManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSOShopkeeperTemplateManagement));
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
            this._availableFiltersLabel = new System.Windows.Forms.Label();
            this._currentFilter = new System.Windows.Forms.Label();
            this._currentFilterLabel = new System.Windows.Forms.Label();
            this._templateEntryBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._templateBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this._filterTogglesBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._filterTogglesScrollPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._filterToggles = new PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel();
            this._saveTemplateButton = new System.Windows.Forms.Button();
            this._appliedFiltersPanel = new System.Windows.Forms.Panel();
            this._appliedFilters = new PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel();
            this._clearFiltersButton = new System.Windows.Forms.Button();
            this._addFilterButton = new System.Windows.Forms.Button();
            this._appliedFiltersLabel = new System.Windows.Forms.Label();
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
            this._appliedFiltersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _templateBGPanel
            // 
            this._templateBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._templateBGPanel.BackColor = System.Drawing.Color.Transparent;
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
            this._templateBGPanel.Controls.Add(this._appliedFiltersPanel);
            this._templateBGPanel.Controls.Add(this._clearFiltersButton);
            this._templateBGPanel.Controls.Add(this._addFilterButton);
            this._templateBGPanel.Controls.Add(this._appliedFiltersLabel);
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
            this._filterTogglesHeaderBG.Controls.Add(this._availableFiltersLabel);
            this._filterTogglesHeaderBG.Location = new System.Drawing.Point(444, 298);
            this._filterTogglesHeaderBG.Name = "_filterTogglesHeaderBG";
            this._filterTogglesHeaderBG.Size = new System.Drawing.Size(193, 44);
            this._filterTogglesHeaderBG.TabIndex = 21;
            // 
            // _availableFiltersLabel
            // 
            this._availableFiltersLabel.AutoSize = true;
            this._availableFiltersLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._availableFiltersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._availableFiltersLabel.Location = new System.Drawing.Point(18, 11);
            this._availableFiltersLabel.Name = "_availableFiltersLabel";
            this._availableFiltersLabel.Size = new System.Drawing.Size(163, 23);
            this._availableFiltersLabel.TabIndex = 10;
            this._availableFiltersLabel.Text = "Available Filters";
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
            // _appliedFiltersPanel
            // 
            this._appliedFiltersPanel.Controls.Add(this._appliedFilters);
            this._appliedFiltersPanel.Location = new System.Drawing.Point(422, 73);
            this._appliedFiltersPanel.Name = "_appliedFiltersPanel";
            this._appliedFiltersPanel.Size = new System.Drawing.Size(667, 221);
            this._appliedFiltersPanel.TabIndex = 14;
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
            // _appliedFiltersLabel
            // 
            this._appliedFiltersLabel.AutoSize = true;
            this._appliedFiltersLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._appliedFiltersLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._appliedFiltersLabel.Location = new System.Drawing.Point(655, 27);
            this._appliedFiltersLabel.Name = "_appliedFiltersLabel";
            this._appliedFiltersLabel.Size = new System.Drawing.Size(309, 25);
            this._appliedFiltersLabel.TabIndex = 13;
            this._appliedFiltersLabel.Text = "Applied Filters (click to remove)";
            // 
            // PSOShopkeeperTemplateManagement
            // 
            this.Controls.Add(this._templateBGPanel);
            this.Name = "PSOShopkeeperTemplateManagement";
            this.Size = new System.Drawing.Size(1350, 651);
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
            this._appliedFiltersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.Button _clearFiltersButton;
        private System.Windows.Forms.Button _addFilterButton;
        private System.Windows.Forms.Panel _appliedFiltersPanel;
        private PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel _appliedFilters;
        private System.Windows.Forms.Label _appliedFiltersLabel;
        private System.Windows.Forms.Label _availableFiltersLabel;
        private System.Windows.Forms.Button _templateHelpButton;
        private FastColoredTextBoxNS.FastColoredTextBox _templateBox;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _filterTogglesScrollPanel;
        private PSOShopkeeper.Controls.DoubleBufferedTableLayoutPanel _filterToggles;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _templateBGPanel;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _filterTogglesBGPanel;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _templateEntryBGPanel;
        private Controls.DoubleBufferedPanel _filterTogglesHeaderBG;
        private Controls.DoubleBufferedPanel _templateTitleBG;
        private System.Windows.Forms.Label _templateTitleLabel;
        private Controls.DoubleBufferedPanel _filterPreviewBG;
        private System.Windows.Forms.Label _filterPreview;
        private Controls.DoubleBufferedPanel _filterPreviewTitleBG;
        private System.Windows.Forms.Label _filterPreviewTitle;
        private System.Windows.Forms.Panel _filterPreviewScrollPanel;
        private System.Windows.Forms.Label _currentFilter;
        private System.Windows.Forms.Label _currentFilterLabel;
        private System.Windows.Forms.Button _saveTemplateButton;
    }
}
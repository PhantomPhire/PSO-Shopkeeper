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
        private System.Windows.Forms.Button _generateOutputButton;
        private System.Windows.Forms.Button _clipboardButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox _multiPriceCheck;
        private System.Windows.Forms.CheckBox _boldPriceCheck;
        private System.Windows.Forms.TextBox _untekkText;
        private System.Windows.Forms.Label _untekkTextLabel;
        private System.Windows.Forms.CheckBox _colorizePercentages;
        private System.Windows.Forms.CheckBox _colorizeHitCheck;
        private System.Windows.Forms.CheckBox _colorizeSpecialsCheck;  
        private System.Windows.Forms.Button _editColorsButton;
        private Controls.DoubleBufferedPanel _outputBGPanel;
        private Controls.DoubleBufferedPanel _outputTabControlsBGPanel1;
        private Controls.DoubleBufferedPanel _outputTabControlsBGPanel2;
        private Controls.DoubleBufferedPanel _outputBoxBG;
        private FastColoredTextBoxNS.FastColoredTextBox _outputBox;
        private Controls.DoubleBufferedPanel _outputBoxTitleBG;
        private System.Windows.Forms.Label _outputBoxTitle;
    }
}


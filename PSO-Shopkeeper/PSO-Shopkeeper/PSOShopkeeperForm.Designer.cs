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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSOShopkeeperForm));
            this._addItemsButton = new System.Windows.Forms.Button();
            this._outputTab = new System.Windows.Forms.TabPage();
            this._clearButton = new System.Windows.Forms.Button();
            this._clipboardButton = new System.Windows.Forms.Button();
            this._outputBox = new System.Windows.Forms.RichTextBox();
            this._generateOutputButton = new System.Windows.Forms.Button();
            this._itemListView = new System.Windows.Forms.TabPage();
            this._clearItemsButton = new System.Windows.Forms.Button();
            this._savePricingButton = new System.Windows.Forms.Button();
            this._itemInformation = new System.Windows.Forms.Label();
            this._itemListPanel = new System.Windows.Forms.DataGridView();
            this._tabs = new System.Windows.Forms.TabControl();
            this._templateTab = new System.Windows.Forms.TabPage();
            this._templateBox = new System.Windows.Forms.RichTextBox();
            this._templateHints = new System.Windows.Forms.Label();
            this._saveTemplateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._settingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this._outputTab.SuspendLayout();
            this._itemListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).BeginInit();
            this._tabs.SuspendLayout();
            this._templateTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _addItemsButton
            // 
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
            // _clearButton
            // 
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
            this._outputBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._outputBox.Location = new System.Drawing.Point(4, 0);
            this._outputBox.Name = "_outputBox";
            this._outputBox.Size = new System.Drawing.Size(1341, 603);
            this._outputBox.TabIndex = 2;
            this._outputBox.Text = "";
            // 
            // _generateOutputButton
            // 
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
            this._itemListView.Controls.Add(this._itemInformation);
            this._itemListView.Controls.Add(this._itemListPanel);
            this._itemListView.Location = new System.Drawing.Point(4, 36);
            this._itemListView.Name = "_itemListView";
            this._itemListView.Padding = new System.Windows.Forms.Padding(3);
            this._itemListView.Size = new System.Drawing.Size(1348, 654);
            this._itemListView.TabIndex = 0;
            this._itemListView.Text = "Item List";
            this._itemListView.UseVisualStyleBackColor = true;
            // 
            // _clearItemsButton
            // 
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
            this._savePricingButton.Location = new System.Drawing.Point(723, 603);
            this._savePricingButton.Name = "_savePricingButton";
            this._savePricingButton.Size = new System.Drawing.Size(108, 45);
            this._savePricingButton.TabIndex = 2;
            this._savePricingButton.Text = "Save Prices";
            this._savePricingButton.UseVisualStyleBackColor = true;
            this._savePricingButton.Click += new System.EventHandler(this.onSavePricesClicked);
            // 
            // _itemInformation
            // 
            this._itemInformation.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._itemInformation.Location = new System.Drawing.Point(948, 0);
            this._itemInformation.Name = "_itemInformation";
            this._itemInformation.Size = new System.Drawing.Size(392, 648);
            this._itemInformation.TabIndex = 1;
            // 
            // _itemListPanel
            // 
            this._itemListPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._itemListPanel.Location = new System.Drawing.Point(0, 3);
            this._itemListPanel.Name = "_itemListPanel";
            this._itemListPanel.Size = new System.Drawing.Size(942, 594);
            this._itemListPanel.TabIndex = 0;
            this._itemListPanel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            this._itemListPanel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            this._itemListPanel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellChanged);
            // 
            // _tabs
            // 
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
            this._templateTab.Controls.Add(this._templateBox);
            this._templateTab.Controls.Add(this._templateHints);
            this._templateTab.Controls.Add(this._saveTemplateButton);
            this._templateTab.Location = new System.Drawing.Point(4, 36);
            this._templateTab.Name = "_templateTab";
            this._templateTab.Padding = new System.Windows.Forms.Padding(3);
            this._templateTab.Size = new System.Drawing.Size(1348, 654);
            this._templateTab.TabIndex = 2;
            this._templateTab.Text = "Template";
            this._templateTab.UseVisualStyleBackColor = true;
            // 
            // _templateBox
            // 
            this._templateBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateBox.Location = new System.Drawing.Point(0, 1);
            this._templateBox.Name = "_templateBox";
            this._templateBox.Size = new System.Drawing.Size(711, 594);
            this._templateBox.TabIndex = 3;
            this._templateBox.Text = "";
            this._templateBox.TextChanged += new System.EventHandler(this.onTemplateTextChanged);
            // 
            // _templateHints
            // 
            this._templateHints.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateHints.Location = new System.Drawing.Point(717, 3);
            this._templateHints.Name = "_templateHints";
            this._templateHints.Size = new System.Drawing.Size(628, 659);
            this._templateHints.TabIndex = 2;
            // 
            // _saveTemplateButton
            // 
            this._saveTemplateButton.Location = new System.Drawing.Point(312, 605);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.onAddItemsClicked);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.onSaveClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // _settingsButton
            // 
            this._settingsButton.Name = "_settingsButton";
            this._settingsButton.Size = new System.Drawing.Size(180, 22);
            this._settingsButton.Text = "Settings";
            this._settingsButton.Click += new System.EventHandler(this.onSettingsButtonClicked);
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
            this._itemListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).EndInit();
            this._tabs.ResumeLayout(false);
            this._templateTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label _itemInformation;
        private System.Windows.Forms.TabPage _templateTab;
        private System.Windows.Forms.Button _savePricingButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button _saveTemplateButton;
        private System.Windows.Forms.Label _templateHints;
        private System.Windows.Forms.RichTextBox _templateBox;
        private System.Windows.Forms.Button _generateOutputButton;
        private System.Windows.Forms.RichTextBox _outputBox;
        private System.Windows.Forms.Button _clipboardButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _settingsButton;
    }
}


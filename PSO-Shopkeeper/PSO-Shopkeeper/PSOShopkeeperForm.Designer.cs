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
            this._outputTab.SuspendLayout();
            this._tabs.SuspendLayout();
            this._templateTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _outputTab
            // 
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


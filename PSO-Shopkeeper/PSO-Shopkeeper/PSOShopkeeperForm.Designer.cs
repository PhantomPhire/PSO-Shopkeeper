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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._bgPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._tabBox = new System.Windows.Forms.GroupBox();
            this._outputTabButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._itemTabButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._templateTabButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this.menuStrip1.SuspendLayout();
            this._bgPanel.SuspendLayout();
            this._tabBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
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
            // _bgPanel
            // 
            this._bgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bgPanel.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Shop_BG;
            this._bgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._bgPanel.Controls.Add(this._tabBox);
            this._bgPanel.Location = new System.Drawing.Point(0, 27);
            this._bgPanel.Name = "_bgPanel";
            this._bgPanel.Size = new System.Drawing.Size(1360, 781);
            this._bgPanel.TabIndex = 4;
            // 
            // _tabBox
            // 
            this._tabBox.BackColor = System.Drawing.Color.Transparent;
            this._tabBox.Controls.Add(this._outputTabButton);
            this._tabBox.Controls.Add(this._itemTabButton);
            this._tabBox.Controls.Add(this._templateTabButton);
            this._tabBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabBox.ForeColor = System.Drawing.SystemColors.Control;
            this._tabBox.Location = new System.Drawing.Point(17, 13);
            this._tabBox.Name = "_tabBox";
            this._tabBox.Size = new System.Drawing.Size(1321, 70);
            this._tabBox.TabIndex = 0;
            this._tabBox.TabStop = false;
            // 
            // _outputTabButton
            // 
            this._outputTabButton.Active = false;
            this._outputTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._outputTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._outputTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._outputTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._outputTabButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._outputTabButton.ForeColor = System.Drawing.Color.White;
            this._outputTabButton.Location = new System.Drawing.Point(941, 15);
            this._outputTabButton.Name = "_outputTabButton";
            this._outputTabButton.Size = new System.Drawing.Size(159, 44);
            this._outputTabButton.TabIndex = 2;
            this._outputTabButton.Text = "Output";
            this._outputTabButton.UseVisualStyleBackColor = false;
            this._outputTabButton.Click += new System.EventHandler(this.onOutputTabButtonClicked);
            // 
            // _itemTabButton
            // 
            this._itemTabButton.Active = false;
            this._itemTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._itemTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._itemTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._itemTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._itemTabButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._itemTabButton.ForeColor = System.Drawing.Color.White;
            this._itemTabButton.Location = new System.Drawing.Point(228, 15);
            this._itemTabButton.Name = "_itemTabButton";
            this._itemTabButton.Size = new System.Drawing.Size(159, 44);
            this._itemTabButton.TabIndex = 1;
            this._itemTabButton.Text = "Items";
            this._itemTabButton.UseVisualStyleBackColor = false;
            this._itemTabButton.Click += new System.EventHandler(this.onItemTabButtonClicked);
            // 
            // _templateTabButton
            // 
            this._templateTabButton.Active = false;
            this._templateTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._templateTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._templateTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._templateTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._templateTabButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateTabButton.ForeColor = System.Drawing.Color.White;
            this._templateTabButton.Location = new System.Drawing.Point(591, 15);
            this._templateTabButton.Name = "_templateTabButton";
            this._templateTabButton.Size = new System.Drawing.Size(159, 44);
            this._templateTabButton.TabIndex = 0;
            this._templateTabButton.Text = "Template";
            this._templateTabButton.UseVisualStyleBackColor = false;
            this._templateTabButton.Click += new System.EventHandler(this.onTemplateTabButtonClicked);
            // 
            // PSOShopkeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 799);
            this.Controls.Add(this._bgPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PSOShopkeeperForm";
            this.Text = "PSO Shopkeeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._bgPanel.ResumeLayout(false);
            this._tabBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controls.DoubleBufferedPanel _bgPanel;
        private System.Windows.Forms.GroupBox _tabBox;
        private Controls.PSOShopkeeperButton _outputTabButton;
        private Controls.PSOShopkeeperButton _itemTabButton;
        private Controls.PSOShopkeeperButton _templateTabButton;
    }
}


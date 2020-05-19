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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._itemListView = new System.Windows.Forms.TabPage();
            this._itemInformation = new System.Windows.Forms.Label();
            this._itemListPanel = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._clearItemsButton = new System.Windows.Forms.Button();
            this._itemListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _addItemsButton
            // 
            this._addItemsButton.Location = new System.Drawing.Point(919, 705);
            this._addItemsButton.Name = "_addItemsButton";
            this._addItemsButton.Size = new System.Drawing.Size(75, 23);
            this._addItemsButton.TabIndex = 1;
            this._addItemsButton.Text = "Add Items";
            this._addItemsButton.UseVisualStyleBackColor = true;
            this._addItemsButton.Click += new System.EventHandler(this.onAddItemsClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1343, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _itemListView
            // 
            this._itemListView.AutoScroll = true;
            this._itemListView.Controls.Add(this._itemInformation);
            this._itemListView.Controls.Add(this._itemListPanel);
            this._itemListView.Location = new System.Drawing.Point(4, 22);
            this._itemListView.Name = "_itemListView";
            this._itemListView.Padding = new System.Windows.Forms.Padding(3);
            this._itemListView.Size = new System.Drawing.Size(1348, 645);
            this._itemListView.TabIndex = 0;
            this._itemListView.Text = "Item List";
            this._itemListView.UseVisualStyleBackColor = true;
            // 
            // _itemInformation
            // 
            this._itemInformation.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._itemInformation.Location = new System.Drawing.Point(948, 0);
            this._itemInformation.Name = "_itemInformation";
            this._itemInformation.Size = new System.Drawing.Size(394, 629);
            this._itemInformation.TabIndex = 1;
            // 
            // _itemListPanel
            // 
            this._itemListPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._itemListPanel.Location = new System.Drawing.Point(0, 3);
            this._itemListPanel.Name = "_itemListPanel";
            this._itemListPanel.Size = new System.Drawing.Size(942, 629);
            this._itemListPanel.TabIndex = 0;
            this._itemListPanel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            this._itemListPanel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._itemListView);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1356, 671);
            this.tabControl1.TabIndex = 0;
            // 
            // _clearItemsButton
            // 
            this._clearItemsButton.Location = new System.Drawing.Point(1022, 705);
            this._clearItemsButton.Name = "_clearItemsButton";
            this._clearItemsButton.Size = new System.Drawing.Size(75, 23);
            this._clearItemsButton.TabIndex = 2;
            this._clearItemsButton.Text = "Clear Items";
            this._clearItemsButton.UseVisualStyleBackColor = true;
            this._clearItemsButton.Click += new System.EventHandler(this.onClearItemsClicked);
            // 
            // PSOShopkeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 740);
            this.Controls.Add(this._clearItemsButton);
            this.Controls.Add(this._addItemsButton);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PSOShopkeeperForm";
            this.Text = "PSO Shopkeeper";
            this._itemListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _addItemsButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage _itemListView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button _clearItemsButton;
        private System.Windows.Forms.DataGridView _itemListPanel;
        private System.Windows.Forms.Label _itemInformation;
    }
}


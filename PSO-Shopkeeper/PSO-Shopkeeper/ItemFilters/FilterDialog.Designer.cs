namespace PSOShopkeeper.ItemFilters
{
    partial class FilterDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterDialog));
            this._filterName = new System.Windows.Forms.Label();
            this._filterDescription = new System.Windows.Forms.Label();
            this._argumentsLabel = new System.Windows.Forms.Label();
            this._okButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._cancelButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._invertFilterBox = new System.Windows.Forms.CheckBox();
            this._argsPanel = new System.Windows.Forms.Panel();
            this._addAnotherButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._argsBGPanel = new System.Windows.Forms.Panel();
            this._bgPanel = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._argsPanel.SuspendLayout();
            this._argsBGPanel.SuspendLayout();
            this._bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _filterName
            // 
            this._filterName.AutoSize = true;
            this._filterName.BackColor = System.Drawing.Color.Transparent;
            this._filterName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filterName.ForeColor = System.Drawing.SystemColors.Control;
            this._filterName.Location = new System.Drawing.Point(22, 35);
            this._filterName.Name = "_filterName";
            this._filterName.Size = new System.Drawing.Size(71, 13);
            this._filterName.TabIndex = 0;
            this._filterName.Text = "Filter Name";
            // 
            // _filterDescription
            // 
            this._filterDescription.AutoSize = true;
            this._filterDescription.BackColor = System.Drawing.Color.Transparent;
            this._filterDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filterDescription.ForeColor = System.Drawing.SystemColors.Control;
            this._filterDescription.Location = new System.Drawing.Point(22, 54);
            this._filterDescription.Name = "_filterDescription";
            this._filterDescription.Size = new System.Drawing.Size(103, 13);
            this._filterDescription.TabIndex = 1;
            this._filterDescription.Text = "Filter Description";
            // 
            // _argumentsLabel
            // 
            this._argumentsLabel.AutoSize = true;
            this._argumentsLabel.BackColor = System.Drawing.Color.Transparent;
            this._argumentsLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._argumentsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this._argumentsLabel.Location = new System.Drawing.Point(22, 97);
            this._argumentsLabel.Name = "_argumentsLabel";
            this._argumentsLabel.Size = new System.Drawing.Size(73, 13);
            this._argumentsLabel.TabIndex = 2;
            this._argumentsLabel.Text = "Arguments:";
            // 
            // _okButton
            // 
            this._okButton.Active = false;
            this._okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._okButton.ForeColor = System.Drawing.Color.White;
            this._okButton.Location = new System.Drawing.Point(206, 427);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 3;
            this._okButton.Text = "Ok";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Active = false;
            this._cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._cancelButton.ForeColor = System.Drawing.Color.White;
            this._cancelButton.Location = new System.Drawing.Point(304, 427);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _invertFilterBox
            // 
            this._invertFilterBox.AutoSize = true;
            this._invertFilterBox.BackColor = System.Drawing.Color.Transparent;
            this._invertFilterBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._invertFilterBox.ForeColor = System.Drawing.SystemColors.Control;
            this._invertFilterBox.Location = new System.Drawing.Point(495, 50);
            this._invertFilterBox.Name = "_invertFilterBox";
            this._invertFilterBox.Size = new System.Drawing.Size(94, 17);
            this._invertFilterBox.TabIndex = 5;
            this._invertFilterBox.Text = "Invert Filter";
            this._invertFilterBox.UseVisualStyleBackColor = false;
            // 
            // _argsPanel
            // 
            this._argsPanel.Controls.Add(this._addAnotherButton);
            this._argsPanel.Location = new System.Drawing.Point(0, 6);
            this._argsPanel.Name = "_argsPanel";
            this._argsPanel.Size = new System.Drawing.Size(553, 256);
            this._argsPanel.TabIndex = 6;
            // 
            // _addAnotherButton
            // 
            this._addAnotherButton.Active = false;
            this._addAnotherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._addAnotherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addAnotherButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._addAnotherButton.ForeColor = System.Drawing.Color.White;
            this._addAnotherButton.Location = new System.Drawing.Point(248, 205);
            this._addAnotherButton.Name = "_addAnotherButton";
            this._addAnotherButton.Size = new System.Drawing.Size(75, 48);
            this._addAnotherButton.TabIndex = 0;
            this._addAnotherButton.Text = "Add Another";
            this._addAnotherButton.UseVisualStyleBackColor = true;
            this._addAnotherButton.Click += new System.EventHandler(this.onAddAnotherClicked);
            // 
            // _argsBGPanel
            // 
            this._argsBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._argsBGPanel.AutoScroll = true;
            this._argsBGPanel.BackColor = System.Drawing.Color.Transparent;
            this._argsBGPanel.Controls.Add(this._argsPanel);
            this._argsBGPanel.Location = new System.Drawing.Point(18, 148);
            this._argsBGPanel.Name = "_argsBGPanel";
            this._argsBGPanel.Size = new System.Drawing.Size(579, 271);
            this._argsBGPanel.TabIndex = 1;
            // 
            // _bgPanel
            // 
            this._bgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_bgPanel.BackgroundImage")));
            this._bgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._bgPanel.Controls.Add(this._argsBGPanel);
            this._bgPanel.Controls.Add(this._filterName);
            this._bgPanel.Controls.Add(this._argumentsLabel);
            this._bgPanel.Controls.Add(this._invertFilterBox);
            this._bgPanel.Controls.Add(this._filterDescription);
            this._bgPanel.Controls.Add(this._okButton);
            this._bgPanel.Controls.Add(this._cancelButton);
            this._bgPanel.Location = new System.Drawing.Point(0, 0);
            this._bgPanel.Name = "_bgPanel";
            this._bgPanel.Size = new System.Drawing.Size(617, 473);
            this._bgPanel.TabIndex = 6;
            this._bgPanel.TitleText = "";
            // 
            // FilterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 470);
            this.Controls.Add(this._bgPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterDialog";
            this.Text = "Filter Specification";
            this.Load += new System.EventHandler(this.onDialogLoad);
            this._argsPanel.ResumeLayout(false);
            this._argsBGPanel.ResumeLayout(false);
            this._bgPanel.ResumeLayout(false);
            this._bgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _filterName;
        private System.Windows.Forms.Label _filterDescription;
        private System.Windows.Forms.Label _argumentsLabel;
        private PSOShopkeeper.Controls.PSOShopkeeperButton _okButton;
        private PSOShopkeeper.Controls.PSOShopkeeperButton _cancelButton;
        private System.Windows.Forms.CheckBox _invertFilterBox;
        private System.Windows.Forms.Panel _argsPanel;
        private PSOShopkeeper.Controls.PSOShopkeeperButton _addAnotherButton;
        private System.Windows.Forms.Panel _argsBGPanel;
        private Controls.PSOShopkeeperPanel _bgPanel;
    }
}
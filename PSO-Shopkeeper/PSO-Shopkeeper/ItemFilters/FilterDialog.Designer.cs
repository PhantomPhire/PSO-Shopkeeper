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
            this.label1 = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._invertFilterBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _filterName
            // 
            this._filterName.AutoSize = true;
            this._filterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filterName.Location = new System.Drawing.Point(13, 13);
            this._filterName.Name = "_filterName";
            this._filterName.Size = new System.Drawing.Size(71, 13);
            this._filterName.TabIndex = 0;
            this._filterName.Text = "Filter Name";
            // 
            // _filterDescription
            // 
            this._filterDescription.AutoSize = true;
            this._filterDescription.Location = new System.Drawing.Point(16, 41);
            this._filterDescription.Name = "_filterDescription";
            this._filterDescription.Size = new System.Drawing.Size(85, 13);
            this._filterDescription.TabIndex = 1;
            this._filterDescription.Text = "Filter Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arguments:";
            // 
            // _okButton
            // 
            this._okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(164, 133);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 3;
            this._okButton.Text = "Ok";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(282, 133);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _invertFilterBox
            // 
            this._invertFilterBox.AutoSize = true;
            this._invertFilterBox.Location = new System.Drawing.Point(437, 13);
            this._invertFilterBox.Name = "_invertFilterBox";
            this._invertFilterBox.Size = new System.Drawing.Size(78, 17);
            this._invertFilterBox.TabIndex = 5;
            this._invertFilterBox.Text = "Invert Filter";
            this._invertFilterBox.UseVisualStyleBackColor = true;
            // 
            // FilterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 161);
            this.Controls.Add(this._invertFilterBox);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._filterDescription);
            this.Controls.Add(this._filterName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterDialog";
            this.Text = "Filter Specification";
            this.Load += new System.EventHandler(this.onDialogLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _filterName;
        private System.Windows.Forms.Label _filterDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.CheckBox _invertFilterBox;
    }
}
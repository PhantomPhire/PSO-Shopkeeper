namespace PSOShopkeeper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this._combineItemsCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _combineItemsCheck
            // 
            this._combineItemsCheck.AutoSize = true;
            this._combineItemsCheck.Location = new System.Drawing.Point(29, 33);
            this._combineItemsCheck.Name = "_combineItemsCheck";
            this._combineItemsCheck.Size = new System.Drawing.Size(143, 17);
            this._combineItemsCheck.TabIndex = 0;
            this._combineItemsCheck.Text = "Combine Duplicate Items";
            this._combineItemsCheck.UseVisualStyleBackColor = true;
            this._combineItemsCheck.CheckedChanged += new System.EventHandler(this.onCombineItemsChecked);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 97);
            this.Controls.Add(this._combineItemsCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _combineItemsCheck;
    }
}
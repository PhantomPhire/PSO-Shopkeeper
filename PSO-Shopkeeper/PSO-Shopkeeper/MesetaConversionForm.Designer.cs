namespace PSOShopkeeper
{
    partial class MesetaConversionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesetaConversionForm));
            this._goButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._pdValueTextBox = new System.Windows.Forms.TextBox();
            this._mesetaPerPDTextBox = new System.Windows.Forms.TextBox();
            this._abbrivateThousdandsCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _goButton
            // 
            this._goButton.Location = new System.Drawing.Point(12, 97);
            this._goButton.Name = "_goButton";
            this._goButton.Size = new System.Drawing.Size(75, 23);
            this._goButton.TabIndex = 0;
            this._goButton.Text = "Go";
            this._goButton.UseVisualStyleBackColor = true;
            this._goButton.Click += new System.EventHandler(this.onGoClicked);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(118, 97);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.onCancelClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max PD to Fill:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meseta Per PD:";
            // 
            // _pdValueTextBox
            // 
            this._pdValueTextBox.Location = new System.Drawing.Point(93, 21);
            this._pdValueTextBox.Name = "_pdValueTextBox";
            this._pdValueTextBox.Size = new System.Drawing.Size(100, 20);
            this._pdValueTextBox.TabIndex = 4;
            // 
            // _mesetaPerPDTextBox
            // 
            this._mesetaPerPDTextBox.Location = new System.Drawing.Point(93, 47);
            this._mesetaPerPDTextBox.Name = "_mesetaPerPDTextBox";
            this._mesetaPerPDTextBox.Size = new System.Drawing.Size(100, 20);
            this._mesetaPerPDTextBox.TabIndex = 5;
            // 
            // _abbrivateThousdandsCheck
            // 
            this._abbrivateThousdandsCheck.AutoSize = true;
            this._abbrivateThousdandsCheck.Location = new System.Drawing.Point(15, 73);
            this._abbrivateThousdandsCheck.Name = "_abbrivateThousdandsCheck";
            this._abbrivateThousdandsCheck.Size = new System.Drawing.Size(183, 17);
            this._abbrivateThousdandsCheck.TabIndex = 6;
            this._abbrivateThousdandsCheck.Text = "Abbreviate Thousands of Meseta";
            this._abbrivateThousdandsCheck.UseVisualStyleBackColor = true;
            // 
            // MesetaConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 130);
            this.Controls.Add(this._abbrivateThousdandsCheck);
            this.Controls.Add(this._mesetaPerPDTextBox);
            this.Controls.Add(this._pdValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._goButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MesetaConversionForm";
            this.Text = "Autofill Meseta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _goButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _pdValueTextBox;
        private System.Windows.Forms.TextBox _mesetaPerPDTextBox;
        private System.Windows.Forms.CheckBox _abbrivateThousdandsCheck;
    }
}
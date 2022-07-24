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
            this._goButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._cancelButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._pdValueTextBox = new System.Windows.Forms.TextBox();
            this._mesetaPerPDTextBox = new System.Windows.Forms.TextBox();
            this._abbrivateThousdandsCheck = new System.Windows.Forms.CheckBox();
            this.psoShopkeeperPanel1 = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this.psoShopkeeperPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _goButton
            // 
            this._goButton.Location = new System.Drawing.Point(33, 152);
            this._goButton.Name = "_goButton";
            this._goButton.Size = new System.Drawing.Size(75, 23);
            this._goButton.TabIndex = 0;
            this._goButton.Text = "Go";
            this._goButton.UseVisualStyleBackColor = true;
            this._goButton.Click += new System.EventHandler(this.onGoClicked);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(142, 152);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max PD to Fill:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meseta Per PD:";
            // 
            // _pdValueTextBox
            // 
            this._pdValueTextBox.Location = new System.Drawing.Point(117, 55);
            this._pdValueTextBox.Name = "_pdValueTextBox";
            this._pdValueTextBox.Size = new System.Drawing.Size(100, 20);
            this._pdValueTextBox.TabIndex = 4;
            // 
            // _mesetaPerPDTextBox
            // 
            this._mesetaPerPDTextBox.Location = new System.Drawing.Point(117, 81);
            this._mesetaPerPDTextBox.Name = "_mesetaPerPDTextBox";
            this._mesetaPerPDTextBox.Size = new System.Drawing.Size(100, 20);
            this._mesetaPerPDTextBox.TabIndex = 5;
            // 
            // _abbrivateThousdandsCheck
            // 
            this._abbrivateThousdandsCheck.AutoSize = true;
            this._abbrivateThousdandsCheck.BackColor = System.Drawing.Color.Transparent;
            this._abbrivateThousdandsCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._abbrivateThousdandsCheck.ForeColor = System.Drawing.SystemColors.Control;
            this._abbrivateThousdandsCheck.Location = new System.Drawing.Point(33, 129);
            this._abbrivateThousdandsCheck.Name = "_abbrivateThousdandsCheck";
            this._abbrivateThousdandsCheck.Size = new System.Drawing.Size(212, 17);
            this._abbrivateThousdandsCheck.TabIndex = 6;
            this._abbrivateThousdandsCheck.Text = "Abbreviate Thousands of Meseta";
            this._abbrivateThousdandsCheck.UseVisualStyleBackColor = false;
            // 
            // psoShopkeeperPanel1
            // 
            this.psoShopkeeperPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.psoShopkeeperPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psoShopkeeperPanel1.BackgroundImage")));
            this.psoShopkeeperPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.psoShopkeeperPanel1.Controls.Add(this._pdValueTextBox);
            this.psoShopkeeperPanel1.Controls.Add(this._mesetaPerPDTextBox);
            this.psoShopkeeperPanel1.Controls.Add(this.label2);
            this.psoShopkeeperPanel1.Controls.Add(this._abbrivateThousdandsCheck);
            this.psoShopkeeperPanel1.Controls.Add(this.label1);
            this.psoShopkeeperPanel1.Controls.Add(this._cancelButton);
            this.psoShopkeeperPanel1.Controls.Add(this._goButton);
            this.psoShopkeeperPanel1.Location = new System.Drawing.Point(-2, -25);
            this.psoShopkeeperPanel1.Name = "psoShopkeeperPanel1";
            this.psoShopkeeperPanel1.Size = new System.Drawing.Size(264, 208);
            this.psoShopkeeperPanel1.TabIndex = 7;
            this.psoShopkeeperPanel1.TitleText = "";
            // 
            // MesetaConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 184);
            this.Controls.Add(this.psoShopkeeperPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MesetaConversionForm";
            this.Text = "Autofill Meseta";
            this.psoShopkeeperPanel1.ResumeLayout(false);
            this.psoShopkeeperPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PSOShopkeeper.Controls.PSOShopkeeperButton _goButton;
        private PSOShopkeeper.Controls.PSOShopkeeperButton _cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _pdValueTextBox;
        private System.Windows.Forms.TextBox _mesetaPerPDTextBox;
        private System.Windows.Forms.CheckBox _abbrivateThousdandsCheck;
        private Controls.PSOShopkeeperPanel psoShopkeeperPanel1;
    }
}
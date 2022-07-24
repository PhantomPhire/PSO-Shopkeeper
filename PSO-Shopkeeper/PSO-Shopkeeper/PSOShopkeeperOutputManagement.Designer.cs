namespace PSOShopkeeper
{
    partial class PSOShopkeeperOutputManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSOShopkeeperOutputManagement));
            this._outputBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._outputBoxBG = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._outputBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this._generateOutputButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._clearButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._clipboardButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._outputTabControlsBGPanel1 = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._colorizeSpecialsCheck = new System.Windows.Forms.CheckBox();
            this._colorizeHitCheck = new System.Windows.Forms.CheckBox();
            this._colorizePercentages = new System.Windows.Forms.CheckBox();
            this._editColorsButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._outputTabControlsBGPanel2 = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._boldPriceCheck = new System.Windows.Forms.CheckBox();
            this._multiPriceCheck = new System.Windows.Forms.CheckBox();
            this._untekkText = new System.Windows.Forms.TextBox();
            this._untekkTextLabel = new System.Windows.Forms.Label();
            this._outputBGPanel.SuspendLayout();
            this._outputBoxBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._outputBox)).BeginInit();
            this._outputTabControlsBGPanel1.SuspendLayout();
            this._outputTabControlsBGPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _outputBGPanel
            // 
            this._outputBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputBGPanel.BackColor = System.Drawing.Color.Transparent;
            this._outputBGPanel.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Shop_BG;
            this._outputBGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputBGPanel.Controls.Add(this._outputBoxBG);
            this._outputBGPanel.Controls.Add(this._generateOutputButton);
            this._outputBGPanel.Controls.Add(this._clearButton);
            this._outputBGPanel.Controls.Add(this._clipboardButton);
            this._outputBGPanel.Controls.Add(this._outputTabControlsBGPanel1);
            this._outputBGPanel.Controls.Add(this._outputTabControlsBGPanel2);
            this._outputBGPanel.Location = new System.Drawing.Point(0, 0);
            this._outputBGPanel.Name = "_outputBGPanel";
            this._outputBGPanel.Size = new System.Drawing.Size(1350, 650);
            this._outputBGPanel.TabIndex = 13;
            // 
            // _outputBoxBG
            // 
            this._outputBoxBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputBoxBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_outputBoxBG.BackgroundImage")));
            this._outputBoxBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputBoxBG.Controls.Add(this._outputBox);
            this._outputBoxBG.Location = new System.Drawing.Point(1, -8);
            this._outputBoxBG.Name = "_outputBoxBG";
            this._outputBoxBG.Size = new System.Drawing.Size(1152, 606);
            this._outputBoxBG.TabIndex = 15;
            this._outputBoxBG.TitleText = "Output";
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
            this._outputBox.Location = new System.Drawing.Point(24, 61);
            this._outputBox.Name = "_outputBox";
            this._outputBox.Paddings = new System.Windows.Forms.Padding(0);
            this._outputBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._outputBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_outputBox.ServiceColors")));
            this._outputBox.ShowLineNumbers = false;
            this._outputBox.Size = new System.Drawing.Size(1114, 537);
            this._outputBox.TabIndex = 0;
            this._outputBox.WordWrap = true;
            this._outputBox.Zoom = 100;
            // 
            // _generateOutputButton
            // 
            this._generateOutputButton.Active = false;
            this._generateOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._generateOutputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._generateOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._generateOutputButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._generateOutputButton.ForeColor = System.Drawing.Color.White;
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
            this._clearButton.Active = false;
            this._clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._clearButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._clearButton.ForeColor = System.Drawing.Color.White;
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
            this._clipboardButton.Active = false;
            this._clipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._clipboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._clipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._clipboardButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._clipboardButton.ForeColor = System.Drawing.Color.White;
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
            this._outputTabControlsBGPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_outputTabControlsBGPanel1.BackgroundImage")));
            this._outputTabControlsBGPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputTabControlsBGPanel1.Controls.Add(this._colorizeSpecialsCheck);
            this._outputTabControlsBGPanel1.Controls.Add(this._colorizeHitCheck);
            this._outputTabControlsBGPanel1.Controls.Add(this._colorizePercentages);
            this._outputTabControlsBGPanel1.Controls.Add(this._editColorsButton);
            this._outputTabControlsBGPanel1.Location = new System.Drawing.Point(1159, 30);
            this._outputTabControlsBGPanel1.Name = "_outputTabControlsBGPanel1";
            this._outputTabControlsBGPanel1.Size = new System.Drawing.Size(192, 202);
            this._outputTabControlsBGPanel1.TabIndex = 13;
            this._outputTabControlsBGPanel1.TitleText = "";
            // 
            // _colorizeSpecialsCheck
            // 
            this._colorizeSpecialsCheck.AutoSize = true;
            this._colorizeSpecialsCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._colorizeSpecialsCheck.ForeColor = System.Drawing.SystemColors.Control;
            this._colorizeSpecialsCheck.Location = new System.Drawing.Point(15, 46);
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
            this._colorizeHitCheck.Location = new System.Drawing.Point(15, 69);
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
            this._colorizePercentages.Location = new System.Drawing.Point(14, 92);
            this._colorizePercentages.Name = "_colorizePercentages";
            this._colorizePercentages.Size = new System.Drawing.Size(169, 17);
            this._colorizePercentages.TabIndex = 11;
            this._colorizePercentages.Text = "Colorize Non-Hit Percents";
            this._colorizePercentages.UseVisualStyleBackColor = true;
            this._colorizePercentages.CheckedChanged += new System.EventHandler(this.onColorizePercentagesChecked);
            // 
            // _editColorsButton
            // 
            this._editColorsButton.Active = false;
            this._editColorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._editColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._editColorsButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._editColorsButton.ForeColor = System.Drawing.Color.White;
            this._editColorsButton.Location = new System.Drawing.Point(24, 127);
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
            this._outputTabControlsBGPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_outputTabControlsBGPanel2.BackgroundImage")));
            this._outputTabControlsBGPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._outputTabControlsBGPanel2.Controls.Add(this._boldPriceCheck);
            this._outputTabControlsBGPanel2.Controls.Add(this._multiPriceCheck);
            this._outputTabControlsBGPanel2.Controls.Add(this._untekkText);
            this._outputTabControlsBGPanel2.Controls.Add(this._untekkTextLabel);
            this._outputTabControlsBGPanel2.Location = new System.Drawing.Point(1160, 394);
            this._outputTabControlsBGPanel2.Name = "_outputTabControlsBGPanel2";
            this._outputTabControlsBGPanel2.Size = new System.Drawing.Size(188, 205);
            this._outputTabControlsBGPanel2.TabIndex = 14;
            this._outputTabControlsBGPanel2.TitleText = "";
            // 
            // _boldPriceCheck
            // 
            this._boldPriceCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._boldPriceCheck.AutoSize = true;
            this._boldPriceCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._boldPriceCheck.ForeColor = System.Drawing.SystemColors.Control;
            this._boldPriceCheck.Location = new System.Drawing.Point(18, 62);
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
            this._multiPriceCheck.Location = new System.Drawing.Point(18, 76);
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
            this._untekkText.Location = new System.Drawing.Point(23, 148);
            this._untekkText.Name = "_untekkText";
            this._untekkText.Size = new System.Drawing.Size(151, 20);
            this._untekkText.TabIndex = 8;
            this._untekkText.TextChanged += new System.EventHandler(this.onUntekkTextChanged);
            // 
            // _untekkTextLabel
            // 
            this._untekkTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._untekkTextLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._untekkTextLabel.ForeColor = System.Drawing.SystemColors.Control;
            this._untekkTextLabel.Location = new System.Drawing.Point(20, 131);
            this._untekkTextLabel.Name = "_untekkTextLabel";
            this._untekkTextLabel.Size = new System.Drawing.Size(143, 23);
            this._untekkTextLabel.TabIndex = 0;
            this._untekkTextLabel.Text = "Untekk Identifier:";
            // 
            // PSOShopkeeperOutputManagement
            // 
            this.Controls.Add(this._outputBGPanel);
            this.Name = "PSOShopkeeperOutputManagement";
            this.Size = new System.Drawing.Size(1350, 651);
            this._outputBGPanel.ResumeLayout(false);
            this._outputBoxBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._outputBox)).EndInit();
            this._outputTabControlsBGPanel1.ResumeLayout(false);
            this._outputTabControlsBGPanel1.PerformLayout();
            this._outputTabControlsBGPanel2.ResumeLayout(false);
            this._outputTabControlsBGPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PSOShopkeeperButton _generateOutputButton;
        private Controls.PSOShopkeeperButton _clipboardButton;
        private Controls.PSOShopkeeperButton _clearButton;
        private System.Windows.Forms.CheckBox _multiPriceCheck;
        private System.Windows.Forms.CheckBox _boldPriceCheck;
        private System.Windows.Forms.TextBox _untekkText;
        private System.Windows.Forms.Label _untekkTextLabel;
        private System.Windows.Forms.CheckBox _colorizePercentages;
        private System.Windows.Forms.CheckBox _colorizeHitCheck;
        private System.Windows.Forms.CheckBox _colorizeSpecialsCheck;
        private Controls.PSOShopkeeperButton _editColorsButton;
        private Controls.DoubleBufferedPanel _outputBGPanel;
        private Controls.PSOShopkeeperPanel _outputTabControlsBGPanel1;
        private Controls.PSOShopkeeperPanel _outputTabControlsBGPanel2;
        private Controls.PSOShopkeeperPanel _outputBoxBG;
        private FastColoredTextBoxNS.FastColoredTextBox _outputBox;
    }
}

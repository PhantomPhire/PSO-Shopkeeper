namespace PSOShopkeeper.ItemFilters
{
    partial class TemplateHelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateHelpForm));
            this._bgPanel = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._templateHints = new FastColoredTextBoxNS.FastColoredTextBox();
            this._bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._templateHints)).BeginInit();
            this.SuspendLayout();
            // 
            // _bgPanel
            // 
            this._bgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_bgPanel.BackgroundImage")));
            this._bgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._bgPanel.Controls.Add(this._templateHints);
            this._bgPanel.Location = new System.Drawing.Point(0, -30);
            this._bgPanel.Name = "_bgPanel";
            this._bgPanel.Size = new System.Drawing.Size(804, 691);
            this._bgPanel.TabIndex = 0;
            this._bgPanel.TitleText = "";
            // 
            // _templateHints
            // 
            this._templateHints.AutoCompleteBracketsList = new char[] {
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
            this._templateHints.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this._templateHints.BackBrush = null;
            this._templateHints.BackColor = System.Drawing.Color.Transparent;
            this._templateHints.CharHeight = 14;
            this._templateHints.CharWidth = 8;
            this._templateHints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._templateHints.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._templateHints.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateHints.ForeColor = System.Drawing.SystemColors.Control;
            this._templateHints.IsReplaceMode = false;
            this._templateHints.Location = new System.Drawing.Point(23, 68);
            this._templateHints.Name = "_templateHints";
            this._templateHints.Paddings = new System.Windows.Forms.Padding(0);
            this._templateHints.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._templateHints.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_templateHints.ServiceColors")));
            this._templateHints.ShowLineNumbers = false;
            this._templateHints.Size = new System.Drawing.Size(778, 594);
            this._templateHints.TabIndex = 1;
            this._templateHints.WordWrap = true;
            this._templateHints.Zoom = 100;
            // 
            // TemplateHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this._bgPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplateHelpForm";
            this.Text = "TemplateHelpForm";
            this._bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._templateHints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PSOShopkeeperPanel _bgPanel;
        private FastColoredTextBoxNS.FastColoredTextBox _templateHints;
    }
}
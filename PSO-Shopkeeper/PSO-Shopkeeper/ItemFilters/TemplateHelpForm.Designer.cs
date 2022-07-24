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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateHelpForm));
            this._bgPanel = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._templateHints = new System.Windows.Forms.Label();
            this._scrollPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._bgPanel.SuspendLayout();
            this._scrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bgPanel
            // 
            this._bgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_bgPanel.BackgroundImage")));
            this._bgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._bgPanel.Controls.Add(this._scrollPanel);
            this._bgPanel.Location = new System.Drawing.Point(0, -30);
            this._bgPanel.Name = "_bgPanel";
            this._bgPanel.Size = new System.Drawing.Size(804, 691);
            this._bgPanel.TabIndex = 0;
            this._bgPanel.TitleText = "";
            // 
            // _templateHints
            // 
            this._templateHints.AutoSize = true;
            this._templateHints.BackColor = System.Drawing.Color.Transparent;
            this._templateHints.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateHints.ForeColor = System.Drawing.SystemColors.Control;
            this._templateHints.Location = new System.Drawing.Point(3, 0);
            this._templateHints.Name = "_templateHints";
            this._templateHints.Size = new System.Drawing.Size(0, 16);
            this._templateHints.TabIndex = 0;
            // 
            // _scrollPanel
            // 
            this._scrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._scrollPanel.AutoScroll = true;
            this._scrollPanel.BackColor = System.Drawing.Color.Transparent;
            this._scrollPanel.Controls.Add(this._templateHints);
            this._scrollPanel.Location = new System.Drawing.Point(23, 69);
            this._scrollPanel.Name = "_scrollPanel";
            this._scrollPanel.Size = new System.Drawing.Size(778, 596);
            this._scrollPanel.TabIndex = 1;
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
            this._scrollPanel.ResumeLayout(false);
            this._scrollPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PSOShopkeeperPanel _bgPanel;
        private System.Windows.Forms.Label _templateHints;
        private Controls.DoubleBufferedPanel _scrollPanel;
    }
}
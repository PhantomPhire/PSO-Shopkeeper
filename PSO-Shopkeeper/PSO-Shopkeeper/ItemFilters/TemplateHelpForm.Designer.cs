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
            this._templateHints = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _templateHints
            // 
            this._templateHints.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._templateHints.Location = new System.Drawing.Point(-1, 2);
            this._templateHints.Multiline = true;
            this._templateHints.Name = "_templateHints";
            this._templateHints.ReadOnly = true;
            this._templateHints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._templateHints.Size = new System.Drawing.Size(801, 613);
            this._templateHints.TabIndex = 0;
            // 
            // TemplateHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this._templateHints);
            this.Name = "TemplateHelpForm";
            this.Text = "TemplateHelpForm";
            this.Load += new System.EventHandler(this.onFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _templateHints;
    }
}
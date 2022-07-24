using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSOShopkeeper.ItemFilters
{
    public partial class TemplateHelpForm : Form
    {
        public TemplateHelpForm()
        {
            InitializeComponent();
            Resize += onTemplateHintsResize;
            _templateHints.Text = TemplateManager.TemplateHints;
            onTemplateHintsResize(this, EventArgs.Empty);
        }

        private void onTemplateHintsResize(object sender, EventArgs e)
        {
            _templateHints.MaximumSize = new Size(_bgPanel.Width - 60, 0);
        }
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;

namespace PSOShopkeeper.Controls
{
    /// <summary>
    /// The PSOContextMenuItem forces the look and feel of a PSO menu item
    /// </summary>
    public class PSOContextMenuItem : ToolStripMenuItem
    {
        /// <summary>
        /// Initializes a new instance of the PSOContextMenuItem class
        /// </summary>
        public PSOContextMenuItem()
            : base()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            Image = global::PSO_Shopkeeper.Properties.Resources.Highlight;
        }

        /// <summary>
        /// A workaround used to attain context menu hover image rendering
        /// </summary>
        private bool _hoverOverride = false;

        /// <summary>
        /// Raises the System.Windows.Forms.Control.MouseEnter event.
        /// </summary>
        /// <param name="e">An System.EventArgs that contains the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            if (!_hoverOverride)
            {
                _hoverOverride = true;
                Invalidate();
            }

            base.OnMouseEnter(e);
        }

        /// <summary>
        /// Raises the System.Windows.Forms.Control.MouseLeave event.
        /// </summary>
        /// <param name="e">An System.EventArgs that contains the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            if (_hoverOverride)
            {
                _hoverOverride = false;
                Invalidate();
            }

            base.OnMouseLeave(e);
        }

        /// <summary>
        /// Raises the System.Windows.Forms.Control.Paint event.
        /// </summary>
        /// <param name="e">An System.EventArgs that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (_hoverOverride)
            {
                Parent.Renderer.DrawItemImage(new ToolStripItemImageRenderEventArgs(e.Graphics, this, new Rectangle(new Point(0, 0), Size)));
            }

            base.OnPaint(e);
        }
    }
}

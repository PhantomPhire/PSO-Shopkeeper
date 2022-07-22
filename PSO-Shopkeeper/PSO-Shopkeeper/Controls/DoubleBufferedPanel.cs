using System.Windows.Forms;

namespace PSOShopkeeper.Controls
{
    /// <summary>
    /// The DoubleBufferedPanel provides a workaround that allows a Panel to be double buffered, as for some reason
    /// the Panel class does not come with that functionality as an option by default. The solution for this was taken from
    /// https://stackoverflow.com/questions/3341032/during-flowlayoutpanel-scrolling-background-distorts-flickers
    /// </summary>
    public class DoubleBufferedPanel : Panel
    {
        /// <summary>
        /// Initializes a new instance of the DoubleBufferedPanel class
        /// </summary>
        public DoubleBufferedPanel()
            : base()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        /// <summary>
        /// Raises the System.Windows.Forms.ScrollableControl.Scroll event.
        /// </summary>
        /// <param name="se">A System.Windows.Forms.ScrollEventArgs that contains the event data.</param>
        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Invalidate();

            base.OnScroll(se);
        }

        /// <summary>
        /// Gets the required creation parameters when the control handle is created.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
                return cp;
            }
        }
    }
}

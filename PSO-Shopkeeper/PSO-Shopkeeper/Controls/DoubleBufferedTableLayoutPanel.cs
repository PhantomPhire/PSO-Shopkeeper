using System.Windows.Forms;

namespace PSOShopkeeper.Controls
{
    /// <summary>
    /// The DoubleBufferedTableLayoutPanel provides a workaround that allows a Panel to be double buffered, as for some reason
    /// the TableLayoutPanel class does not come with that functionality as an option by default.
    /// </summary>
    public class DoubleBufferedTableLayoutPanel : TableLayoutPanel
    {
        /// <summary>
        /// Initializes a new instance of the DoubleBufferedTableLayoutPanel class
        /// </summary>
        public DoubleBufferedTableLayoutPanel()
            : base()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }
    }
}

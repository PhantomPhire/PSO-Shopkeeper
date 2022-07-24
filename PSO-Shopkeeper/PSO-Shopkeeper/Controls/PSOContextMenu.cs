using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace PSOShopkeeper.Controls
{
    /// <summary>
    /// The PSOContextMenu class is a ContextMenuStrip that forces the appearance of a PSO menu.
    /// </summary>
    public class PSOContextMenu : ContextMenuStrip
    {
        /// <summary>
        /// Initializes a new instance of the PSOContextMenu class
        /// </summary>
        public PSOContextMenu()
        {
            initializePSOContextMenu();
        }

        /// <summary>
        /// Initializes a new instance of the PSOContextMenu class
        /// </summary>
        /// <param name="container">The container for the ContextMenuStrip to use</param>
        public PSOContextMenu(IContainer container)
            : base(container)
        {
            initializePSOContextMenu();
        }

        /// <summary>
        /// Initializes the look and feel of a PSO menu. Should be called by each constructor
        /// </summary>
        private void initializePSOContextMenu()
        {
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Panel_BG_2_3;
            BackgroundImageLayout = ImageLayout.Stretch;
            Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = Color.White;
            ShowImageMargin = false;
            Renderer = new PSOContextMenuRenderer();
        }

        /// <summary>
        /// The PSOContextMenuRenderer class forces context menu item's automatic highlight behavior to be transparent
        /// </summary>
        private class PSOContextMenuRenderer : ToolStripProfessionalRenderer
        {
            /// <summary>
            /// Initializes a new instance of the PSOContextMenuRenderer class
            /// </summary>
            public PSOContextMenuRenderer()
                : base(new PSOContextMenuColorTable())
            {
            }
        }

        /// <summary>
        /// The PSOContextMenuColorTable class forces context menu item's automatic highlight behavior to be transparent
        /// </summary>
        private class PSOContextMenuColorTable : ProfessionalColorTable
        {
            /// <summary>
            /// Forces transparent menu item selected behavior
            /// </summary>
            public override Color MenuItemSelected
            {
                get { return Color.Transparent; }
            }

            /// <summary>
            /// Forces transparent menu item selected behavior
            /// </summary>
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Transparent; }
            }

            /// <summary>
            /// Forces transparent menu item selected behavior
            /// </summary>
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Transparent; }
            }

            /// <summary>
            /// Forces transparent menu item selected behavior
            /// </summary>
            public override Color MenuItemBorder
            {
                get { return Color.Transparent; }
            }
        }
    }
}

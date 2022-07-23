using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace PSOShopkeeper.Controls
{
    /// <summary>
    /// The PSOShopkeeperPanel class encapsulates a PSO panel, with the appropriate background image and an optional title
    /// </summary>
    public class PSOShopkeeperPanel : DoubleBufferedPanel
    {
        /// <summary>
        /// Initializes a new instance of the PSOShopkeeperPanel class
        /// </summary>
        public PSOShopkeeperPanel()
        {
            Resize += onResize;
        }

        private const int shortThreshold = 200;
        private const int wideThreshold = 500;
        private const int superWideThreshold = 900;
        private const int tallThreshold = 500;

        /// <summary>
        /// Reacts to the resizing of the panel by assiging the approrpriate background image
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onResize(object sender, EventArgs e)
        {
            // Check if it is short
            if (Height < shortThreshold)
            {
                if (Width < superWideThreshold)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Vertical_Text_Short_BG;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Tab_BG;
                }
            }
            else if (Height < tallThreshold)
            {
                if (Width > wideThreshold)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Filters_BG;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Vertical_Text_Short_BG;
                }
            }
            else
            {
                if (Width > wideThreshold)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Output_BG;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Vertical_Text_BG;
                }
            }
        }

        /// <summary>
        /// Backing field for TitleText
        /// </summary>
        private string _titleText = "";

        /// <summary>
        /// Gets and sets a string determing the text to put in the title bar for the panel
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets title text of panel")]
        public string TitleText
        {
            get { return _titleText; }
            set 
            { 
                _titleText = value;
            }
        }
    }
}

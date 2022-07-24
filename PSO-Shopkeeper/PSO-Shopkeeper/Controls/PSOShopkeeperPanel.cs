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

        /// <summary>
        /// Reacts to the resizing of the panel by assiging the approrpriate background image
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onResize(object sender, EventArgs e)
        {
            if (Height < 100)
            {
                if (Width < 100)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_1;
                }
                else if(Width < 200)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_1;
                }
                else if (Width < 400)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_1;
                }
                else if (Width < 800)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_1;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_1;
                }
            }
            else if (Height < 200)
            {
                if (Width < 100)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_2;
                }
                else if (Width < 200)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_2;
                }
                else if (Width < 400)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_2;
                }
                else if (Width < 800)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_2;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_2;
                }
            }
            else if (Height < 400)
            {
                if (Width < 100)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_3;
                }
                else if (Width < 200)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_3;
                }
                else if (Width < 400)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_3;
                }
                else if (Width < 800)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_3;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_3;
                }
            }
            else if (Height < 800)
            {
                if (Width < 100)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_4;
                }
                else if (Width < 200)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_4;
                }
                else if (Width < 400)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_4;
                }
                else if (Width < 800)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_4;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_4;
                }
            }
            else
            {
                if (Width < 100)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_5;
                }
                else if (Width < 200)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_5;
                }
                else if (Width < 400)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_5;
                }
                else if (Width < 800)
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_5;
                }
                else
                {
                    BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_5;
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

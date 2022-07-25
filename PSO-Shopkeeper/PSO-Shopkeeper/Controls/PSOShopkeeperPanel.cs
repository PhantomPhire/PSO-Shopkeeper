using System;
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
            Move += onResize;
            Resize += onResize;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private const int titleHorizontalOffset = 20;
        private const int titleIdealVerticalOffset = 28;

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
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_1;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_1_Title;
                    }
                }
                else if(Width < 200)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_1;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_1_Title;
                    }
                }
                else if (Width < 400)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_1;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_1_Title;
                    }
                }
                else if (Width < 800)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_1;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_1_Title;
                    }
                }
                else
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_1;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_1_Title;
                    }
                }
            }
            else if (Height < 200)
            {
                if (Width < 100)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_2;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_2_Title;
                    }
                }
                else if (Width < 200)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_2;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_2_Title;
                    }
                }
                else if (Width < 400)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_2;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_2_Title;
                    }
                }
                else if (Width < 800)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_2;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_2_Title;
                    }
                }
                else
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_2;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_2_Title;
                    }
                }
            }
            else if (Height < 400)
            {
                if (Width < 100)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_3;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_3_Title;
                    }
                }
                else if (Width < 200)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_3;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_3_Title;
                    }
                }
                else if (Width < 400)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_3;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_3_Title;
                    }
                }
                else if (Width < 800)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_3;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_3_Title;
                    }
                }
                else
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_3;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_3_Title;
                    }
                }
            }
            else if (Height < 800)
            {
                if (Width < 100)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_4;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_4_Title;
                    }
                }
                else if (Width < 200)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_4;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_4_Title;
                    }
                }
                else if (Width < 400)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_4;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_4_Title;
                    }
                }
                else if (Width < 800)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_4;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_4_Title;
                    }
                }
                else
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_4;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_4_Title;
                    }
                }
            }
            else
            {
                if (Width < 100)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_5;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_1_5_Title;
                    }
                }
                else if (Width < 200)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_5;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_2_5_Title;
                    }
                }
                else if (Width < 400)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_5;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_3_5_Title;
                    }
                }
                else if (Width < 800)
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_5;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_4_5_Title;
                    }
                }
                else
                {
                    if (_titlePanel == null)
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_5;
                    }
                    else
                    {
                        BackgroundImage = PSO_Shopkeeper.Properties.Resources.Panel_BG_5_5_Title;
                    }
                }
            }
            
            if (_titlePanel != null)
            {
                _titlePanel.Location = new Point(titleHorizontalOffset, (int)(titleIdealVerticalOffset * ((double)Height / (double)BackgroundImage.Height)));
                _titlePanel.BringToFront();
            }
        }

        /// <summary>
        /// Backing field for TitleText
        /// </summary>
        private string _titleText = "";

        /// <summary>
        /// The panel containing the title label
        /// </summary>
        private DoubleBufferedPanel _titlePanel = null;

        /// <summary>
        /// The label used for displaying the title
        /// </summary>
        private Label _titleLabel = null;

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

                if (_titleText.Length > 0)
                {
                    if (_titlePanel == null)
                    {
                        _titlePanel = new DoubleBufferedPanel();
                        _titlePanel.BackgroundImageLayout = ImageLayout.Stretch;
                        _titleLabel = new Label();
                        _titleLabel.AutoSize = true;
                        _titleLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                        _titleLabel.ForeColor = Color.Black;
                        _titleLabel.Resize += onLabelResize;
                        Controls.Add(_titlePanel);
                        _titlePanel.Controls.Add(_titleLabel);
                        _titleLabel.Location = new Point(20, 10);
                        _titleLabel.Text = _titleText;
                        _titlePanel.BringToFront();
                    }
                    onResize(null, null);
                }
                else if (_titlePanel != null)
                {
                    Controls.Remove(_titlePanel);
                    Controls.Remove(_titleLabel);
                    _titlePanel.Dispose();
                    _titleLabel.Dispose();
                    _titlePanel = null;
                    _titleLabel = null;
                }
            }
        }

        /// <summary>
        /// Reacts to the resizing of the title label by assiging the approrpriate background image
        /// </summary>
        /// <param name="sender">The object initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onLabelResize(object sender, EventArgs e)
        {
            if (_titleLabel.Width < 20)
            {
                _titlePanel.BackgroundImage = PSO_Shopkeeper.Properties.Resources.Title_BG_Button;
            }
            else if(_titleLabel.Width < 50)
            {
                _titlePanel.BackgroundImage = PSO_Shopkeeper.Properties.Resources.Title_BG_Small;
            }
            else if (_titleLabel.Width < 80)
            {
                _titlePanel.BackgroundImage = PSO_Shopkeeper.Properties.Resources.Title_BG_2;
            }
            else
            {
                _titlePanel.BackgroundImage = PSO_Shopkeeper.Properties.Resources.Title_BG_3;
            }

            _titlePanel.Size = new Size(_titleLabel.Width + 40, 44);
        }
    }
}

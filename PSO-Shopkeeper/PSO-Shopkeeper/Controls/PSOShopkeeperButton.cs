using System.Windows.Forms;
using System.Drawing;

namespace PSOShopkeeper.Controls
{
    /// <summary>
    /// The PSOShopkeeperButton is a Button with the standard appearance of PSOShopkeeper buttons forced
    /// </summary>
    public class PSOShopkeeperButton : Button
    {
        /// <summary>
        /// Initializes a new instance of the PSOShopkeeperButton class
        /// </summary>
        public PSOShopkeeperButton()
        {
            Font = new Font("Tahoma", 8.5F, FontStyle.Bold);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Silver;
            FlatAppearance.MouseDownBackColor = Color.Black;
            ForeColor = Color.White;
            Active = false;
        }

        /// <summary>
        /// Backing field for Active
        /// </summary>
        private bool _active = false;

        private readonly Color _inactiveColor = Color.FromArgb(100, 0, 0, 0);
        private readonly Color _activeColor   = Color.FromArgb(100, 0, 255, 0);

        /// <summary>
        /// Gets and sets a flag determining if the button is active (highlighted) or not
        /// </summary>
        public bool Active
        { 
            get { return _active; } 
            set 
            { 
                _active = value;
                BackColor = _active ? _activeColor : _inactiveColor;
            } 
        }
    }
}

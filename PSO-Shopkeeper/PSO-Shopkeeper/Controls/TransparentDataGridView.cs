using System.Windows.Forms;
using System.Drawing;

namespace PSOShopkeeper.Controls
{
    /// <summary>
    /// The TransparentDataGridView prvoides a solution that allows a DataGridView to be transparent against its host container
    /// The solution for this was taken from https://stackoverflow.com/questions/1330220/set-datagrid-view-background-to-transparent
    /// </summary>
    public class TransparentDataGridView : DataGridView
    {
        /// <summary>
        /// Initializes a new instance of the TransparentDataGridView class
        /// </summary>
        public TransparentDataGridView()
            : base()
        {
        }

        /// <summary>
        /// Paints the background of the System.Windows.Forms.DataGridView.
        /// </summary>
        /// <param name="graphics">The System.Drawing.Graphics used to paint the background.</param>
        /// <param name="clipBounds"> A System.Drawing.Rectangle that represents the area of the System.Windows.Forms.DataGridView
        //     that needs to be painted.</param>
        /// <param name="gridBounds">A System.Drawing.Rectangle that represents the area in which cells are drawn.</param>
        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);
            Rectangle rectSource = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            Rectangle rectDest = new Rectangle(0, 0, rectSource.Width, rectSource.Height);

            Bitmap b = new Bitmap(Parent.ClientRectangle.Width, Parent.ClientRectangle.Height);
            Graphics.FromImage(b).DrawImage(this.Parent.BackgroundImage, Parent.ClientRectangle);


            graphics.DrawImage(b, rectDest, rectSource, GraphicsUnit.Pixel);
            SetCellsTransparent();
        }


        /// <summary>
        /// Sets cells of the DataGridView to transparent
        /// </summary>
        public void SetCellsTransparent()
        {
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.Transparent;
            this.RowHeadersDefaultCellStyle.BackColor = Color.Transparent;


            foreach (DataGridViewColumn col in this.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.Transparent;
                col.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            }
        }
    }
}

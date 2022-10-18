using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Cabecalho : ToolStripMenuItem
    {
        protected override void OnMouseMove(MouseEventArgs mea)
        {
            this.ForeColor = Color.FromArgb(37, 37, 38);
            base.OnMouseMove(mea);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ForeColor = Color.White;
            base.OnMouseLeave(e);
        }
    }
}

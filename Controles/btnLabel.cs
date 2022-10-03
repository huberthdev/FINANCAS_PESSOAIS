using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class btnLabel : Label
    {
        protected override void OnCreateControl()
        {
            this.AutoSize = false;
            this.Text = "";
            this.Size = new Size(23, 23);
            this.BorderStyle = BorderStyle.None;

            base.OnCreateControl();
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;

            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;

            base.OnMouseLeave(e);
        }
    }
}

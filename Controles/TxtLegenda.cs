using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class TxtLegenda : TextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            int alt = this.Size.Height;
            Point loc = this.Location;

            Label borda = new Label();
            //borda.Location = ((Point)loc);
            ////borda.Width = 2;
            this.Parent.Controls.AddRange(new Control[] { borda });

            //Control xx = this.Parent;

            base.OnHandleCreated(e);
        }

    }
}

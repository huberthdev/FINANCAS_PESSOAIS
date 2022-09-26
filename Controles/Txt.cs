using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Txt : TextBox
    {

        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            base.OnCreateControl();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.SelectAll();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLostFocus(e);
        }

    }
}

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class cbCombo : ComboBox
    {
        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DropDownHeight = 136;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            base.OnCreateControl();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.SelectAll();
            base.OnGotFocus(e);
        }
    }
}

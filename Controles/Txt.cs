﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Txt : TextBox
    {
        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(37,37,38);
            this.BorderStyle = BorderStyle.FixedSingle;
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

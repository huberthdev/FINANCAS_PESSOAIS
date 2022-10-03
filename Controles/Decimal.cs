﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Decimal : TextBox
    {
        protected override void OnCreateControl()
        {
            this.BackColor = Color.Black;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ForeColor = Color.White;
            base.OnCreateControl();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.SelectAll();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (this.Text != "")
            {
                string valor = this.Text;
                valor.Trim();
                this.Text = Convert.ToDouble(valor).ToString("n");
            }

            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b") //Faz com que a tecla ESC limpe o campo
                this.Text = "";

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',' && this.Text.Contains(","))
                e.Handled = true;

            base.OnKeyPress(e);
        }
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Cpf : TextBox
    {

        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.TextAlign = HorizontalAlignment.Center;
            this.Width = 110;
            this.MaxLength = 14;

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

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\b")
                return;

            if (e.KeyChar.ToString() == "\u001b") //Faz com que a tecla ESC limpe o campo
                this.Text = "";

            if (char.IsDigit(e.KeyChar))
            {
                int t = this.Text.Length;

                if (t == 3 || t == 7)
                    this.Text += ".";
                else if (t == 11)
                    this.Text += "-";

                t++;
                this.SelectionStart = t;
            }
            else
                e.Handled = true;

            base.OnKeyPress(e);
        }

    }
}

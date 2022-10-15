using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Inteiro : TextBox
    {
        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.TextAlign = HorizontalAlignment.Center;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Black;
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
                this.Text = Convert.ToDouble(valor).ToString("N0");
            }

            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b") //Faz com que a tecla ESC limpe o campo
                this.Text = "";

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            string txt;

            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                txt = Clipboard.GetText().Trim();

                try
                {
                    txt = Convert.ToInt64(txt).ToString();
                    Clipboard.SetText(txt);
                }
                catch
                {
                    Clipboard.SetText("0");
                }
            }

            base.OnKeyDown(e);
        }

    }
}

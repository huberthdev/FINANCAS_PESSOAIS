using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Decimal : TextBox
    {

        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.TextAlign = HorizontalAlignment.Center;

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

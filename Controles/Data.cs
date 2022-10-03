using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class Data : TextBox
    {
        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Black;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ForeColor = Color.White;
            this.Width = 110;
            
            base.OnCreateControl();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.SelectAll();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            int t = this.Text.Length;
            string data = ""; string dia = ""; string mes = ""; string ano = "";

            try
            {
                data = this.Text;
                this.Text = Convert.ToDateTime(data).ToString("dd/MM/yyyy");
                return;
            }
            catch
            {

            }

            if (t == 1 || t == 2)
                data = this.Text + DateTime.Now.ToString("/MM/yyyy");
            else if (t == 3 || t == 4)
            {
                t = t - 2;
                dia = this.Text.Substring(0, 2);
                mes = this.Text.Substring(2, t);
                data = dia + "/" + mes + DateTime.Now.ToString("/yyyy");
            }
            else if(t == 6 || t == 8)
            {
                t = t - 4;
                dia = this.Text.Substring(0, 2);
                mes = this.Text.Substring(2, 2);
                ano = this.Text.Substring(4, t);
                data = dia + "/" + mes + "/" + ano;
            }

            try
            {
                this.Text = Convert.ToDateTime(data).ToString("dd/MM/yyyy");
            }
            catch
            {
                this.Text = "";
            }
            
            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\b")
                return;

            if (e.KeyChar.ToString() == "\u001b") //Faz com que a tecla ESC limpe o campo
                this.Text = "";

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            base.OnKeyPress(e);
        }
    }
}

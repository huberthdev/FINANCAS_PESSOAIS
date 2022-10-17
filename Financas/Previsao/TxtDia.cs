using System.Drawing;
using System.Windows.Forms;

namespace Setup.Financas.Previsao
{
    public class TxtDia : TextBox
    {
        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(37,37,38);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ForeColor = Color.FromArgb(Prev.cor);
            this.Size = new Size(58, 25);
            this.TextAlign = HorizontalAlignment.Center;
            base.OnCreateControl();
        }
    }
}
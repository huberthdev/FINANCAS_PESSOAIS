using System.Drawing;
using System.Windows.Forms;

namespace Setup.Financas.Previsao
{
    public class CkStatus : CheckBox
    {
        protected override void OnCreateControl()
        {
            this.Text = "";
            this.AutoSize = false;
            this.Size = new Size(15, 14);
            this.BackColor = Color.FromArgb(37,37,38);
            this.Enabled = false;
            base.OnCreateControl();
        }
    }
}
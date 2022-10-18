using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas.Previsao
{
    public class Icon_Edit : PictureBox
    {
        protected override void OnCreateControl()
        {
            this.BackgroundImageLayout = ImageLayout.None;
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.Image = global::Setup.Properties.Resources.edit;
            this.Size = new Size(23, 23);
            this.SizeMode = PictureBoxSizeMode.CenterImage;
            this.TabStop = false;

            base.OnCreateControl();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Color.Transparent;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(58, 58, 58);
            base.OnMouseMove(e);
        }
    }
}

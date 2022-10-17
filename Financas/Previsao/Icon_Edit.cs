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
            this.BorderStyle = BorderStyle.None;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            base.OnMouseHover(e);
        }
    }
}

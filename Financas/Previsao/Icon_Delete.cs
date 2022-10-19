using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas.Previsao
{
    public class Icon_Delete : PictureBox
    {
        protected override void OnCreateControl()
        {
            this.BackgroundImageLayout = ImageLayout.None;
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.Image = global::Setup.Properties.Resources.delete;
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

        protected override void OnClick(EventArgs e)
        {
            string chave = this.Tag.ToString();

            COD.Pergunta("Deseja realmente excluir este item?");
            if (!COD.Resposta)
                return;

            string sql = "DELETE FROM PREVISAO WHERE CHAVE = '" + chave + "'";
            BD.ExecutarSQL(sql);

            if(this.Parent.CausesValidation == true)
                this.Parent.CausesValidation = false;
            else
                this.Parent.CausesValidation = true;

            base.OnClick(e);
        }
    }
}

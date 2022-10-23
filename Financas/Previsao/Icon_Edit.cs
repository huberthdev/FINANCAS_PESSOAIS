using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

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

        protected override void OnClick(EventArgs e)
        {
            string[] chave = this.Tag.ToString().Split(".");

            string dia = chave[0];
            string mes = chave[1];
            string ano = chave[2];
            string classe = chave[3];
            string tipo, valor, obs;

            string sql = "SELECT B.CLASSE, B.TIPO, REPLACE(IIF(A.VALOR IS NULL, 0, A.VALOR), '.', ','), A.OBS FROM PREVISAO A RIGHT JOIN CLASSE B ";
            sql += "ON A.CLASSE = B.CLASSE_ID WHERE B.CLASSE_ID = " + classe + "";
            BD.Buscar(sql);

            classe = BD.Resultado.Rows[0][0].ToString();
            tipo = BD.Resultado.Rows[0][1].ToString();
            valor = BD.Resultado.Rows[0][2].ToString();
            obs = BD.Resultado.Rows[0][3].ToString();
            mes = DateTimeFormatInfo.CurrentInfo.GetMonthName(int.Parse(mes)).ToUpper();

            boxAddPrev prev = new boxAddPrev();

            if (tipo == "0")
                prev.optDespesa.Checked = true;
            else
                prev.optReceita.Checked = true;

            prev.CarregarCBs(classe:classe, dia:dia, mes:mes, ano:ano);
            prev.txtValor.Text = valor;
            prev.txtObs.Text = obs;

            prev.ShowDialog();

            base.OnClick(e);
        }
    }
}

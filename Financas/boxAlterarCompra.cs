using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class boxAlterarCompra : Form
    {
        public boxAlterarCompra()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string sql;
            string id = this.Tag.ToString();

            if (!COD.ValidarCampos(panel1) || id == "")
                return;
            
            string data = BD.CvData(txtData.Text);
            string valor = BD.CvNum(txtValor.Text);

            try
            {
                sql = "UPDATE COMPRA_CREDITO SET DATA_PARCELA = '" + data + "', VALOR = '" + valor + "' WHERE COMPRA_CREDITO_ID = " + id + "";
                BD.ExecutarSQL(sql);
            }
            catch
            {
                COD.Erro("Não foi possível alterar esta compra!");
                return;
            }

            try
            {
                sql = "UPDATE KEY_COMPRA_CREDITO SET DESCRICAO = '" + txtDesc.Text + "' WHERE CHAVE IN(SELECT A.CHAVE FROM KEY_COMPRA_CREDITO A INNER JOIN COMPRA_CREDITO B ON A.CHAVE = B.CHAVE WHERE B.COMPRA_CREDITO_ID = " + id + ")";
                BD.ExecutarSQL(sql);
            }
            catch
            {
                COD.Erro("Não foi possível alterar esta compra!");
                return;
            }

            this.Dispose();
        }
    }
}

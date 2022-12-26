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
            string sql = "", id, tipo, data, valor, nValor, conta = "";

            id = this.Tag.ToString().Split(".").GetValue(0).ToString();
            tipo = this.Tag.ToString().Split(".").GetValue(1).ToString();
            
            if(tipo != "C")
                conta = nConta(id);

            if (!COD.ValidarCampos(panel1) || id == "" || tipo == "")
                return;

            data = BD.CvData(txtData.Text);
            valor = BD.CvNum(txtValor.Text);
            nValor = BD.CvNum(txtValor.Tag.ToString());

            if (tipo == "C")
            {
                sql = "UPDATE COMPRA_CREDITO SET DATA_PARCELA = '" + data + "', VALOR = '" + valor + "' WHERE COMPRA_CREDITO_ID = " + id + "";
            }
            else if(tipo == "D" || tipo == "R")
            {
                if(tipo == "D")
                {
                    valor = "-" + valor;
                    nValor = nValor.Replace("-", "");
                }
                else
                {
                    nValor = "-" + nValor;
                }

                if(conta != "")
                {
                    Classes.Conta.AtualizarSaldoConta(conta, valor);
                    Classes.Conta.AtualizarSaldoConta(conta, nValor);

                    sql = "UPDATE BD SET DATA = '" + data + "', VALOR = '" + valor + "', DESCRICAO = '" + txtDesc.Text + "' WHERE BD_ID = " + id + "";
                }
            }

            try
            {
                BD.ExecutarSQL(sql);

                if (tipo == "C")
                {
                    try
                    {
                        sql = "UPDATE KEY_COMPRA_CREDITO SET DESCRICAO = '" + txtDesc.Text + "' WHERE CHAVE IN(SELECT A.CHAVE FROM KEY_COMPRA_CREDITO A INNER JOIN COMPRA_CREDITO B ON A.CHAVE = B.CHAVE WHERE B.COMPRA_CREDITO_ID = " + id + ")";
                        BD.ExecutarSQL(sql);
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {
                COD.Erro("Não foi possível alterar esta compra!");
                return;
            }

            this.Tag = "1";

            this.Dispose();
        }

        private string nConta(string id)
        {
            string conta = "";
            string sql = "SELECT CONTA FROM BD WHERE BD_ID = " + id + "";

            try
            {
                conta = BD.Buscar(sql).Rows[0][0].ToString();
            }
            catch
            {
                conta = "";
            }

            return conta;
        }
    }
}

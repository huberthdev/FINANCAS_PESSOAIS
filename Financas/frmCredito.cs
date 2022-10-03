using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class frmCredito : Form
    {
        public frmCredito()
        {
            InitializeComponent();

            CarregarCbClassesCartoes();
        }

        private void CarregarCbClassesCartoes(string campo = "")
        {
            //Preenche o combobox com as classes cadastradas no banco de dados
            if (campo == "classe" || campo == "")
            {
                cbClasse.Items.Clear();
                cbClasse.Items.Add("");
                Classes.Classe.Tipo = 0;
                foreach (Classes.Classe c in Classes.Classe.Lista())
                {
                    cbClasse.Items.Add(c);
                }
            }

            //Preenche o combobox com os cartoes cadastrados no banco de dados
            if (campo == "cartao" || campo == "")
            {
                cbCartao.Items.Clear();
                cbCartao.Items.Add("");
                foreach (Classes.CartaoCredito c in Classes.CartaoCredito.Lista())
                {
                    cbCartao.Items.Add(c);
                }

            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string chave = "";
            string dia_venc;
            string melhor_dia_comp;
            string parcela;
            string vlParc;
            int qtdParc;

            string cartao = ((Classes.CartaoCredito)cbCartao.SelectedItem).id.ToString();
            string classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();

            string[] v = new string[6];

            v[0] = null;
            v[1] = classe;
            v[2] = cartao;
            v[3] = BD.CvNum(txtValor.Text);
            v[4] = BD.CvData(txtData.Text);
            v[5] = txtDesc.Text;

            //TENTA GERAR A CHAVE DESTA TRANSAÇÃO VIA PROCEDURE NO BANCO DE DADOS
            try
            {
                chave = BD.InsertProcedureCredito(v);

                if (chave == "")
                {
                    COD.Erro("Não foi possível salvar esta compra!");
                    return;
                }
            }
            catch
            {
                COD.Erro("Não foi possível salvar esta compra!");
                return;
            }

            qtdParc = int.Parse(txtQtdeParc.Text);

            vlParc = (double.Parse(txtValor.Text) / qtdParc).ToString("C2");
            vlParc = BD.CvNum(vlParc);

            string sql = "SELECT DIA_VENC, MELHOR_DIA_COMPRA FROM CARTAO_CREDITO WHERE ";
            sql += "CARTAO_CREDITO_ID = "+ cartao +"";
            BD.Buscar(sql);
            dia_venc = BD.Resultado.Rows[0][0].ToString();
            melhor_dia_comp = BD.Resultado.Rows[0][1].ToString();

            string[] c = new string[5];
            string[] vl = new string[5];

            for (int i = 0; i < qtdParc; i++)
            {
                parcela = i + "/" + qtdParc;

                c[0] = "chave";
                vl[0] = chave;

                c[1] = "valor";
                vl[1] = vlParc;

                c[2] = "parcela";
                vl[2] = parcela;

                c[3] = "data_parcela";
                vl[3] = "";

                c[4] = "status";
                vl[4] = "0";

            }

        }
    }
}

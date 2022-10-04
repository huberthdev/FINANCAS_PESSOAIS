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
            CarregarLista();
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
            int dia_compra;
            int x;
            string melhor_dia_comp;
            string parcela;
            string vlParc;
            string data;
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

            //Configuração de parâmetros para distribuição das parcelas de acordo com a configuração do cartão selecionado

            dia_compra = DateTime.Parse(txtData.Text).Day;

            if (dia_compra >= int.Parse(melhor_dia_comp))
            {
                data = dia_venc + DateTime.Parse(txtData.Text).ToString("/MM/yyyy");
                data = DateTime.Parse(data).AddMonths(1).ToString("d");
            }
            else
            {
                if(dia_compra >= int.Parse(dia_venc))
                {
                    data = dia_venc + DateTime.Parse(txtData.Text).ToString("/MM/yyyy");
                    data = DateTime.Parse(data).AddMonths(1).ToString("d");
                }
                else
                {
                    data = dia_venc + DateTime.Parse(txtData.Text).ToString("/MM/yyyy");
                    data = DateTime.Parse(data).AddMonths(-1).ToString("d");
                }
            }

            for (int i = 0; i < qtdParc; i++)
            {
                x = i + 1;

                parcela = (x) + "/" + qtdParc;

                c[0] = "chave";
                vl[0] = chave;

                c[1] = "valor";
                vl[1] = vlParc;

                c[2] = "parcela";
                vl[2] = parcela;

                c[3] = "data_parcela";
                vl[3] = BD.CvData(data);

                c[4] = "status";
                vl[4] = "0";

                BD.Salvar("COMPRA_CREDITO", c, vl);

                data = DateTime.Parse(data).AddMonths(1).ToString("d");
            }

            CarregarLista();
        }

        private void CarregarLista()
        {
            string sql = "SELECT B.CHAVE, A.COMPRA_CREDITO_ID AS ID, B.DATA_COMPRA AS DATA, C.CLASSE, A.VALOR, A.PARCELA, ";
            sql += "A.DATA_PARCELA AS DATA_PGMTO, A.STATUS FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ";
            sql += "ON A.CHAVE = B.CHAVE INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID";

            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch
            {

            }
        }
    }
}

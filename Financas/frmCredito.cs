using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;
using System.Drawing;

namespace Setup.Financas
{
    public partial class frmCredito : Form
    {
        public frmCredito()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();
            lblPeriodo.Tag = ((byte)DateTime.Today.Month) + "" + ((int)DateTime.Today.Year);
            lblPeriodo.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month).ToUpper() + " • " + DateTime.Today.Year;

            CarregarCbClassesCartoes();
            CarregarLista();
            ConfigurarLista();
            CarregarTreeFaturas();
        }

        private void CarregarCbClassesCartoes(string campo = "")
        {
            //Preenche o combobox com as classes cadastradas no banco de dados
            if (campo == "classe" || campo == "")
            {
                cbClasse.Items.Clear();
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
                cbFCartao.Items.Clear();
                cbFCartao.Items.Add("");
                foreach (Classes.CartaoCredito c in Classes.CartaoCredito.Lista())
                {
                    cbCartao.Items.Add(c);
                    cbFCartao.Items.Add(c);
                }

            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string chave = "";
            int dia_venc;
            int dia_compra;
            int melhor_dia_comp;
            int x;
            string parcela;
            string vlParc;
            string data = "";
            int qtdParc;
            string sql;

            if (COD.ValidarCampos(this) == false)
            {
                return;
            }

            string cartao = ((Classes.CartaoCredito)cbCartao.SelectedItem).cartao.ToString();
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

            sql = "SELECT DIA_VENC, MELHOR_DIA_COMPRA FROM CARTAO_CREDITO WHERE ";
            sql += "CARTAO_CREDITO_ID = "+ cartao +"";
            BD.Buscar(sql);

            //Configuração de parâmetros para distribuição das parcelas de acordo com a configuração do cartão selecionado

            dia_venc = int.Parse(BD.Resultado.Rows[0][0].ToString());
            melhor_dia_comp = int.Parse(BD.Resultado.Rows[0][1].ToString());
            dia_compra = DateTime.Parse(txtData.Text).Day;

            if(dia_venc < melhor_dia_comp && dia_compra < melhor_dia_comp)
            {
                data = dia_venc + DateTime.Parse(txtData.Text).ToString("/MM/yyyy");
                data = DateTime.Parse(data).AddMonths(1).ToString("d");
            }
            else if (dia_venc < melhor_dia_comp && dia_compra >= melhor_dia_comp)
            {
                data = dia_venc + DateTime.Parse(txtData.Text).ToString("/MM/yyyy");
                data = DateTime.Parse(data).AddMonths(2).ToString("d");
            }
            else if (dia_venc > melhor_dia_comp && dia_compra < melhor_dia_comp)
            {
                data = dia_venc + DateTime.Parse(txtData.Text).ToString("/MM/yyyy");
            }
            else if (dia_venc > melhor_dia_comp && dia_compra >= melhor_dia_comp)
            {
                data = dia_venc + DateTime.Parse(txtData.Text).ToString("/MM/yyyy");
                data = DateTime.Parse(data).AddMonths(1).ToString("d");
            }

            if (data == "")
                return;

                //------------------------------------------------------------------------------------------------------------

            string[] c = new string[5];
            string[] vl = new string[5];

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
            CarregarTreeFaturas();
            NovoLancamento();
        }

        private void ConfigurarLista()
        {
            int col = lista.ColumnCount;

            for (int i = 0; i < col; i++)
            {
                lista.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CarregarLista()
        {
            string periodo;
            string cartao = "";

            if (cbFCartao.Text != "")
            {
                cartao = ((Classes.CartaoCredito)cbFCartao.SelectedItem).cartao.ToString();
            }

            periodo = lblPeriodo.Tag.ToString();

            string sql = "SELECT A.CHAVE, A.COMPRA_CREDITO_ID AS ID, B.DATA_COMPRA AS DATA, C.CLASSE, A.VALOR, A.PARCELA, ";
            sql += "A.DATA_PARCELA AS DATA_PGMTO, B.DESCRICAO FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ";
            sql += "ON A.CHAVE = B.CHAVE INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID ";
            
            if(periodo != "")
            {
                sql += "WHERE EXTRACT(MONTH FROM A.DATA_PARCELA)||EXTRACT(YEAR FROM A.DATA_PARCELA) = "+ periodo +" ";
            }

            if(cartao != "")
            {
                sql += "AND B.CARTAO = " + cartao + "";
            }

            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch
            {

            }

            status.Items[0].Text = "LINHAS: " + lista.RowCount;
        }

        private void CarregarTreeFaturas()
        {
            string sql;
            string ano;
            string mes;
            string periodo;
            string cartao;
            string cor;
            string mesNome;
            string valor;

            treeFaturas.Nodes.Clear();

            //PREENCHER OS NODES COM OS ANOS DISTINTOS
            sql = "SELECT DISTINCT EXTRACT(YEAR FROM DATA_PARCELA) FROM COMPRA_CREDITO";
            BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                ano = BD.Resultado.Rows[i][0].ToString();
                treeFaturas.Nodes.Add("ano", ano).ForeColor = Color.Turquoise;
            }

            //PREENCHER OS NODES COM OS MESES DISTINTOS
            sql = "SELECT DISTINCT EXTRACT(MONTH FROM DATA_PARCELA), EXTRACT(YEAR FROM DATA_PARCELA), SUM(VALOR) FROM COMPRA_CREDITO ";
            sql += "GROUP BY EXTRACT(MONTH FROM DATA_PARCELA), EXTRACT(YEAR FROM DATA_PARCELA) ";
            sql += "ORDER BY EXTRACT(YEAR FROM DATA_PARCELA) ";
            BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                mes = BD.Resultado.Rows[i][0].ToString();
                ano = BD.Resultado.Rows[i][1].ToString();
                valor = BD.Resultado.Rows[i][2].ToString();

                for (int x = 0; x < treeFaturas.Nodes.Count; x++)
                {
                    if (treeFaturas.Nodes[x].Text == ano)
                    {
                        mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(int.Parse(mes)).ToUpper();
                        treeFaturas.Nodes[x].Nodes.Add(mes + ano, mesNome + " • " + double.Parse(valor).ToString("C"));
                    }
                }
            }

            //PREENCHE OS NODES COM OS CARTÕES E SEUS VALORES RESPECTIVOS DENTRO DE CADA MÊS
            sql = "SELECT DISTINCT D.CONTA, EXTRACT(MONTH FROM A.DATA_PARCELA) || EXTRACT(YEAR FROM A.DATA_PARCELA), C.COR, SUM(A.VALOR) ";
            sql += "FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CARTAO_CREDITO C ";
            sql += "ON B.CARTAO = C.CARTAO_CREDITO_ID INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID GROUP BY ";
            sql += "D.CONTA, EXTRACT(MONTH FROM A.DATA_PARCELA), EXTRACT(YEAR FROM A.DATA_PARCELA), C.COR ORDER BY EXTRACT(YEAR FROM A.DATA_PARCELA)";
            BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                cartao = BD.Resultado.Rows[i][0].ToString();
                periodo = BD.Resultado.Rows[i][1].ToString();
                cor = BD.Resultado.Rows[i][2].ToString();
                valor = BD.Resultado.Rows[i][3].ToString();

                if (cor == "")
                {
                    cor = "-16777216";
                }

                for (int j = 0; j < treeFaturas.Nodes.Count; j++)
                {
                    for (int k = 0; k < treeFaturas.Nodes[j].Nodes.Count; k++)
                    {
                        if (treeFaturas.Nodes[j].Nodes[k].Name == periodo)
                        {
                            treeFaturas.Nodes[j].Nodes[k].Nodes.Add(periodo, cartao + " • "
                                + double.Parse(valor).ToString("C"), cartao.Length).BackColor = Color.FromArgb(int.Parse(cor));
                        }
                    }
                }
            }

            for (int i = 0; i < treeFaturas.Nodes.Count; i++)
            {
                if(treeFaturas.Nodes[i].Text == DateTime.Today.Year.ToString())
                {
                    treeFaturas.Nodes[i].Expand();
                }
            }

            //VERIFICA SE A FATURA DO MES ESTÁ PAGA E MUDA A COR PARA VERMELHO[NÃO PAGO] E VERDE[PAGO]


            if (treeFaturas.Nodes.Count == 0)
            {
                lblPeriodo.Text = "";
            }
        }

        private void cartoes_Click(object sender, EventArgs e)
        {
            boxCartaoCredito boxC = new boxCartaoCredito();
            boxC.ShowDialog();
        }

        private void frmCredito_Activated(object sender, EventArgs e)
        {
            CarregarCbClassesCartoes("cartao");
            CarregarTreeFaturas();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            string chave;

            if (lista.RowCount == 0 || lista.SelectedRows.Count == 0)
                return;

            chave = lista.SelectedRows[0].Cells[1].Value.ToString();

            Classes.Geral.ExcluirCompraCredito(chave);

            CarregarLista();
            CarregarTreeFaturas();
        }

        private void NovoLancamento()
        {
            COD.LimparCampos(this, txtData, cbCartao);
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            NovoLancamento();
        }

        private void cbFCartao_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void treeFaturas_DoubleClick(object sender, EventArgs e)
        {
            string chave;
            string periodo;
            string cartao = "";

            if (treeFaturas.SelectedNode is null || treeFaturas.SelectedNode.Name == "ano")
            {
                return;
            }

            chave = treeFaturas.SelectedNode.Name;
            periodo = chave.Substring(chave.Length - 4, 4) + "/" + treeFaturas.SelectedNode.Text;

            if(treeFaturas.SelectedNode.Level == 2)
            {
                cartao = treeFaturas.SelectedNode.Text;
                cartao = cartao.Substring(0, treeFaturas.SelectedNode.ImageIndex);
            }

            try
            {
                cbFCartao.Text = cartao;
            }
            catch (Exception)
            {

            }

            lblPeriodo.Text = periodo;
            lblPeriodo.Tag = chave;

            CarregarLista();
        }

        private void cbFCartao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCredito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            string id;

            if (lista.RowCount == 0)
                return;

            id = lista.SelectedRows[0].Cells[2].Value.ToString();

            Classes.Geral.AbrirDetalheTransacao(id, "C");
        }
    }
}

using Setup.Classes;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class frmCredito : Form
    {
        public frmCredito()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();
            status.Items["periodo"].Text = "[" + DateTime.Today.Month + "." + DateTime.Today.Year + "]";
            //lblPeriodo.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month).ToUpper() + " • " + DateTime.Today.Year;

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
                try
                {
                    Filtros.cCartao = cbCartao.Text;
                    Filtros.fCartao = cbFCartao.Text;
                }
                catch
                {
                    Filtros.cCartao = "";
                    Filtros.fCartao = "";
                }

                cbCartao.Items.Clear();
                cbFCartao.Items.Clear();
                cbFCartao.Items.Add("");
                Classes.CartaoCredito.Ativo = 1;
                foreach (Classes.CartaoCredito c in Classes.CartaoCredito.Lista())
                {
                    cbCartao.Items.Add(c);
                    cbFCartao.Items.Add(c);
                }

                try
                {
                    cbCartao.Text = Filtros.cCartao;
                    cbFCartao.Text = Filtros.fCartao;
                }
                catch
                {

                }
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string chave = "", parcela, vlParc, data = "", sql;
            int dia_venc, dia_compra, melhor_dia_comp, x, qtdParc;

            if (COD.ValidarCampos(this) == false)
            {
                return;
            }

            string cartao = ((CartaoCredito)cbCartao.SelectedItem).cartao.ToString();
            string classe = ((Classe)cbClasse.SelectedItem).id.ToString();

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
            string periodo, cartao = "";
            double valorFatura = 0;

            if (cbFCartao.Text != "")
            {
                cartao = ((CartaoCredito)cbFCartao.SelectedItem).cartao.ToString();
            }

            try
            {
                periodo = status.Items["periodo"].Text.Replace(".", "");
                periodo = periodo.Replace("[", "");
                periodo = periodo.Replace("]", "");
            }
            catch
            {
                return;                
            }

            if(periodo == "")
            {
                periodo = DateTime.Today.ToString("MMyyyy");
            }

            string sql = "SELECT A.CHAVE, A.COMPRA_CREDITO_ID AS ID, B.DATA_COMPRA AS DATA, C.CLASSE, A.VALOR, A.PARCELA, ";
            sql += "A.DATA_PARCELA AS DATA_PGMTO, B.DESCRICAO, A.STATUS FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ";
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

            for (int i = 0; i < lista.RowCount; i++)
            {
                valorFatura +=  double.Parse(lista.Rows[i].Cells[4].Value.ToString());
            }

            status.Items["statusLabel"].Text = "LINHAS: " + lista.RowCount;
            status.Items["valorFatura"].Text = valorFatura.ToString("C");

        }

        private void CarregarTreeFaturas()
        {
            string sql, ano, mes, periodo, cartao, cor, mesNome, valor, s = "", status;

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
            sql = "SELECT DISTINCT D.CONTA, EXTRACT(MONTH FROM A.DATA_PARCELA) || EXTRACT(YEAR FROM A.DATA_PARCELA), C.COR, SUM(A.VALOR), SUM(A.STATUS) ";
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
                status = BD.Resultado.Rows[i][4].ToString();

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
                            if (status == "0")
                                s = "Pendente";
                            else
                                s = "Pago";

                            treeFaturas.Nodes[j].Nodes[k].Nodes.Add(periodo, cartao + " • " + double.Parse(valor).ToString("C") + " • " + s, cartao.Length).BackColor = Color.FromArgb(int.Parse(cor));
                        }
                    }
                }
            }

            periodo = DateTime.Today.ToString("Myyyy");
            for (int i = 0; i < treeFaturas.Nodes.Count; i++)
            {
                if(treeFaturas.Nodes[i].Text == DateTime.Today.Year.ToString())
                {
                    treeFaturas.Nodes[i].Expand();

                    for (int x = 0; x < treeFaturas.Nodes[i].Nodes.Count; x++)
                    {
                        if(treeFaturas.Nodes[i].Nodes[x].Name == periodo)
                        {
                            treeFaturas.Nodes[i].Nodes[x].Expand();
                        }
                    }
                }

                if(DateTime.Today.Month == 12 && treeFaturas.Nodes[i].Text == (DateTime.Today.Year + 1).ToString())
                {
                    treeFaturas.Nodes[i].Expand();
                }
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

            if (lista.RowCount == 0)
                return;

            try
            {
                chave = lista.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                return;
            }

            if(!Geral.ExcluirCompraCredito(chave))
                return;

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
            string chave, periodo, cartao = "";

            if (treeFaturas.SelectedNode is null || treeFaturas.SelectedNode.Name == "ano")
            {
                return;
            }

            chave = treeFaturas.SelectedNode.Name;
            periodo = chave.Substring(0, chave.Length - 4) + "." + chave.Substring(chave.Length - 4, 4);

            if (treeFaturas.SelectedNode.Level == 2)
            {
                cartao = treeFaturas.SelectedNode.Text;
                cartao = cartao.Substring(0, treeFaturas.SelectedNode.ImageIndex);
            }

            try
            {
                cbFCartao.Text = cartao;
                status.Items["periodo"].Text = "[" + periodo + "]";
            }
            catch
            {

            }

            CarregarLista();
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

            id = lista.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                Geral.AbrirDetalheTransacao(id, "C");
            }
            catch
            {

            }
        }

        private void btnPagarFatura_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (lista.RowCount == 0)
            {
                COD.Erro("A lista está vazia!");
                return;
            }

            if (cbFCartao.Text == "")
            {
                COD.Erro("Selecione um Cartão!");
                cbFCartao.Focus();
                return;
            }

            for (int i = 0; i < lista.RowCount; i++)
            {
                if(lista.Rows[i].Cells[8].Value.ToString() == "1")
                {
                    x++;
                }
            }

            if (x != 0)
            {
                return;
            }

            boxPagFatura pagF = new boxPagFatura();

            pagF.lista.DataSource = lista.DataSource;
            pagF.lblPeriodo.Text = status.Items["periodo"].Text + " • " + status.Items["valorFatura"].Text;

            try
            {
                pagF.lblPeriodo.Tag = status.Items["periodo"].Text.Replace(".", "");

                pagF.cbConta.Items.Clear();
                foreach (Conta c in Conta.Lista())
                {
                    pagF.cbConta.Items.Add(c);
                }

                pagF.cbConta.Text = cbFCartao.Text;
            }
            catch
            {
                COD.Erro("Não foi possível realizar esta operação!");
                return;
            }

            pagF.ShowDialog();
        }

        private void lista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < lista.RowCount; i++)
            {
                for (int c = 0; c < lista.ColumnCount; c++)
                {
                    if (lista.Rows[i].Cells[8].Value.ToString() == "1")
                    {
                        if (lista.Columns[c].Index == 4)
                        {
                            lista.Rows[i].Cells[c].Style.ForeColor = Color.LimeGreen;
                        }
                    }
                    else
                    {
                        if(lista.Columns[c].Index == 4)
                        {
                            lista.Rows[i].Cells[c].Style.ForeColor = Color.Tomato;
                        }
                    }
                }
            }
        }

        private void frmCredito_Load(object sender, EventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            string id, data, valor, desc;

            try
            {
                id = lista.SelectedRows[0].Cells[1].Value.ToString();
                valor = lista.SelectedRows[0].Cells[4].Value.ToString();
                data = lista.SelectedRows[0].Cells[6].Value.ToString();
                desc = lista.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch
            {
                return;
            }

            boxAlterarCompra AltComp = new boxAlterarCompra();

            AltComp.txtValor.Text = double.Parse(valor).ToString("N");
            AltComp.txtData.Text = DateTime.Parse(data).ToShortDateString();
            AltComp.txtDesc.Text = desc;
            AltComp.Tag = id;
            AltComp.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string id;

            try
            {
                id = lista.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                return;
            }

            if (lista.RowCount == 0)
            {
                e.Cancel = true;
            }
            else if(lista.SelectedRows[0].Cells[8].Value.ToString() == "1")
            {
                e.Cancel = true;
            }

            contextMenuStrip1.Items["editar"].Text = "Alterar Compra Nº [" + id + "]";
        }
    }
}

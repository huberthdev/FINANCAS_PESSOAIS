﻿using Setup.Classes;
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
            //lblPeriodo.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month).ToUpper() + " • " + DateTime.Today.Year;

            CarregarCbClassesCartoes();
            cbFCartao.Text = Cartao_Parcela_Mais_Proxima();
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
                Classe.Tipo = 0;
                foreach (Classe c in Classe.Lista())
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
                CartaoCredito.Ativo = 1;
                foreach (CartaoCredito c in CartaoCredito.Lista())
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
            Salvar_Transacao();
        }

        private void Salvar_Transacao(string outro_valor = "")
        {
            string chave, parcela, vlParc, data, sql, valor;
            int dia_venc, dia_compra, melhor_dia_comp, x, qtdParc;
            string cartao, classe, desc, conta;

            if (outro_valor == "")
            {
                if (COD.ValidarCampos(this) == false)
                    return;

                cartao = ((CartaoCredito)cbCartao.SelectedItem).cartao.ToString();
                classe = ((Classe)cbClasse.SelectedItem).id.ToString();
                valor = txtValor.Text;
                valor = BD.CvNum(valor);
                data = BD.CvData(txtData.Text);
                desc = txtDesc.Text;

                if (ckEstorno.Checked)
                {
                    valor = "-" + valor;
                    COD.Pergunta("Lançar como estorno. Confirma?");
                    if (!COD.Resposta)
                        return;
                }
            }
            else
            {
                try
                {
                    COD.Pergunta("Debitar valor da fatura: \r\n\r\nValor: [" + outro_valor + "] \r\nConta: [" + cbFCartao.Text + "]");
                    if (!COD.Resposta)
                        return;

                    classe = Classe.GetID("Pag. Fatura");

                    cartao = ((CartaoCredito)cbFCartao.SelectedItem).cartao.ToString();
                    valor = outro_valor;
                    data = lista.Rows[0].Cells[6].Value.ToString();
                    data = DateTime.Parse(data).ToShortDateString();
                    dia_compra = ((CartaoCredito)cbFCartao.SelectedItem).vencimento;
                    data = dia_compra + data.Substring(2);
                    data = BD.CvData(data);
                    desc = "Pag. Antecipado - " + DateTime.Today.ToShortDateString().Replace("/", ".");
                }
                catch
                {
                    COD.Erro("Não foi possível resgistrar este pagamento!");
                    return;
                }
            }

            string[] v = new string[6];

            v[0] = null;
            v[1] = classe;
            v[2] = cartao;
            v[3] = valor;
            v[4] = data;
            v[5] = desc;

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

            if (outro_valor == "")
            {
                qtdParc = int.Parse(txtQtdeParc.Text);

                vlParc = (double.Parse(txtValor.Text) / qtdParc).ToString("C2");
                vlParc = BD.CvNum(vlParc);

                if (ckEstorno.Checked)
                {
                    vlParc = "-" + vlParc;
                }

                sql = "SELECT DIA_VENC, MELHOR_DIA_COMPRA FROM CARTAO_CREDITO WHERE ";
                sql += "CARTAO_CREDITO_ID = " + cartao + "";
                BD.Buscar(sql);

                //Configuração de parâmetros para distribuição das parcelas de acordo com a configuração do cartão selecionado

                dia_venc = int.Parse(BD.Resultado.Rows[0][0].ToString());
                melhor_dia_comp = int.Parse(BD.Resultado.Rows[0][1].ToString());
                dia_compra = DateTime.Parse(txtData.Text).Day;

                if (dia_venc < melhor_dia_comp && dia_compra < melhor_dia_comp)
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
            }
            else
            {
                qtdParc = 1;
                vlParc = "-" + valor;
            }

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

            if (outro_valor != "")
            {
                conta = ((CartaoCredito)cbFCartao.SelectedItem).conta.ToString();
                Conta.AtualizarSaldoConta(conta, vlParc);
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
            string mes, periodo, cartao = "";
            
            if (cbFCartao.Text != "")
            {
                cartao = ((CartaoCredito)cbFCartao.SelectedItem).cartao.ToString();
            }

            try
            {
                periodo = status.Items["periodo"].Text.Replace("[", "");
                periodo = periodo.Replace("]", "");
                mes = periodo.Split(".").GetValue(0).ToString();
                mes = Geral.MesNome(mes);
                periodo = mes + periodo.Split(".").GetValue(1).ToString();
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
                sql += "AND B.CARTAO = " + cartao + " ";
            }

            sql += "ORDER BY B.DATA_COMPRA DESC, A.COMPRA_CREDITO_ID DESC";

            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch
            {

            }
        }

        private void lista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            double valorFatura = 0;

            for (int i = 0; i < lista.RowCount; i++)
            {
                for (int c = 0; c < lista.ColumnCount; c++)
                {
                    if (!lista.Rows[i].Cells[4].Value.ToString().Contains("-"))
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
                            if (lista.Columns[c].Index == 4)
                            {
                                lista.Rows[i].Cells[c].Style.ForeColor = Color.Tomato;
                            }
                        }
                    }
                    else
                    {
                        if (lista.Columns[c].Index == 4)
                        {
                            lista.Rows[i].Cells[c].Style.ForeColor = Color.FromArgb(0, 192, 192);
                        }
                    }
                }
            }

            for (int i = 0; i < lista.RowCount; i++)
            {
                valorFatura += double.Parse(lista.Rows[i].Cells[4].Value.ToString());
            }

            status.Items["statusLabel"].Text = "LINHAS: " + lista.RowCount;
            status.Items["valorFatura"].Text = valorFatura.ToString("C");

            lblPeriodo.Text = status.Items["periodo"].Text + "  " + status.Items["valorFatura"].Text;

            Atualizar_Limite_Utilizado();
        }

        private void CarregarTreeFaturas()
        {
            string sql, data, periodo = "", cartao, cor, mesNome, valor, s = "", status;
            string proxPeriodo, proxAno;

            string mes = DateTime.Today.Month.ToString();
            string ano = DateTime.Today.Year.ToString();

            bool FatMesTotPaga = false;

            treeFaturas.Nodes.Clear();

            //VERIFICA SE TODAS AS FATURAS DO MÊS ATUAL FORAM PAGAS PARA PODER HABILITAR A ABERTUDA DO PRÓXIMO MÊS
            data = String.Concat("01/", mes, "/", ano);
            data = DateTime.Parse(data).AddMonths(1).ToShortDateString();
            try
            {
                sql = "SELECT STATUS FROM COMPRA_CREDITO WHERE EXTRACT(MONTH FROM DATA_PARCELA) = " + mes + " ";
                sql += "AND EXTRACT(YEAR FROM DATA_PARCELA) = " + ano + " GROUP BY STATUS ORDER BY STATUS";
                if(BD.Buscar(sql).Rows[0][0].ToString() != "0")
                {
                    FatMesTotPaga = true;
                }
            }
            catch
            {

            }

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
            sql = "SELECT DISTINCT D.CONTA, EXTRACT(MONTH FROM A.DATA_PARCELA) || EXTRACT(YEAR FROM A.DATA_PARCELA), C.COR, SUM(A.VALOR), MIN(A.STATUS) AS STATUS, C.DIA_VENC ";
            sql += "FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CARTAO_CREDITO C ";
            sql += "ON B.CARTAO = C.CARTAO_CREDITO_ID INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID GROUP BY ";
            sql += "D.CONTA, EXTRACT(MONTH FROM A.DATA_PARCELA), EXTRACT(YEAR FROM A.DATA_PARCELA), C.COR, C.DIA_VENC ORDER BY EXTRACT(YEAR FROM A.DATA_PARCELA), C.DIA_VENC";
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

            proxPeriodo = DateTime.Parse(data).ToString("Myyyy");
            proxAno = DateTime.Parse(data).ToString("yyyy");

            if (!FatMesTotPaga)
            {
                periodo = DateTime.Today.ToString("Myyyy");
                ano = DateTime.Today.Year.ToString();
            }
            else
            {
                periodo = proxPeriodo;
                ano = proxAno;
            }

            for (int i = 0; i < treeFaturas.Nodes.Count; i++)
            {
                if(treeFaturas.Nodes[i].Text == ano || treeFaturas.Nodes[i].Text == proxAno)
                {
                    treeFaturas.Nodes[i].Expand();

                    for (int x = 0; x < treeFaturas.Nodes[i].Nodes.Count; x++)
                    {
                        //treeFaturas.Nodes[i].Nodes[x].Name == periodo || 
                        if (treeFaturas.Nodes[i].Nodes[x].Name == periodo || treeFaturas.Nodes[i].Nodes[x].Name == proxPeriodo)
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

        private void Excluir_Compra()
        {
            string chave, classe;

            if (lista.RowCount == 0)
                return;

            try
            {
                chave = lista.SelectedRows[0].Cells[0].Value.ToString();
                classe = lista.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }

            if (!Geral.ExcluirCompraCredito("0." + chave + "." + classe))
                return;

            CarregarLista();
            CarregarTreeFaturas();

        }

        private void excluir_Click(object sender, EventArgs e)
        {
            Excluir_Compra();
        }

        private void NovoLancamento()
        {
            COD.LimparCampos(this, txtData, cbCartao);
            ckEstorno.Checked = false;
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
            string mes, chave, periodo, cartao = "";

            if (treeFaturas.SelectedNode is null || treeFaturas.SelectedNode.Name == "ano")
            {
                return;
            }

            chave = treeFaturas.SelectedNode.Name;
            mes = chave.Substring(0, chave.Length - 4);
            mes = Geral.MesNome(mes, true);
            periodo =  mes + "." + chave.Substring(chave.Length - 4, 4);

            if (treeFaturas.SelectedNode.Level == 2)
            {
                cartao = treeFaturas.SelectedNode.Text;
                cartao = cartao.Substring(0, treeFaturas.SelectedNode.ImageIndex);
            }

            try
            {
                cbFCartao.Text = cartao;
                status.Items["periodo"].Text = "[" + periodo + "]";
                status.Items["periodo"].Tag = chave;
            }
            catch
            {
                return;
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

            id = lista.SelectedRows[0].Cells[1].Value.ToString();

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

            for (int i = 0; i < lista.RowCount; i++)
            {
                if (lista.Rows[i].Cells[8].Value.ToString() == "0")
                {
                    x++;
                }
            }

            if (x == 0)
            {
                return;
            }

            if (cbFCartao.Text == "")
            {
                COD.Erro("Selecione um Cartão!");
                cbFCartao.Focus();
                return;
            }

            cmsPagar.Show(Cursor.Position);
        }

        private void pagarValorTotal_Click(object sender, EventArgs e)
        {
            Pagar_Fatura_Total();
        }

        private void pagarOutroValor_Click(object sender, EventArgs e)
        {
            Pagar_Fatura_Outro_Valor();
        }

        private void Pagar_Fatura_Total()
        {
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

        private void Pagar_Fatura_Outro_Valor()
        {
            string valor;
            boxValor vl = new boxValor();
            vl.lblTitulo.Text = "Valor R$";
            vl.ShowDialog();
            valor = BD.SaldoInicial;

            if (valor == "0.00")
                return;

            Salvar_Transacao(valor);
        }

        private void editar_Click(object sender, EventArgs e)
        {
            string id, data, desc;
            double valor;

            try
            {
                id = lista.SelectedRows[0].Cells[1].Value.ToString();
                valor = double.Parse(lista.SelectedRows[0].Cells[4].Value.ToString());
                data = lista.SelectedRows[0].Cells[6].Value.ToString();
                desc = lista.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch
            {
                return;
            }

            boxAlterarCompra AltComp = new boxAlterarCompra();

            AltComp.Tag = id + ".C";
            AltComp.txtValor.Text = valor.ToString("N");
            AltComp.txtData.Text = DateTime.Parse(data).ToShortDateString();
            AltComp.txtDesc.Text = desc;
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

        private string Cartao_Parcela_Mais_Proxima()
        {
            int mes = DateTime.Today.Month;
            int ano = DateTime.Today.Year;

            string pData = DateTime.Parse("01/" + mes + "/" + ano).AddMonths(1).ToShortDateString();
            string conta;

            string sql = "SELECT FIRST 1 CONTA, DATA FROM (SELECT DISTINCT D.CONTA, A.DATA_PARCELA AS DATA FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CARTAO_CREDITO C ON B.CARTAO = C.CARTAO_CREDITO_ID INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID WHERE EXTRACT(MONTH FROM A.DATA_PARCELA) = " + mes + " AND EXTRACT(YEAR FROM A.DATA_PARCELA) = " + ano + " AND A.STATUS = 0 ";

            mes = DateTime.Parse(pData).Month;
            ano = DateTime.Parse(pData).Year;

            sql += "UNION SELECT DISTINCT D.CONTA, A.DATA_PARCELA AS DATA FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CARTAO_CREDITO C ON B.CARTAO = C.CARTAO_CREDITO_ID INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID WHERE EXTRACT(MONTH FROM A.DATA_PARCELA) = " + mes + " AND EXTRACT(YEAR FROM A.DATA_PARCELA) = " + ano + " AND A.STATUS = 0) ORDER BY CONTA, DATA";

            try
            {
                conta = BD.Buscar(sql).Rows[0][0].ToString();
                pData = BD.Buscar(sql).Rows[0][1].ToString();
            }
            catch
            {
                conta = "";
            }

            mes = DateTime.Parse(pData).Month;
            ano = DateTime.Parse(pData).Year;

            try
            {
                status.Items["periodo"].Text = "[" + Geral.MesNome(mes.ToString(), true) + "." + ano + "]";
                status.Items["periodo"].Tag = mes + "" + ano;
            }
            catch 
            {
                status.Items["periodo"].Text = "[" + Geral.MesNome(DateTime.Today.Month.ToString(), true) + "." + DateTime.Today.Year.ToString() + "]";
                status.Items["periodo"].Tag = DateTime.Today.Month + "" + ano;
            }

            return conta;
        }

        private void mesAnterior_Click(object sender, EventArgs e)
        {
            Mudar_Periodo(0);
        }

        private void mesProximo_Click(object sender, EventArgs e)
        {
            Mudar_Periodo(1);
        }

        private void Mudar_Periodo(int x)
        {
            string mes, ano, chave, periodo;

            chave = status.Items["periodo"].Tag.ToString();
            mes = chave.Substring(0, chave.Length - 4);
            ano = chave.Substring(chave.Length - 4, 4);

            if (x == 1)
            {
                ano = DateTime.Parse("01/" + mes + "/" + ano).AddMonths(1).Year.ToString();
                mes = DateTime.Parse("01/" + mes + "/" + ano).AddMonths(1).Month.ToString();
            }
            else
            {
                ano = DateTime.Parse("01/" + mes + "/" + ano).AddMonths(-1).Year.ToString();
                mes = DateTime.Parse("01/" + mes + "/" + ano).AddMonths(-1).Month.ToString();
            }

            try
            {
                chave = mes + "" + ano;
                mes = Geral.MesNome(mes, true);
                periodo = mes + "." + ano;

                status.Items["periodo"].Text = "[" + periodo + "]";
                status.Items["periodo"].Tag = chave;
            }
            catch
            {
                return;
            }

            CarregarLista();
        }

        private void lista_SelectionChanged(object sender, EventArgs e)
        {
            Ativar_Exclusao();
        }

        private void lista_Click(object sender, EventArgs e)
        {
            Ativar_Exclusao();
        }

        private void Ativar_Exclusao()
        {
            int cont = 1;

            try
            {
                cont = lista.SelectedCells.Count;
            }
            catch
            {

            }

            if (cont == 0)
                return;

            if (lista.CurrentRow.Cells[8].Value.ToString() == "1")
            {
                menuStrip1.Items["excluir"].Enabled = false;
            }
            else
            {
                menuStrip1.Items["excluir"].Enabled = true;
            }
        }

        private void excluir__Click(object sender, EventArgs e)
        {
            Excluir_Compra();
        }

        private void Atualizar_Limite_Utilizado()
        {
            string sql, txt = ""; int cartao;

            status.Items["utilizado"].Text = "";

            try
            {
                cartao = ((CartaoCredito)cbFCartao.SelectedItem).cartao;
            }
            catch
            {
                return;
            }

            sql = "UPDATE CARTAO_CREDITO SET CARTAO_CREDITO.UTILIZADO = ";
            sql += "(SELECT SUM(A.VALOR) FROM COMPRA_CREDITO A INNER JOIN ";
            sql += "KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE WHERE B.CARTAO = "+ cartao +" ";
            sql += "AND A.STATUS = 0) WHERE CARTAO_CREDITO.CARTAO_CREDITO_ID = "+ cartao +"";
            BD.ExecutarSQL(sql);

            sql = "SELECT IIF(LIMITE IS NULL, 0, LIMITE), IIF(UTILIZADO IS NULL, 0, UTILIZADO), ";
            sql += "IIF((LIMITE - UTILIZADO) < 0, 0, (LIMITE - UTILIZADO)) AS DISPONIVEL , MELHOR_DIA_COMPRA FROM ";
            sql += "CARTAO_CREDITO WHERE CARTAO_CREDITO_ID = "+ cartao +"";

            try
            {
                if (BD.Buscar(sql).Rows.Count > 0)
                {
                    txt = "[LIMITE: " + Double.Parse(BD.Resultado.Rows[0][0].ToString()).ToString("N") + "]  ";
                    txt += "[UTILIZADO: " + Double.Parse(BD.Resultado.Rows[0][1].ToString()).ToString("N") + "]  ";
                    txt += "[DISPONÍVEL: " + Double.Parse(BD.Resultado.Rows[0][2].ToString()).ToString("N") + "]  ";
                    txt += "[FECHAMENTO DIA: " + BD.Resultado.Rows[0][3].ToString() + "]";
                }
            }
            catch
            {
                return;
            }

            status.Items["utilizado"].Text = txt;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace Setup.Financas
{
    public partial class frmRelatorio : Form
    {
        public bool UpdList = true;

        public frmRelatorio()
        {
            InitializeComponent();

            CarregarCbClassesContas();
            DatasPadrao();
        }

        private void DatasPadrao()
        {
            int mes = DateTime.Today.Month;
            int ano = DateTime.Today.Year;
            int ultDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

            txtDataInicio.Value = new DateTime(ano, mes, 01);
            txtDataInicio.Checked = true;

            txtDataFim.Value = new DateTime(ano, mes, ultDia);
            txtDataFim.Checked = true;
        }

        private void CarregarLista(string sql = "")
        {
            string classe, conta = "", descricao = "";
            string data1 = "", data2 = "";

            if (txtDataInicio.Checked)
            {
                data1 = BD.CvData(txtDataInicio.Value.ToShortDateString());
            }

            if (txtDataFim.Checked)
            {
                data2 = BD.CvData(txtDataFim.Value.ToShortDateString());
            }

            string v1 = BD.CvNum(txtValor1.Text);
            string v2 = BD.CvNum(txtValor2.Text);

            if (data1 == "")
                data1 = "01.01.1900";

            if (data2 == "")
                data2 = "31.12.9999";

            if(txtDescricao.Text != "")
                descricao = "%" + txtDescricao.Text.Replace("*", "%").ToUpper().Trim() + "%";

            lista.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (txtValor1.Text != "" && txtValor2.Text != "")
            {
                if (Math.Abs(double.Parse(v1)) > Math.Abs(double.Parse(v2)))
                {
                    v2 = BD.CvNum(txtValor1.Text);
                    v1 = BD.CvNum(txtValor2.Text);
                }
            }

            if (sql == "")
            {
                sql = "SELECT ID, TIPO, DATA, CLASSE, CONTA, VALOR, DESC, STATUS FROM( ";

                //MONTAGEM DO SQL COM TODAS AS CONDIÇÕES DE FILTRO NA TABELA BD - RECEITAS E DESPESAS
                sql += "SELECT A.BD_ID AS ID, 'D' AS TIPO, A.DATA AS DATA, B.CLASSE, C.CONTA, A.VALOR, A.DESCRICAO AS DESC, A.STATUS AS STATUS FROM BD A ";
                sql += "INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID ";
                sql += "INNER JOIN CONTA C ON A.CONTA = C.CONTA_ID ";
                sql += "WHERE A.DATA BETWEEN CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE) ";

                if(descricao != "")
                {
                    sql += "AND UPPER(A.DESCRICAO) LIKE '" + descricao + "' ";
                }

                if (ckReceita.Checked == true && ckDespesa.Checked == false)//RECEITAS
                {
                    if(txtValor1.Text == "" && txtValor2.Text == "")
                        sql += "AND A.VALOR > 0 ";
                    else if(txtValor1.Text != "" && txtValor2.Text == "")
                        sql += "AND A.VALOR BETWEEN CAST(" + v1 + " AS DECIMAL) AND 1000000 ";
                    else if (txtValor1.Text == "" && txtValor2.Text != "")
                        sql += "AND A.VALOR BETWEEN 0 AND CAST(" + v2 + " AS DECIMAL) ";
                    else if (txtValor1.Text != "" && txtValor2.Text != "" && txtValor1.Text != txtValor2.Text)
                        sql += "AND A.VALOR BETWEEN CAST(" + v1 + " AS DECIMAL) AND CAST(" + v2 + " AS DECIMAL) ";
                    else if (txtValor1.Text != "" && txtValor2.Text != "" && txtValor1.Text == txtValor2.Text)
                        sql += "AND A.VALOR = "+ v1 +" ";
                }
                else if (ckReceita.Checked == false && ckDespesa.Checked == true)//DESPESAS
                {
                    v1 = "-" + v1;
                    v2 = "-" + v2;

                    if (txtValor1.Text == "" && txtValor2.Text == "")
                        sql += "AND A.VALOR < 0 ";
                    else if (txtValor1.Text != "" && txtValor2.Text == "")
                        sql += "AND A.VALOR BETWEEN -1000000 AND CAST(" + v1 + " AS DECIMAL) ";
                    else if (txtValor1.Text == "" && txtValor2.Text != "")
                        sql += "AND A.VALOR BETWEEN CAST(" + v2 + " AS DECIMAL) AND 0 ";
                    else if (txtValor1.Text != "" && txtValor2.Text != "" && txtValor1.Text != txtValor2.Text)
                        sql += "AND A.VALOR BETWEEN CAST(" + v2 + " AS DECIMAL) AND CAST(" + v1 + " AS DECIMAL) ";
                    else if (txtValor1.Text != "" && txtValor2.Text != "" && txtValor1.Text == txtValor2.Text)
                        sql += "AND A.VALOR = " + v1 + " ";
                }
                    
                //FILTRO CLASSE
                if (cbClasse.Text != "")
                {
                    classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();
                    sql += "AND A.CLASSE = "+ classe +" ";
                }

                //FILTRO CONTA
                if (cbConta.Text != "")
                {
                    conta = ((Classes.Conta)cbConta.SelectedItem).id.ToString();
                    sql += "AND A.CONTA = " + conta + " ";
                }
                //
                //MONTAGEM DO SQL COM TODAS AS CONDIÇÕES DE FILTRO NA TABELA TRANSFERENCIA
                //
                if(ckDespesa.Checked && ckReceita.Checked || !ckDespesa.Checked && !ckReceita.Checked)
                {
                    sql += "UNION SELECT A.TRANSFERENCIA_ID AS ID, 'T' AS TIPO, A.DATA AS DATA, ";
                    sql += "'TRANSF. ENTRE CONTAS' AS CLASSE, B.CONTA || ' >> ' || C.CONTA, A.VALOR, A.DESCRICAO AS DESC, '1' AS STATUS ";
                    sql += "FROM TRANSFERENCIA A INNER JOIN CONTA B ON A.CONTA_DEBITO = B.CONTA_ID INNER JOIN CONTA C ON A.CONTA_CREDITO = C.CONTA_ID ";
                    sql += "WHERE A.DATA BETWEEN CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE) ";
                    //FILTRO CONTA
                    if (cbConta.Text != "")
                    {
                        sql += "AND (B.CONTA_ID = " + conta + " OR C.CONTA_ID = " + conta + ") ";
                    }
                    //FILTRO DESCRIÇÃO
                    if (descricao != "")
                    {
                        sql += "AND UPPER(A.DESCRICAO) LIKE '" + descricao + "' ";
                    }
                }
                //
                //MONTAGEM DO SQL COM TODAS AS CONDIÇÕES DE FILTRO NA TABELA COMPRA_CREDITO
                //
                if (!(!ckDespesa.Checked && ckReceita.Checked))
                {
                    sql += "UNION SELECT A.COMPRA_CREDITO_ID || '.' || A.CHAVE AS ID, 'C' AS TIPO, B.DATA_COMPRA AS DATA, ";
                    sql += "C.CLASSE, E.CONTA, (A.VALOR * -1) AS VALOR, B.DESCRICAO || ' [' || A. PARCELA || ']' AS DESC, A.STATUS AS STATUS FROM COMPRA_CREDITO A INNER JOIN ";
                    sql += "KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CLASSE C ";
                    sql += "ON B.CLASSE = C.CLASSE_ID INNER JOIN CARTAO_CREDITO D ON B.CARTAO = D.CARTAO_CREDITO_ID ";
                    sql += "INNER JOIN CONTA E ON D.CONTA = E.CONTA_ID ";
                    sql += "WHERE A.VALOR > 0 AND A.DATA_PARCELA BETWEEN CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE) ";
                    if (descricao != "")
                    {
                        sql += "AND UPPER(B.DESCRICAO) LIKE '" + descricao + "' ";
                    }
                    //FILTRO CLASSE
                    if (cbClasse.Text != "")
                    {
                        classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();
                        sql += "AND C.CLASSE_ID = " + classe + " ";
                    }
                    //FILTRO CONTA
                    if(cbConta.Text != "")
                    {
                        sql += "AND E.CONTA_ID = " + conta + " ";
                    }
                }

                sql += ") ORDER BY DATA DESC ";
            }

            try
            {
                status.Items["msg"].Text = "";
                status.Items["msg"].Image = null;

                lista.DataSource = BD.Buscar(sql);
            }
            catch (Exception ex)
            {
                status.Items["msg"].Text = ex.Message.ToString();
            }

            //PREENCHE A BARRA DE STATUS A QUANTIDADE DE LINHAS DA LISTA
            status.Items["totalLn"].Text = "LINHAS: " + lista.RowCount;
            
        }

        public void CarregarCbClassesContas(string campo = "")
        {
            //Preenche o combobox com as classes cadastradas no banco de dados
            if(campo=="classe" || campo == "")
            {
                cbClasse.Items.Clear();
                if (ckReceita.Checked == true && ckDespesa.Checked == false || ckReceita.Checked == false && ckDespesa.Checked == true)
                {
                    cbClasse.Items.Clear();
                    cbClasse.Items.Add("");
                    Classes.Classe.Tipo = Convert.ToByte(ckReceita.Checked);
                    foreach (Classes.Classe c in Classes.Classe.Lista())
                    {
                        cbClasse.Items.Add(c);
                    }
                }
            }

            //Preenche o combobox com as contas cadastradas no banco de dados
            if(campo=="conta" || campo == "")
            {
                cbConta.Items.Clear();
                cbConta.Items.Add("");
                foreach (Classes.Conta c in Classes.Conta.Lista())
                {
                    cbConta.Items.Add(c);
                }

            }
        }

        /// <summary>
        /// Funcão para somar a coluna de valor do relatório. Os valores referente
        /// às transferências não são contabilizadas na soma total.
        /// </summary>
        private void SomarColunaValor()
        {
            string tipo;
            double valor = 0;

            status.Items["total"].ForeColor = Color.White;

            if (lista.RowCount == 0)
            {
                status.Items["total"].Text = "Total: R$ 0,00";
                return;
            }

            for (int i = 0; i < lista.RowCount; i++)
            {
                tipo = lista.Rows[i].Cells[1].Value.ToString();
                if(tipo == "D" || tipo == "C")
                {
                    valor += double.Parse(lista.Rows[i].Cells[5].Value.ToString());
                }
            }

            status.Items["total"].Text = "Total: " + valor.ToString("C");

            if(valor < 0)
            {
                status.Items["total"].ForeColor = Color.Tomato;
            }
        }

        private void Formatacao_Condicional()
        {
            double valor;

            if (lista.RowCount == 0)
                return;

            for (int i = 0; i < lista.RowCount; i++)
            {
                valor = double.Parse(lista.Rows[i].Cells[5].Value.ToString());
                if (valor < 0)
                {
                    lista.Rows[i].Cells[5].Style.ForeColor = Color.Tomato;
                }
                else
                {
                    lista.Rows[i].Cells[5].Style.ForeColor = Color.LimeGreen;
                }

                if (lista.Rows[i].Cells[1].Value.ToString()=="T")
                {
                    for (int c = 0; c < lista.ColumnCount; c++)
                    {
                        lista.Rows[i].Cells[c].Style.ForeColor = Color.Fuchsia;
                    }
                }
                else if (lista.Rows[i].Cells[1].Value.ToString() == "C" && lista.Rows[i].Cells[7].Value.ToString() == "0")
                {
                    for (int c = 0; c < lista.ColumnCount; c++)
                    {
                        lista.Rows[i].Cells[c].Style.ForeColor = Color.DodgerBlue;
                    }
                }
            }

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void frmRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            ExcluirLancamento();
        }
        
        private void ExcluirLancamento()
        {
            string id, tipo, classe;

            try
            {
                id = lista.SelectedRows[0].Cells[0].Value.ToString();
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();
                classe = lista.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            {
                COD.Erro("Selecione uma linha na lista!");
                return;
            }

            if (tipo == "T")
            {
                Classes.Geral.ExcluirTransferencia(id + "." + classe);
            }
            else if (tipo == "D")
            {
                Classes.Geral.ExcluirLancamento(id + "." + classe);
            }
            else if (tipo == "C")
            {
                Classes.Geral.ExcluirCompraCredito(id + "." + classe);
            }

            CarregarLista();

        }

        private void lista_SelectionChanged(object sender, EventArgs e)
        {
            string tipo;
            double soma = 0;

            try
            {
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }

            if (lista.SelectedRows.Count > 1)
            {
                menuStrip1.Items[1].Enabled = false;
                menuStrip1.Items[2].Enabled = false;
            }
            else
            {
                menuStrip1.Items[1].Enabled = true;
                menuStrip1.Items[2].Enabled = true;

                if (tipo != "D")
                    menuStrip1.Items[2].Enabled = false;
                else
                    menuStrip1.Items[2].Enabled = true;
            }

            status.Items["somaLn"].Text = "";

            if (lista.SelectedRows.Count > 1)
            {
                for (int i = 0; i < lista.RowCount; i++)
                {
                    if (lista.Rows[i].Selected)
                    {
                        soma += double.Parse(lista.Rows[i].Cells[5].Value.ToString());
                    }
                }

                status.Items["somaLn"].Text = "Seleção: " + soma.ToString("C");

                status.Items["somaLn"].ForeColor = Color.FromArgb(37,37,38);

                if (soma < 0)
                {
                    status.Items["somaLn"].ForeColor = Color.Tomato;
                }
                else if(soma > 0)
                {
                    status.Items["somaLn"].ForeColor = Color.LimeGreen;
                }
            }

        }

        private void cbClasse_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void cbConta_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void limparFiltro_Click(object sender, EventArgs e)
        {
            LimparFiltro();
        }

        private void LimparFiltro(bool receita = false, bool despesa = false)
        {
            COD.LimparCampos(pnFiltro);
            DatasPadrao();
            ckReceita.Checked = receita;
            ckDespesa.Checked = despesa;
            CarregarLista();
        }

        private void ckReceita_Click(object sender, EventArgs e)
        {
            CarregarLista();
            CarregarCbClassesContas("classe");
        }

        private void ckDespesa_Click(object sender, EventArgs e)
        {
            CarregarLista();
            CarregarCbClassesContas("classe");
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            string id, tipo;

            if (lista.RowCount == 0)
                return;

            try
            {
                id = lista.SelectedRows[0].Cells[0].Value.ToString();
                id = id.Split(".").GetValue(0).ToString();
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();

                Classes.Geral.AbrirDetalheTransacao(id, tipo);

            }
            catch 
            {

            }
        }

        private void lista_Sorted(object sender, EventArgs e)
        {
            Formatacao_Condicional();
        }

        private void txtDataInicio_ValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void txtDataFim_ValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void ckReceita_CheckedChanged(object sender, EventArgs e)
        {
            if (ckReceita.Checked == true && ckDespesa.Checked == true || ckReceita.Checked == false && ckDespesa.Checked == false)
            {
                txtValor1.Enabled = false;
                txtValor2.Enabled = false;
            }
            else
            {
                txtValor1.Enabled = true;
                txtValor2.Enabled = true;
            }
        }

        private void ckDespesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckReceita.Checked == true && ckDespesa.Checked == true || ckReceita.Checked == false && ckDespesa.Checked == false)
            {
                txtValor1.Enabled = false;
                txtValor2.Enabled = false;
            }
            else
            {
                txtValor1.Enabled = true;
                txtValor2.Enabled = true;
            }
        }

        private void lg2_Click(object sender, EventArgs e)
        {
            LimparFiltro(despesa:true);
        }

        private void lg1_Click(object sender, EventArgs e)
        {
            LimparFiltro(receita:true);
        }

        private void lista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Formatacao_Condicional();
            SomarColunaValor();
        }

        private void exportar_Click(object sender, EventArgs e)
        {

        }

        private void excel_Click(object sender, EventArgs e)
        {
            try
            {
                gerar_excel();
            }
            catch
            {
                COD.Erro("Não foi possível gerar o relatório!");
            }
        }

        private void gerar_excel()
        {
            decimal porc; int cont = 0; string data, mesNome;

            Excel.Application XcelApp = new Excel.Application();
            Excel.Range celulas;

            if (lista.Rows.Count > 0)
            {
                int ln = lista.Rows.Count;

                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < lista.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = lista.Columns[i - 1].HeaderText;
                        cont++;
                    }

                    XcelApp.Cells[1, cont] = "MÊS";
                    XcelApp.Cells[1, cont + 1] = "ANO";

                    lblPorc.Visible = true;
                    progresso.Visible = true;
                    progresso.Value = 1;
                    progresso.Maximum = lista.Rows.Count;

                    for (int i = 0; i < lista.Rows.Count; i++)
                    {
                        int p = i + 1;

                        try
                        {
                            porc = Decimal.Divide(p, ln);
                            lblPorc.Text = porc.ToString("P0");

                            progresso.Value++;
                        }
                        catch
                        {
                            lblPorc.Visible = false;
                            progresso.Visible = false;
                        }

                        for (int j = 0; j < lista.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = lista.Rows[i].Cells[j].Value;
                        }

                        //TIPO DE LANÇAMENTO
                        if(Double.Parse(lista.Rows[i].Cells[5].Value.ToString()) < 0)
                        {
                            XcelApp.Cells[i + 2, 2] = "DESPESA";
                        }
                        else if(lista.Rows[i].Cells[1].Value.ToString() == "T")
                        {
                            XcelApp.Cells[i + 2, 2] = "TRANSF";
                        }
                        else
                        {
                            XcelApp.Cells[i + 2, 2] = "RECEITA";
                        }

                        //MÊS E ANO
                        data = lista.Rows[i].Cells[2].Value.ToString();
                        mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Parse(data).Month).ToUpper();

                        XcelApp.Cells[i + 2, 8] = mesNome;
                        XcelApp.Cells[i + 2, 9] = DateTime.Parse(data).Year.ToString();

                    }
                    //
                    celulas = XcelApp.Range["A1", "A1"].CurrentRegion;
                    celulas.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    celulas.Range["A1", "A" + celulas.Rows.Count].NumberFormat = "0";
                    celulas.Range["C1", "C" + celulas.Rows.Count].NumberFormat = "dd/MM/YYYY";
                    celulas.Range["F1", "F" + celulas.Rows.Count].NumberFormat = "#,##0.00";
                    XcelApp.Columns.AutoFit();
                    XcelApp.Range["A1", "I1"].Interior.Color = 5855577;
                    XcelApp.Range["A1", "I1"].Font.Color = 16777215;
                    XcelApp.Range["A2", "A2"].Activate();
                    XcelApp.ActiveWindow.FreezePanes = true;
                    //
                    XcelApp.Visible = true;

                    COD.ShowNotification("Sucesso:", "Relatório gerado com sucesso!", ToolTipIcon.Info, x: true);
                }
                catch (Exception ex)
                {
                    COD.Erro("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void alterarBD_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void Alterar()
        {
            string tipo, id, data, desc;
            double valor;

            try
            {
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();
                id = lista.SelectedRows[0].Cells[0].Value.ToString();
                valor = double.Parse(lista.SelectedRows[0].Cells[5].Value.ToString());
                data = lista.SelectedRows[0].Cells[2].Value.ToString();
                desc = lista.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch
            {
                return;
            }

            if (tipo != "D")
                return;

            boxAlterarCompra AltComp = new boxAlterarCompra();

            if (valor < 0)
                AltComp.Tag = id + ".D";
            else
                AltComp.Tag = id + ".R";

            AltComp.txtValor.Tag = valor.ToString();
            AltComp.txtValor.Text = Math.Abs(valor).ToString("N");
            AltComp.txtData.Text = DateTime.Parse(data).ToShortDateString();
            AltComp.txtDesc.Text = desc;
            AltComp.ShowDialog();

            if(AltComp.Tag.ToString() == "1")
                CarregarLista();
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string tipo = "";

            contextMenuStrip1.Items["alterarBD"].Visible = true;

            try
            {
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch 
            {
                e.Cancel = true;
            }

            if (lista.RowCount == 0)
            {
                e.Cancel = true;
            }
            else if (tipo != "D")
            {
                //e.Cancel = true;
                contextMenuStrip1.Items["alterarBD"].Visible = false;
            }
        }

        private void excluirBD_Click(object sender, EventArgs e)
        {
            ExcluirLancamento();
        }
    }
}

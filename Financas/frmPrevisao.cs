using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class frmPrevisao : Form
    {
        public frmPrevisao()
        {
            InitializeComponent();
        }

        private void frmPrevisao_Load(object sender, EventArgs e)
        {
            CarregarCbMesAno();
        }

        public void CarregarPrevisao()
        {
            string sql;
            int cor = Previsao.Prev.cor;

            int mes = ((ToolStripComboBox)menuStrip1.Items["mes"]).SelectedIndex + 1;
            if (mes == 0)
                mes = DateTime.Today.Month;
            int ano = int.Parse(menuStrip1.Items["ano"].Text);
            string periodo = "01." + mes + "." + ano;
            periodo = DateTime.Parse(periodo).AddMonths(-1).ToShortDateString().Replace("/", ".");

            //panel.Controls.Clear();

            //Montagem do SQL
            //
            sql = "SELECT CLASSE, TIPO, DIA, CAST(ORCADO AS DECIMAL(10, 2)) AS ORCADO, CAST(REALIZADO AS DECIMAL(10, 2)) AS REALIZADO, ";
            sql += "CAST(DESVIO AS DECIMAL(10, 2)) AS DESVIO, STATUS, ORD, OBS, CHAVE FROM (";
            //
            //Compras no Crédito
            //
            sql += "SELECT D.CONTA AS CLASSE, ' Cartão de Crédito' AS TIPO, ";
            sql += "EXTRACT(DAY FROM A.DATA_PARCELA) AS DIA, 0 AS ORCADO, ";
            sql += "SUM(A.VALOR * -1) AS REALIZADO, SUM(A.VALOR) AS DESVIO, ";
            sql += "'0' AS STATUS, 'A' AS ORD, '' AS OBS, C.COR AS CHAVE FROM COMPRA_CREDITO A ";
            sql += "INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE ";
            sql += "INNER JOIN CARTAO_CREDITO C ON B.CARTAO = C.CARTAO_CREDITO_ID ";
            sql += "INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID WHERE A.STATUS = 0 AND ";
            sql += "EXTRACT(MONTH FROM A.DATA_PARCELA) = " + mes + " AND ";
            sql += "EXTRACT(YEAR FROM A.DATA_PARCELA) = " + ano + " ";
            sql += "GROUP BY D.CONTA, DIA, CHAVE ";
            //
            //PEGA O VALOR DO GASTO PREVISTO QUE AINDA NÃO TIVERAM DÉBITO E CARTÃO DE CRÉDITO REALIZADO NA CLASSE ESPECÍFICA
            //
            sql += "UNION SELECT B.CLASSE, ' Despesa' AS TIPO, ";
            sql += "A.DIA, A.VALOR AS ORCADO, 0 AS REALIZADO, A.VALOR AS DESVIO, A.STATUS, 'B' AS ORD, A.OBS, A.CHAVE ";
            sql += "FROM PREVISAO A INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID ";
            sql += "WHERE A.CLASSE NOT IN(SELECT DISTINCT CLASSE FROM BD WHERE ";
            sql += "EXTRACT(MONTH FROM DATA) = " + mes + " AND EXTRACT(YEAR FROM DATA) = " + ano + " AND VALOR < 0) ";
            sql += "AND A.CLASSE NOT IN(SELECT DISTINCT B.CLASSE FROM COMPRA_CREDITO A ";
            sql += "INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE WHERE EXTRACT(MONTH FROM B.DATA_COMPRA) = " + mes + " ";
            sql += "AND EXTRACT(YEAR FROM B.DATA_COMPRA) = " + ano + ") ";
            sql += "AND B.TIPO = 0 AND A.VALOR > 0 AND A.MES = "+ mes +" AND A.ANO = " + ano + " ";
            //
            //PEGA O VALOR DA RECEITA PREVISTA QUE AINDA NÃO TEVE O CRÉDITO REALIZADO NA CLASSE ESPECÍFICA
            //
            sql += "UNION SELECT B.CLASSE, ' Receita Prevista' AS TIPO, ";
            sql += "A.DIA, A.VALOR AS ORCADO, 0 AS REALIZADO, (A.VALOR * -1) AS DESVIO, A.STATUS, 'B' AS ORD, A.OBS, A.CHAVE ";
            sql += "FROM PREVISAO A INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID ";
            sql += "WHERE A.CLASSE NOT IN(SELECT DISTINCT CLASSE FROM BD WHERE ";
            sql += "EXTRACT(MONTH FROM DATA) = " + mes + " AND EXTRACT(YEAR FROM DATA) = " + ano + " AND VALOR > 0) ";
            sql += "AND B.TIPO = 1 AND A.VALOR > 0 AND A.MES = " + mes + " AND A.ANO = " + ano + " ";
            //
            //PEGA OS DADOS DAS RECEITAS PREVISTAS CREDITADAS - FILTRO MÊS E ANO COM ORÇADO PARA CADA CLASSE
            //
            sql += "UNION SELECT C.CLASSE, ' Receita Creditada' AS TIPO, B.DIA, B.VALOR AS ORCADO, SUM(A.VALOR) AS REALIZADO, IIF((SUM(A.VALOR) - B.VALOR) > 0, 0, SUM(A.VALOR) - B.VALOR) AS DESVIO, IIF(SUM(A.VALOR) >= B.VALOR, 1, 0) AS STATUS, 'B' AS ORD, B.OBS, B.CHAVE ";
            sql += "FROM BD A INNER JOIN PREVISAO B ON A.CLASSE = B.CLASSE AND EXTRACT(MONTH FROM A.DATA) || EXTRACT(YEAR FROM A.DATA) = B.MES || B.ANO ";

            sql += "INNER JOIN CLASSE C ON A.CLASSE = C.CLASSE_ID WHERE EXTRACT(MONTH FROM A.DATA) = " + mes + " AND EXTRACT(YEAR FROM A.DATA) = " + ano + " AND A.VALOR > 0 ";
            sql += "GROUP BY C.CLASSE, B.DIA, ORCADO, B.STATUS, B.OBS, B.CHAVE ";
            //
            //
            //
            sql += "UNION SELECT CLS AS CLASSE, TIPO, DIA, ORCADO, SUM(REALIZADO) AS REALIZADO, ";
            sql += "IIF(ORCADO + SUM(REALIZADO) < 0, 0, ORCADO + SUM(REALIZADO)) AS DESVIO, ";
            sql += "IIF(ABS(SUM(REALIZADO)) >= IIF(ORCADO IS NULL, 0, ORCADO), 1, 0) AS STATUS, ORD, OB AS OBS, CV AS CHAVE FROM(";

            sql += "SELECT C.CLASSE AS CLS, ' Despesa' AS TIPO, IIF(B.DIA IS NULL, EXTRACT(DAY FROM CURRENT_DATE), B.DIA) AS DIA, ";
            sql += "IIF(B.VALOR IS NULL, 0, B.VALOR) AS ORCADO, SUM(A.VALOR) AS REALIZADO, ";
            sql += "IIF(B.VALOR IS NULL, 0, B.VALOR) - ABS(SUM(A.VALOR)) AS DESVIO, 0 AS ST, 'B' AS ORD, B.OBS AS OB, ";
            sql += "IIF(B.CHAVE IS NULL, EXTRACT(DAY FROM CURRENT_DATE) || '.' || EXTRACT(MONTH FROM CURRENT_DATE) || '.' || EXTRACT(YEAR FROM CURRENT_DATE) || '.' || C.CLASSE_ID, B.CHAVE) AS CV ";
            sql += "FROM BD A LEFT OUTER JOIN PREVISAO B ON A.CLASSE = B.CLASSE AND EXTRACT(MONTH FROM A.DATA) || EXTRACT(YEAR FROM A.DATA) = B.MES || B.ANO ";
            sql += "INNER JOIN CLASSE C ON A.CLASSE = C.CLASSE_ID ";
            sql += "WHERE EXTRACT(MONTH FROM A.DATA) = " + mes + " AND EXTRACT(YEAR FROM A.DATA) = " + ano + " AND A.VALOR < 0 ";
            sql += "GROUP BY C.CLASSE, TIPO, ORCADO, DIA, B.STATUS, B.OBS, CV ";

            sql += "UNION SELECT C.CLASSE AS CLS, ' Despesa' AS TIPO, IIF(D.DIA IS NULL, EXTRACT(DAY FROM CURRENT_DATE), D.DIA) AS DIA, ";
            sql += "IIF(D.VALOR IS NULL, 0, D.VALOR) AS ORCADO, SUM(A.VALOR * -1) AS REALIZADO, ";
            sql += "IIF(D.VALOR IS NULL, 0, D.VALOR) - SUM(A.VALOR) AS DESVIO, 0 AS ST, 'B' AS ORD, D.OBS AS OB, ";
            sql += "IIF(D.CHAVE IS NULL, EXTRACT(DAY FROM CURRENT_DATE) || '.' || EXTRACT(MONTH FROM CURRENT_DATE) || '.' || EXTRACT(YEAR FROM CURRENT_DATE) || '.' || C.CLASSE_ID, D.CHAVE) AS CV ";
            sql += "FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID ";
            sql += "LEFT JOIN PREVISAO D ON B.CLASSE = D.CLASSE AND EXTRACT(MONTH FROM B.DATA_COMPRA) || EXTRACT(YEAR FROM B.DATA_COMPRA) = D.MES || D.ANO ";
            sql += "WHERE C.GRUPO <> 1 AND EXTRACT(MONTH FROM B.DATA_COMPRA) = " + mes + " AND EXTRACT(YEAR FROM B.DATA_COMPRA) = " + ano + " ";
            sql += "GROUP BY C.CLASSE, TIPO, ORCADO, DIA, D.STATUS, D.OBS, CV) GROUP BY CLS, TIPO, DIA, ORCADO, ST, ORD, OB, CV ";

            if (ckDesvioAcumulado.Checked)
            {
                sql += "UNION SELECT '[Desvio Saldo Acumulado]' AS CLS, ' -' AS TIPO, '0' AS DIA, '0' AS ORCADO, '0' AS REALIZADO, IIF((SUM(SALDO) * -1) IS NULL, 0, (SUM(SALDO) * -1)) AS DESVIO, '1' AS ST, 'F' AS ORD, '' AS OB, '' AS CV FROM SALDO_PREV WHERE EXTRACT(MONTH FROM PERIODO) = " + DateTime.Parse(periodo).Month + " AND EXTRACT(YEAR FROM PERIODO) = " + DateTime.Parse(periodo).Year + " GROUP BY CLS";
            }

            sql += ") ORDER BY ORD, DIA";
            //
            //
            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch
            {

            }
        }

        private void novo_Click(object sender, EventArgs e)
        {
            string mes, ano;

            boxAddPrev prev = new boxAddPrev();

            mes = menuStrip1.Items["mes"].Text;
            ano = menuStrip1.Items["ano"].Text;
            
            prev.cbMes.Text = mes;
            prev.cbAno.Text = ano;

            prev.CarregarCBs(mes:mes, ano:ano);

            prev.ShowDialog();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarPrevisao();
        }

        private void CarregarCbMesAno()
        {
            ToolStripComboBox ano = new ToolStripComboBox();
            ToolStripComboBox mes = new ToolStripComboBox();

            string mesNome;

            foreach (ToolStripItem item in menuStrip1.Items)
            {
                if (item.Name == "ano")
                {
                    ano = ((ToolStripComboBox)item);

                    for (int i = 0; i < 3; i++)
                    {
                        ano.Items.AddRange(new object[] {(DateTime.Today.Year -1 + i )});
                    }

                    ano.Text = DateTime.Today.Year.ToString();
                }
                else if(item.Name == "mes")
                {
                    mes = ((ToolStripComboBox)item);

                    for (int i = 1; i < 13; i++)
                    {
                        mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(i).ToUpper();
                        mes.Items.AddRange(new object[] { (mesNome) });
                    }

                    mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month).ToUpper();
                    mes.Text = mesNome;
                }
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            int mes, ano;
            string mesNome, sql;

            mes = ((ToolStripComboBox)menuStrip1.Items["mes"]).SelectedIndex + 1;
            mesNome = menuStrip1.Items["mes"].Text;
            ano = int.Parse(menuStrip1.Items["ano"].Text);

            COD.Pergunta("Deseja realmente excluir toda a previsão deste período?\r\n\r\n"+ mesNome +"/"+ ano +"");
            if (!COD.Resposta)
                return;

            sql = "DELETE FROM PREVISAO WHERE MES = " + mes + " AND ANO = " + ano + "";
            BD.ExecutarSQL(sql);

            CarregarPrevisao();
        }

        private void mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPrevisao();
            panel.Focus();
        }

        private void ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPrevisao();
            panel.Focus();
        }

        private void next_Click(object sender, EventArgs e)
        {
            MudarPeriodo(1);
            panel.Focus();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MudarPeriodo();
            panel.Focus();
        }

        private void MudarPeriodo(int x = 0)
        {
            string data, mes, ano;

            if (x == 0)
                x = -1;

            mes = (((ToolStripComboBox)menuStrip1.Items["mes"]).SelectedIndex + 1).ToString();
            ano = menuStrip1.Items["ano"].Text;

            data = String.Concat("01/", mes, "/", ano);

            data = DateTime.Parse(data).AddMonths(x).ToShortDateString();

            mes = ((DateTime.Parse(data).Month) - 1).ToString();
            ano = DateTime.Parse(data).Year.ToString();

            menuStrip1.Items["ano"].Text = ano;
            ((ToolStripComboBox)menuStrip1.Items["mes"]).SelectedIndex = int.Parse(mes);
        }

        private void panel_CausesValidationChanged(object sender, EventArgs e)
        {
            CarregarPrevisao();
        }

        private void lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lista.RowCount == 0 || e.ColumnIndex > 1)
                return;

            string chave = lista.SelectedRows[0].Cells[11].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                try
                {
                    EditarLinha(chave);
                }
                catch
                {

                }
            } //Editar linha
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    ExcluirLinha(chave);
                }
                catch
                {

                }

            } //Excluir linha
        }

        private void EditarLinha(string chave)
        {
            if (chave == null || chave == "")
                return;

            string[] cv = chave.Split(".");

            string dia = cv[0];
            string mes = cv[1];
            string ano = cv[2];
            string classe = cv[3];
            string tipo, valor, obs;

            string sql = "SELECT CLASSE, TIPO, VALOR, OBS FROM (SELECT B.CLASSE, B.TIPO, REPLACE(IIF(A.VALOR IS NULL, 0, A.VALOR), '.', ',') AS VALOR, A.OBS ";
            sql += "FROM PREVISAO A INNER JOIN CLASSE B ";
            sql += "ON A.CLASSE = B.CLASSE_ID WHERE B.CLASSE_ID = " + classe + " AND MES = " + mes + " AND ANO = " + ano + " ";
            sql += "UNION SELECT CLASSE, TIPO, '0,00', '' FROM CLASSE WHERE CLASSE_ID = " + classe + ") ORDER BY VALOR DESC";

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

            prev.CarregarCBs(classe: classe, dia: dia, mes: mes, ano: ano);
            prev.txtValor.Text = valor;
            prev.txtObs.Text = obs;

            prev.ShowDialog();
        }

        private void ExcluirLinha(string chave)
        {
            if (chave == null || chave == "")
                return;

            try
            {
                string classe = chave.Split(".").GetValue(3).ToString();
            }
            catch 
            {
                return;
            }

            COD.Pergunta("Excluir previsão. Confirma?");
            if (!COD.Resposta)
                return;

            string sql = "DELETE FROM PREVISAO WHERE CHAVE = '" + chave + "'";
            BD.ExecutarSQL(sql);

            CarregarPrevisao();
        }

        private void lista_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                lista.Cursor = Cursors.Hand;
            else if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 10)
                lista.Cursor = Cursors.IBeam;
            else
                lista.Cursor = Cursors.Default;
        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            if (lista.RowCount == 0)
                return;
            try
            {
                string chave = lista.SelectedRows[0].Cells[11].Value.ToString();
                EditarLinha(chave);
            }
            catch
            {

            }
        }

        private void ColorirLinhas()
        {
            for (int i = 0; i < lista.RowCount; i++)
            {
                string ord, tipo;

                ord = lista.Rows[i].Cells[9].Value.ToString();
                tipo = lista.Rows[i].Cells[3].Value.ToString();

                if (tipo.Contains("Despesa"))
                {
                    lista.Rows[i].Cells[2].Style.ForeColor = Color.Tomato;
                    lista.Rows[i].Cells[3].Style.ForeColor = Color.Tomato;
                }
                else if (tipo.Contains("Receita"))
                {
                    lista.Rows[i].Cells[2].Style.ForeColor = Color.LimeGreen;
                    lista.Rows[i].Cells[3].Style.ForeColor = Color.LimeGreen;
                }

                if (ord == "A" || ord == "F")
                {
                    lista.Rows[i].ReadOnly = true;
                }
            }

        }

        private void lista_DataSourceChanged(object sender, EventArgs e)
        {
            string tipo, msg;
            double receita = 0, despesa = 0, restante = 0, desvio = 0, saldo = 0, valor = 0, soma_credito = 0;
            int[] mes = new int[2]; string mesSel, anoSel; int ultDia;

            status.Items["receita"].Text = "";
            status.Items["despesa"].Text = "";
            status.Items["restante"].Text = "";
            status.Items["saldo"].Text = "";
            status.Items["soma_credito"].Text = "";
            status.Items["msg"].Text = "";

            if (lista.RowCount == 0)
                return;

            for (int i = 0; i < lista.RowCount; i++)
            {
                tipo = lista.Rows[i].Cells[3].Value.ToString();

                if (tipo.Contains("Crédito"))
                {
                    soma_credito += Double.Parse(lista.Rows[i].Cells[6].Value.ToString());
                }

                if (tipo.Contains("Receita"))
                {
                    valor = Double.Parse(lista.Rows[i].Cells[5].Value.ToString());
                    receita += Math.Abs(valor);
                }
                else if (tipo.Contains("Despesa") || tipo.Contains("-"))
                {
                    despesa += Double.Parse(lista.Rows[i].Cells[6].Value.ToString());
                }

                valor = Double.Parse(lista.Rows[i].Cells[7].Value.ToString());
                if (valor > 0)
                {
                    restante += Double.Parse(lista.Rows[i].Cells[7].Value.ToString());
                }

                desvio += Double.Parse(lista.Rows[i].Cells[7].Value.ToString());
            }

            receita = Math.Abs(receita);
            status.Items["receita"].Text = receita.ToString("C");

            despesa = Math.Abs(despesa);
            status.Items["despesa"].Text = despesa.ToString("C");

            status.Items["restante"].Text = restante.ToString("C");

            saldo = Classes.Conta.SaldoTotal();
            status.Items["saldo"].Text = saldo.ToString("C");

            soma_credito = Math.Abs(soma_credito);
            status.Items["soma_credito"].Text = soma_credito.ToString("C");

            desvio = desvio * -1;

            mes[0] = DateTime.Today.Month;
            mes[1] = ((ToolStripComboBox)menuStrip1.Items["mes"]).SelectedIndex + 1;
            
            mesSel = mes[1].ToString();
            anoSel = menuStrip1.Items["ano"].Text;

            ultDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)-1;

            if (mes[0].ToString() == mes[1].ToString())
            {
                desvio = desvio + saldo;
            }

            if (desvio >= 0)
            {
                msg = "Desvio: " + desvio.ToString("C");
                status.Items["msg"].Text = msg;
                status.Items["msg"].ForeColor = Color.LimeGreen;
            }
            else
            {
                msg = "Desvio: " + desvio.ToString("C");
                status.Items["msg"].Text = msg;
                status.Items["msg"].ForeColor = Color.Tomato;
            }

            try
            {
                if(mesSel != "0" && desvio != 0)
                {
                    SalvarSaldoPrevPeriodo(mesSel + '.' + anoSel, BD.CvNum(desvio.ToString()));
                }
            }
            catch
            {

            }

            ColorirLinhas();
        }

        private void lista_Sorted(object sender, EventArgs e)
        {
            ColorirLinhas();
        }

        private void lista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string sql, mes, ano; int dia; bool sc;
            string chave, valor, obs;

            try
            {
                chave = lista.Rows[e.RowIndex].Cells[11].Value.ToString();
                sc = int.TryParse(lista.Rows[e.RowIndex].Cells[4].Value.ToString(), out dia);
                valor = lista.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                obs = lista.Rows[e.RowIndex].Cells[10].Value.ToString().Trim();
            }
            catch 
            {
                return;
            }

            try
            {
                valor = BD.CvNum(valor);
                mes = (((ToolStripComboBox)menuStrip1.Items["mes"]).SelectedIndex + 1).ToString();
                ano = menuStrip1.Items["ano"].Text;
                chave = chave.Split(".").GetValue(0).ToString() + "." + mes + "." + ano + "." + chave.Split(".").GetValue(3).ToString();
            }
            catch
            {
                return;
            }

            sql = "SELECT CHAVE FROM PREVISAO WHERE CHAVE = '" + chave + "'";
            if (BD.Buscar(sql).Rows.Count == 0)
            {
                SalvarPrevisao(chave:chave, valor:valor, obs:obs);
            }
            else
            {
                sql = "UPDATE PREVISAO SET OBS = '" + obs + "'";
                if (dia > 0 && dia < 31)
                {
                    sql += ", DIA = " + dia + " ";
                }

                if (valor != "")
                {
                    sql += ", VALOR = " + valor + " ";
                }    

                sql += "WHERE CHAVE = '" + chave + "'";
                BD.ExecutarSQL(sql);
            }

            try
            {
                CarregarPrevisao();
            }
            catch 
            {
                
            }
            
        }

        private void SalvarPrevisao(string chave, string valor = "", string obs = "")
        {
            string[] cv = chave.Split(".");

            string dia = cv[0];
            string mes = cv[1];
            string ano = cv[2];
            string classe = cv[3];

            string[] c = new string[8];
            string[] v = new string[8];

            c[0] = "chave";
            v[0] = chave;

            c[1] = "dia";
            v[1] = dia;

            c[2] = "mes";
            v[2] = mes;

            c[3] = "ano";
            v[3] = ano;

            c[4] = "classe";
            v[4] = classe;

            c[5] = "valor";
            v[5] = valor;

            c[6] = "status";
            v[6] = "0";

            c[7] = "obs";
            v[7] = obs;

            try
            {
                BD.Salvar("PREVISAO", c, v);
            }
            catch
            {
                
            }
        }

        private void lista_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void lista_KeyDown(object sender, KeyEventArgs e)
        {
            string chave;

            if (lista.Rows.Count == 0)
                return;

            try
            {
                chave = lista.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch
            {
                return;
            }

            if(e.KeyCode == Keys.Delete)
            {
                ExcluirLinha(chave:chave);
            }

            if (e.KeyCode == Keys.F2)
            {
                EditarLinha(chave: chave);
            }
        }

        private void detalhes_Click(object sender, EventArgs e)
        {
            string[] cv;
            string chave, sql;
            string classe, mes, ano;

            try
            {
                chave = lista.SelectedRows[0].Cells[11].Value.ToString();
                cv = chave.Split(".");
                classe = cv[3];

                mes = (((ToolStripComboBox)menuStrip1.Items["mes"]).SelectedIndex + 1).ToString();
                ano = menuStrip1.Items["ano"].Text;
            }
            catch
            {
                return;
            }

            //sql = "SELECT B.CLASSE, A.DATA, A.VALOR, A.DESCRICAO FROM BD A INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE B.CLASSE_ID = " + classe + " AND EXTRACT(MONTH FROM A.DATA) = " + mes + " AND EXTRACT(YEAR FROM A.DATA) = " + ano + "";

            sql = "SELECT CLASSE, DATA, VALOR, DESCRICAO FROM(SELECT B.CLASSE, A.DATA, ABS(A.VALOR) AS VALOR, TRIM(IIF(A.DESCRICAO IS NULL, '', A.DESCRICAO) || ' [DÉBITO]') AS DESCRICAO FROM BD A INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE A.CLASSE = " + classe +" AND EXTRACT(MONTH FROM A.DATA) = " + mes + " AND EXTRACT(YEAR FROM A.DATA) = " + ano + " UNION SELECT C.CLASSE, B.DATA_COMPRA AS DATA, B.VALOR, TRIM(IIF(B.DESCRICAO IS NULL, '', B.DESCRICAO) || ' [CRÉDITO]') AS DESCRICAO FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID WHERE B.CLASSE = " + classe +" AND EXTRACT(MONTH FROM B.DATA_COMPRA) = " + mes + " AND EXTRACT(YEAR FROM B.DATA_COMPRA) = " + ano + ")";

            try
            {
                if (BD.Buscar(sql).Rows.Count == 0)
                    return;
            }
            catch
            {
                return;
            }

            boxFlutuante flut = new boxFlutuante();
            try
            {
                flut.lista.DataSource = BD.Buscar(sql);
                flut.ShowDialog();
                flut.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            }
            catch
            {

            }
        }

        private void replicar__Click(object sender, EventArgs e)
        {
            string chave ="";

            try
            {
                chave = lista.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch
            {
                return;
            }

            Classes.Geral.ReplicarPrevisao(chave);
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            string chave = "";

            try
            {
                chave = lista.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch
            {
                return;
            }

            EditarLinha(chave);
        }

        private void excluir__Click(object sender, EventArgs e)
        {
            string chave = "";

            try
            {
                chave = lista.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch
            {
                return;
            }

            ExcluirLinha(chave);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string tipo = "";

            try
            {
                tipo = lista.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch
            {
                e.Cancel = true;
                return;
            }

            if (tipo == "A")
                e.Cancel = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodo">PASSAR CHAVE NO FORMATO "01." + MES E ANO</param>
        /// <param name="desvio"></param>
        private void SalvarSaldoPrevPeriodo(string periodo, string desvio)
        {
            string sql; int lin;
            string hoje, data, ultDia;

            try
            {
                data = "01/" + periodo.Split(".").GetValue(0).ToString() + "/" + periodo.Split(".").GetValue(1).ToString();
                ultDia = DateTime.DaysInMonth(DateTime.Parse(data).Year, DateTime.Parse(data).Month).ToString();
                data = ultDia + "." + DateTime.Parse(data).Month.ToString() + "." + DateTime.Parse(data).Year.ToString();
                data = DateTime.Parse(data).ToShortDateString();
                data = BD.CvData(data);
                hoje = BD.CvData(DateTime.Today.ToShortDateString());
            }
            catch
            {
                return;
            }

            sql = "SELECT PERIODO FROM SALDO_PREV WHERE PERIODO = '"+ data + "'";
            try
            {
                lin = BD.Buscar(sql).Rows.Count;
            }
            catch
            {
                return;
            }

            if(lin > 0)
            {
                sql = "UPDATE SALDO_PREV SET SALDO = '"+ desvio +"' WHERE PERIODO = '"+ data + "'";
            }
            else
            {
                sql = "INSERT INTO SALDO_PREV(PERIODO, SALDO) VALUES('"+ data +"', '"+ desvio +"')";
            }

            try
            {
                BD.ExecutarSQL(sql);
            }
            catch
            {

            }

            sql = "DELETE FROM SALDO_PREV WHERE PERIODO < '" + hoje + "'";
            BD.ExecutarSQL(sql);

        }

        private void replicar_Click(object sender, EventArgs e)
        {
            string mesAtual, proxMes, sql;

            string[] mes = new string[2];
            string[] ano = new string[2];

            COD.Pergunta("Replicar estas previsões para o próximo mês?");
            if (!COD.Resposta)
                return;

            try
            {
                mes[0] = menuStrip1.Items["mes"].Text.ToString().Substring(0,3);
                mes[0] = Classes.Geral.MesNome(nomMes: mes[0]);
                ano[0] = menuStrip1.Items["ano"].Text;
                mesAtual = "01/" + mes[0] + "/" + ano[0];
                proxMes = DateTime.Parse(mesAtual).AddMonths(1).ToShortDateString();
            }
            catch 
            {
                COD.Erro("Não foi possível replicar a previsão deste mês!");
                return;
            }

            mes[1] = DateTime.Parse(proxMes).Month.ToString();
            ano[1] = DateTime.Parse(proxMes).Year.ToString();

            sql = "INSERT INTO PREVISAO(CHAVE, DIA, MES, ANO, CLASSE, VALOR, STATUS, OBS) ";
            sql += "SELECT DIA || '.' || '"+ mes[1] +"' || '.' || '"+ ano[1] +"' || '.' || CLASSE, ";
            sql += "DIA, "+ mes[1] +", "+ ano[1] +", CLASSE, VALOR, STATUS, OBS ";
            sql += "FROM PREVISAO WHERE MES = "+ mes[0] +" AND ANO = "+ ano[0] +" ";
            sql += "AND CLASSE NOT IN(SELECT CLASSE FROM PREVISAO WHERE MES = " + mes[1] + " AND ANO = " + ano[1] + ")";

            try
            {
                BD.ExecutarSQL(sql);
            }
            catch
            {
                COD.Erro("Não foi possível replicar a previsão deste mês!");
                return;
            }

            COD.OK("Previsão replicada para o próximo mês!");
        }

        private void lista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < lista.RowCount; i++)
            {
                if (lista.Rows[i].Cells["TIPO"].Value.ToString().Contains("Crédito"))
                {
                    lista.Rows[i].Cells["EDITAR"].Style.SelectionBackColor = Color.FromArgb(122, 122, 122);
                    lista.Rows[i].Cells["EDITAR"].Tag = "C";

                    lista.Rows[i].Cells["EXCLUIRR"].Style.SelectionBackColor = Color.FromArgb(122, 122, 122);
                    lista.Rows[i].Cells["EXCLUIRR"].Tag = "C";
                }
            }
        }

        private void ckDesvioAcumulado_Click(object sender, EventArgs e)
        {
            CarregarPrevisao();
        }
    }
}

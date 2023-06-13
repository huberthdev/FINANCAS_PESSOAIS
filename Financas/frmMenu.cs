using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;

namespace Setup.Financas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnCompromissos.Size = new Size(636, 510);
            pnCompromissos.MinimumSize = new Size(636, 510);

            txtData.Text = DateTime.Today.ToShortDateString();
            gPeriodo.Tag = DateTime.Today.Month + "." + DateTime.Today.Year;
            gPeriodo.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month) + "." + DateTime.Today.Year;

            statusStrip.Items["usuario"].Text = "Usuário: " + BD.UsuarioLogado;
        }

        private void frmMenu_Activated(object sender, EventArgs e)
        {
            Carregar_Controles_Definicoes();

            if(!COD.All_True)
                COD.Definir_Config_Alertas();

            if (!COD.AtivarNotifLogin)
            {
                COD.ShowNotification("Login", "Seja bem vindo ao sistema de gestão financeira!", ToolTipIcon.None);
                COD.AtivarNotifLogin = true;
            }

            CarregarCbClassesContas();
            CarregarListaSaldoContas();
            CarregarListaGastoClasseMesAtual();
            CarregarListaGeral();
            CarregarListaCompromissos();

            COD.All_True = true;
        }

        private void CarregarListaGeral()
        {
            string mes, ano, sql;
            string rec = "R$ 0,00", desp = "R$ 0,00", transf = "R$ 0,00", credito = "R$ 0,00";

            if(gPeriodo.Tag != null)
            {
                mes = gPeriodo.Tag.ToString().Split(".").GetValue(0).ToString();
                ano = gPeriodo.Tag.ToString().Split(".").GetValue(1).ToString();
            }
            else
            {
                mes = DateTime.Today.Month.ToString();
                ano = DateTime.Today.Year.ToString();
            }

            sql = "SELECT TIPO, VALOR FROM (SELECT '1' AS TIPO, IIF(SUM(VALOR) IS NULL, 0, SUM(VALOR)) AS VALOR FROM BD WHERE VALOR > 0 AND EXTRACT(MONTH FROM DATA) = " + mes +" AND EXTRACT(YEAR FROM DATA) = "+ ano +" ";
            sql += "UNION SELECT '2' AS TIPO, IIF(ABS(SUM(VALOR)) IS NULL, 0, ABS(SUM(VALOR))) AS VALOR FROM BD WHERE VALOR < 0 AND EXTRACT(MONTH FROM DATA) = " + mes + " AND EXTRACT(YEAR FROM DATA) = " + ano + " ";
            sql += "UNION SELECT '3' AS TIPO, IIF(SUM(VALOR) IS NULL, 0, SUM(VALOR)) AS VALOR FROM TRANSFERENCIA WHERE EXTRACT(MONTH FROM DATA) = " + mes + " AND EXTRACT(YEAR FROM DATA) = " + ano + " ";
            sql += "UNION SELECT '4' AS TIPO, IIF(SUM(VALOR) IS NULL, 0, SUM(VALOR)) AS VALOR FROM COMPRA_CREDITO WHERE EXTRACT(MONTH FROM DATA_PARCELA) = " + mes + " AND EXTRACT(YEAR FROM DATA_PARCELA) = " + ano + ") ORDER BY TIPO";
            BD.Buscar(sql);

            try
            {
                rec = Double.Parse(BD.Resultado.Rows[0][1].ToString()).ToString("C");
                desp = Double.Parse(BD.Resultado.Rows[1][1].ToString()).ToString("C");
                transf = Double.Parse(BD.Resultado.Rows[2][1].ToString()).ToString("C");
                credito = Double.Parse(BD.Resultado.Rows[3][1].ToString()).ToString("C");
            }
            catch
            {
                
            }

            gReceitas.Text = rec;
            gDespesas.Text = desp;
            gTransferencias.Text = transf;
            gCredito.Text = credito;
        }

        private void MudarPeriodo(int x = 0)
        {
            string data, mes, mesNome, ano, periodo;

            if (x == 0)
                x = -1;

            try
            {
                mes = gPeriodo.Tag.ToString().Split(".").GetValue(0).ToString();
                ano = gPeriodo.Tag.ToString().Split(".").GetValue(1).ToString();
            }
            catch
            {
                mes = DateTime.Today.Month.ToString();
                ano = DateTime.Today.Year.ToString();
            }

            data = String.Concat("01/", mes, "/", ano);

            data = DateTime.Parse(data).AddMonths(x).ToShortDateString();

            mes = ((DateTime.Parse(data).Month)).ToString();
            mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(int.Parse(mes));
            ano = DateTime.Parse(data).Year.ToString();

            periodo = mes + "." + ano;

            gPeriodo.Text = mesNome + "." + ano;
            gPeriodo.Tag = periodo;
        }

        //FUNÇÃO PARA ABRIA CALCULADORA NATIVA DO WINDOWS
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void anotaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNota nota = new frmNota();
            nota.ShowDialog();
        }

        private void anotaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNota nota = new frmNota();
            nota.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio rel = new frmRelatorio();
            rel.ShowDialog();
        }

        //TODAS AS FUNÇÕES DA ABA LANÇAMENTO DE RECEITAS E DESPESAS
        private void CarregarListaSaldoContas()
        {
            string sql = "SELECT CONTA_ID, CONTA, SALDO, RESERVADO FROM CONTA ";
            sql += "WHERE SALDO <> 0 ORDER BY RESERVADO, SALDO DESC";

            try
            {
                listaSaldo_Contas.DataSource = BD.Buscar(sql);
            }
            catch
            {

            }
            
        }

        private void listaSaldo_Contas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            double valor, total = 0;
            string reservado;

            for (int i = 0; i < listaSaldo_Contas.RowCount; i++)
            {
                reservado = listaSaldo_Contas.Rows[i].Cells[3].Value.ToString();

                valor = double.Parse(listaSaldo_Contas.Rows[i].Cells[2].Value.ToString());
                if (reservado == "0")
                {
                    total += valor;
                }

                if (valor < 0 && reservado == "0")
                {
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.Tomato;
                }
                else if(valor > 0 && reservado == "0")
                {
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.LimeGreen;
                }
                else
                {
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.DarkOrange;
                }
            }

            listaSaldo_Contas.Columns[2].HeaderText = "SALDO: " + total.ToString("C");
        }

        private void CarregarListaGastoClasseMesAtual()
        {
            string mes, ano, sql;
            double total = 0;

            if (gPeriodo.Tag != null)
            {
                mes = gPeriodo.Tag.ToString().Split(".").GetValue(0).ToString();
                ano = gPeriodo.Tag.ToString().Split(".").GetValue(1).ToString();
            }
            else
            {
                mes = DateTime.Today.Month.ToString();
                ano = DateTime.Today.Year.ToString();
            }

            sql = "SELECT CLASSE, SUM(VALOR) AS VALOR FROM(SELECT B.CLASSE, ABS(SUM(A.VALOR)) AS VALOR FROM BD A ";
            sql += "INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE A.VALOR < 0 AND EXTRACT(MONTH FROM A.DATA) = " + mes + " AND ";
            sql += "EXTRACT(YEAR FROM A.DATA) = " + ano + " GROUP BY B.CLASSE ";
            sql += "UNION SELECT C.CLASSE, SUM(A.VALOR) AS VALOR FROM COMPRA_CREDITO A LEFT OUTER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE ";
            sql += "INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID WHERE EXTRACT(MONTH FROM A.DATA_PARCELA) = " + mes + " ";
            sql += "AND EXTRACT(YEAR FROM A.DATA_PARCELA) = " + ano + " AND A.VALOR > 0 GROUP BY C.CLASSE) GROUP BY CLASSE ";

            /*
            sql += "union select 'ZZZ' as CLASSE_ID, 'TOTAL:' as CLASSE, abs(sum(a.VALOR)) as VALOR from bd ";
            sql += "a inner join classe b on a.CLASSE = b.CLASSE_ID where a.VALOR < '0' and ";
            sql += "extract(month from a.DATA) = " + mesAtual + " and extract(year from a.DATA) = " + anoAtual + " ";
            sql += ") order by classe";
            */

            try
            {
                lista_Gastos_Classe.DataSource = BD.Buscar(sql);
            }
            catch
            {
                return;
            }

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                total += double.Parse(BD.Resultado.Rows[i][1].ToString());
            }

            lista_Gastos_Classe.Columns["CLASSE"].HeaderText = "";
            lista_Gastos_Classe.Columns["VALOR"].HeaderText = total.ToString("C");
        }

        private void CarregarCbClassesContas(string tabela = "")
        {
            string classe, conta;

            //Preenche o combobox com as classes cadastradas no banco de dados
            if(tabela=="classe" || tabela == "")
            {
                classe = cbClasse.Text;
                cbClasse.Items.Clear();
                Classes.Classe.Tipo = Convert.ToByte(opReceita.Checked);
                foreach (Classes.Classe c in Classes.Classe.Lista())
                {
                    cbClasse.Items.Add(c);
                }
                cbClasse.Text = classe;
            }

            //Preenche o combobox com as contas cadastradas no banco de dados
            if (tabela == "conta" || tabela == "")
            {
                conta = cbConta.Text;
                cbConta.Items.Clear();
                foreach (Classes.Conta c in Classes.Conta.Lista())
                {
                    cbConta.Items.Add(c);
                }
                cbConta.Text = conta;
            }
        }

        private void opReceita_CheckedChanged(object sender, EventArgs e)
        {
            CarregarCbClassesContas("classe");
        }

        private void opDespesa_CheckedChanged(object sender, EventArgs e)
        {
            CarregarCbClassesContas("classe");
        }

        private void queryDesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmQuery query = new Formularios.frmQuery();
            query.Show();
        }

        private void ToolRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio rel = new frmRelatorio();
            rel.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COD.Pergunta("Sair do Sistema?");
            if (COD.Resposta == false)
                return;

            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string classe, conta, valor;

            if (!COD.ValidarCampos(pnSalvarIn, errorProvider1))
                return;

            classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();
            conta = ((Classes.Conta)cbConta.SelectedItem).id.ToString();

            valor = txtValor.Text;

            if (opDespesa.Checked == true)
                valor = BD.CvNum((decimal.Parse(valor) * -1).ToString());
            else
                valor = BD.CvNum(valor).ToString();

            string[] c = new string[6];
            string[] v = new string[6];

            c[0] = "classe";
            v[0] = classe;

            c[1] = "conta";
            v[1] = conta;

            c[2] = "data";
            v[2] = BD.CvData(txtData.Text);

            c[3] = "valor";
            v[3] = valor;

            c[4] = "descricao";
            v[4] = txtDescricao.Text;

            c[5] = "status";
            v[5] = "1";

            BD.Salvar("bd", c, v, 0, "Registro salvo com sucesso!");
            Classes.Conta.AtualizarSaldoConta(conta, valor);

            COD.LimparCampos(pnSalvarIn, txtData, cbClasse);
            CarregarListaSaldoContas();
            CarregarListaGastoClasseMesAtual();
            CarregarListaGeral();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            COD.LimparCampos(pnSalvarIn, txtData, cbClasse);
        }

        private void comprasCredito_Click(object sender, EventArgs e)
        {
            frmCredito cred = new frmCredito();
            cred.Show();
        }

        private void cartaoDeCreditoAdd_Click(object sender, EventArgs e)
        {
            boxCartaoCredito boxCartaoADD = new boxCartaoCredito();
            boxCartaoADD.ShowDialog();
        }

        private void usuarioAdd_Click(object sender, EventArgs e)
        {
            Formularios.frmUsuario usuario = new Formularios.frmUsuario();
            usuario.ShowDialog();
        }

        private void connBD_Click(object sender, EventArgs e)
        {
            Formularios.frmConfigBD bd = new Formularios.frmConfigBD();
            bd.ShowDialog();
        }

        private void compraCredito_Click(object sender, EventArgs e)
        {
            frmCredito cred = new frmCredito();
            cred.Show();
        }

        private void transf_Click(object sender, EventArgs e)
        {
            frmTransf transf = new frmTransf();
            transf.ShowDialog();
        }

        private void lista_Gastos_Classe_DoubleClick(object sender, EventArgs e)
        {
            string classe;
            int mes = DateTime.Today.Month, ano = DateTime.Today.Year;
            int ultDia = DateTime.DaysInMonth(ano, mes);

            if (lista_Gastos_Classe.Rows.Count == 0)
                return;

            try
            {
                mes = int.Parse(gPeriodo.Tag.ToString().Split(".").GetValue(0).ToString());
                ano = int.Parse(gPeriodo.Tag.ToString().Split(".").GetValue(1).ToString());
                ultDia = DateTime.DaysInMonth(ano, mes);
            }
            catch
            {

            }

            try
            {
                classe = lista_Gastos_Classe.SelectedRows[0].Cells[1].Value.ToString();

                frmRelatorio rel = new frmRelatorio();
                rel.ckDespesa.Checked = true;
                rel.CarregarCbClassesContas("classe");
                rel.cbClasse.Text = classe;
                rel.txtDataInicio.Value = new DateTime(ano, mes, 01);
                rel.txtDataInicio.Checked = true;
                rel.txtDataFim.Value = new DateTime(ano, mes, ultDia);
                rel.txtDataFim.Checked = true;
                rel.ShowDialog();
            }
            catch
            {
                return;                
            }

        }

        private void ToolVisaoGeral_Click(object sender, EventArgs e)
        {
            frmGestao gest = new frmGestao();
            gest.Show();
        }

        private void ToolPrevisao_Click(object sender, EventArgs e)
        {
            frmPrevisao prev = new frmPrevisao();
            prev.Show();
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.ShowDialog();
        }

        private void cads_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.ShowDialog();
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void mesAnterior_Click(object sender, EventArgs e)
        {
            MudarPeriodo();
            CarregarListaGeral();
            CarregarListaGastoClasseMesAtual();
        }

        private void mesProximo_Click(object sender, EventArgs e)
        {
            MudarPeriodo(1);
            CarregarListaGeral();
            CarregarListaGastoClasseMesAtual();
        }

        private void CarregarListaCompromissos()
        {
            string sql, mes_ano;
            int mes, ano;

            for (int i = 0; i < 2; i++)
            {
                mes = DateTime.Today.AddMonths(i).Month;
                ano = DateTime.Today.AddMonths(i).Year;
                mes_ano = mes.ToString() + "." + ano.ToString();

                listaCompromissos.Tag = mes_ano;
                sql = SQLListaCompromissos(mes_ano);

                if(sql != "")
                {
                    listaCompromissos.DataSource = BD.Buscar(sql);
                    return;
                }
            }
        }

        private string SQLListaCompromissos(string mes_ano)
        {
            string sql;
            string mes = mes_ano.Split(".").GetValue(0).ToString();
            string ano = mes_ano.Split(".").GetValue(1).ToString();

            sql = "DELETE FROM PREVISAO WHERE VALOR = 0";
            BD.ExecutarSQL(sql);

            sql = "SELECT TIPO, COMPROMISSO, DIA, VALOR FROM(SELECT 'CARTÃO DE CRÉDITO' AS TIPO, D.CONTA AS COMPROMISSO, EXTRACT(DAY FROM A.DATA_PARCELA) AS DIA, SUM(A.VALOR) AS VALOR FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CARTAO_CREDITO C ON B.CARTAO = C.CARTAO_CREDITO_ID INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID WHERE EXTRACT(MONTH FROM A.DATA_PARCELA) = " + mes + " AND EXTRACT(YEAR FROM A.DATA_PARCELA) = " + ano + " AND A.STATUS = 0 GROUP BY D.CONTA, EXTRACT(DAY FROM A.DATA_PARCELA) UNION SELECT 'PREVISÃO' AS TIPO, B.CLASSE AS COMPROMISSO, A.DIA, A.VALOR FROM PREVISAO A INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE A.MES = " + mes + " AND A.ANO = " + ano + " AND B.TIPO = 0 AND A.STATUS = 0 AND A.VALOR > 0 ";

            sql += "AND A.PREVISAO_ID IN(SELECT PV.PREVISAO_ID FROM PREVISAO PV INNER JOIN CLASSE CL ON ";
            sql += "PV.CLASSE = CL.CLASSE_ID WHERE MES = " + mes + " AND ANO = " + ano + " AND PREVISAO_ID NOT IN(";
            sql += "SELECT A.PREVISAO_ID FROM PREVISAO A LEFT JOIN BD B ON A.CLASSE = B.CLASSE INNER JOIN CLASSE C ON A.CLASSE = C.CLASSE_ID ";
            sql += "AND EXTRACT(MONTH FROM B.DATA) = A.MES AND EXTRACT(YEAR FROM B.DATA) = A.ANO WHERE C.TIPO = 0 AND A.MES = " + mes + " ";
            sql += "AND A.ANO = " + ano + " UNION SELECT A.PREVISAO_ID FROM PREVISAO A LEFT JOIN KEY_COMPRA_CREDITO B ON A.CLASSE = B.CLASSE ";
            sql += "INNER JOIN CLASSE C ON A.CLASSE = C.CLASSE_ID AND EXTRACT(MONTH FROM B.DATA_COMPRA) = A.MES AND EXTRACT(YEAR FROM B.DATA_COMPRA) = A.ANO WHERE C.TIPO = 0 AND A.MES = " + mes + " AND A.ANO = " + ano + "))";
            
            sql += ") ORDER BY DIA";

            try
            {
                if(BD.Buscar(sql).Rows.Count > 0)
                {
                    return sql;
                }

                return "";
            }
            catch
            {
                return "";
            }
        }

        private void listaCompromissos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string mes_ano = DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();
            string periodo, mes, ano, txt_notif; int venc_hoje = 0, vencido = 0;

            try
            {
                periodo = listaCompromissos.Tag.ToString();
                mes = periodo.Split(".").GetValue(0).ToString();
                ano = periodo.Split(".").GetValue(1).ToString();

                if(ano == DateTime.Today.Year.ToString())
                {
                    mes = Classes.Geral.MesNome(mes, false);
                    lblVencimentos.Text = "Vencimentos: " + mes;
                }
                else
                {
                    mes = Classes.Geral.MesNome(mes, true);
                    lblVencimentos.Text = "Vencimentos: " + mes + "." + ano;
                }
            }
            catch
            {

            }

            if (listaCompromissos.RowCount == 0)
                return;

            if (listaCompromissos.Tag.ToString() != mes_ano)
                return;

            for (int i = 0; i < listaCompromissos.RowCount; i++)
            {
                if (listaCompromissos.Rows[i].Cells[2].Value.ToString() == DateTime.Today.Day.ToString())
                {
                    for (int c = 0; c < listaCompromissos.ColumnCount; c++)
                    {
                        listaCompromissos.Rows[i].Cells[c].Style.ForeColor = Color.FromArgb(255, 165, 0);
                    }
                    venc_hoje++;
                }
                else if(int.Parse(listaCompromissos.Rows[i].Cells[2].Value.ToString()) < DateTime.Today.Day)
                {
                    for (int c = 0; c < listaCompromissos.ColumnCount; c++)
                    {
                        listaCompromissos.Rows[i].Cells[c].Style.ForeColor = Color.Tomato;
                    }
                    vencido++;
                }
            }

            if (!COD.AtivarNotifVencimentos)
            {
                if (venc_hoje > 0)
                {
                    if(venc_hoje == 1)
                        txt_notif = "Há " + venc_hoje + " compromisso vencendo hoje.";
                    else
                        txt_notif = "Há " + venc_hoje + " compromissos vencendo hoje.";

                    COD.ShowNotification("Atenção:", txt_notif, ToolTipIcon.Info, 20);
                }
                if (vencido > 0)
                {
                    if (vencido == 1)
                        txt_notif = "Há " + vencido + " compromisso vencido.";
                    else
                        txt_notif = "Há " + vencido + " compromissos vencidos.";

                    COD.ShowNotification("Alerta:", txt_notif, ToolTipIcon.Warning, 20);
                }

                COD.AtivarNotifVencimentos = true;
            }
        }

        private void transferencia_Click(object sender, EventArgs e)
        {
            frmTransf transf = new frmTransf();
            transf.ShowDialog();
        }

        private void previsaoDeCustos_Click(object sender, EventArgs e)
        {
            frmPrevisao prev = new frmPrevisao();
            prev.Show();
        }

        private void receitaDespesa_Click(object sender, EventArgs e)
        {
            cbClasse.Focus();
        }

        private void fechar_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void definicoes_Click(object sender, EventArgs e)
        {
            pnDefinicoes.Visible = true;
            pnSalvar.Visible = false;
            lblLeft.Visible = false;
        }

        private void fechar__Click(object sender, EventArgs e)
        {
            pnDefinicoes.Visible = false;
            pnSalvar.Visible = true;
            pnCompromissos.Size = new Size(636, 510);
            lblLeft.Visible = true;
            COD.All_True = true;
        }

        private void Carregar_Controles_Definicoes()
        {
            string key, ativado;

            ConfigurationManager.RefreshSection("appSettings");

            foreach (var item in ConfigurationManager.AppSettings.AllKeys)
            {
                key = item.ToString();

                foreach (Control act in pnDefinicoes.Controls)
                {
                    if (key == act.Name)
                    {
                        try
                        {
                            ativado = ConfigurationManager.AppSettings[key].ToString();
                            act.TabIndex = int.Parse(ativado);
                        }
                        catch
                        {

                        }
                    }
                }
            }

        }

        private void pnDefinicoes_DoubleClick(object sender, EventArgs e)
        {
            pnDefinicoes.Visible = false;
            pnSalvar.Visible = true;
            pnCompromissos.Size = new Size(636, 510);
            lblLeft.Visible = true;
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

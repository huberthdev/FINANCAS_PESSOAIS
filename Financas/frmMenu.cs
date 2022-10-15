using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

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
            CarregarListasClasseConta();
            CarregarCbClassesContas();
            txtData.Text = DateTime.Today.ToShortDateString();
        }

        //FUNÇÃO PARA ABRIA CALCULADORA NATIVA DO WINDOWS
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        //NAVEGAÇÃO ENTRE AS ABAS/FORMULÁRIOS DE UTILIDADES DO SISTEMA
        private void receitaDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 0;
        }

        private void novoLançamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 0;
        }

        private void classesDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 1;
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

        //TODAS AS FUNÇÕES DA ABA CADASTRO DE CLASSES E CONTAS
        private void CarregarListasClasseConta(string tabela = "")
        {
            int tipo = Convert.ToInt32(optReceita.Checked);
            string classe = "%" + txtClasse.Text.Replace("*", "%").ToUpper() + "%";
            string conta = "%" + txtConta.Text.Replace("*", "%").ToUpper() + "%";

            if (tabela == "" || tabela == "classe")
            {
                listaClasse.DataSource = BD.Buscar("SELECT CLASSE_ID, CLASSE FROM CLASSE WHERE TIPO = " + tipo + " " +
                    "AND UPPER(CLASSE) LIKE '" + classe + "'");
            }

            if (tabela == "" || tabela == "conta")
            {
                listaConta.DataSource = BD.Buscar("SELECT CONTA_ID, CONTA, CARTAO_CREDITO AS CREDITO FROM CONTA WHERE " +
                    "UPPER(CONTA) LIKE '" + conta + "' ORDER BY CARTAO_CREDITO DESC");
                listaConta.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnExcluirClasse_Click(object sender, EventArgs e)
        {
            if (listaClasse.RowCount == 0) return;

            string id = listaClasse.CurrentRow.Cells[0].Value.ToString();
            string classe = listaClasse.CurrentRow.Cells[1].Value.ToString();

            COD.Pergunta("Excluir Classe: " + classe);
            if (COD.Resposta == false) 
                return;

            if (BD.Delete("CLASSE", id).Item1)
                CarregarListasClasseConta();                
        }

        private void btnSalvarClasse_Click(object sender, EventArgs e)
        {
            if (COD.ValidarCampos(gpClasse, errorProvider1) == false)
                return;

            int tp = Convert.ToInt32(optReceita.Checked);
            int at = Convert.ToInt32(ckAtivoClasse.Checked);

            string[] c = new string[4];
            string[] v = new string[4];

            c[0] = "tipo";
            v[0] = tp.ToString();

            c[1] = "classe";
            v[1] = txtClasse.Text.Trim();

            c[2] = "ativo";
            v[2] = at.ToString();

            c[3] = "grupo";
            v[3] = "0";

            BD.Salvar("CLASSE", c, v, 0, "Classe cadastrada com sucesso!");

            txtClasse.Text = "";

            CarregarListasClasseConta();
            CarregarCbClassesContas();
        }

        private void btnSalvarConta_Click(object sender, EventArgs e)
        {
            if (COD.ValidarCampos(gpConta, errorProvider1) == false)
                return;

            //PEGAR O VALOR DO SALDO INICIAL DA NOVA CONTA VIA FORMULÁRIO
            boxValor si = new boxValor();
            si.ShowDialog();
            string saldo = BD.SaldoInicial;

            int at = Convert.ToInt32(ckAtivoConta.Checked);

            string[] c = new string[4];
            string[] v = new string[4];

            c[0] = "conta";
            v[0] = txtConta.Text.Trim();

            c[1] = "saldo";
            v[1] = saldo;

            c[2] = "ativo";
            v[2] = at.ToString();

            c[3] = "cartao_credito";
            v[3] = "0";

            BD.Salvar("CONTA", c, v, 0, "Conta cadastrada com sucesso!");

            txtConta.Text = "";

            CarregarListasClasseConta();
            CarregarCbClassesContas();
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            if (listaConta.RowCount == 0)
                return;

            string id = listaConta.CurrentRow.Cells[0].Value.ToString();
            string conta = listaConta.CurrentRow.Cells[1].Value.ToString();

            COD.Pergunta("Excluir Conta: " + conta);
            if (COD.Resposta == false) 
                return;

            if (BD.Delete("CONTA", id).Item1)
                CarregarListasClasseConta();
        }

        //TODAS AS FUNÇÕES DA ABA LANÇAMENTO DE RECEITAS E DESPESAS
        private void CarregarListaSaldoContas()
        {
            double valor, total = 0;

            string sql = "SELECT CONTA_ID, CONTA, SALDO FROM CONTA ";
            sql += "WHERE SALDO <> 0 ORDER BY SALDO DESC";

            listaSaldo_Contas.DataSource = BD.Buscar(sql);

            for (int i = 0; i < listaSaldo_Contas.RowCount; i++)
            {
                valor = double.Parse(listaSaldo_Contas.Rows[i].Cells[2].Value.ToString());
                total += valor;

                if (valor < 0)
                {
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                }
            }

            listaSaldo_Contas.Columns[2].HeaderText = "SALDO: " + total.ToString("C");
        }

        private void CarregarListaGastoClasseMesAtual()
        {
            string mesNome;
            double total = 0;

            int mesAtual = DateTime.Today.Month;
            int anoAtual = DateTime.Today.Year;

            mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(mesAtual).ToUpper();

            string sql = "select b.CLASSE_ID, b.CLASSE, abs(sum(a.VALOR)) as VALOR from bd ";
            sql += "a inner join classe b on a.CLASSE = b.CLASSE_ID where a.VALOR < '0' and ";
            sql += "extract(month from a.DATA) = " + mesAtual + " and extract(year from a.DATA) = " + anoAtual + "";
            sql += "group by b.CLASSE_ID, b.CLASSE order by b.classe";

            lista_Gastos_Classe.DataSource = BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                total += double.Parse(BD.Resultado.Rows[i][2].ToString());
                //RowTemplate.DefaultCellStyle.ForeColor = Color.Red
                //lista_Gastos_Classe.Rows[i].Cells[2].Style.ForeColor = Color.Red;
            }

            lista_Gastos_Classe.Columns[1].HeaderText = "Gasto: " + mesNome;
            lista_Gastos_Classe.Columns[2].HeaderText = total.ToString("C");
        }

        private void CarregarCbClassesContas(string tabela = "")
        {
            //Preenche o combobox com as classes cadastradas no banco de dados
            if(tabela=="classe" || tabela == "")
            {
                cbClasse.Items.Clear();
                Classes.Classe.Tipo = Convert.ToByte(opReceita.Checked);
                foreach (Classes.Classe c in Classes.Classe.Lista())
                {
                    cbClasse.Items.Add(c);
                }
            }

            //Preenche o combobox com as contas cadastradas no banco de dados
            if (tabela == "conta" || tabela == "")
            {
                cbConta.Items.Clear();
                foreach (Classes.Conta c in Classes.Conta.Lista())
                {
                    cbConta.Items.Add(c);
                }

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

            Application.Exit();
        }

        private void transnferênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransf transf = new frmTransf();
            transf.ShowDialog();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 1;
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtClasse_TextChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta("classe");
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta("conta");
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string classe, conta, valor;

            if (!COD.ValidarCampos(pnLancamento, errorProvider1))
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
            Classes.Geral.AtualizarSaldoConta(conta, valor);

            COD.LimparCampos(pnLancamento, txtData, cbClasse);
            CarregarListaSaldoContas();
            CarregarListaGastoClasseMesAtual();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            COD.LimparCampos(pnLancamento, txtData, cbClasse);
        }

        private void comprasCredito_Click(object sender, EventArgs e)
        {
            frmCredito cred = new frmCredito();
            cred.ShowDialog();
        }

        private void optReceita_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void optDespesa_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
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
            cred.ShowDialog();
        }

        private void transf_Click(object sender, EventArgs e)
        {
            frmTransf transf = new frmTransf();
            transf.ShowDialog();
        }

        private void listaConta_MouseEnter(object sender, EventArgs e)
        {
            listaConta.ReadOnly = false;
            listaConta.Columns[1].ReadOnly = true;
        }

        private void listaConta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ck = "0";
            string id;

            if (listaConta.RowCount == 0)
                return;

            id = listaConta.SelectedRows[0].Cells[0].Value.ToString();

            if(e.ColumnIndex == 2)
            {
                listaConta.EndEdit();
                ck = listaConta.Rows[e.RowIndex].Cells[2].Value.ToString();

                string sql = "UPDATE CONTA SET CARTAO_CREDITO = " + ck + " WHERE CONTA_ID = " + id + "";
                BD.ExecutarSQL(sql);
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void lista_Gastos_Classe_DoubleClick(object sender, EventArgs e)
        {
            string classe;

            if (lista_Gastos_Classe.Rows.Count == 0)
                return;

            classe = lista_Gastos_Classe.SelectedRows[0].Cells[1].Value.ToString();

            frmRelatorio rel = new frmRelatorio();
            rel.ckDespesa.Checked = true;
            rel.CarregarCbClassesContas("classe");
            rel.cbClasse.Text = classe;
            rel.ShowDialog();
        }
    }
}

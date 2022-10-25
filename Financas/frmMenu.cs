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
            CarregarCbClassesContas();
            CarregarListaSaldoContas();
            CarregarListaGastoClasseMesAtual();

            txtData.Text = DateTime.Today.ToShortDateString();
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
            string sql = "SELECT CONTA_ID, CONTA, SALDO FROM CONTA ";
            sql += "WHERE SALDO <> 0 ORDER BY SALDO DESC";

            listaSaldo_Contas.DataSource = BD.Buscar(sql);
        }

        private void CarregarListaGastoClasseMesAtual()
        {
            string mesNome;
            double total = 0;

            int mesAtual = DateTime.Today.Month;
            int anoAtual = DateTime.Today.Year;

            mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(mesAtual).ToUpper();

            string sql = "SELECT CLASSE, SUM(VALOR) AS VALOR FROM(SELECT B.CLASSE, ABS(SUM(A.VALOR)) AS VALOR FROM BD A ";
            sql += "INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE A.VALOR < '0' AND EXTRACT(MONTH FROM A.DATA) = " + mesAtual + " AND ";
            sql += "EXTRACT(YEAR FROM A.DATA) = " + anoAtual + " GROUP BY B.CLASSE_ID, B.CLASSE ";
            sql += "UNION SELECT C.CLASSE, SUM(A.VALOR) AS VALOR FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE ";
            sql += "INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID  WHERE EXTRACT(MONTH FROM B.DATA_COMPRA) = " + mesAtual + " ";
            sql += "AND EXTRACT(YEAR FROM B.DATA_COMPRA) = " + anoAtual + " GROUP BY A.COMPRA_CREDITO_ID, C.CLASSE) GROUP BY CLASSE ";

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

            lista_Gastos_Classe.Columns[0].HeaderText = "Gasto: " + mesNome;
            lista_Gastos_Classe.Columns[1].HeaderText = total.ToString("C");
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
            Classes.Geral.AtualizarSaldoConta(conta, valor);

            COD.LimparCampos(pnSalvar, txtData, cbClasse);
            CarregarListaSaldoContas();
            CarregarListaGastoClasseMesAtual();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            COD.LimparCampos(pnSalvarIn, txtData, cbClasse);
        }

        private void comprasCredito_Click(object sender, EventArgs e)
        {
            frmCredito cred = new frmCredito();
            cred.ShowDialog();
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

        private void lista_Gastos_Classe_DoubleClick(object sender, EventArgs e)
        {
            string classe;

            if (lista_Gastos_Classe.Rows.Count == 0)
                return;

            try
            {
                classe = lista_Gastos_Classe.SelectedRows[0].Cells[0].Value.ToString();

                frmRelatorio rel = new frmRelatorio();
                rel.ckDespesa.Checked = true;
                rel.CarregarCbClassesContas("classe");
                rel.cbClasse.Text = classe;
                rel.ShowDialog();
            }
            catch
            {
                return;                
            }

        }

        private void ToolVisaoGeral_Click(object sender, EventArgs e)
        {

        }

        private void ToolPrevisao_Click(object sender, EventArgs e)
        {
            frmPrevisao prev = new frmPrevisao();
            prev.ShowDialog();
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.ShowDialog();
        }

        private void listaSaldo_Contas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            double valor, total = 0;

            for (int i = 0; i < listaSaldo_Contas.RowCount; i++)
            {
                valor = double.Parse(listaSaldo_Contas.Rows[i].Cells[2].Value.ToString());
                total += valor;

                if (valor < 0)
                {
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.Tomato;
                }
                else
                {
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.LimeGreen;
                }
            }

            listaSaldo_Contas.Columns[2].HeaderText = "SALDO: " + total.ToString("C");
        }

        private void cads_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.ShowDialog();
        }
    }
}

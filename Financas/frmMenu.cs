using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

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
            CarregarListaSaldoContas();
            CarregarListaGastoClasseMesAtual();
            CarregarCbClassesContas();
            txtData.Text = DateTime.Today.ToShortDateString();
        }

        //FUNÇÃO PARA ABRIA CALCULADORA NATIVA DO WINDOWS
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        //ABRIR FORMULÁRIO DE CONFIGURAÇÃO DO BANCO DE DADOS
        private void conexãoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmConfigBD bd = new Formularios.frmConfigBD();
            bd.ShowDialog();
        }

        //NAVEGAÇÃO ENTRE AS ABAS/FORMULÁRIOS DE UTILIDADES DO SISTEMA
        private void receitaDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 2;
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmUsuario usuario = new Formularios.frmUsuario();
            usuario.ShowDialog();
        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 0;
        }

        private void novoLançamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 2;
        }

        private void classesDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 1;
        }

        private void anotaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Financas.frmNota nota = new Financas.frmNota();
            nota.ShowDialog();
        }

        private void anotaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financas.frmNota nota = new Financas.frmNota();
            nota.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaMenu.SelectedIndex = 0;
        }

        //TODAS AS FUNÇÕES DA ABA CADASTRO DE CLASSES E CONTAS
        private void opLimpar_Click(object sender, EventArgs e)
        {
            COD.LimparCampos(pnLanc_Rec_desp, txtData, cbClasse);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (COD.ValidarCampos(pnLanc_Rec_desp, errorProvider1) == false)
                return;

            string classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();
            string conta = ((Classes.Conta)cbConta.SelectedItem).id.ToString();
            string valor = txtValor.Text;

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
            v[5] = Convert.ToInt32(opReceita.Checked).ToString();

            BD.Salvar("bd", c, v, 0, "Operação salva com sucesso!");
            Classes.Geral.AtualizarSaldoConta(conta, valor);

            COD.LimparCampos(pnLanc_Rec_desp, txtData, cbClasse);
            CarregarListaSaldoContas();
            CarregarListaGastoClasseMesAtual();

        }

        private void CarregarListasClasseConta()
        {
            int tipo = Convert.ToInt32(optReceita.Checked);
            
            listaClasse.DataSource = BD.Buscar("SELECT CLASSE_ID, CLASSE FROM CLASSE WHERE TIPO = "+ tipo +"");
            listaClasse.Columns[0].Visible = false;

            listaConta.DataSource = BD.Buscar("SELECT CONTA_ID, CONTA FROM CONTA");
            listaConta.Columns[0].Visible = false;

        }

        private void optReceita_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void optDespesa_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void btnExcluirClasse_Click(object sender, EventArgs e)
        {
            if (listaClasse.RowCount == 0) return;

            string id = listaClasse.CurrentRow.Cells[0].Value.ToString();
            string classe = listaClasse.CurrentRow.Cells[1].Value.ToString();

            COD.Pergunta("Excluir Classe: " + classe);
            if (COD.Resposta == false) return;

            if (BD.Delete("CLASSE", id))
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
        }

        private void btnSalvarConta_Click(object sender, EventArgs e)
        {
            if (COD.ValidarCampos(gpConta, errorProvider1) == false)
                return;

            int at = Convert.ToInt32(ckAtivoConta.Checked);

            string[] c = new string[3];
            string[] v = new string[3];

            c[0] = "conta";
            v[0] = txtConta.Text.Trim();

            c[1] = "saldo";
            v[1] = "0";

            c[2] = "ativo";
            v[2] = at.ToString();

            BD.Salvar("CONTA", c, v, 0, "Conta cadastrada com sucesso!");

            txtConta.Text = "";

            CarregarListasClasseConta();           
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            if (listaConta.RowCount == 0) return;

            string id = listaClasse.CurrentRow.Cells[0].Value.ToString();
            string conta = listaClasse.CurrentRow.Cells[1].Value.ToString();

            COD.Pergunta("Excluir Conta: " + conta);
            if (COD.Resposta == false) return;

            if (BD.Delete("CONTA", id))
                CarregarListasClasseConta();
        }

        private void listaClasse_MouseMove(object sender, MouseEventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void listaConta_MouseMove(object sender, MouseEventArgs e)
        {
            CarregarListasClasseConta();
        }

        //TODAS AS FUNÇÕES DA ABA LANÇAMENTO DE RECEITAS E DESPESAS
        private void CarregarListaSaldoContas()
        {
            string sql = "SELECT CONTA_ID, CONTA, SALDO FROM CONTA ";
            sql += "WHERE SALDO <> 0 ORDER BY SALDO DESC";
            listaSaldo_Contas.DataSource = BD.Buscar(sql);

            for (int i = 0; i < listaSaldo_Contas.RowCount; i++)
            {
                String valor = listaSaldo_Contas.Rows[i].Cells[2].Value.ToString();
                if (Decimal.Parse(valor) < 0)
                    listaSaldo_Contas.Rows[i].Cells[2].Style.ForeColor = Color.Red;
            }
        }

        private void CarregarListaGastoClasseMesAtual()
        {
            string mesAtual = DateTime.Today.Month.ToString();

            string sql = "select b.CLASSE_ID, b.CLASSE, abs(sum(a.VALOR)) as VALOR from bd ";
            sql += "a inner join classe b on a.CLASSE = b.CLASSE_ID where a.VALOR < '0' and ";
            sql += "extract(month from a.DATA) = " + mesAtual + " ";
            sql += "group by b.CLASSE_ID, b.CLASSE";

            lista_Gastos_Classe.DataSource = BD.Buscar(sql);
        }

        private void CarregarCbClassesContas()
        {
            //Preenche o combobox com as classes cadastradas no banco de dados
            cbClasse.Items.Clear();
            Classes.Classe.Tipo = Convert.ToByte(opReceita.Checked);
            foreach (Classes.Classe c in Classes.Classe.Lista())
            {
                cbClasse.Items.Add(c);
            }

            //Preenche o combobox com as contas cadastradas no banco de dados
            cbConta.Items.Clear();
            foreach (Classes.Conta c in Classes.Conta.Lista())
            {
                cbConta.Items.Add(c);
            }

        }

        private void opReceita_CheckedChanged(object sender, EventArgs e)
        {
            CarregarCbClassesContas();
        }

        private void opDespesa_CheckedChanged(object sender, EventArgs e)
        {
            CarregarCbClassesContas();
        }

        private void ToolQuery_Click(object sender, EventArgs e)
        {
            Formularios.frmQuery query = new Formularios.frmQuery();
            query.Show();
        }

        private void queryDesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmQuery query = new Formularios.frmQuery();
            query.Show();
        }
    }
}

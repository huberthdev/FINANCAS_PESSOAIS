using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class frmTransf : Form
    {
        public frmTransf()
        {
            InitializeComponent();
        }

        private void frmTransf_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Today.ToShortDateString();
            CarregarContas();
            CarregarLista();
        }

        private void CarregarContas()
        {
            cbContaDebito.Items.Clear();
            cbContaCredito.Items.Clear();
            foreach (Classes.Conta c in Classes.Conta.Lista())
            {
                cbContaDebito.Items.Add(c);
                cbContaCredito.Items.Add(c);
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (COD.ValidarCampos(this) == false)
                return;

            if (cbContaDebito.Text == cbContaCredito.Text)
            {
                COD.Erro("Transação inválida. As contas não podem ser iguai!");
                return;
            }

            string[] c = new string[5];
            string[] v = new string[5];

            string contaD = ((Classes.Conta)cbContaDebito.SelectedItem).id.ToString();
            string contaC = ((Classes.Conta)cbContaCredito.SelectedItem).id.ToString();
            string vD = BD.CvNum((decimal.Parse(txtValor.Text) * -1).ToString());
            string vC = BD.CvNum((decimal.Parse(txtValor.Text)).ToString());

            c[0] = "data";
            v[0] = BD.CvData(txtData.Text);

            c[1] = "conta_debito";
            v[1] = contaD;

            c[2] = "conta_credito";
            v[2] = contaC;

            c[3] = "valor";
            v[3] = BD.CvNum(txtValor.Text);

            c[4] = "descricao";
            v[4] = txtDescricao.Text;

            //ATUALIZA O SALDO DAS CONTAS DÉBITO E CRÉDITO
            Classes.Conta.AtualizarSaldoConta(contaD, vD);
            Classes.Conta.AtualizarSaldoConta(contaC, vC);

            //SALVA A MOVIMENTAÇÃO NO BANCO DE DADOS
            BD.Salvar("TRANSFERENCIA", c, v, 0, "Transferência realizada com sucesso!");

            COD.LimparCampos(this, txtData, cbContaDebito);

            CarregarLista();
        }

        private void CarregarLista()
        {
            string sql = "SELECT T1.TRANSFERENCIA_ID, T1.DATA, N1.CONTA AS DE, N2.CONTA AS PARA, T1.VALOR, T1.DESCRICAO ";
            sql += "FROM TRANSFERENCIA T1 ";
            sql += "INNER JOIN CONTA N1 ON T1.CONTA_DEBITO = N1.CONTA_ID ";
            sql += "INNER JOIN CONTA N2 ON T1.CONTA_CREDITO = N2.CONTA_ID ";
            sql += "ORDER BY T1.TRANSFERENCIA_ID DESC";

            try
            {
                lista.DataSource = BD.Buscar(sql);
                status.Items[0].Text = "LINHAS: " + lista.RowCount;
            }
            catch
            {

            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            COD.LimparCampos(this, txtData, cbContaDebito);
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            string id = "0";

            try
            {
                id = lista.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                COD.Erro("Selecione uma linha na lista!");
                return;
            }

            Classes.Geral.ExcluirTransferencia(id);

            CarregarLista();
        }

        private void frmTransf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void txtClasse_TextChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta("classe");
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta("conta");
        }

        private void optReceita_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void optDespesa_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void listaConta_MouseEnter(object sender, EventArgs e)
        {
            listaConta.ReadOnly = false;
            listaConta.Columns[1].ReadOnly = true;
        }

        private void CarregarListasClasseConta(string tabela = "")
        {
            int tipo = Convert.ToInt32(optReceita.Checked);
            string classe = "%" + txtClasse.Text.Replace("*", "%").ToUpper() + "%";
            string conta = "%" + txtConta.Text.Replace("*", "%").ToUpper() + "%";

            if (tabela == "" || tabela == "classe")
            {
                try
                {
                    listaClasse.DataSource = BD.Buscar("SELECT CLASSE_ID, CLASSE, ATIVO FROM CLASSE WHERE TIPO = " + tipo + " " +
                        "AND UPPER(CLASSE) LIKE '" + classe + "'");
                }
                catch
                {

                }
            }

            if (tabela == "" || tabela == "conta")
            {
                try
                {
                    listaConta.DataSource = BD.Buscar("SELECT CONTA_ID, CONTA, IIF(CARTAO_CREDITO IS NULL, 0, CARTAO_CREDITO) AS CREDITO, IIF(RESERVADO IS NULL, 0, RESERVADO) AS RESERVADO, IIF(POUPANCA IS NULL, 0, POUPANCA) AS POUPANCA FROM CONTA WHERE " +
                        "UPPER(CONTA) LIKE '" + conta + "' ORDER BY CARTAO_CREDITO DESC, RESERVADO DESC, POUPANCA DESC");
                    listaConta.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
                catch
                {

                }
            }
        }

        private void SalvarClasse()
        {
            if (COD.ValidarCampos(pnClasse) == false)
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

        private void ExcluirClasse()
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

        private void SalvarConta()
        {
            if (COD.ValidarCampos(pnConta) == false)
                return;

            //PEGAR O VALOR DO SALDO INICIAL DA NOVA CONTA VIA FORMULÁRIO
            boxValor si = new boxValor();
            si.ShowDialog();
            string saldo = BD.SaldoInicial;

            int at = Convert.ToInt32(ckAtivoConta.Checked);

            string[] c = new string[5];
            string[] v = new string[5];

            c[0] = "conta";
            v[0] = txtConta.Text.Trim();

            c[1] = "saldo";
            v[1] = saldo;

            c[2] = "ativo";
            v[2] = at.ToString();

            c[3] = "cartao_credito";
            v[3] = "0";

            c[4] = "reservado";
            v[4] = "0";

            BD.Salvar("CONTA", c, v, 0, "Conta cadastrada com sucesso!");

            txtConta.Text = "";

            CarregarListasClasseConta();
        }

        private void ExcluirConta()
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

        private void btnSalvarConta_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void optConta_Click(object sender, EventArgs e)
        {
            pnConta.Location = new Point(8, 27);
            pnClasse.Location = new Point(555, 27);
        }

        private void optClasse_Click(object sender, EventArgs e)
        {
            pnClasse.Location = new Point(8, 27);
            pnConta.Location = new Point(555, 27);
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (optConta.Checked)
            {
                SalvarConta();
            }
            else
            {
                SalvarClasse();
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (optConta.Checked)
            {
                ExcluirConta();
            }
            else
            {
                ExcluirClasse();
            }
        }

        private void ckAtivoClasse_Click(object sender, EventArgs e)
        {
            string id; int status;

            status = Convert.ToInt32(ckAtivoClasse.Checked);

            try
            {
                id = listaClasse.Rows[listaClasse.CurrentCell.RowIndex].Cells[0].Value.ToString();
                listaClasse.Rows[listaClasse.CurrentCell.RowIndex].Cells[2].Value = status;
            }
            catch 
            {
                return;
            }

            string sql = "UPDATE CLASSE SET ATIVO = " + status + " WHERE CLASSE_ID = "+ id +"";
            BD.ExecutarSQL(sql);

            FormatacaoCondicional();

        }

        private void listaClasse_SelectionChanged(object sender, EventArgs e)
        {
            bool status;

            try
            {
                status = Convert.ToBoolean(listaClasse.SelectedRows[0].Cells[2].Value);
            }
            catch
            {
                return;
            }

            ckAtivoClasse.Checked = status;
        }

        private void FormatacaoCondicional()
        {
            for (int i = 0; i < listaClasse.RowCount; i++)
            {
                if(listaClasse.Rows[i].Cells[2].Value.ToString() == "0")
                    listaClasse.Rows[i].Cells[1].Style.ForeColor = Color.Tomato;
                else
                    listaClasse.Rows[i].Cells[1].Style.ForeColor = Color.White;
            }
        }

        private void listaClasse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FormatacaoCondicional();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            COD.ReleaseCapture();
            COD.SendMessage(this.Handle, COD.WM_NCLBUTTONDOWN, COD.HT_CAPTION, 0);
        }

        private void listaConta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ck = 0;
            string id, sql;

            if (listaConta.RowCount == 0)
                return;

            try
            {
                id = listaConta.SelectedRows[0].Cells["ID_CONTA"].Value.ToString();
            }
            catch
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                ck = int.Parse(listaConta.Rows[e.RowIndex].Cells["CREDITO"].Value.ToString());
                ck = ~ck & 1;

                sql = "UPDATE CONTA SET CARTAO_CREDITO = " + ck + " WHERE CONTA_ID = " + id + "";
                BD.ExecutarSQL(sql);
            }
            else if (e.ColumnIndex == 3)
            {
                ck = int.Parse(listaConta.Rows[e.RowIndex].Cells["RESERVADO"].Value.ToString());
                ck = ~ck & 1;

                sql = "UPDATE CONTA SET RESERVADO = " + ck + " WHERE CONTA_ID = " + id + "";
                BD.ExecutarSQL(sql);
            }
            else if (e.ColumnIndex == 4)
            {
                ck = int.Parse(listaConta.Rows[e.RowIndex].Cells["POUPANCA"].Value.ToString());
                ck = ~ck & 1;

                if(ck == 1)
                    sql = "UPDATE CONTA SET POUPANCA = " + ck + ", RESERVADO = 1 WHERE CONTA_ID = " + id + "";
                else
                    sql = "UPDATE CONTA SET POUPANCA = " + ck + " WHERE CONTA_ID = " + id + "";

                BD.ExecutarSQL(sql);
            }
        }
    }
}

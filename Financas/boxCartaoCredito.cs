using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class boxCartaoCredito : Form
    {
        public boxCartaoCredito()
        {
            InitializeComponent();
            CarregarCBs();
            CarregarLista();
            ConfigurarLista();
        }

        private void CarregarCBs()
        {
            for (int i = 1; i < 31; i++)
            {
                cbVenc.Items.Add(i);
                cbFecha.Items.Add(i);
            }
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
            string sql = "SELECT CARTAO_CREDITO_ID AS ID, CARTAO, STATUS AS ATIVO ";
            sql += "FROM CARTAO_CREDITO";

            lista.DataSource = BD.Buscar(sql);
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblID.Tag.ToString());

            if (COD.ValidarCampos(this) == false)
                return;
            
            string[] c = new string[6];
            string[] v = new string[6];

            c[0] = "cartao";
            v[0] = txtNome.Text;

            c[1] = "limite";
            v[1] = BD.CvNum(txtLimite.Text);

            c[2] = "utilizado";
            v[2] = BD.CvNum(txtLimite.Tag.ToString());

            c[3] = "dia_venc";
            v[3] = cbVenc.Text;

            c[4] = "melhor_dia_compra";
            v[4] = cbFecha.Text;

            c[5] = "status";
            v[5] = Convert.ToInt32(ckStatus.Checked).ToString();

            if(id == 0)
                BD.Salvar("CARTAO_CREDITO", c, v, 0, "Cartão Adicionado com Sucesso!");
            else
                BD.Salvar("CARTAO_CREDITO", c, v, id, "Cartão Alterado com Sucesso!");

            Novo();

            CarregarLista();
        }

        private void Novo()
        {
            COD.LimparCampos(this, null, txtNome);
            lblID.Text = "ID Selecionado: 0";
            lblID.Tag = "";
            txtLimite.Tag = "0";
        }

        private void novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            string id;
            string cartao;

            if (lista.RowCount == 0)
                return;

            id = lista.SelectedRows[0].Cells[0].Value.ToString();
            cartao = lista.SelectedRows[0].Cells[1].Value.ToString();

            BD.Delete("CARTAO_CREDITO", id, "Excluir Cartão. Confirma? \r\n\r\n Cartão: "+ cartao +"");

            Novo();

            CarregarLista();
        }

        private void lista_Click(object sender, EventArgs e)
        {
            string sql;
            string id;

            if (lista.RowCount == 0)
                return;

            id = lista.SelectedRows[0].Cells[0].Value.ToString();

            lblID.Text = "ID Selecionado: " + id;
            lblID.Tag = id;

            sql = "SELECT CARTAO, LIMITE, DIA_VENC, MELHOR_DIA_COMPRA, STATUS, UTILIZADO ";
            sql += "FROM CARTAO_CREDITO WHERE CARTAO_CREDITO_ID = "+ id +"";
            BD.Buscar(sql);

            txtNome.Text = BD.Resultado.Rows[0][0].ToString();
            txtLimite.Text = Convert.ToDouble(BD.Resultado.Rows[0][1].ToString()).ToString("N");
            cbVenc.Text = BD.Resultado.Rows[0][2].ToString();
            cbFecha.Text = BD.Resultado.Rows[0][3].ToString();
            ckStatus.Checked = Convert.ToBoolean(int.Parse(BD.Resultado.Rows[0][4].ToString()));
            txtLimite.Tag = BD.Resultado.Rows[0][5].ToString();
        }
    }
}

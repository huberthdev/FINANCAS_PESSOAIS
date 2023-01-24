using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (COD.ValidarCampos(this.painel) == false)
                return;

            int id = 0;
            string usuario = txtUsuario.Text;
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string acesso = cbAcesso.Text;

            senha = COD.CriptografiaMd5(senha);

            if (lblID.Text != "")
                id = int.Parse(lblID.Text);
            
            string[] c = new string[4];
            string[] v = new string[4];

            c[0] = "USUARIO";
            v[0] = usuario;

            c[1] = "NOME";
            v[1] = nome;

            c[2] = "SENHA";
            v[2] = senha;

            c[3] = "ACESSO";
            v[3] = acesso;
            
            if(id==0)
                BD.Salvar("USUARIO", c, v, id, "Usuário cadastrado com sucesso!");
            else            
                BD.Salvar("USUARIO", c, v, id, "Usuário atualizado com sucesso!");

            COD.LimparCampos(this.painel, null, txtUsuario);
            lblID.Text = "";

            CarregarLista();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista(string sql = "")
        {

            if(sql=="")
                sql = "SELECT USUARIO_ID, USUARIO, NOME, ACESSO FROM USUARIO";

            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch 
            {
                
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            string txt = txtBuscar.Text;
            txt = txt.Replace("*", "%").ToUpper();

            string sql = "SELECT USUARIO_ID, USUARIO, NOME, ACESSO FROM USUARIO ";
            sql += "WHERE UPPER(NOME) LIKE '"+ txt +"%' OR UPPER(USUARIO) LIKE '"+ txt +"%'";

            CarregarLista(sql);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string id = "0";

            if (lblID.Text != "")
                id = lblID.Text;

            if (id == "0")
                COD.Erro("Nenhum usuário foi selecionado!");
            else
                BD.Delete("USUARIO", id, "Deseja realmente excluir o usuário selecionado? ID: " + id);
            lblID.Text = "";

            COD.LimparCampos(this.painel, null, txtUsuario);

            CarregarLista();

        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {
            if (lblID.Text != "")
            {
                txtSenha.ReadOnly = true;
                txtSenha.Tag = "";
            }
            else
            {
                txtSenha.ReadOnly = false;
                txtSenha.Tag = "'Senha'";
            }

        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            lblID.Text = lista.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = lista.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = lista.CurrentRow.Cells[2].Value.ToString();
            cbAcesso.Text = lista.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

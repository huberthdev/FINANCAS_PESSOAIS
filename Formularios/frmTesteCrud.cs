using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmTesteCrud : Form
    {

        public int id;
        
        public frmTesteCrud()
        {
            InitializeComponent();
            
        }   

        private void frmTesteCrud_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            string[] c = new string[3];
            string[] v = new string[3];

            c[0] = "nome";
            v[0] = txtNome.Text;

            c[1] = "dn";
            v[1] = BD.CvData(txtDN.Text);

            c[2] = "email";
            v[2] = txtEmail.Text;
                      
            BD.Salvar("usuario", c, v, 0, "Usuário cadastrado com sucesso!");

            COD.LimparCampos(this, null, txtNome);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            COD.LimparCampos(this,null,txtNome);            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                id = int.Parse(txtID.Text);
            }
            catch (Exception)
            {
                id = 0;
            }

            string[] c = new string[3];
            string[] v = new string[3];

            c[0] = "nome";
            v[0] = txtNome.Text;

            c[1] = "dn";
            v[1] = BD.CvData(txtDN.Text);

            c[2] = "email";
            v[2] = txtEmail.Text;

            BD.Salvar("Usuario", c, v, id, "Usuário alterado com sucesso!");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                id = int.Parse(txtID.Text);
            }
            catch (Exception)
            {
                id = 0;
            }

            if (BD.Delete("usuario", id, "Deseja realmente excluir este usuário?") == true)
                COD.OK("Usuário excluído com sucesso!");

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM USUARIO WHERE UPPER(NOME) LIKE '%" + txtPesquisar.Text.ToUpper() + "%' ";
            sql += "OR UPPER(EMAIL) LIKE '%" + txtPesquisar.Text.ToUpper() + "%'";

            lista.DataSource = BD.Buscar(sql);

        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = "";
        }
    }
}

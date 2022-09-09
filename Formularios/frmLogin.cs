using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="Admin" && txtSenha.Text == "123")
            {
                BD.UsuarioLogado = txtUsuario.Text;
                this.Dispose();
            }
            else
            {

                COD.NumTentativasLogin++;

                if (COD.NumTentativasLogin==3)
                {
                    COD.Erro("Número máximo de tentativas. O sistema será fechado!");
                    Application.Exit();
                }

                lblMsg.Visible = true;

                COD.Erro("Tentativa nº " + COD.NumTentativasLogin + ". O sistema fechará na tentativa nº 3!");

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

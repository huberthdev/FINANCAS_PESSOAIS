using System;
using System.Windows.Forms;
using System.Configuration;

namespace Setup.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            ConfigurationManager.RefreshSection("appSettings");

            string usuario = ConfigurationManager.AppSettings["Usuario"].ToString();
            string senha = ConfigurationManager.AppSettings["Senha"].ToString();

            txtUsuario.Text = usuario;
            txtSenha.Text = senha;

            if (usuario != "" || senha != "")
                ckLembrar.Checked = true;
                btnEntrar.Focus();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {                       

            if (COD.ValidarCampos(panel1, errorProvider1)==false)
                return;
            
            try
            {

                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                senha = COD.CriptografiaMd5(senha);

                if (!ckLembrar.Checked)
                {
                    usuario = "";
                    senha = "";
                }                  

                string sql = "SELECT USUARIO_ID FROM USUARIO WHERE USUARIO = '" + txtUsuario.Text + "' ";
                sql += "AND SENHA = '" + senha + "'";
                string id = BD.Buscar(sql).Rows[0][0].ToString();

                BD.UsuarioLogado = usuario;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Usuario"].Value = usuario;
                config.AppSettings.Settings["Senha"].Value = txtSenha.Text;
                config.Save(ConfigurationSaveMode.Modified);

                this.Dispose(); 

            }
            catch 
            {

                COD.NumTentativasLogin++;

                if (COD.NumTentativasLogin == 3)
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}

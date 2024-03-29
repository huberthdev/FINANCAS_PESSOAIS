﻿using System;
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
            string lembrar = ConfigurationManager.AppSettings["LembrarLogin"].ToString();

            if (usuario != "" && senha != "" && lembrar == "1")
            {
                txtUsuario.Text = usuario;
                txtSenha.Text = senha;

                ckLembrar.Checked = true;
                btnEntrar.Focus();
            }
            else
            {
                ckLembrar.Checked = false;
                txtUsuario.Focus();
            }

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

                string sql = "SELECT USUARIO_ID FROM USUARIO WHERE USUARIO = '" + txtUsuario.Text + "' ";
                sql += "AND SENHA = '" + senha + "'";
                string id = BD.Buscar(sql).Rows[0][0].ToString();

                BD.UsuarioLogado = usuario;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (!ckLembrar.Checked)
                {
                    usuario = "";
                    senha = "";
                    config.AppSettings.Settings["LembrarLogin"].Value = "0";
                }
                else
                {
                    config.AppSettings.Settings["LembrarLogin"].Value = "1";
                }

                config.AppSettings.Settings["Usuario"].Value = usuario;

                if(senha != "")
                    config.AppSettings.Settings["Senha"].Value = txtSenha.Text;
                else
                    config.AppSettings.Settings["Senha"].Value = "";

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

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            COD.ReleaseCapture();
            COD.SendMessage(this.Handle, COD.WM_NCLBUTTONDOWN, COD.HT_CAPTION, 0);
        }
    }
}

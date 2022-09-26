using System;
using System.Windows.Forms;
using System.Configuration;

namespace Setup.Formularios
{
    public partial class frmConfigBD : Form
    {
        public frmConfigBD()
        {

            InitializeComponent();

            txtServidor.Text = "127.0.0.1";
            txtPorta.Text = "3050";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCaminhoBD_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Configurações de base de dados";
            openFileDialog1.Filter = "Bases Firebird|*.fdb";
            openFileDialog1.FileName = "";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtBD.Text = openFileDialog1.FileName.ToString();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (COD.ValidarCampos(panel1, errorProvider1) == false)
                return;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["Banco"].Value = txtBD.Text;
            config.AppSettings.Settings["Servidor"].Value = txtServidor.Text;
            config.AppSettings.Settings["Porta"].Value = txtPorta.Text;

            config.Save(ConfigurationSaveMode.Modified);

            COD.OK("Configurações salvas com sucesso.\r\n\r\nO sistema será fechado!");

            Application.Exit();

        }
    }
}

using System;
using System.Configuration;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void Carregar_Controles()
        {
            string key, ativado;

            ConfigurationManager.RefreshSection("appSettings");

            foreach (var item in ConfigurationManager.AppSettings.AllKeys)
            {
                key = item.ToString();

                foreach (Control act in this.Controls)
                {
                    if(key == act.Name)
                    {
                        try
                        {
                            ativado = ConfigurationManager.AppSettings[key].ToString();
                            act.TabIndex = int.Parse(ativado);
                        }
                        catch 
                        {
                            
                        }
                    }
                }
            }

        }

        private void Configuracoes_Activated(object sender, EventArgs e)
        {
            Carregar_Controles();
        }

        private void Configuracoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            COD.All_True = true;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

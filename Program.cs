using System;
using  System.Windows.Forms;

namespace Setup
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {

                BD.TestarConexao();

                //Abre o formulário de boas vindas
                Application.Run(new Formularios.frmSplash());

                //Abre o formulário de login
                Formularios.frmLogin login = new Formularios.frmLogin();
                login.ShowDialog();

                //Verifica se o usuário realmente fez o login no sistema
                if (BD.UsuarioLogado == null || BD.UsuarioLogado == "")
                    Application.Exit();
                else
                {

                    //Formularios.frmUsuario usuario = new Formularios.frmUsuario();
                    //usuario.ShowDialog();

                    //Formularios.frmTestes teste = new Formularios.frmTestes();
                    //teste.ShowDialog();

                    Financas.frmMenu menu = new Financas.frmMenu();
                    menu.ShowDialog();

                }

            }
            catch
            {
                Formularios.frmConfigBD bd = new Formularios.frmConfigBD();
                bd.ShowDialog();
            }

        }
    }
}

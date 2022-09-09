using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            /*
            //Abre o formul�rio de boas vindas
            Application.Run(new Formularios.frmSplash());

            //Abre o formul�rio de login
            Formularios.frmLogin login = new Formularios.frmLogin();
            login.ShowDialog();

            //Verifica se o usu�rio realmente fez o login no sistema
            if (BD.UsuarioLogado == null || BD.UsuarioLogado == "")
                Application.Exit();
            else
            {
            
                //Abre o formul�rio principal
                Formularios.frmMain main = new Formularios.frmMain();
                main.ShowDialog();
            }
            

            Formularios.frmTesteCrud main = new Formularios.frmTesteCrud();
            main.ShowDialog();
            */

            Formularios.frmUsuario main = new Formularios.frmUsuario();
            main.ShowDialog();


        }
    }
}

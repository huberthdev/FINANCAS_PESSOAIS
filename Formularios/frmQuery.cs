using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmQuery : Form
    {
        public frmQuery()
        {
            InitializeComponent();
        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = txtSQL.Text;

            if (sql == "")
                return;

            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch
            {
                lista.DataSource = null;
            }
            
        }
    }
}

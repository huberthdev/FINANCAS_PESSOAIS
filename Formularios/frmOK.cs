using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmOK : Form
    {
        public frmOK()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmOK_Load(object sender, EventArgs e)
        {

        }
    }
}

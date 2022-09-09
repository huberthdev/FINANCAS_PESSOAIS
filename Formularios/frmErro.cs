using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmErro : Form
    {
        public frmErro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmErro_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmPergunta : Form
    {
        public frmPergunta()
        {
            InitializeComponent();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            COD.Resposta = false;
            this.Dispose();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            COD.Resposta = true;
            this.Dispose();
        }

        private void frmPergunta_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value++;
            }
            catch 
            {
                timer1.Enabled = false;
                this.Dispose();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

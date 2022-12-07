using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class boxAlterarCompra : Form
    {
        public boxAlterarCompra()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

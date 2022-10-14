using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas
{
    public partial class boxValor : Form
    {
        public boxValor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string saldo = "0,00";

            if (txtSaldo.Text != "")
                saldo = txtSaldo.Text;

            BD.SaldoInicial = BD.CvNum(saldo);

            this.Close();
        }
    }
}

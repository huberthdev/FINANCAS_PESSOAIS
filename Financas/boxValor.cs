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

        private void btnOK_Click(object sender, EventArgs e)
        {
            string saldo = "0,00";

            if (txtSaldo.Text != "")
                saldo = txtSaldo.Text;

            BD.SaldoInicial = BD.CvNum(saldo);

            this.Close();
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b") //Faz com que a tecla ESC limpe o campo
                this.Text = "";

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',' && this.Text.Contains(","))
                e.Handled = true;
        }
    }
}

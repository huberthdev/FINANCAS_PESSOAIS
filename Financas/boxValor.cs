using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}

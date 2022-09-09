using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COD.Erro("Houve um erro!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            COD.OK("Sucesso na operação!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            COD.Pergunta("Confirma a operação?");

            if (COD.Resposta == true)
                MessageBox.Show("Verdadeiro");
            else
                MessageBox.Show("Falso");
        }

        private void btnTesteSQL_Click(object sender, EventArgs e)
        {
            Formularios.frmTesteCrud TesteCrud = new Formularios.frmTesteCrud();
            TesteCrud.ShowDialog();
        }
    }
}

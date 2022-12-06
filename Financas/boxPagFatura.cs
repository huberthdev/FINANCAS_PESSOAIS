using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class boxPagFatura : Form
    {
        
        static double valor = 0;

        public boxPagFatura()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pagarFatura_Click(object sender, EventArgs e)
        {
            double valor = 0; int x = 0; string codigo; string sql; string cods = "";
            string conta = cbConta.Text;
            string[] ln = new string[lista.RowCount];

            string nConta = ((Classes.Conta)cbConta.SelectedItem).id.ToString();

            if (lista.RowCount == 0)
                return;

            try
            {
                valor = ValorDaFatura();

                if(valor == 0)
                    return;

                COD.Pergunta("Debitar valor da fatura: \r\n Valor: [" + valor.ToString("C") + "] \r\n Conta: ["+ conta +"]");
                if (!COD.Resposta)
                    return;
            }
            catch
            {

            }

            for (int i = 0; i < lista.RowCount; i++)
            {
                DataGridViewCheckBoxCell ck = new DataGridViewCheckBoxCell();
                ck = ((DataGridViewCheckBoxCell)lista.Rows[i].Cells[0]);

                if (ck.Value.ToString() == "1")
                {
                    ln[x++] = lista.Rows[i].Cells[3].Value.ToString();
                }
            }

            for (int i = 0; i < ln.Length; i++)
            {
                codigo = ln[i];
                if(codigo != null)
                    cods += codigo + ", ";
            }

            cods = cods.Remove(cods.Length - 2);

            sql = "UPDATE COMPRA_CREDITO SET STATUS = 1 WHERE COMPRA_CREDITO_ID IN(" + cods + ")";
            BD.ExecutarSQL(sql, "Fatura paga!");

            valor = valor * -1;
            Classes.Geral.AtualizarSaldoConta(nConta, BD.CvNum(valor.ToString()));

            this.Dispose();
        }

        private void lista_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            lista.ReadOnly = false;
            for (int i = 0; i < lista.ColumnCount; i++)
            {
                if (i != 0)
                {
                    lista.Columns[i].ReadOnly = true;
                }
            }
        }

        private void lista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < lista.RowCount; i++)
            {
                DataGridViewCheckBoxCell ck = new DataGridViewCheckBoxCell();

                ck = ((DataGridViewCheckBoxCell)lista.Rows[i].Cells[0]);
                ck.Value = 1;
            }
        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            if (lista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1")
                lista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            else
                lista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;

            ValorDaFatura();
        }

        private double ValorDaFatura()
        {
            string[] txt = lblPeriodo.Text.Split(" • ");
            string periodo = txt[0];
            valor = 0;

            for (int i = 0; i < lista.RowCount; i++)
            {
                DataGridViewCheckBoxCell ck = new DataGridViewCheckBoxCell();
                ck = ((DataGridViewCheckBoxCell)lista.Rows[i].Cells[0]);

                if (ck.Value.ToString() == "1")
                {
                    valor += double.Parse(lista.Rows[i].Cells[5].Value.ToString());
                }
            }

            lblPeriodo.Text = periodo + " • " + valor.ToString("N");
            lblPeriodo.Tag = valor;
            return valor;
        }
    }
}

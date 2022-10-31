using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class boxPagFatura : Form
    {
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
            if (lista.RowCount == 0)
                return;

            string vetor = "";

            for (int i = 1; i < lista.RowCount; i++)
            {
                if(lista.Rows[i].Cells[0].Value.ToString() != null)
                {
                    vetor += lista.Rows[i].Cells[1].Value.ToString() + ", ";
                }
            }
        }

        private void boxPagFatura_Load(object sender, EventArgs e)
        {
            CarregarCB();
        }

        private void CarregarCB()
        {
            cbConta.Items.Clear();
            foreach (Classes.Conta c in Classes.Conta.Lista())
            {
                cbConta.Items.Add(c);
            }
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

        private void lista_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.RowCount; i++)
            {

            }
        }
    }
}

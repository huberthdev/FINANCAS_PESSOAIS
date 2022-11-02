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
            if (lista.RowCount == 0)
                return;

            COD.OK(lblPeriodo.Tag.ToString());
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

        private void ValorDaFatura()
        {
            valor = 0;
            string[] txt = lblPeriodo.Text.Split(" • ");
            string periodo = txt[0];

            for (int i = 0; i < lista.RowCount; i++)
            {
                DataGridViewCheckBoxCell ck = new DataGridViewCheckBoxCell();
                ck = ((DataGridViewCheckBoxCell)lista.Rows[i].Cells[0]);

                if (ck.Value.ToString() == "1")
                {
                    valor += double.Parse(lista.Rows[i].Cells[6].Value.ToString());
                }
            }

            lblPeriodo.Text = periodo + " • " + valor.ToString("N");
            lblPeriodo.Tag = valor;
        }
    }
}

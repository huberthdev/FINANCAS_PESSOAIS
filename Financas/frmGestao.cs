﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas
{
    public partial class frmGestao : Form
    {
        public frmGestao()
        {
            InitializeComponent();
        }

        private void frmGestao_Load(object sender, EventArgs e)
        {
            CarregarCbMesAno();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MudarPeriodo();
        }

        private void next_Click(object sender, EventArgs e)
        {
            MudarPeriodo(1);
        }

        private void CarregarCbMesAno()
        {
            ToolStripComboBox ano = new ToolStripComboBox();

            foreach (ToolStripItem item in menuStrip1.Items)
            {
                if(item.Name == "ano")
                {
                    string sql = "SELECT DISTINCT EXTRACT(YEAR FROM DATA) FROM BD UNION SELECT DISTINCT EXTRACT(YEAR FROM DATA_COMPRA) FROM KEY_COMPRA_CREDITO";
                    BD.Buscar(sql);

                    ano = ((ToolStripComboBox)item);

                    for (int i = 0; i < BD.Resultado.Rows.Count; i++)
                    {
                        ano.Items.AddRange(new object[] { (BD.Resultado.Rows[i][0].ToString()) });
                    }

                    ano.Text = DateTime.Today.Year.ToString();
                }
            }
        }

        private void MudarPeriodo(int x = 0)
        {
            string ano = menuStrip1.Items["ano"].Text;

            if (x == 0)
            {
                ano = (int.Parse(ano) - 1).ToString();
            }
            else
            {
                ano = (int.Parse(ano) + 1).ToString();
            }

            menuStrip1.Items["ano"].Text = ano;
        }

        private void Carregar_Lista()
        {
            string sql, ano, pagFatura;

            ano = menuStrip1.Items["ano"].Text;

            pagFatura = Classes.Classe.GetID("Pag. Fatura");

            if (ano == "")
                return;

            for (int i = 1; i < 13; i++)
            {
                sql = "UPDATE VISAO_ANUAL SET VISAO_ANUAL.RECEITA = (SELECT IIF(SUM(VALOR) IS NULL, 0, SUM(VALOR)) FROM BD ";
                sql += "WHERE VALOR > 0 AND EXTRACT(YEAR FROM DATA) = "+ ano +" AND EXTRACT(MONTH FROM DATA) = "+ i +") WHERE MES = "+ i +"";
                BD.ExecutarSQL(sql);
            }

            for (int i = 1; i < 13; i++)
            {
                if (optDtParc.Checked)
                {
                    sql = "UPDATE VISAO_ANUAL SET VISAO_ANUAL.DESPESA = (SELECT SUM(VALOR) FROM ";
                    sql += "(SELECT IIF(ABS(SUM(VALOR)) IS NULL, 0, ABS(SUM(VALOR))) AS VALOR FROM BD WHERE VALOR < 0 AND ";
                    sql += "EXTRACT(YEAR FROM DATA) = " + ano + " AND EXTRACT(MONTH FROM DATA) = " + i + " ";
                    sql += "UNION SELECT IIF(SUM(VALOR) IS NULL, 0, SUM(VALOR)) AS VALOR FROM COMPRA_CREDITO WHERE ";
                    sql += "VALOR > 0 AND EXTRACT(YEAR FROM DATA_PARCELA) = " + ano + " AND EXTRACT(MONTH FROM DATA_PARCELA) = " + i + ")) WHERE MES = " + i + "";
                }
                else
                {
                    sql = "UPDATE VISAO_ANUAL SET VISAO_ANUAL.DESPESA = (SELECT SUM(VALOR) AS VALOR FROM(SELECT ABS(SUM(A.VALOR)) AS VALOR FROM BD A INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE A.VALOR < 0 AND EXTRACT(MONTH FROM A.DATA) = " + i + " AND EXTRACT(YEAR FROM A.DATA) = " + ano + " UNION SELECT SUM(B.VALOR) AS VALOR FROM KEY_COMPRA_CREDITO B INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID WHERE EXTRACT(MONTH FROM b.DATA_compra) = " + i + " AND EXTRACT(YEAR FROM b.DATA_compra) = " + ano + " AND C.CLASSE_ID <> "+ pagFatura + ")) WHERE MES = " + i + "";
                }

                try
                {
                    BD.ExecutarSQL(sql);
                }
                catch
                {

                }
                
            }

            sql = "UPDATE VISAO_ANUAL SET DESVIO = RECEITA - DESPESA";
            BD.ExecutarSQL(sql);

            sql = "SELECT MES, ";
            sql += "CASE MES WHEN 1 THEN 'JANEIRO' WHEN 2 THEN 'FEVEREIRO' WHEN 3 THEN 'MARÇO' WHEN 4 THEN 'ABRIL' ";
            sql += "WHEN 5 THEN 'MAIO' WHEN 6 THEN 'JUNHO' WHEN 7 THEN 'JULHO' WHEN 8 THEN 'AGOSTO' WHEN 9 THEN 'SETEMBRO' ";
            sql += "WHEN 10 THEN 'OUTUBRO' WHEN 11 THEN 'NOVEMBRO' WHEN 12 THEN 'DEZEMBRO' END AS MES_NOME, ";
            sql += "IIF(RECEITA = 0, NULL, RECEITA) AS RECEITA, IIF(DESPESA = 0, NULL, DESPESA) AS DESPESA, ";
            sql += "IIF(DESVIO = 0, NULL, DESVIO) AS DESVIO FROM VISAO_ANUAL ";

            sql += "UNION SELECT 13 AS MES, 'TOTAL "+ ano +"' AS MES_NOME, IIF(SUM(RECEITA) = 0, NULL, SUM(RECEITA)) AS RECEITA, ";
            sql += "IIF(SUM(DESPESA) = 0, NULL, SUM(DESPESA)) AS DESPESA, IIF(SUM(DESVIO) = 0, NULL, SUM(DESVIO)) AS DESVIO ";
            sql += "FROM VISAO_ANUAL";
            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch 
            {
                
            }
        }

        private void Formatar_Lista()
        {
            string valor;

            if (lista.RowCount == 0)
                return;

            for (int i = 0; i < lista.RowCount; i++)
            {
                lista.Rows[i].Cells["RECEITA"].Style.ForeColor = Color.FromArgb(64, 192, 87);
                lista.Rows[i].Cells["DESPESA"].Style.ForeColor = Color.Tomato;

                valor = lista.Rows[i].Cells["DESVIO"].Value.ToString();
                if (valor.Contains("-"))
                    lista.Rows[i].Cells["DESVIO"].Style.ForeColor = Color.Tomato;
                else
                    lista.Rows[i].Cells["DESVIO"].Style.ForeColor = Color.FromArgb(64, 192, 87);
            }
        }

        private void lista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Formatar_Lista();
        }

        private void ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista.Focus();
            Carregar_Lista();
        }

        private void optDtParc_Click(object sender, EventArgs e)
        {
            Carregar_Lista();
        }

        private void optDtCompra_Click(object sender, EventArgs e)
        {
            Carregar_Lista();
        }

        private void optDtParc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

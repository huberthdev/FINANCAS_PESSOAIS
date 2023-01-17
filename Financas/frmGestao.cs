using System;
using System.Windows.Forms;

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
            Carregar_Lista();
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
            Carregar_Lista();
        }

        private void Carregar_Lista()
        {
            string sql, ano;

            ano = menuStrip1.Items["ano"].Text;

            for (int i = 1; i < 13; i++)
            {
                sql = "UPDATE VISAO_ANUAL SET VISAO_ANUAL.RECEITA = (SELECT IIF(SUM(VALOR) IS NULL, 0, SUM(VALOR)) FROM BD ";
                sql += "WHERE VALOR > 0 AND EXTRACT(YEAR FROM DATA) = "+ ano +" AND EXTRACT(MONTH FROM DATA) = "+ i +") WHERE MES = "+ i +"";
                BD.ExecutarSQL(sql);
            }

            for (int i = 1; i < 13; i++)
            {
                sql = "UPDATE VISAO_ANUAL SET VISAO_ANUAL.DESPESA = (SELECT SUM(VALOR) FROM ";
                sql += "(SELECT IIF(ABS(SUM(VALOR)) IS NULL, 0, ABS(SUM(VALOR))) AS VALOR FROM BD WHERE VALOR < 0 AND ";
                sql += "EXTRACT(YEAR FROM DATA) = "+ ano +" AND EXTRACT(MONTH FROM DATA) = "+ i +" ";
                sql += "UNION SELECT IIF(ABS(SUM(VALOR)) IS NULL, 0, ABS(SUM(VALOR))) AS VALOR FROM COMPRA_CREDITO WHERE ";
                sql += "EXTRACT(YEAR FROM DATA_PARCELA) = " + ano + " AND EXTRACT(MONTH FROM DATA_PARCELA) = " + i + ")) WHERE MES = " + i + "";
                BD.ExecutarSQL(sql);
            }

            sql = "UPDATE VISAO_ANUAL SET DESVIO = RECEITA - DESPESA";
            BD.ExecutarSQL(sql);

            sql = "SELECT * FROM VISAO_ANUAL";
            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch 
            {

            }
        }
    }
}

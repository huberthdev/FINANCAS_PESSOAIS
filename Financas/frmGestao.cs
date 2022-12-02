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


    }
}

using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Setup.Formularios
{
    public partial class frmQuery : Form
    {
        public frmQuery()
        {
            InitializeComponent();
            CarregarTreeTabelas();
        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = txtSQL.Text;
            string limite;
            int n;

            int nivel = treeTabelas.SelectedNode.Level;

            limite = menuStrip1.Items[2].Text;

            if (int.TryParse(limite, out n) == false)
            {
                limite = "1000";
                menuStrip1.Items[2].Text = limite;
            }

            if (sql == "")
                return;

            if(!sql.Contains("SELECT FIRST"))
                sql = sql.Replace("SELECT", "SELECT FIRST "+ limite +"");

            CarregarSQL(sql);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "";
            lista.DataSource = null;
            CarregarBarraStatus();
        }

        private void selectFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql;
            string tabela;
            string coluna;
            string limite;
            int n;

            int nivel = treeTabelas.SelectedNode.Level;

            limite = menuStrip1.Items[2].Text;

            if (int.TryParse(limite, out n) == false)
            {
                limite = "1000";
                menuStrip1.Items[2].Text = limite;
            }  

            if (nivel == 1)
            {
                tabela = treeTabelas.SelectedNode.Parent.FullPath;
                coluna = treeTabelas.SelectedNode.Text;
            }
            else
            {
                tabela = treeTabelas.SelectedNode.FullPath;
                coluna = "";
            }

            tabela = tabela.Trim();
            coluna = coluna.Trim();

            if (coluna == "")
                sql = "SELECT FIRST "+ limite +" * FROM " + tabela + "";
            else
                sql = "SELECT FIRST " + limite +" " + coluna + " FROM " + tabela + "";

            txtSQL.Text = sql;

            CarregarSQL(sql);
        }

        private void CarregarSQL(string sql)
        {
            try
            {
                lista.DataSource = BD.Buscar(sql);
            }
            catch
            {
                lista.DataSource = null;
            }

            CarregarBarraStatus();
        }

        private void CarregarBarraStatus()
        {
            int lin = lista.Rows.Count;

            if (lin == 1)
                status.Items[0].Text = "1 linha";
            else
                status.Items[0].Text = lin + " linhas";
        }

        private void CarregarTreeTabelas()
        {
            string tabela;
            string sql;
            string coluna;

            treeTabelas.Nodes.Clear();

            try
            {
                sql = "SELECT RDB$RELATION_NAME AS TABELAS FROM RDB$RELATIONS WHERE RDB$VIEW_BLR IS NULL ";
                sql += "AND (RDB$SYSTEM_FLAG = 0 OR RDB$SYSTEM_FLAG IS NULL)";

                BD.Buscar(sql);

                for (int i = 0; i < BD.Resultado.Rows.Count; i++)
                {
                    tabela = BD.Resultado.Rows[i][0].ToString();
                    tabela = tabela.Trim();
                    treeTabelas.Nodes.Add(tabela);
                }

            }
            catch
            {
                return;
            }

            for (int i = 0; i < treeTabelas.Nodes.Count; i++)
            {
                tabela = treeTabelas.Nodes[i].Text;
                sql = "select rdb$field_name from rdb$relation_fields ";
                sql += "where rdb$relation_name = '" + tabela + "'";
                BD.Buscar(sql);

                for (int x = 0; x < BD.Resultado.Rows.Count; x++)
                {
                    coluna = BD.Resultado.Rows[x][0].ToString();
                    coluna = coluna.Trim();
                    treeTabelas.Nodes[i].Nodes.Add(coluna);
                }
            }

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarTreeTabelas();
        }

        private void frmQuery_Activated(object sender, EventArgs e)
        {
            
        }

        private void exp_excel_Click(object sender, EventArgs e)
        {
            decimal porc;

            Excel.Application XcelApp = new Excel.Application();
            Excel.Range celulas;

            if (lista.Rows.Count > 0)
            {
                int ln = lista.Rows.Count;

                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < lista.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = lista.Columns[i - 1].HeaderText;
                    }
                    //

                    lblPorc.Visible = true;
                    progresso.Visible = true;
                    progresso.Value = 1;
                    progresso.Maximum = lista.Rows.Count;

                    for (int i = 0; i < lista.Rows.Count; i++)
                    {
                        int p = i + 1;

                        try
                        {
                            porc = Decimal.Divide(p, ln);
                            lblPorc.Text = porc.ToString("P0");

                            progresso.Value++;
                        }
                        catch
                        {
                            lblPorc.Visible = false;
                            progresso.Visible = false;
                        }

                        for (int j = 0; j < lista.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = lista.Rows[i].Cells[j].Value;
                        }
                    }
                    //
                    celulas = XcelApp.Range["A1", "A1"].CurrentRegion;
                    celulas.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    COD.Erro("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }

        }
    }
}

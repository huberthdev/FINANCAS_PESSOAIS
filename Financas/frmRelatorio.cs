using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();

            txtDataInicio.Text = "01/" + DateTime.Today.ToString("MM/yyyy");

            CarregarCbClassesContas();
            CarregarLista();
        }

        private void CarregarLista(string sql = "")
        {
            string classe = "";
            string conta = "";

            string data1 = txtDataInicio.Text.Replace("/", ".");
            string data2 = txtDataFim.Text.Replace("/", ".");

            if (data1 == "")
                data1 = "01.01.1900";

            if (data2 == "")
                data2 = "31.12.9999";

            lista.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (sql == "")
            {
                //MONTAGEM DO SQL COM TODAS AS CONDIÇÕES DE FILTRO NA TABELA BD - RECEITAS E DESPESAS
                sql = "SELECT A.BD_ID AS ID, 'D' AS TIPO, A.DATA, B.CLASSE, A.VALOR, A.DESCRICAO AS DESC FROM BD A ";
                sql += "INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE A.DATA BETWEEN ";
                sql += "CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE) ";
                
                if (ckReceita.Checked == true && ckDespesa.Checked == false)
                    sql += "AND A.VALOR > 0 ";
                else if (ckReceita.Checked == false && ckDespesa.Checked == true)
                    sql += "AND A.VALOR < 0 ";

                //FILTRO CLASSE
                if (cbClasse.Text != "")
                {
                    classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();
                    sql += "AND A.CLASSE = "+ classe +" ";
                }

                //FILTRO CONTA
                if (cbConta.Text != "")
                {
                    conta = ((Classes.Conta)cbConta.SelectedItem).id.ToString();
                    sql += "AND A.CONTA = " + conta + " ";
                }

                sql += "UNION SELECT TRANSFERENCIA_ID AS ID, 'T' AS TIPO, DATA, ";
                sql += "'TRANSF. ENTRE CONTAS' AS CLASSE, VALOR, DESCRICAO AS DESC ";
                sql += "FROM TRANSFERENCIA WHERE DATA BETWEEN ";
                sql += "CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE)";

                try
                {
                    lista.DataSource = BD.Buscar(sql);
                }
                catch (Exception ex)
                {
                    status.Items[0].Text = ex.Message.ToString();
                }

                //PREENCHE A BARRA DE STATUS A QUANTIDADE DE LINHAS DA LISTA
                status.Items[0].Text = "LINHAS: " + lista.RowCount;

                Formatacao_Condicional();
                SomarColunaValor();
            }

        }

        private void CarregarCbClassesContas(string campo = "")
        {
            //Preenche o combobox com as classes cadastradas no banco de dados
            if(campo=="classe" || campo == "")
            {
                cbClasse.Items.Clear();
                if (ckReceita.Checked == true && ckDespesa.Checked == false || ckReceita.Checked == false && ckDespesa.Checked == true)
                {
                    cbClasse.Items.Clear();
                    cbClasse.Items.Add("");
                    Classes.Classe.Tipo = Convert.ToByte(ckReceita.Checked);
                    foreach (Classes.Classe c in Classes.Classe.Lista())
                    {
                        cbClasse.Items.Add(c);
                    }
                }
            }

            //Preenche o combobox com as contas cadastradas no banco de dados
            if(campo=="conta" || campo == "")
            {
                cbConta.Items.Clear();
                cbConta.Items.Add("");
                foreach (Classes.Conta c in Classes.Conta.Lista())
                {
                    cbConta.Items.Add(c);
                }

            }
        }

        private void SomarColunaValor()
        {
            string tipo;
            double valor = 0;

            if (lista.RowCount == 0)
            {
                status.Items[0].Text += " | Soma: 0,00";
                return;
            }

            for (int i = 0; i < lista.RowCount; i++)
            {
                tipo = lista.Rows[i].Cells[1].Value.ToString();
                if(tipo=="D")
                    valor = valor + double.Parse(lista.Rows[i].Cells[4].Value.ToString());
            }

            status.Items[0].Text += " | Soma: " + valor.ToString("c");
        }

        private void Formatacao_Condicional()
        {
            double valor;

            if (lista.RowCount == 0)
                return;

            for (int i = 0; i < lista.RowCount; i++)
            {
                valor = double.Parse(lista.Rows[i].Cells[4].Value.ToString());
                if (valor < 0)
                {
                    lista.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                }
                else
                {
                    lista.Rows[i].Cells[4].Style.ForeColor = Color.Green;
                }

                if (lista.Rows[i].Cells[1].Value.ToString()=="T")
                {
                    for (int c = 0; c < lista.ColumnCount; c++)
                    {
                        lista.Rows[i].Cells[c].Style.ForeColor = Color.Fuchsia;
                    }
                }
            }

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void ckReceita_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckDespesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            string id;
            string tipo;

            try
            {
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();
                id = lista.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                COD.Erro("Selecione uma linha na lista!");
                return;
            }

            if (tipo == "T")
            {
                Classes.Geral.ExcluirTransferencia(id);
            }
            else if(tipo == "D")
            {
                Classes.Geral.ExcluirLancamento(id);
            }

            CarregarLista();
        }

        private void lista_SelectionChanged(object sender, EventArgs e)
        {
            string tipo;

            try
            {
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }

            if (tipo != "D")
                menuStrip1.Items[2].Enabled = false;
            else
                menuStrip1.Items[2].Enabled = true;
        }

        private void cbClasse_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void cbConta_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void limparFiltro_Click(object sender, EventArgs e)
        {
            COD.LimparCampos(this);
            txtDataInicio.Text = "01/" + DateTime.Today.ToString("MM/yyyy");
            ckReceita.Checked = false;
            ckDespesa.Checked = false;
        }

        private void ckReceita_Click(object sender, EventArgs e)
        {
            CarregarLista();
            CarregarCbClassesContas("classe");
        }

        private void ckDespesa_Click(object sender, EventArgs e)
        {
            CarregarLista();
            CarregarCbClassesContas("classe");
        }
    }
}

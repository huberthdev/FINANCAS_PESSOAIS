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

            int mes = DateTime.Today.Month;
            int ano = DateTime.Today.Year;
            int ultDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

            txtDataInicio.Value = new DateTime(ano, mes, 01);
            txtDataFim.Value = new DateTime(ano, mes, ultDia);

            CarregarCbClassesContas();
        }

        private void CarregarLista(string sql = "")
        {
            string classe, conta, descricao = "";
            string data1 = "", data2 = "";

            if (txtDataInicio.Checked)
            {
                data1 = BD.CvData(txtDataInicio.Value.ToShortDateString());
            }

            if (txtDataFim.Checked)
            {
                data2 = BD.CvData(txtDataFim.Value.ToShortDateString());
            }

            string v1 = BD.CvNum(txtValor1.Text);
            string v2 = BD.CvNum(txtValor2.Text);

            if (data1 == "")
                data1 = "01.01.1900";

            if (data2 == "")
                data2 = "31.12.9999";

            if(txtDescricao.Text != "")
                descricao = "%" + txtDescricao.Text.Replace("*", "%").ToUpper().Trim() + "%";

            lista.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (sql == "")
            {
                //MONTAGEM DO SQL COM TODAS AS CONDIÇÕES DE FILTRO NA TABELA BD - RECEITAS E DESPESAS
                sql = "SELECT A.BD_ID AS ID, 'D' AS TIPO, A.DATA, B.CLASSE, A.VALOR, A.DESCRICAO AS DESC FROM BD A ";
                sql += "INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID WHERE A.DATA BETWEEN ";
                sql += "CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE) ";

                if(descricao != "")
                {
                    sql += "AND UPPER(A.DESCRICAO) LIKE '" + descricao + "' ";
                }

                if (ckReceita.Checked == true && ckDespesa.Checked == false)
                {
                    if(txtValor1.Text == "" && txtValor2.Text == "")
                        sql += "AND A.VALOR > 0 ";
                    else if(txtValor1.Text != "" && txtValor2.Text == "")
                        sql += "AND A.VALOR BETWEEN CAST(" + v1 + " AS DECIMAL) AND 1000000 ";
                    else if (txtValor1.Text == "" && txtValor2.Text != "")
                        sql += "AND A.VALOR BETWEEN 0 AND CAST(" + v2 + " AS DECIMAL) ";
                    else if (txtValor1.Text != "" && txtValor2.Text != "")
                        sql += "AND A.VALOR BETWEEN CAST(" + v1 + " AS DECIMAL) AND CAST(" + v2 + " AS DECIMAL) ";
                }
                else if (ckReceita.Checked == false && ckDespesa.Checked == true)
                {
                    v1 = "-" + v1;
                    v2 = "-" + v2;

                    if (txtValor1.Text == "" && txtValor2.Text == "")
                        sql += "AND A.VALOR < 0 ";
                    else if (txtValor1.Text != "" && txtValor2.Text == "")
                        sql += "AND A.VALOR BETWEEN CAST(" + v1 + " AS DECIMAL) AND 0 ";
                    else if (txtValor1.Text == "" && txtValor2.Text != "")
                        sql += "AND A.VALOR BETWEEN -1000000 AND CAST(" + v2 + " AS DECIMAL) ";
                    else if (txtValor1.Text != "" && txtValor2.Text != "")
                        sql += "AND A.VALOR BETWEEN CAST(" + v2 + " AS DECIMAL) AND CAST(" + v1 + " AS DECIMAL) ";
                }
                    
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

                //MONTAGEM DO SQL COM TODAS AS CONDIÇÕES DE FILTRO NA TABELA TRANSFERENCIA
                sql += "UNION SELECT TRANSFERENCIA_ID AS ID, 'T' AS TIPO, DATA, ";
                sql += "'TRANSF. ENTRE CONTAS' AS CLASSE, VALOR, DESCRICAO AS DESC ";
                sql += "FROM TRANSFERENCIA WHERE DATA BETWEEN ";
                sql += "CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE) ";

                //MONTAGEM DO SQL COM TODAS AS CONDIÇÕES DE FILTRO NA TABELA COMPRA_CREDITO
                if (!(!ckDespesa.Checked && ckReceita.Checked))
                {
                    sql += "UNION SELECT A.COMPRA_CREDITO_ID AS ID, 'C' AS TIPO, B.DATA_COMPRA AS DATA, ";
                    sql += "C.CLASSE, (B.VALOR * -1) AS VALOR, B.DESCRICAO AS DESC FROM COMPRA_CREDITO A INNER JOIN ";
                    sql += "KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE INNER JOIN CLASSE C ";
                    sql += "ON B.CLASSE = C.CLASSE_ID WHERE A.DATA_PARCELA BETWEEN ";
                    sql += "CAST('" + data1 + "' AS DATE) AND CAST('" + data2 + "' AS DATE) ";
                    if (descricao != "")
                    {
                        sql += "AND UPPER(B.DESCRICAO) LIKE '" + descricao + "' ";
                    }

                    //FILTRO CLASSE
                    if (cbClasse.Text != "")
                    {
                        classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();
                        sql += "AND C.CLASSE_ID = " + classe + " ";
                    }
                }

            }

            try
            {
                status.Items["totalLn"].Text = "";
                status.Items["totalLn"].Image = null;
                lista.DataSource = BD.Buscar(sql);
            }
            catch (Exception ex)
            {
                status.Items["totalLn"].Text = ex.Message.ToString();
            }

            //PREENCHE A BARRA DE STATUS A QUANTIDADE DE LINHAS DA LISTA
            status.Items["totalLn"].Text = "LINHAS: " + lista.RowCount;

            if(txtValor1.Text != "" && txtValor2.Text != "")
            {
                v1 = txtValor1.Text;
                v2 = txtValor2.Text;
                if(Math.Abs(decimal.Parse(v1)) > Math.Abs(decimal.Parse(v2)))
                {
                    status.Items["totalLn"].Text = "No Filtro: O campo Valor1 não pode ser 'MAIOR' que o campo Valor2";
                    status.Items["totalLn"].Image = imageList1.Images[1];
                }
            }

            //Thread.Sleep(5000);
            Formatacao_Condicional();
            SomarColunaValor();
        }

        public void CarregarCbClassesContas(string campo = "")
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

        /// <summary>
        /// Funcão para somar a coluna de valor do relatório. Os valores referente
        /// às transferências não são contabilizadas na soma total.
        /// </summary>
        private void SomarColunaValor()
        {
            string tipo;
            double valor = 0;

            status.Items["total"].ForeColor = Color.Turquoise;

            if (lista.RowCount == 0)
            {
                status.Items["total"].Text = "Total: R$ 0,00";
                return;
            }

            for (int i = 0; i < lista.RowCount; i++)
            {
                tipo = lista.Rows[i].Cells[1].Value.ToString();
                if(tipo == "D" || tipo == "C")
                {
                    valor += double.Parse(lista.Rows[i].Cells[4].Value.ToString());
                }
            }

            status.Items["total"].Text = "Total: " + valor.ToString("C");

            if(valor < 0)
            {
                status.Items["total"].ForeColor = Color.Red;
            }
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
                else if (lista.Rows[i].Cells[1].Value.ToString() == "C")
                {
                    for (int c = 0; c < lista.ColumnCount; c++)
                    {
                        lista.Rows[i].Cells[c].Style.ForeColor = Color.Turquoise;
                    }
                }
            }

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarLista();
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
            else if (tipo == "C")
            {
                Classes.Geral.ExcluirCompraCredito(id);
            }

            CarregarLista();
        }

        private void lista_SelectionChanged(object sender, EventArgs e)
        {
            string tipo;
            double soma = 0;

            try
            {
                tipo = lista.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }

            if (lista.SelectedRows.Count > 1)
            {
                menuStrip1.Items[1].Enabled = false;
                menuStrip1.Items[2].Enabled = false;
            }
            else
            {
                menuStrip1.Items[1].Enabled = true;
                menuStrip1.Items[2].Enabled = true;

                if (tipo != "D")
                    menuStrip1.Items[2].Enabled = false;
                else
                    menuStrip1.Items[2].Enabled = true;
            }

            status.Items["somaLn"].Text = "";

            if (lista.SelectedRows.Count > 1)
            {
                for (int i = 0; i < lista.RowCount; i++)
                {
                    if (lista.Rows[i].Selected)
                    {
                        soma += double.Parse(lista.Rows[i].Cells[4].Value.ToString());
                    }
                }

                status.Items["somaLn"].Text = "Seleção: " + soma.ToString("C");

                status.Items["somaLn"].ForeColor = Color.White;

                if (soma < 0)
                {
                    status.Items["somaLn"].ForeColor = Color.Red;
                }
                else if(soma > 0)
                {
                    status.Items["somaLn"].ForeColor = Color.Green;
                }
            }

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

        private void frmRelatorio_Activated(object sender, EventArgs e)
        {
            Formatacao_Condicional();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            string id, tipo;

            if (lista.RowCount == 0)
                return;

            id = lista.SelectedRows[0].Cells[0].Value.ToString();
            tipo = lista.SelectedRows[0].Cells[1].Value.ToString();

            Classes.Geral.AbrirDetalheTransacao(id, tipo);
        }

        private void lista_Sorted(object sender, EventArgs e)
        {
            Formatacao_Condicional();
        }

        private void txtDataInicio_ValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void txtDataFim_ValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }
    }
}

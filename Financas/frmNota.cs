using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class frmNota : Form
    {
        public frmNota()
        {
            InitializeComponent();        
            CarregarLista();
        }

        private void lblCor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblCor.BackColor = colorDialog1.Color;
                lblFaixa.BackColor = colorDialog1.Color;
            }
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            if (txtTitulo.Tag.ToString() == "0" && txtTexto.TextLength <= 36)
            {
                txtTitulo.Text = txtTexto.Text.ToUpper();
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTitulo.Tag = "1";
        }

        private void SalvarNota()
        {
            string titulo;
            int cor;

            if (txtTitulo.Text.Trim() == "")
                titulo = DateTime.Now.ToString();
            else
                titulo = txtTitulo.Text.Trim();

            string[] c = new string[4];
            string[] v = new string[4];

            c[0] = "titulo";
            v[0] = titulo;

            c[1] = "texto";
            v[1] = txtTexto.Text.Trim();

            c[2] = "cor";
            cor = lblCor.BackColor.ToArgb();
            v[2] = cor.ToString();

            c[3] = "hash";
            v[3] = COD.CriptografiaMd5(titulo.Trim() + txtTexto.Text.Trim());
                     
            BD.Salvar("NOTA", c, v);

            COD.LimparCampos(this);
        }

        private void CarregarLista()
        {             
            try
            {                            
                lista.DataSource = BD.Buscar("SELECT * FROM NOTA");
                lista.Columns[0].Visible = false;
                lista.Columns[3].Visible = false;
                lista.Columns[4].Visible = false;

                ColorirLinhas();
            }
            catch
            {
                return;
            }
            
        }

        private void ColorirLinhas()
        {
            String c;
            int cor;

            for (int i = 0; i < lista.Rows.Count; i++)
            {
                c = lista.Rows[i].Cells[3].Value.ToString();
                cor = int.Parse(c);

                lista.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(cor);
                lista.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(cor);
                lista.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(cor);
                lista.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(cor);
            }
        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            string[] hash = new string[2];

            hash[0] = txtTitulo.Text.Trim() + txtTexto.Text.Trim();
            hash[0] = COD.CriptografiaMd5(hash[0]);

            try
            {
                hash[1] = BD.Buscar("SELECT HASH FROM NOTA WHERE HASH = '" + hash[0] + "'").Rows[0][0].ToString();
            }
            catch
            {
                if(hash[1] == null)
                {
                    if (txtTexto.Text.Trim() != "" || txtTitulo.Text.Trim() != "")
                    {
                        SalvarNota();
                        CarregarLista();
                    }
                }
                
            }
            
        }

        private void frmNota_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTitulo.Text.Trim() != "" || txtTexto.Text.Trim() != "")
            {
                COD.Pergunta("Deseja sair sem salvar?");
                if (COD.Resposta == false)
                {
                    e.Cancel = true;
                    return;
                }
            }

            e.Cancel = false;
        }

        private void lista_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (lista.Rows.Count == 0)
                return;

            String id;

            try
            {
                id = lista.Rows[e.Row.Index].Cells[0].Value.ToString();

                COD.Pergunta("Excluir nota selecionada?");
                if (COD.Resposta == false)
                {
                    e.Cancel = true;
                    return;
                }

                e.Cancel = true;
                BD.Delete("NOTA", id);
                COD.LimparCampos(this);
            }
            catch
            {

            }

            try
            {
                CarregarLista();                
            }
            catch
            {
                
            }

        }

        private void lista_MouseClick(object sender, MouseEventArgs e)
        {
            
            if(lista.Rows.Count != 0)
            {
                string c;
                int cor;

                txtTitulo.Text = lista.CurrentRow.Cells[1].Value.ToString();
                txtTexto.Text = lista.CurrentRow.Cells[2].Value.ToString();

                c = lista.CurrentRow.Cells[3].Value.ToString();
                cor = int.Parse(c);

                lblCor.BackColor = Color.FromArgb(cor);
                lblFaixa.BackColor = Color.FromArgb(cor);
            }
        }

        private void frmNota_Activated(object sender, EventArgs e)
        {
            lista.AllowUserToDeleteRows = true;
            ColorirLinhas();
        }
    }
}

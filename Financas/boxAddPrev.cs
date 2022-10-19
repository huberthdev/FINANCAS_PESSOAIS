using System;
using System.Windows.Forms;
using System.Globalization;

namespace Setup.Financas
{
    public partial class boxAddPrev : Form
    {
        public boxAddPrev()
        {
            InitializeComponent();
            CarregarCBs();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string chave, valor, obs;
            int dia, mes, ano, classe;

            if (!COD.ValidarCampos(this))
            {
                return;
            }

            dia = int.Parse(cbDia.Text);
            mes = cbMes.SelectedIndex + 1;
            ano = int.Parse(cbAno.Text);
            classe = ((Classes.Classe)cbClasse.SelectedItem).id;

            chave = String.Concat(dia, mes, ano, classe);
            valor = BD.CvNum(txtValor.Text);
            obs = txtObs.Text;

            string[] c = new string[8];
            string[] v = new string[8];

            c[0] = "chave";
            v[0] = chave;

            c[1] = "dia";
            v[1] = dia.ToString();

            c[2] = "mes";
            v[2] = mes.ToString();

            c[3] = "ano";
            v[3] = ano.ToString();

            c[4] = "classe";
            v[4] = classe.ToString();

            c[5] = "valor";
            v[5] = valor;

            c[6] = "status";
            v[6] = "0";

            c[7] = "obs";
            v[7] = obs;

            BD.Salvar("PREVISAO", c, v);

        }

        private void CarregarCBs()
        {
            string mesNome;

            //Preenche o combobox com as classes cadastradas no banco de dados
            cbClasse.Items.Clear();
            Classes.Classe.Tipo = Convert.ToByte(optReceita.Checked);
            foreach (Classes.Classe c in Classes.Classe.Lista())
            {
                cbClasse.Items.Add(c);
            }
            //
            //Preenche o combobox com os Dias
            //
            for (int i = 1; i < 31; i++)
            {
                cbDia.Items.Add(i);
            }
            //
            //Preenche o combobox com os Meses
            //
            for (int i = 1; i < 13; i++)
            {
                mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(i).ToUpper();
                cbMes.Items.Add(mesNome);
            }
            //
            //Preenche o combobox com os Anos
            //
            for (int i = 0; i < 3; i++)
            {
                cbAno.Items.Add(DateTime.Today.Year - 1 + i);
            }

        }

        private void optReceita_Click(object sender, EventArgs e)
        {
            CarregarCBs();
        }

        private void optDespesa_Click(object sender, EventArgs e)
        {
            CarregarCBs();
        }
    }
}

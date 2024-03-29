﻿using System;
using System.Globalization;
using System.Windows.Forms;

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
            string id, sql, chave, valor, obs;
            int dia, mes, ano, classe;

            if (!COD.ValidarCampos(this))
            {
                return;
            }

            dia = int.Parse(cbDia.Text);
            mes = cbMes.SelectedIndex + 1;
            ano = int.Parse(cbAno.Text);
            classe = ((Classes.Classe)cbClasse.SelectedItem).id;

            chave = String.Concat(dia, ".", mes, ".", ano, ".", classe);
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

            sql = "SELECT PREVISAO_ID FROM PREVISAO WHERE MES = "+ mes +" AND ANO = "+ ano +" AND CLASSE = "+ classe +"";
            
            try
            {
                BD.Buscar(sql);
                id = BD.Resultado.Rows[0][0].ToString();
                BD.Salvar("PREVISAO", c, v, int.Parse(id), "Previsão alterada!");
            }
            catch
            {
                BD.Salvar("PREVISAO", c, v, Msg:"Previsão salva!");
            }

            RecarregarPrevisao();
        }

        private void RecarregarPrevisao()
        {
            Form frm = ((frmPrevisao)Application.OpenForms["frmPrevisao"]);

            if (frm.Controls["panel"].CausesValidation == true)
                frm.Controls["panel"].CausesValidation = false;
            else
                frm.Controls["panel"].CausesValidation = true;
        }

        public void CarregarCBs(string x = "", string classe = "", string dia = "", string mes = "", string ano = "")
        {
            string mesNome;

            //Preenche o combobox com as classes cadastradas no banco de dados
                cbClasse.Items.Clear();
                Classes.Classe.Tipo = Convert.ToByte(optReceita.Checked);
                foreach (Classes.Classe c in Classes.Classe.Lista())
                {
                    cbClasse.Items.Add(c);
                }
                if (classe != "")
                    cbClasse.Text = classe;
            //
            //Preenche o combobox com os Dias
            //
            if (x == "")
            {
                cbDia.Items.Clear();
                for (int i = 1; i < 31; i++)
                {
                    cbDia.Items.Add(i);
                }
                if (dia != "")
                    cbDia.Text = dia;
                else
                    cbDia.Text = DateTime.Today.Day.ToString();
            }
            //
            //Preenche o combobox com os Meses
            //
            if (x == "")
            {
                cbMes.Items.Clear();
                for (int i = 1; i < 13; i++)
                {
                    mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(i).ToUpper();
                    cbMes.Items.Add(mesNome);
                }
                if (mes != "")
                    cbMes.Text = mes;
                else
                    cbMes.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month).ToUpper();
            }
            //
            //Preenche o combobox com os Anos
            //
            if (x == "")
            {
                cbAno.Items.Clear();
                for (int i = 0; i < 3; i++)
                {
                    cbAno.Items.Add(DateTime.Today.Year - 1 + i);
                }
                if (ano != "")
                    cbAno.Text = ano;
                else
                    cbAno.Text = DateTime.Today.Year.ToString();
            }

        }

        private void optReceita_Click(object sender, EventArgs e)
        {
            CarregarCBs(x:"x");
        }

        private void optDespesa_Click(object sender, EventArgs e)
        {
            CarregarCBs(x:"x");
        }

        private void boxAddPrev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void replicar_Click(object sender, EventArgs e)
        {
            string dia, mes, ano, classe, chave;

            dia = cbDia.Text;
            mes = (cbMes.SelectedIndex + 1).ToString();
            ano = cbAno.Text;
            classe = ((Classes.Classe)cbClasse.SelectedItem).id.ToString();
            chave = dia + "." + mes + "." + ano + "." + classe;

            Classes.Geral.ReplicarPrevisao(chave);

            this.Dispose();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            COD.ReleaseCapture();
            COD.SendMessage(this.Handle, COD.WM_NCLBUTTONDOWN, COD.HT_CAPTION, 0);
        }
    }
}

﻿using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void txtClasse_TextChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta("classe");
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta("conta");
        }

        private void optReceita_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void optDespesa_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListasClasseConta();
        }

        private void listaConta_MouseEnter(object sender, EventArgs e)
        {
            listaConta.ReadOnly = false;
            listaConta.Columns[1].ReadOnly = true;
        }

        private void listaConta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ck = "0";
            string id;

            if (listaConta.RowCount == 0)
                return;

            id = listaConta.SelectedRows[0].Cells[0].Value.ToString();

            if (e.ColumnIndex == 2)
            {
                listaConta.EndEdit();
                ck = listaConta.Rows[e.RowIndex].Cells[2].Value.ToString();

                string sql = "UPDATE CONTA SET CARTAO_CREDITO = " + ck + " WHERE CONTA_ID = " + id + "";
                BD.ExecutarSQL(sql);
            }
        }

        private void CarregarListasClasseConta(string tabela = "")
        {
            int tipo = Convert.ToInt32(optReceita.Checked);
            string classe = "%" + txtClasse.Text.Replace("*", "%").ToUpper() + "%";
            string conta = "%" + txtConta.Text.Replace("*", "%").ToUpper() + "%";

            if (tabela == "" || tabela == "classe")
            {
                listaClasse.DataSource = BD.Buscar("SELECT CLASSE_ID, CLASSE FROM CLASSE WHERE TIPO = " + tipo + " " +
                    "AND UPPER(CLASSE) LIKE '" + classe + "'");
            }

            if (tabela == "" || tabela == "conta")
            {
                listaConta.DataSource = BD.Buscar("SELECT CONTA_ID, CONTA, CARTAO_CREDITO AS CREDITO FROM CONTA WHERE " +
                    "UPPER(CONTA) LIKE '" + conta + "' ORDER BY CARTAO_CREDITO DESC");
                listaConta.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnExcluirClasse_Click(object sender, EventArgs e)
        {
            if (listaClasse.RowCount == 0) return;

            string id = listaClasse.CurrentRow.Cells[0].Value.ToString();
            string classe = listaClasse.CurrentRow.Cells[1].Value.ToString();

            COD.Pergunta("Excluir Classe: " + classe);
            if (COD.Resposta == false)
                return;

            if (BD.Delete("CLASSE", id).Item1)
                CarregarListasClasseConta();
        }

        private void btnSalvarClasse_Click(object sender, EventArgs e)
        {
            if (COD.ValidarCampos(gpClasse) == false)
                return;

            int tp = Convert.ToInt32(optReceita.Checked);
            int at = Convert.ToInt32(ckAtivoClasse.Checked);

            string[] c = new string[4];
            string[] v = new string[4];

            c[0] = "tipo";
            v[0] = tp.ToString();

            c[1] = "classe";
            v[1] = txtClasse.Text.Trim();

            c[2] = "ativo";
            v[2] = at.ToString();

            c[3] = "grupo";
            v[3] = "0";

            BD.Salvar("CLASSE", c, v, 0, "Classe cadastrada com sucesso!");

            txtClasse.Text = "";

            CarregarListasClasseConta();
        }

        private void btnSalvarConta_Click(object sender, EventArgs e)
        {
            if (COD.ValidarCampos(gpConta) == false)
                return;

            //PEGAR O VALOR DO SALDO INICIAL DA NOVA CONTA VIA FORMULÁRIO
            boxValor si = new boxValor();
            si.ShowDialog();
            string saldo = BD.SaldoInicial;

            int at = Convert.ToInt32(ckAtivoConta.Checked);

            string[] c = new string[4];
            string[] v = new string[4];

            c[0] = "conta";
            v[0] = txtConta.Text.Trim();

            c[1] = "saldo";
            v[1] = saldo;

            c[2] = "ativo";
            v[2] = at.ToString();

            c[3] = "cartao_credito";
            v[3] = "0";

            BD.Salvar("CONTA", c, v, 0, "Conta cadastrada com sucesso!");

            txtConta.Text = "";

            CarregarListasClasseConta();
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            if (listaConta.RowCount == 0)
                return;

            string id = listaConta.CurrentRow.Cells[0].Value.ToString();
            string conta = listaConta.CurrentRow.Cells[1].Value.ToString();

            COD.Pergunta("Excluir Conta: " + conta);
            if (COD.Resposta == false)
                return;

            if (BD.Delete("CONTA", id).Item1)
                CarregarListasClasseConta();
        }

    }
}
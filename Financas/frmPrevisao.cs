﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Setup.Financas
{
    public partial class frmPrevisao : Form
    {
        public frmPrevisao()
        {
            InitializeComponent();
        }

        private void frmPrevisao_Load(object sender, EventArgs e)
        {
            CarregarPrevisao();
            CarregarCbMesAno();
        }

        private void CarregarPrevisao()
        {
            int top1 = 12; //Texto
            int top2 = 14; //Botão
            int top3 = 17; //Check

            string sql, ord, chave;
            int cor = Previsao.Prev.cor;

            panel.Controls.Clear();

            //Montagem do SQL
            //
            //Compras no Crédito
            //
            sql = "SELECT CLASSE, TIPO, DIA, ORCADO, REALIZADO, DESVIO, STATUS, ORD, OBS, CHAVE FROM (";

            sql += "SELECT D.CONTA AS CLASSE, ' Cartão de Crédito' AS TIPO, ";
            sql += "EXTRACT(DAY FROM A.DATA_PARCELA) AS DIA, '0,00' AS ORCADO, ";
            sql += "SUM(A.VALOR * -1) AS REALIZADO, SUM(A.VALOR) AS DESVIO, ";
            sql += "C.COR AS STATUS, 'A' AS ORD, '' AS OBS, '' AS CHAVE FROM COMPRA_CREDITO A ";
            sql += "INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE ";
            sql += "INNER JOIN CARTAO_CREDITO C ON B.CARTAO = C.CARTAO_CREDITO_ID ";
            sql += "INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID WHERE A.STATUS = 0 AND ";
            sql += "EXTRACT(MONTH FROM A.DATA_PARCELA) = 11 AND ";
            sql += "EXTRACT(YEAR FROM A.DATA_PARCELA) = 2022 ";
            sql += "GROUP BY D.CONTA, DIA, STATUS ";
            //
            //PEGA O VALOR DO GASTO PREVISTO QUE AINDA NÃO TIVERAM DÉBITO REALIZADO NA CLASSE ESPECÍFICA
            //
            sql += "UNION SELECT B.CLASSE, ' Despesa' AS TIPO, ";
            sql += "A.DIA, A.VALOR AS ORCADO, '0,00' AS REALIZADO, A.VALOR AS DESVIO, A.STATUS, 'B' AS ORD, A.OBS , A.CHAVE ";
            sql += "FROM PREVISAO A INNER JOIN CLASSE B ON A.CLASSE = B.CLASSE_ID ";
            sql += "WHERE A.CLASSE NOT IN(SELECT DISTINCT CLASSE FROM BD WHERE ";
            sql += "EXTRACT(MONTH FROM DATA) = 10 AND EXTRACT(YEAR FROM DATA) = 2022 AND VALOR < 0) ";
            sql += "AND A.CLASSE NOT IN(SELECT DISTINCT B.CLASSE FROM COMPRA_CREDITO A ";
            sql += "INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE WHERE EXTRACT(MONTH FROM B.DATA_COMPRA) = 10 ";
            sql += "AND EXTRACT(YEAR FROM B.DATA_COMPRA) = 2022 AND A.STATUS = 0) ";
            sql += "AND B.TIPO = 0 AND A.VALOR > 0 AND A.MES = 10 AND A.ANO = 2022 ";

            sql += ") ORDER BY ORD";
            //
            //
            BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {

                ord = BD.Resultado.Rows[i][7].ToString();

                if (ord == "A")
                {
                    cor = int.Parse(BD.Resultado.Rows[i][6].ToString());
                    Previsao.Prev.cor = cor;
                }
                else
                {
                    Previsao.Prev.cor = -1000000;
                }

                //Controle para Classe
                Previsao.TxtClasse classe = new Previsao.TxtClasse();
                classe.Name = "classe" + i;
                classe.Location = new Point(11, top1);
                classe.Text = " " + BD.Resultado.Rows[i][0].ToString();
                panel.Controls.Add(classe);
                //
                //Controle para Tipo
                //
                Previsao.TxtTipo tipo = new Previsao.TxtTipo();
                tipo.Name = "tipo" + i;
                tipo.Location = new Point(245, top1);
                tipo.Text = " " + BD.Resultado.Rows[i][1].ToString();
                panel.Controls.Add(tipo);
                //
                //Controle para Dia
                //
                Previsao.TxtDia dia = new Previsao.TxtDia();
                dia.Name = "dia" + i;
                dia.Location = new Point(393, top1);
                dia.Text = BD.Resultado.Rows[i][2].ToString();
                panel.Controls.Add(dia);
                //
                //Controle para Orçado
                //
                Previsao.TxtOrcado orcado = new Previsao.TxtOrcado();
                orcado.Name = "orcado" + i;
                orcado.Location = new Point(450, top1);
                orcado.Text = BD.Resultado.Rows[i][3].ToString();
                panel.Controls.Add(orcado);
                //
                //Controle para Real
                //
                Previsao.TxtReal real = new Previsao.TxtReal();
                real.Name = "real" + i;
                real.Location = new Point(535, top1);
                real.Text = BD.Resultado.Rows[i][4].ToString();
                panel.Controls.Add(real);
                //
                //Controle para Desvio
                //
                Previsao.TxtDesvio desvio = new Previsao.TxtDesvio();
                desvio.Name = "desvio" + i;
                desvio.Location = new Point(620, top1);
                desvio.Text = BD.Resultado.Rows[i][5].ToString();
                panel.Controls.Add(desvio);
                //
                //Controle para Status
                //
                Previsao.CkStatus status = new Previsao.CkStatus();
                status.Name = "status" + i;
                status.Location = new Point(712, top3);
                panel.Controls.Add(status);
                //
                Previsao.TxtObs obs = new Previsao.TxtObs();
                obs.Name = "obs" + i;
                obs.Location = new Point(731, top1);
                if (ord != "A")
                {
                    obs.Text = BD.Resultado.Rows[i][8].ToString();
                }
                panel.Controls.Add(obs);
                
                if(ord != "A")
                {
                    chave = BD.Resultado.Rows[i][9].ToString();
                    //
                    //Controle para Editar
                    //
                    Previsao.Icon_Edit editar = new Previsao.Icon_Edit();
                    editar.Name = "editar" + i;
                    editar.Location = new Point(986, top1);
                    editar.Tag = chave;
                    panel.Controls.Add(editar);
                    //
                    //Controle para Excluir
                    //
                    Previsao.Icon_Delete excluir = new Previsao.Icon_Delete();
                    excluir.Name = "excluir" + i;
                    excluir.Location = new Point(1015, top1);
                    excluir.Tag = chave;
                    panel.Controls.Add(excluir);
                    //
                }

                top1 += 31; //Texto
                top2 += 31; //Botão
                top3 += 31; //Check

            }
        }

        private void novo_Click(object sender, EventArgs e)
        {
            boxAddPrev prev = new boxAddPrev();
            prev.ShowDialog();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarPrevisao();
        }

        private void CarregarCbMesAno()
        {
            ToolStripComboBox ano = new ToolStripComboBox();
            ToolStripComboBox mes = new ToolStripComboBox();

            string mesNome;

            foreach (ToolStripItem item in menuStrip1.Items)
            {
                if (item.Name == "ano")
                {
                    ano = ((ToolStripComboBox)item);

                    for (int i = 0; i < 3; i++)
                    {
                        ano.Items.AddRange(new object[] {(DateTime.Today.Year -1 + i )});
                    }

                    ano.Text = DateTime.Today.Year.ToString();
                }
                else if(item.Name == "mes")
                {
                    mes = ((ToolStripComboBox)item);

                    for (int i = 1; i < 13; i++)
                    {
                        mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(i).ToUpper();
                        mes.Items.AddRange(new object[] { (mesNome) });
                    }

                    mesNome = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month).ToUpper();
                    mes.Text = mesNome;
                }
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

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
        }

        private void CarregarPrevisao()
        {
            int top1 = 12; //Texto
            int top2 = 14; //Botão
            int top3 = 17; //Check

            string sql, ord;
            int cor = Previsao.Prev.cor;

            panel.Controls.Clear();

            //Montagem do SQL
            sql = "SELECT D.CONTA, ' Cartão de Crédito' AS TIPO, EXTRACT(DAY FROM A.DATA_PARCELA) AS DIA, ";
            sql += "'0,00' AS ORCADO, SUM(A.VALOR * -1) AS REALIZADO, SUM(A.VALOR) AS DESVIO, C.COR AS COR, 'A' AS ORD FROM COMPRA_CREDITO A ";
            sql += "INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE ";
            sql += "INNER JOIN CARTAO_CREDITO C ON B.CARTAO = C.CARTAO_CREDITO_ID ";
            sql += "INNER JOIN CONTA D ON C.CONTA = D.CONTA_ID ";
            sql += "WHERE A.STATUS = 0 AND EXTRACT(MONTH FROM A.DATA_PARCELA) = 11 AND EXTRACT(YEAR FROM A.DATA_PARCELA) = 2022 ";
            sql += "GROUP BY D.CONTA, DIA, C.COR";
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
                    Previsao.Prev.cor = -16777216;
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
                    obs.Text = BD.Resultado.Rows[i][6].ToString();
                }
                panel.Controls.Add(obs);
                //
                //Controle para Editar
                //
                Previsao.Icon_Edit editar = new Previsao.Icon_Edit();
                editar.Name = "editar" + i;
                editar.Location = new Point(986, top1);
                panel.Controls.Add(editar);
                //
                //Controle para Excluir
                //
                Previsao.Icon_Delete excluir = new Previsao.Icon_Delete();
                excluir.Name = "excluir" + i;
                excluir.Location = new Point(1015, top1);
                panel.Controls.Add(excluir);

                top1 += 31; //Texto
                top2 += 31; //Botão
                top3 += 31; //Check

            }
        }

        private void novo_Click(object sender, EventArgs e)
        {

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            CarregarPrevisao();
        }
    }
}

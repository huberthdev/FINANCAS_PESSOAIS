using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace Setup.Classes
{
    public static class Filtros
    {
        public static string cCartao;
        public static string fCartao;
    }

    public static class Geral
    {   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numMes">Informe o número do mês</param>
        /// <returns>É retornado o mês em formato de texto</returns>
        public static string MesNome(string numMes, bool abv)
        {
            string mes;

            try
            {
                mes = DateTimeFormatInfo.CurrentInfo.GetMonthName(int.Parse(numMes)).ToUpper();
            }
            catch
            {
                mes = "";
            }

            if (abv)
                mes = mes.Substring(0, 3);

            return mes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomMes">Informe o número do mês. Ex.: "JAN"</param>
        /// <returns>É retornado o mês em formato numérico</returns>
        public static string MesNome(string nomMes)
        {
            string mes = "";

            switch (nomMes)
            {
                case "JAN":
                    mes = "1";
                    break;
                case "FEV":
                    mes = "2";
                    break;
                case "MAR":
                    mes = "3";
                    break;
                case "ABR":
                    mes = "4";
                    break;
                case "MAI":
                    mes = "5";
                    break;
                case "JUN":
                    mes = "6";
                    break;
                case "JUL":
                    mes = "7";
                    break;
                case "AGO":
                    mes = "8";
                    break;
                case "SET":
                    mes = "9";
                    break;
                case "OUT":
                    mes = "10";
                    break;
                case "NOV":
                    mes = "11";
                    break;
                case "DEZ":
                    mes = "12";
                    break;
            }

            return mes;
        }

        public static void ExcluirTransferencia(string id, bool msg = true)
        {
            string sql, valor, contaC, vC, contaD, vD;

            COD.Pergunta("Excluir transação selecionada?");
            if (COD.Resposta == false)
                return;

            id = id.Split(".").GetValue(0).ToString();
            sql = "SELECT CONTA_DEBITO, CONTA_CREDITO, VALOR FROM TRANSFERENCIA WHERE TRANSFERENCIA_ID = " + id + "";
            BD.Buscar(sql);

            contaC = BD.Resultado.Rows[0][0].ToString();
            contaD = BD.Resultado.Rows[0][1].ToString();
            valor = BD.Resultado.Rows[0][2].ToString();

            vD = BD.CvNum((decimal.Parse(valor) * -1).ToString());
            vC = BD.CvNum((decimal.Parse(valor)).ToString());

            //ATUALIZA O SALDO DAS CONTAS DÉBITO E CRÉDITO
            Conta.AtualizarSaldoConta(contaC, vC);
            Conta.AtualizarSaldoConta(contaD, vD);

            //EXCLUI A MOVIMENTAÇÃO ND BANCO DE DADOS

            try
            {
                BD.Delete("TRANSFERENCIA", id);

                if (msg == true)
                {
                    COD.OK("Movimentação excluída com sucesso!");
                }
            }
            catch (Exception)
            {
                COD.Erro("Não foi possível excluir esta movimentação!");
            }
            
        }

        public static void ExcluirLancamento(string id, bool msg = true)
        {
            string sql, conta, valor, classe;

            classe = id.Split(".").GetValue(1).ToString();
            id = id.Split(".").GetValue(0).ToString();

            COD.Pergunta("Excluir lançamento selecionado?\r\n\r\nClasse: "+classe);
            if (COD.Resposta == false)
                return;

            sql = "SELECT CONTA, VALOR FROM BD WHERE BD_ID = " + id + "";
            BD.Buscar(sql);

            conta = BD.Resultado.Rows[0][0].ToString();
            valor = BD.Resultado.Rows[0][1].ToString();

            valor = BD.CvNum((decimal.Parse(valor) * -1).ToString());

            //ATUALIZA O SALDO DA CONTA
            Conta.AtualizarSaldoConta(conta, valor);

            //EXCLUI A MOVIMENTAÇÃO ND BANCO DE DADOS
            try
            {
                BD.Delete("BD", id);

                if (msg == true)
                {
                    COD.OK("Lançamento excluído com sucesso!");
                }
            }
            catch
            {
                COD.Erro("Não foi possível excluir este lançamento!");
            }
        }

        public static bool ExcluirCompraCredito(string chave)
        {
            string sql, classe;

            classe = chave.Split(".").GetValue(2).ToString();
            chave = chave.Split(".").GetValue(1).ToString();

            if (chave == "")
                return false;

            sql = "SELECT SUM(STATUS) FROM COMPRA_CREDITO WHERE CHAVE = " + chave + "";
            BD.Buscar(sql);

            if (int.Parse(BD.Resultado.Rows[0][0].ToString()) > 0)
            {
                COD.Erro("Exclusão não permitida!\r\n\r\nEsta compra já possui parcela paga!");
                return false;
            }

            COD.Pergunta("Excluir Compra. Confirma?\r\n\r\nClasse: "+classe);
            if (COD.Resposta == false)
            {
                return false;
            }
            else
            {
                sql = "DELETE FROM COMPRA_CREDITO WHERE CHAVE = " + chave + "";
                BD.ExecutarSQL(sql);

                sql = "DELETE FROM KEY_COMPRA_CREDITO WHERE CHAVE = " + chave + "";
                BD.ExecutarSQL(sql);

                return true;
            }    
        }

        public static void AbrirDetalheTransacao(string id, string tipo)
        {
            string sql, texto;

            if (tipo == "C")
            {
                sql = "SELECT B.CHAVE, C.CLASSE, E.CONTA, A.VALOR AS VALOR_PARCELA, A.PARCELA, A.DATA_PARCELA, CASE A.STATUS WHEN 1 THEN 'PAGO' WHEN 0 THEN 'PENDENTE' END AS STATUS, ";
                sql += "B.VALOR AS VALOR_TOTAL, B.DATA_COMPRA, B.DESCRICAO, D.COR ";
                sql += "FROM COMPRA_CREDITO A INNER JOIN KEY_COMPRA_CREDITO B ON A.CHAVE = B.CHAVE ";
                sql += "INNER JOIN CLASSE C ON B.CLASSE = C.CLASSE_ID ";
                sql += "INNER JOIN CARTAO_CREDITO D ON B.CARTAO = D.CARTAO_CREDITO_ID ";
                sql += "INNER JOIN CONTA E ON D.CONTA = E.CONTA_ID ";
                sql += "WHERE A.COMPRA_CREDITO_ID = " + id + "";

                try
                {
                    BD.Buscar(sql);
                }
                catch
                {
                    return;
                }

                string chave = "Compra Nº: " + BD.Resultado.Rows[0][0].ToString();
                string classe = "Classe: " + BD.Resultado.Rows[0][1].ToString();
                string cartao = "Cartão: " + BD.Resultado.Rows[0][2].ToString();
                string v_parcela = "Valor da Parcela: " + double.Parse(BD.Resultado.Rows[0][3].ToString()).ToString("N");
                string parcela = "Parcela: " + BD.Resultado.Rows[0][4].ToString();
                string dt_parcela = "Data da Parcela: " + DateTime.Parse(BD.Resultado.Rows[0][5].ToString()).ToShortDateString();
                string status = "Status: " + BD.Resultado.Rows[0][6].ToString();
                string v_total = "Valor Total: " + double.Parse(BD.Resultado.Rows[0][7].ToString()).ToString("N");
                string dt_compra = "Data: " + DateTime.Parse(BD.Resultado.Rows[0][8].ToString()).ToShortDateString();
                string descricao = "Descrição: " + BD.Resultado.Rows[0][9].ToString();
                string cor = BD.Resultado.Rows[0][10].ToString();

                texto = dt_compra + "\t" + v_total + "\r\n\r\n";
                texto += chave + "\r\n\r\n" + classe + "\r\n\r\n" + cartao;
                texto += "\r\n\r\n" + dt_parcela + "\t" + parcela;
                texto += "\r\n\r\n" + v_parcela + "\t" + status;
                texto += "\r\n\r\n" + descricao;

                Financas.boxDescricao desc = new Financas.boxDescricao();
                desc.txtTexto.Text = texto;

                //ColorirPalavra(desc.txtTexto, "Cartão:");

                if(cor != "")
                {
                    if(cor != "-16777216")
                    {
                        desc.lnD.BackColor = Color.FromArgb(int.Parse(cor));
                        desc.lnU.BackColor = Color.FromArgb(int.Parse(cor));
                        desc.lnL.BackColor = Color.FromArgb(int.Parse(cor));
                        desc.lnR.BackColor = Color.FromArgb(int.Parse(cor));
                    }
                }

                desc.ShowDialog();
            }
            
        }

        public static void ReplicarPrevisao(string chave)
        {
            int lin;
            string dia, mes, ano, classe, data, sql, id;

            dia = chave.Split(".").GetValue(0).ToString();
            mes = chave.Split(".").GetValue(1).ToString();
            ano = chave.Split(".").GetValue(2).ToString();
            classe = chave.Split(".").GetValue(3).ToString();

            sql = "SELECT PREVISAO_ID FROM PREVISAO WHERE MES = " + mes + " AND ANO = " + ano + " AND CLASSE = " + classe + "";
            try
            {
                id = BD.Buscar(sql).Rows[0][0].ToString();
            }
            catch
            {
                return;
            }

            data = "01/" + mes + "/" + ano;
            data = DateTime.Parse(data).AddMonths(1).ToShortDateString();
            mes = DateTime.Parse(data).Month.ToString();

            chave = dia + "." + mes + "." + ano + "." + classe;

            sql = "SELECT CHAVE FROM PREVISAO WHERE CHAVE = '" + chave + "'";
            try
            {
                lin = BD.Buscar(sql).Rows.Count;
            }
            catch
            {
                return;
            }

            if (lin != 0)
            {
                COD.Erro("Já existe o previsto desta classe para o próximo mês!");
                return;
            }

            COD.Pergunta("Replicar esta previsão para o próximo mês?");
            if (!COD.Resposta)
                return;

            sql = "INSERT INTO PREVISAO(CHAVE, DIA, MES, ANO, CLASSE, VALOR, STATUS, OBS) ";
            sql += "SELECT '" + chave + "', '" + dia + "', '" + mes + "', '" + ano + "', '" + classe + "', VALOR, '0', OBS ";
            sql += "FROM PREVISAO WHERE PREVISAO_ID = " + id + "";
            try
            {
                BD.ExecutarSQL(sql);
            }
            catch
            {
                COD.Erro("Não foi possível replicar esta previsão!");
            }
        }

    }

    public class Classe
    {
        public int id;
        public string nome;
        private static byte opt = 1;

        public static byte Tipo {
            set 
            {
                opt = value; 
            }
        }

        public override string ToString()
        {
            return this.nome;
        }

        public static List<Classe> Lista()
        {
            var lista = new List<Classe>();
            var c1 = new Classe();

            string sql = "SELECT CLASSE_ID, CLASSE FROM CLASSE WHERE TIPO = "+ opt + " AND ATIVO = 1 ORDER BY CLASSE";
            
            BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                c1 = new Classe();
                c1.id = int.Parse(BD.Resultado.Rows[i][0].ToString());
                c1.nome = BD.Resultado.Rows[i][1].ToString();
                lista.Add(c1);
            }

            return lista;
        }
    }

    public class Conta
    {
        public int id;
        public string nome;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conta">Informe o código da conta em formato string</param>
        /// <param name="valor">Informe o valor em formato string que deve ser debitado na conta desejada</param>
        public static void AtualizarSaldoConta(string conta, string valor)
        {
            string sql = "update conta set saldo = saldo + " + valor + " ";
            sql += "where conta_id = '" + conta + "'";
            BD.ExecutarSQL(sql);
        }

        public override string ToString()
        {
            return this.nome;
        }

        public static List<Conta> Lista()
        {
            var lista = new List<Conta>();
            var c1 = new Conta();

            string sql = "SELECT A.CONTA_ID, A.CONTA, A.ATIVO, A.CARTAO_CREDITO, COUNT(B.CONTA) FROM CONTA A LEFT JOIN BD B ";
            sql += "ON A.CONTA_ID = B.CONTA GROUP BY A.CONTA_ID, A.CONTA, A.ATIVO, A.CARTAO_CREDITO ";
            sql += "ORDER BY A.ATIVO DESC, A.CARTAO_CREDITO DESC, COUNT(B.CONTA) DESC";

            BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                c1 = new Conta();
                c1.id = int.Parse(BD.Resultado.Rows[i][0].ToString());
                c1.nome = BD.Resultado.Rows[i][1].ToString();
                lista.Add(c1);
            }

            return lista;
        }

        public static double SaldoTotal(string id = "", bool ativo = true)
        {
            string sql = "SELECT SUM(SALDO) FROM CONTA WHERE RESERVADO = 0 ";
            if (id != "")
            {
                sql += "AND CONTA_ID = "+ id +"";
            }

            try
            {
                return double.Parse(BD.Buscar(sql).Rows[0][0].ToString());
            }
            catch 
            {
                return 0;
            }
        }
    }

    public class CartaoCredito
    {
        public int conta;
        public int cartao;
        public string nome;
        public int vencimento;
        private static byte cad = 0;

        public static byte Ativo
        {
            set
            {
                cad = value;
            }
        }

        public override string ToString()
        {
            return this.nome;
        }

        public static List<CartaoCredito> Lista()
        {
            string sql;
            var lista = new List<CartaoCredito>();
            var c1 = new CartaoCredito();

            sql = "SELECT A.CONTA_ID, COALESCE(B.CARTAO_CREDITO_ID, 0), A.CONTA, B.DIA_VENC FROM CONTA A LEFT JOIN ";
            sql += "CARTAO_CREDITO B ON A.CONTA_ID = B.CONTA WHERE A.CARTAO_CREDITO = 1 ";
            if (cad == 1)
            {
                sql += "AND B.CONTA > 0 ";
            }
            sql += "ORDER BY A.CONTA";

            BD.Buscar(sql);

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                c1 = new CartaoCredito();
                c1.conta = int.Parse(BD.Resultado.Rows[i][0].ToString());
                c1.cartao = int.Parse(BD.Resultado.Rows[i][1].ToString());
                c1.nome = BD.Resultado.Rows[i][2].ToString();
                c1.vencimento = int.Parse(BD.Resultado.Rows[i][3].ToString());
                lista.Add(c1);
            }

            return lista;
        }

    }
}

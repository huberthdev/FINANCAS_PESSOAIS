using System;
using System.Collections.Generic;

namespace Setup.Classes
{
    public static class Geral
    {
        public static void AtualizarSaldoConta(string conta, string valor)
        {
            string sql = "update conta set saldo = saldo + " + valor + " ";
            sql += "where conta_id = '" + conta + "'";
            BD.ExecutarSQL(sql);
        }

        public static void ExcluirTransferencia(string id, bool msg = true)
        {
            string sql;
            string valor;
            string contaC;
            string vC;
            string contaD;
            string vD;

            COD.Pergunta("Excluir transação selecionada?");
            if (COD.Resposta == false)
                return;

            sql = "SELECT CONTA_DEBITO, CONTA_CREDITO, VALOR FROM TRANSFERENCIA WHERE TRANSFERENCIA_ID = " + id + "";
            BD.Buscar(sql);

            contaC = BD.Resultado.Rows[0][0].ToString();
            contaD = BD.Resultado.Rows[0][1].ToString();
            valor = BD.Resultado.Rows[0][2].ToString();

            vD = BD.CvNum((decimal.Parse(valor) * -1).ToString());
            vC = BD.CvNum((decimal.Parse(valor)).ToString());

            //ATUALIZA O SALDO DAS CONTAS DÉBITO E CRÉDITO
            AtualizarSaldoConta(contaC, vC);
            AtualizarSaldoConta(contaD, vD);

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
            string sql;
            string conta;
            string valor;

            COD.Pergunta("Excluir lançamento selecionado?");
            if (COD.Resposta == false)
                return;

            sql = "SELECT CONTA, VALOR FROM BD WHERE BD_ID = " + id + "";
            BD.Buscar(sql);

            conta = BD.Resultado.Rows[0][0].ToString();
            valor = BD.Resultado.Rows[0][1].ToString();

            valor = BD.CvNum((decimal.Parse(valor) * -1).ToString());

            //ATUALIZA O SALDO DA CONTA
            AtualizarSaldoConta(conta, valor);

            //EXCLUI A MOVIMENTAÇÃO ND BANCO DE DADOS
            try
            {
                BD.Delete("BD", id);

                if (msg == true)
                {
                    COD.OK("Lançamento excluído com sucesso!");
                }
            }
            catch (Exception)
            {
                COD.Erro("Não foi possível excluir este lançamento!");
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

            String sql = "SELECT CLASSE_ID, CLASSE FROM CLASSE WHERE TIPO = "+ opt +" ORDER BY CLASSE";
            
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

        public override string ToString()
        {
            return this.nome;
        }

        public static List<Conta> Lista()
        {
            var lista = new List<Conta>();
            var c1 = new Conta();

            BD.Buscar("SELECT CONTA_ID, CONTA FROM CONTA ORDER BY CONTA");

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                c1 = new Conta();
                c1.id = int.Parse(BD.Resultado.Rows[i][0].ToString());
                c1.nome = BD.Resultado.Rows[i][1].ToString();
                lista.Add(c1);
            }

            return lista;
        }
    }

    public class CartaoCredito
    {
        public int id;
        public string nome;

        public override string ToString()
        {
            return this.nome;
        }

        public static List<CartaoCredito> Lista()
        {
            var lista = new List<CartaoCredito>();
            var c1 = new CartaoCredito();

            BD.Buscar("SELECT CARTAO_CREDITO_ID, CARTAO FROM CARTAO_CREDITO ORDER BY CARTAO");

            for (int i = 0; i < BD.Resultado.Rows.Count; i++)
            {
                c1 = new CartaoCredito();
                c1.id = int.Parse(BD.Resultado.Rows[i][0].ToString());
                c1.nome = BD.Resultado.Rows[i][1].ToString();
                lista.Add(c1);
            }

            return lista;
        }

    }
}

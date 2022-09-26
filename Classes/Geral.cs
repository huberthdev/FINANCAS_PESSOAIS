using System;
using System.Collections.Generic;
using System.Text;

namespace Setup.Classes
{
    public class Geral
    {
        public static void AtualizarSaldoConta(string conta, string valor)
        {
            string sql = "update conta set saldo = saldo + " + valor + " ";
            sql += "where conta_id = '" + conta + "'";
            BD.ExecutarSQL(sql);
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
}

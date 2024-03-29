﻿using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Configuration;

namespace Setup
{
    public class BD
    {
        public static string SaldoInicial;

        public static DataTable Resultado;

        public static string UsuarioLogado;

        private static FbConnection Conectar()
        {

            ConfigurationManager.RefreshSection("appSettings");

            string caminho = ConfigurationManager.AppSettings["Banco"].ToString();
            string servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
            string porta = ConfigurationManager.AppSettings["Porta"].ToString();
            string usuario = "SYSDBA";
            string senha = "masterkey";

            return new FbConnection("User="+ usuario +";Password="+ senha +";Database="+ caminho +";DataSource="+ servidor +";Port="+ porta);
        }

        public static void TestarConexao()
        {
            using (FbConnection ConexaoFB = Conectar())
            {
                try
                {
                    ConexaoFB.Open();                    
                }
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    ConexaoFB.Dispose();
                }
            }
        }
           
        /// <summary>
        /// Função para converter o formato de data com "/" para "."
        /// </summary>
        /// <param name="data">Informar a data no formato string 00/00/0000 para a função converter
        /// para o formato aceito no banco de dados Firebird 00.00.0000</param>
        /// <returns></returns>
        public static string CvData(string data)
        {
            if (data == "")
                return null;
            else
            {
                data = data.Replace("/", ".");
                return data;
            }
        }

        public static string CvNum(string num)
        {
            if (num == "")
                return "0";
            else
            {
                num = num.Replace("R$", "");
                num = num.Trim();
                num = num.Replace(".", "");
                num = num.Replace(",", ".");
                return num;
            }
        }

        public static int ExecutarSQL(string SQL, string Msg = "")
        {
            using (FbConnection ConexaoFD = Conectar())
            {
                try
                {
                    ConexaoFD.Open();
                    FbCommand cmd = new FbCommand(SQL, ConexaoFD);

                    return cmd.ExecuteNonQuery();
                                        
                }
                catch (FbException ex)
                {

                    throw new Exception(ex.ToString());
                }
                finally
                {
                    ConexaoFD.Dispose();
                }
            }
        }

        private static string Insert(string Tabela, string[] Campos, string[] Valores)
        {

            string sql = "INSERT INTO " + Tabela + "(";

            foreach (string item in Campos)
            {
                sql += item + ", ";
            }

            sql += ")";
            sql = sql.Replace(", )", ")");

            sql += " VALUES(";

            foreach (string item in Valores)
            {
                if (item==null || item=="")
                    sql += "null" + ", ";
                else              
                    sql += "'"+ item +"', ";
            }

            sql += ")";
            sql = sql.Replace(", )", ")");
                      
            return sql;

        }

        public static string InsertProcedureCredito(string[] Valores)
        {
            string chave = "";

            string sql = "SELECT ID FROM KEY_COMPRA_CREDITO_SALVAR(";
            //"CLASSE, CARTAO, VALOR, DATA_COMPRA, DESCRICAO)";

            foreach (string item in Valores)
            {
                if (item == null || item == "")
                    sql += "null" + ", ";
                else
                    sql += "'" + item + "', ";
            }

            sql += ")";
            sql = sql.Replace(", )", ")");

            try
            {
                BD.Buscar(sql);
                chave = BD.Resultado.Rows[0][0].ToString();
            }
            catch
            {

            }

            return chave;

        }

        private static string Update(string Tabela, string[] Campos, string[] Valores, long ID)
        {

            int i = 0;
            string sql = "UPDATE " + Tabela + " SET ";

            foreach (string item in Campos)
            {
                if(Valores[i] == "" || Valores[i] == null)
                    sql += item + " = " + "null" + ", ";
                else
                    sql += item + " = '" + Valores[i] + "', ";

                i++;
            }

            sql += "WHERE";
            sql = sql.Replace(", WHERE", " WHERE ");

            sql += Tabela + "_ID = " + ID;
                        
            return sql;

        }

        public static Tuple<bool, string> Delete(string Tabela, string ID, string TextoConfirmacao = "")
        {
            int codigo = 0;
            string erro;

            if (ID != "")
                codigo = int.Parse(ID);

            string sql = "DELETE FROM " + Tabela + " WHERE " + Tabela + "_ID = " + ID;

            if (TextoConfirmacao != "")
            {
                COD.Pergunta(TextoConfirmacao.ToString());
                if (!COD.Resposta)
                    return new Tuple<bool, string>(false, "");
            }

            try
            {
                ExecutarSQL(sql);
                return new Tuple<bool, string>(true, "");
            }
            catch (Exception ex)
            {
                erro = ex.ToString();

                if (erro.Contains("FOREIGN"))
                {
                    erro = "CHAVE ESTRANGEIRA EM USO";
                }
                else
                {
                    erro = "";
                }

                return new Tuple<bool, string>(false, erro);
            }
                       
        
        }

        public static bool Ativar(string Tabela, long ID, bool Status, string TextoConfirmacao = "")
        {

            string s;

            if (Status == false)
                s = "S";
            else
                s = "N";

            string sql = "UPDATE " + Tabela + " SET ATIVO = " + s;

            if (TextoConfirmacao != "")
            {
                COD.Pergunta(TextoConfirmacao.ToString());
                if (!COD.Resposta)
                    return false;
            }

            try
            {
                ExecutarSQL(sql);
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
            
        }
        
        public static bool Salvar(string Tabela, string[] Campos, string[] Valores, long ID = 0, string Msg = "")
        {

            if (ID == 0)
                try
                {
                    ExecutarSQL(Insert(Tabela, Campos, Valores), Msg);
                    if (Msg != "")
                        COD.OK(Msg);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                
            else
                try
                {
                    ExecutarSQL(Update(Tabela, Campos, Valores, ID), Msg);
                    if (Msg != "")
                        COD.OK(Msg);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                
        }

        public static DataTable Buscar(string sql)
        {

            using (FbConnection Conexao = Conectar())
            {
                try
                {
                    DataTable dt = new DataTable();
                    Conexao.Open();
                    FbCommand cmd = new FbCommand(sql, Conexao);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    da.Fill(dt);
                    Resultado = dt;
                    return dt;
                    
                }
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    Conexao.Dispose();
                }
            }

        }
    }
}

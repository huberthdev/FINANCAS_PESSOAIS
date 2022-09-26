using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Configuration;

namespace Setup
{
    public class BD
    {
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

        public static bool Delete(string Tabela, string ID, string TextoConfirmacao = "")
        {

            int codigo = 0;

            if (ID != "")
                codigo = int.Parse(ID);

            string sql = "DELETE FROM " + Tabela + " WHERE " + Tabela + "_ID = " + ID;

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

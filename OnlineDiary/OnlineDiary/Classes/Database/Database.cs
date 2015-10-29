using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineDiary.Classes.Database
{
    public class Database
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlConnection conexao;
        private SqlCommand comando;

        public Database()
        {
            conexao = new SqlConnection(strConexao);
        }

        public SqlDataReader QueryReader(string strComando)
        {
            comando = new SqlCommand();
            comando.CommandText = strComando;
            return comando.ExecuteReader();
        }

        public int QueryRow(string strComando)
        {
            comando = new SqlCommand();
            return comando.ExecuteNonQuery();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineDiary.Classes
{
    public class DatabaseReserva
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlConnection conexao;
        private SqlCommand comando;

        public DatabaseReserva()
        {
            conexao = new SqlConnection(strConexao);
        }

        public SqlConnection Retorna_Conexao()
        {
            return conexao;
        }

        public SqlDataReader Ler(string strComando)
        {
            comando = new SqlCommand();
            comando.CommandText = strComando;
            return comando.ExecuteReader();
        }

        public int Executar(string strComando)
        {
            try{	   
                comando = new SqlCommand(strComando, this.conexao);
                this.conexao.Open();
                return comando.ExecuteNonQuery();
	        }
	        catch (Exception){
                return -1;
	        }
            finally{
                this.conexao.Close();
            }
        }

    }
}
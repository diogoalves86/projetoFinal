using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace OnlineDiary.Classes
{
    public class Turma
    {
        private Database banco = new Database();


        public void PegarTurma()
        {
            Hashtable alunos = new Hashtable();
            SqlDataReader reader = banco.QueryReader("SELECT * FROM Turma");
            while(reader.Read())
            {
                alunos["aa"] = "a";
            }
        }
    }
}
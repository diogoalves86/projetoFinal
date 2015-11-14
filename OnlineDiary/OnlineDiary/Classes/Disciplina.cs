using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineDiary.Classes
{
    public class Disciplina
    {
        private DatabaseReserva banco;
        public int? Id { get; set; }

        [Required, StringLength(20, ErrorMessage="O campo Nome pode ter no máximo 20 caracteres")]
        [Display(Name="Nome da Disciplina")]
        [MinLength(4, ErrorMessage="O campo Nome precisa ter pelo menos 4 caracteres.")]
        public string Nome { get; set; }

        public Disciplina(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;    
            this.banco = new DatabaseReserva();    
        }

        public string Cadastrar_Disciplina(string nome)
        {
            string consulta = String.Format("INSERT INTO Disciplina(nome) VALUES ('{0}');", nome);
            string valida_campo = Valida_Dados.Valida_Campo(this, this.Nome, new string[]{"Nome"});
            if (valida_campo != "OK")
                return valida_campo;

            if (this.banco.Executar(consulta) != -1)
                return "OK";
            return "";
        }
    }
}
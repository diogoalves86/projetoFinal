using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineDiary.Classes
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        public int UsuarioID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Nome { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Cpf { get; set; }
        
        public string Matricula { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
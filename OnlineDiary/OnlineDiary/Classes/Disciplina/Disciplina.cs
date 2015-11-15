using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineDiary.Classes
{
    public class Disciplina
    {
        [Key]
        public int? Id { get; set; }
        [Required, StringLength(20, ErrorMessage="O campo Nome pode ter no máximo 20 caracteres")]
        [Display(Name="Nome da Disciplina")]
        [MinLength(4, ErrorMessage="O campo Nome precisa ter pelo menos 4 caracteres.")]
        public string Nome { get; set; }
    }
}
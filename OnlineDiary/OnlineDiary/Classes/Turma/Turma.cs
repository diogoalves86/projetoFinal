using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineDiary.Classes
{
    public class Turma
    {
        [Key]
        public int? Id { get; set; }

        [Required, StringLength(100), Display(Name = "Turma")]
        public string Nome { get; set; }
    }
}
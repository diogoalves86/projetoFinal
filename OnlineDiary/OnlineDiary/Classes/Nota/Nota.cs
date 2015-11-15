using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineDiary.Classes
{
    public class Nota
    {
        [Key]
        public int? Id { get; set; }

        [Display(Name = "Nota da 1ª Certificação")]
        public int? primeira_certificação { get; set; }

        [Display(Name = "Nota da 2ª Certificação")]
        public int? segunda_certificação { get; set; }

        [Display(Name = "Nota da 3ª Certificação")]
        public int? terceira_certificação { get; set; }

        [Display(Name = "Nota da 2ªchamada da 1ª Certificação")]
        public int? primeira_recuperacao { get; set; }

        [Display(Name = "Nota da 2ªchamada da 2ª Certificação")]
        public int? segunda_recuperacao { get; set; }

        [Display(Name = "Nota da 2ªchamada da 3ª Certificação")]
        public int? terceira_recuperacao { get; set; }

        public virtual Disciplina disciplina { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}
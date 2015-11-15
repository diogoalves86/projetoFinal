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

        [Required]
        [Display(Name = "Nota da 1ª Certificação")]
        public int primeira_certificação { get; set; }
    }
}
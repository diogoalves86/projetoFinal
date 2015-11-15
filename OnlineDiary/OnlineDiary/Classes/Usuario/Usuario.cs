﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Security;


namespace OnlineDiary.Classes
{
    public class Usuario
    {
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Nome { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Cpf { get; set; }
        
        public string Matricula { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public virtual Turma Turma { get; set; }
    }
}
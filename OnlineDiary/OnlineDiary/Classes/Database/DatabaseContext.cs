using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineDiary.Classes
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            :base("Default")
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<Turma> Turma { get; set; }
    }
}
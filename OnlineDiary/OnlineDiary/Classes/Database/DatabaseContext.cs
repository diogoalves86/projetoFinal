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

        public DbSet<Memberships> Usuarios { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineDiary.Classes
{
    public class UsuarioContext
    {
        public DatabaseContext db = new DatabaseContext();

        public void InsertOrUpdate(Memberships usuario)
        {
            try
            {
                db.Entry(usuario).State = usuario.Id == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var usuario = db.Usuarios.Find(id);
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
                throw;
            }
        }

        public IQueryable<Memberships> CarregarDados()
        {
            try
            {
                var dados = db.Usuarios;
                return dados;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
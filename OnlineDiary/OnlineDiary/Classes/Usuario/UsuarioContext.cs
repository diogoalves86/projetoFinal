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

        public void InsertOrUpdate(Usuario usuario)
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
                var usuario = db.Usuario.Find(id);
                db.Usuario.Remove(usuario);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
                throw;
            }
        }

        public IQueryable<Usuario> CarregarDados()
        {
            try
            {
                var dados = db.Usuario;
                return dados;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
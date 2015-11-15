using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineDiary.Classes
{
    public class NotaContext
    {
        public DatabaseContext db = new DatabaseContext();

        public void InsertOrUpdate(Nota nota)
        {
            try
            {
                db.Entry(nota).State = nota.Id == 0 ? EntityState.Added : EntityState.Modified;
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
                var nota = db.Nota.Find(id);
                db.Nota.Remove(nota);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
                throw;
            }
        }

        public IQueryable<Nota> CarregarDados()
        {
            try
            {
                var dados = db.Nota;
                return dados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
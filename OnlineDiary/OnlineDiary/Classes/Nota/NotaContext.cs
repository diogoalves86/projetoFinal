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

        public void Pega_Nota_Aluno(string id_aluno)
        {
            try
            {
                var dados = db.Database.SqlQuery(typeof(Nota), "select notas.* from notas, users where notas.usuario_id=users.UserId");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Nota> Listar_Notas()
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
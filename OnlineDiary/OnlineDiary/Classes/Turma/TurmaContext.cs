using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineDiary.Classes
{
    public class TurmaContext
    {
        public DatabaseContext db = new DatabaseContext();

        public void InsertOrUpdate(Turma turma)
        {
            try
            {
                db.Entry(turma).State = turma.Id == 0 ? EntityState.Added : EntityState.Modified;
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
                var turma = db.Turma.Find(id);
                db.Turma.Remove(turma);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
                throw;
            }
        }

        public IQueryable<Turma> Lista_Turmas()
        {
            try
            {
                var dados = db.Turma;
                return dados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
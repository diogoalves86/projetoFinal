using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace OnlineDiary.Classes
{
    public class DisciplinaContext
    {
        public DatabaseContext db = new DatabaseContext();

        public void InsertOrUpdate(Disciplina disciplina)
        {
            try
            {
                db.Database.Connection.Open();
                db.Entry(disciplina).State = disciplina.Id == null ? EntityState.Added : EntityState.Modified;
                db.Disciplina.Add(disciplina);
                db.SaveChanges();
                db.Database.Connection.Close();
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
                var disciplina = db.Disciplina.Find(id);
                db.Disciplina.Remove(disciplina);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IQueryable<Disciplina> Lista_Disciplinas()
        {
            try
            {
                var dados = db.Disciplina.Where(o=>true);
                return dados;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
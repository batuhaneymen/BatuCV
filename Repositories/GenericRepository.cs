using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BatuCV.Models.entity;

namespace BatuCV.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        dbCVEntities1 db = new dbCVEntities1();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void Tadd(T p)
        {
            db.Set<T>().Add(p);
             db.SaveChanges();
        }
        public void Tdelete(T p) 
        { 
            db.Set<T>().Remove(p);
            db.SaveChanges();
        
        }

        public T get(int id) 
        {
            return db.Set<T>().Find(id);        
        }
        public void TUpdate(T p) 
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}
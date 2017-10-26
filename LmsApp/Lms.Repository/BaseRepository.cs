﻿using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Model;

namespace Lms.Repository
{
    public class BaseRepository<T> where T:Entiry
    {
        protected BusinessDbContext db;

        public BaseRepository()
        {
            this.db = new BusinessDbContext();
        }

        public bool Add(T entry)
        {
            DbSet<T> dbSet = this.db.Set<T>();
            T add = dbSet.Add(entry);
            int i = this.db.SaveChanges();
            return i > 0;
        }

        public IQueryable<T> Get()
        {
            DbSet<T> dbSet = this.db.Set<T>();
            return dbSet.AsQueryable();
        }

        public T GetDetail(string id)
        {
           return this.db.Set<T>().Find(id);        
        }

        public bool Edit(T entity)
        {
            this.db.Entry(entity).State = EntityState.Modified;
            int i = this.db.SaveChanges();
            return i > 0;
        }

        public bool Delete(string id)
        {
            var entity = GetDetail(id);
            if (entity!=null)
            {
                this.db.Set<T>().Remove(entity);
                int i = this.db.SaveChanges();
                return i > 0;
            }
            return true;
        }
    }
}
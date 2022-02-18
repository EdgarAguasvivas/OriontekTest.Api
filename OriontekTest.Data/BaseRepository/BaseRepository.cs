using Microsoft.EntityFrameworkCore;
using OriontekTest.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OriontekTest.Data.BaseRepository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private ApiDbContext context;
        public BaseRepository(ApiDbContext context)
        {
            this.context = context;
        }        
       
        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
        public void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }
    }
}

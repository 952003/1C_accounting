using _1C_accounting.DataBase;
using _1C_accounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Repositories.Implementations
{
    public abstract class DbSetRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> dbSet;

        protected readonly AppDbContext dbContext;

        public DbSetRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }

        public virtual async Task Add(TEntity entity)
        {
            await dbSet.AddAsync(entity);
        }

        public virtual async Task Delete(Guid id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
                dbSet.Remove(entity);
        }

        public virtual async Task<TEntity> Get(Guid id)
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }

        public virtual void Update(TEntity entity)
        {
            dbContext.ChangeTracker.Clear();
            dbSet.Update(entity);
        }
    }
}

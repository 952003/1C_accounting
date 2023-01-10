using System;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);

        Task<TEntity> Get(Guid id);

        IQueryable<TEntity> GetAll();

        void Update(TEntity entity);

        Task Delete(Guid id);
    }
}

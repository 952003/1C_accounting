using _1C_accounting.DataBase;
using _1C_accounting.Repositories.Implementations;
using _1C_accounting.Repositories.Interfaces;
using _1C_accounting.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Services.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        private IIngridientsRepository ingridientsRepository;

        private IProductsRepository productsRepository;

        public IIngridientsRepository IngridientsRepository
        {
            get
            {
                return ingridientsRepository ?? (ingridientsRepository = new IngridientsRepository(dbContext));
            }
        }

        public IProductsRepository ProductsRepository
        {
            get
            {
                return productsRepository ?? (productsRepository = new ProductsRepository(dbContext));
            }
        }

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        #region Disposable

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion Disposable
    }
}

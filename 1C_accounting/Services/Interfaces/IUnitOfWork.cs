using _1C_accounting.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IIngridientsRepository IngridientsRepository { get; }

        IProductsRepository ProductsRepository { get; }

        Task SaveChangesAsync();
    }
}

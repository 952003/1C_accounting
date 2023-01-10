using _1C_accounting.DataBase;
using _1C_accounting.Models;
using _1C_accounting.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Repositories.Implementations
{
    public class ProductsRepository : DbSetRepository<Product>, IProductsRepository
    {
        public ProductsRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}

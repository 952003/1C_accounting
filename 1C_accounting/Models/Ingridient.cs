using _1C_accounting.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Models
{
    public class Ingridient : BaseModelProd
    {
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}

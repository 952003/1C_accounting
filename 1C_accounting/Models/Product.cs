using _1C_accounting.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Models
{
    public class Product : BaseModelProd
    {
        public virtual List<Ingridient> Ingridients { get; set; } = new List<Ingridient>();
    }
}

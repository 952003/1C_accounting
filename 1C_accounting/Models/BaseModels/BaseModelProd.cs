using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1C_accounting.Models.BaseModels
{
    public abstract class BaseModelProd
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public decimal Price { get; set; }
        public decimal Zero_price { get; set; }
    }
}

using MyStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}

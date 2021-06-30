using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09_DependencyInjection.Models
{
   public interface IProductRepository
    {
        ICollection<Product> GetProducts();

    }
}

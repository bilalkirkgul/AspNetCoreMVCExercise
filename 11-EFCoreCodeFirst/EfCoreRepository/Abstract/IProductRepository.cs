using _11_EFCoreCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.EfCoreRepository.Abstract
{
   public interface IProductRepository
    {
        ICollection<Product> Products { get; }
        ICollection<Product> GetProductsByCategoryID(int categoryID);

        public bool InsertProduct(Product product);
        public bool UpdateProduct(Product product);

        public bool DeleteProduct(int id);

        public Product GetProductById(int id);
    }
}

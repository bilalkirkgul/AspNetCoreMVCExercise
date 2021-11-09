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

        bool InsertProduct(Product product);
        bool UpdateProduct(Product product);

        bool DeleteProduct(int id);

        Product GetProductById(int id);

        List<Product> ProductListCategory();
    }
}

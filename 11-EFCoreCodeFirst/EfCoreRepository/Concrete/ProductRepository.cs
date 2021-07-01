using _11_EFCoreCodeFirst.EfCoreRepository.Abstract;
using _11_EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.EfCoreRepository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        CoreContext context;

        public ProductRepository(CoreContext coreContext)
        {
            context = coreContext;
        }

        public ICollection<Product> Products => context.Products.ToList();

        public bool InsertProduct(Product product)
        {
            //context.Products.Add(product);
            //return context.SaveChanges() > 0;

            context.Entry(product).State = EntityState.Added;
            return context.SaveChanges() > 0;
        }

        public bool UpdateProduct(Product product)
        {
            //Product updateProduct = GetProductById(product.ProductID);
            //context.Entry(updateProduct).CurrentValues.SetValues(product);
            //return context.SaveChanges() > 0;

            context.Entry(product).State = EntityState.Modified;
            return context.SaveChanges() > 0;

        }

        public bool DeleteProduct(int id)
        {
            Product deleteProduct = GetProductById(id);
            context.Entry(deleteProduct).State = EntityState.Deleted;
            return context.SaveChanges() > 0;

            //context.Products.Remove(deleteProduct);
            //return context.SaveChanges() > 0;
        }

        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        public ICollection<Product> GetProductsByCategoryID(int categoryID)
        {
            return context.Products.Where(a => a.CategoryID == categoryID).ToList();
        }

       
    }
}

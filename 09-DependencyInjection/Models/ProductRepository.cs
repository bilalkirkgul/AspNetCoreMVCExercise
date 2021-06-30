using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09_DependencyInjection.Models
{
    public class ProductRepository : IProductRepository
    {
        public ICollection<Product> GetProducts()
        {
            ICollection<Product> products = new List<Product>()
           {
               new Product{ ProductID=1,ProductName="Klavye", Stock=100,Price=1.350m},
                new Product{ ProductID=2,ProductName="Mause", Stock=100,Price=500},
                 new Product{ ProductID=3,ProductName="Monitör", Stock=100,Price=5.350m},
                  new Product{ ProductID=4,ProductName="MausePad", Stock=100,Price=50},
                   new Product{ ProductID=5,ProductName="Ekran Kartı", Stock=100,Price=15.000m},
           };
            return products;
        }
    }
}

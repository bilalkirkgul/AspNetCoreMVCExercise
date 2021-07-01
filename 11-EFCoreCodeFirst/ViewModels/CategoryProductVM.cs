using _11_EFCoreCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.ViewModels
{
    public class CategoryProductVM
    {
        public CategoryProductVM()
        {
            Products = new List<Product>();
            Categories = new List<Category>();
        }

        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}

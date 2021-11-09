using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.ViewModels
{
    public class ProductCategoryVM
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}

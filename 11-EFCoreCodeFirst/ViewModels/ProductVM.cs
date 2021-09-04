using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.ViewModels
{
    public class ProductVM
    {
        public ProductVM()
        {
            Categories = new List<SelectListItem>();
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int CategoryID { get; set; }
        public List<SelectListItem> Categories { get; set; }

    }
}

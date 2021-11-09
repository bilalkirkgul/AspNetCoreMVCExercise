using _10_DbFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_DbFirstApproach.ViewComponents
{
    public class Product : ViewComponent
    {
        NorthwindContext context;
        public Product()
        {
            context = new NorthwindContext();
        }
      

        public IViewComponentResult Invoke()
        {
            var model = context.Products.ToList().OrderByDescending(x => x.ProductId).ToList();
            return View(model);
        }
    }
}

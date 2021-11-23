using _10_DbFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_DbFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext context;
        public HomeController()
        {
            context = new NorthwindContext();
        }

        public IActionResult Index(int id=0)
        {
            List<Product> products;
            if (id == 0)
            {
                products = context.Products.ToList();
            }
            else
            {
                products = context.Products.Where(a => a.CategoryId == id).ToList();
            }

            return View(products);
        }
    }
}

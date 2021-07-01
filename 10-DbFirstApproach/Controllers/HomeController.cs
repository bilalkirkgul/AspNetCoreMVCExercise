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

        public HomeController(NorthwindContext northwind)
        {
            context = northwind;
        }

        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();

            return View(categories);
        }
    }
}

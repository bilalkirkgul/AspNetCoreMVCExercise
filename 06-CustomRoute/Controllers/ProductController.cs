using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_CustomRoute.NewFolder
{
    public class ProductController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View();
        }
    }
}

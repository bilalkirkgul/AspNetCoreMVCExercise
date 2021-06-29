using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_CustomRoute.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Anasayfa")]
        public IActionResult HomePage()
        {
            return View();
        }
        [Route("BilalKirkgulBlog")]
        public IActionResult Blog()
        {
            return View();
        }
        [Route("Galeri")]
        public IActionResult Gallery()
        {
            return View();
        }
    }
}

using _03_AspNetCoreMVCIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_AspNetCoreMVCIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Merhaba Core";
            return View();
        }

        List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId=1,ProductName="elma",Price=5},
                new Product{ ProductId=2,ProductName="karpuz",Price=6},
                new Product{ ProductId=3,ProductName="Klavye",Price=100}
            };
            return products;
        }

        public IActionResult Index2()
        {
           
            return View(GetProducts());
        }
    }
}

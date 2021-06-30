using _09_DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository repository;
        public HomeController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public IActionResult Index()
        {
            return View(repository.GetProducts().ToList());
        }
    }
}

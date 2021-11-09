using _11_EFCoreCodeFirst.EfCoreRepository.Abstract;
using _11_EFCoreCodeFirst.Models;
using _11_EFCoreCodeFirst.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository productRepository;
        public HomeController(IProductRepository product)
        {
            productRepository = product;
        }

        List<ProductCategoryVM> ProductsCategoriesViewModel(List<Product> product)
        {
            List<ProductCategoryVM> model = new List<ProductCategoryVM>();
            foreach (Product item in product)
            {
                model.Add(new ProductCategoryVM
                {
                    ProductID = item.ProductID,
                    ProductName = item.ProductName,
                    UnitInStock = item.UnitsInStock,
                    UnitPrice = item.UnitPrice,
                    CategoryID = item.CategoryID,
                   CategoryName=item.Category.CategoryName,
                   Description=item.Category.Description

                });
            }
            return model;
            
        }

        public IActionResult Index()
        {
            var model = ProductsCategoriesViewModel(productRepository.ProductListCategory());
            return View(model);
        }
    }
}

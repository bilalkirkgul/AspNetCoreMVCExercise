using _11_EFCoreCodeFirst.EfCoreRepository.Abstract;
using _11_EFCoreCodeFirst.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository categoryRepository;
        IProductRepository productRepository;

        public CategoryController(ICategoryRepository category,IProductRepository product)//Startup services eklemesi yaptım..
        {
            categoryRepository = category;
            productRepository = product;
        }

        public IActionResult Index(int? id)
        {
            CategoryProductVM viewModel = new CategoryProductVM();

            viewModel.Categories = categoryRepository.Categories.ToList();

            if (id.HasValue)
            {
                viewModel.Products = productRepository.GetProductsByCategoryID(id.Value);
            }
            else
            {
                viewModel.Products = productRepository.Products.ToList();
            }

            return View(viewModel);
        }
    }
}

using _11_EFCoreCodeFirst.EfCoreRepository.Abstract;
using _11_EFCoreCodeFirst.Models;
using _11_EFCoreCodeFirst.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository;
        ICategoryRepository categoryRepository;

        public ProductController(IProductRepository product, ICategoryRepository category)
        {
            productRepository = product;
            categoryRepository = category;
        }

        ProductVM ViewModelDoldur(Product product = null)
        {
            ProductVM productVM = new ProductVM();
            foreach (var item in categoryRepository.Categories)
            {
                productVM.Categories.Add(new SelectListItem { Value = item.CategoryID.ToString(), Text = item.CategoryName });
            }
            if (product != null)
            {
                productVM.ProductID = product.ProductID;
                productVM.ProductName = product.ProductName;
                productVM.UnitPrice = product.UnitPrice;
                productVM.UnitInStock = product.UnitsInStock;
                productVM.CategoryID = product.CategoryID;
            }
            return productVM;
        }


        public IActionResult Insert()
        {
            return View(ViewModelDoldur());
        }
        [HttpPost]
        public IActionResult Insert(ProductVM item)
        {
            try
            {
                if (item.CategoryID == 0)
                {
                    throw new Exception("Kategori");
                }
                if (ModelState.IsValid)
                {
                    Product product = new Product();
                    product.CategoryID = item.CategoryID;
                    product.ProductName = item.ProductName;
                    product.UnitPrice = item.UnitPrice;
                    product.UnitsInStock = item.UnitInStock;
                    bool check = productRepository.InsertProduct(product);
                    if (check)
                    {
                        ViewBag.IsSuccess = "Kayıt işlemi başarılı";
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
            }
            catch (Exception ex)
            {

                if (ex.Message == "Kategori")
                {

                    ViewBag.IsSuccess = "Kategori kısmı boş geçilemez";
                }
                else
                {
                    ViewBag.IsSuccess = "Kayıt İşlemi yapılamadı";
                }
            }

            return View(ViewModelDoldur());
        }


        public IActionResult Update(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index", "Category");
            }
            Product product = productRepository.GetProductById(id);
            return View(ViewModelDoldur(product));
        }


        [HttpPost]
        public IActionResult Update(ProductVM item) //View sayfasında productID verdik ama sayfada gizledik. istersek burada parametre içerisinde verip ürünün ıd'sini yakalayabiliriz.
        {
            Product updateProduct = null;     
            try
            {
                if (ModelState.IsValid)
                {
                    updateProduct = productRepository.GetProductById(item.ProductID);
                    updateProduct.ProductID = item.ProductID;
                    updateProduct.CategoryID = item.CategoryID;
                    updateProduct.ProductName = item.ProductName;
                    updateProduct.UnitPrice = item.UnitPrice;
                    updateProduct.UnitsInStock = item.UnitInStock;

                    bool check = productRepository.UpdateProduct(updateProduct);
                    if (check)
                    {
                        ViewBag.IsSuccess = "Güncelleme işlemi başarılı";
                    }
                }            
            }
            catch (Exception)
            {
                ViewBag.IsSuccess = "Güncelleme işlemi yapılamadı";
            }

            return View(item);

        }

        public IActionResult Delete(int id)
        {
            productRepository.DeleteProduct(id);
            return RedirectToAction("Index", "Category");
        }
    }
}

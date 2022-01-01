using _04_TagHalpers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_TagHalpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserVM user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserName=="bilal")
                {
                    if (user.Password=="123")
                    {
                        ViewBag.Message = "Hoşgeldiniz";
                        return RedirectToAction("LoginTagHelper");
                    }
                    else
                    {
                        ViewBag.Message = "Kullanıcı adı doğru parola yanlış";
                    }
                }
                else
                {
                    if (user.Password == "123")
                    {
                        ViewBag.Message = "Parola doğru kullanıcı adı yanlış";
                    }
                    else
                    {
                        ViewBag.Message = "Tüm bilgilerinizi kontrol ediniz";
                    }
                }

            }
           


            return View();
        }

        public IActionResult LoginTagHelper()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginTagHelper(UserVM user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserName == "bilal")
                {
                    if (user.Password == "123")
                    {
                        ViewBag.Message = "Hoşgeldiniz";
                    }
                    else
                    {
                        ViewBag.Message = "Kullanıcı adı doğru parola yanlış";
                    }
                }

            }
            else
            {
                if (user.Password == "123")
                {
                    ViewBag.Message = "Parola doğru kullanıcı adı yanlış";
                }
                else
                {
                    ViewBag.Message = "tüm bilgilerinizi kontrol ediniz";
                }
            }


            return View();
       
        }

        public IActionResult Details(string name)
        {
            ViewBag.Message = name;
            return View();
        }
    }
}

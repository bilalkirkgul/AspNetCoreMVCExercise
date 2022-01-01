using _10_DbFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_DbFirstApproach.ViewComponents
{
    public class Category : ViewComponent
    {

        NorthwindContext context;
        public Category()
        {
            context = new NorthwindContext();
        }

        public IViewComponentResult Invoke()
        {
            var model = context.Categories.ToList();
            return View(model);
        }

    }
}

using _11_EFCoreCodeFirst.EfCoreRepository.Abstract;
using _11_EFCoreCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.EfCoreRepository.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        CoreContext context;

        public CategoryRepository(CoreContext coreContext)
        {
            context = coreContext;
        }


        public ICollection<Category> Categories => context.Categories.ToList();
    }
}

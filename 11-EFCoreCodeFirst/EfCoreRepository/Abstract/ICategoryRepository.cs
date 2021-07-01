using _11_EFCoreCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.EfCoreRepository.Abstract
{
   public interface ICategoryRepository
    {
        ICollection<Category> Categories { get; }


    }
}

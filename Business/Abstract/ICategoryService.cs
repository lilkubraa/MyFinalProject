using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        ICategoryService GetById(int categoryId);
    }
}

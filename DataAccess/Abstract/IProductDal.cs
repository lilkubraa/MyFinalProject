using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {

        List<ProductDetailsDto> GetProductDetails();
        void Add(object product);
    }
}
// bu olaya 'code refaractoring' denir kodun iyileştirilmesi
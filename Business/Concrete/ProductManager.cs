using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.İnMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //YETKİSİ VAR Mİ?

            return _ProductDal.GetAll(); 
           
        }
    }

}
    


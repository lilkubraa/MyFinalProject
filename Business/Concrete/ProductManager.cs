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

        public ProductManager()
        {
        }

        public IEnumerable<object> GetAllByUnitPrice(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //YETKİSİ VAR Mİ?

            return _ProductDal.GetAll(); 
           
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _ProductDal.GetAll(p => p.CategoryId == id);
        }

        public IEnumerable<object> GeProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p => p.UnitPrice <= max);
        }
    }

}
    


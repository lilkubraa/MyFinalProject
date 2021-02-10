using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.İnMemory
{
    //naming comensing
    public class İnMemoryProductDal:IProductDal
        //lambda
    {
        List<Product> _products;
        public İnMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitInStock=2},

            };
            //oracle ,sql server ,postgres, mongoDb
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
       
        public void Delete(Product product)
        {
            Product productToDelete = new Product(); //
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }

            }
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);



            _products.Remove(productToDelete);
        }
       
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            // gonderdıgım urun ıd ısıne sahıp olan listedeki urunu bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }   

        public List<Product> GetAllByCategoryId(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailsDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}

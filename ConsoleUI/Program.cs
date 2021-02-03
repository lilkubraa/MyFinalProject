using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.İnMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    // O harf open closed Principle 
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}

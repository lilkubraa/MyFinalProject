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
            // ProductTest();
            //IoC
            //data transformation object
            //CATEGORYTEST();
            CategoryManager categoryManager = new CategoryManager();
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }


        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GeProductDetails())
            {
                Console.WriteLine(product.ProductName);
    }
}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryTest();
            ProductManager productManager2 = new ProductManager(new EfProductDal());
            foreach (var product in productManager2.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName+" + "+ product.CategoryName);
            }

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product2 in productManager.GetAllByCategoryId(5).Data)
            {
                Console.WriteLine(product2.ProductName);
            }
            Console.WriteLine("-------------------------------------");
            foreach (var Product3 in productManager.GetByUnitPrice(10, 25).Data)
            {
                Console.WriteLine(Product3.ProductName);
            }
        }
    }
}

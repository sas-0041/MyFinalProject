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
            ProductManager productManager=new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            foreach (var product2 in productManager.GetAllByCategoryId(5))
            {
                Console.WriteLine(product2.ProductName);
            }
            Console.WriteLine("-------------------------------------");
            foreach (var Product3 in productManager.GetByUnitPrice(10,25))
            {
                Console.WriteLine(Product3.ProductName);
            }
        }
    }
}

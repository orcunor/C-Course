using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 100;
            product1.UnitsInStock = 5;


            Product product2 = new Product { Id = 1, ProductName = "Kalem", CategoryId = 5, UnitPrice = 35, UnitsInStock = 13 };

            // PascalCase  // camelCase
            // case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);





















            //int number = 100;
            //productManager.Test(number);
            //Console.WriteLine(number); // 100
                
        }
    }
}

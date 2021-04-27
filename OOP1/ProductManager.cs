using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "updated!");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + "deleted!");
        }

       
        















        //public void Test (int number)
        //{
        //    number = 99;
        //}

    }
}

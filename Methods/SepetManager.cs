using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        // naming convention
        public void Add(Product product)
        {

            Console.WriteLine("Added to cart : " + product.ProductName + " -->" + " Stok Adedi = " + product.StockQuantity);

        }

        public void Add2(string productName, double price, string description,int stockQuantity)
        {

        }




    }
}

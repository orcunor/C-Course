using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";
            product1.StockQuantity = 4;

            Product product2 = new Product();
            product2.ProductName = "Muz";
            product2.Price = 20;
            product2.Description = "İthal Muz";
            product2.StockQuantity = 5;

            Product[] products = new Product[]
            {
                product1,
                product2
            };


            foreach (var product in products)
            {
                Console.WriteLine("Ürünün adı = " +product.ProductName+"\n"+ "Ürün Fiyatı = " + product.Price);
            }

            Console.WriteLine("----------------------------Methods-----------------------------------------");

            
            SepetManager sepetManager = new SepetManager(); //instance- örnek
            sepetManager.Add(product1);
            sepetManager.Add(product2);




        }
    }
}

//Do not repat yourself - DRY - Clean Code - Best Practice